/////////////////////////////////////////////////////////////////////////
////                            MecaArm.c                            ////
////                                                                 ////
////                 MECATRONICA SISTEMA DUAL 2019                   ////
////                                                                 ////
//// Programa controlador de los movimientos de los motores del      ////
//// brazo robótico Meca Arm.                                        ////
////                                                                 ////
/////////////////////////////////////////////////////////////////////////

#include <18F4550.h>
#include <stdlib.h>
#include <string.h> 

/*------------- CONFIGURACIONES -------------*/

#fuses HSPLL,NOWDT,NOPROTECT,NOLVP,NODEBUG,PLL5,CPUDIV1,VREGEN,MCLR,USBDIV, // Fusibles
#use delay(clock=48000000) // Frecuencia de trabajo del PIC
#use rs232(baud=9600, xmit=PIN_C6, rcv=PIN_C7, BITS=8, PARITY=N, STOP=1, ERRORS)// Configuracion del RS232 Estándar
#USE FIXED_IO (b_OUTPUTS=pin_b0, pin_b1,pin_b2,pin_b3,pin_b4,pin_b5) // Puerto B como salida
#USE FIXED_IO (d_OUTPUTS=pin_d0,pin_d1,pin_d2,pin_d3,pin_d4,pin_d5)  // Puerto D como salida
#USE FIXED_IO (c_OUTPUTS=pin_c0,pin_c1,pin_c2) // C0, C1 Y C2  como salida
#use standard_io(A) // Puerto A se configura automaticamente

/*------------- DEFINICIONES -------------*/

#define LED_J     PIN_C0
#define LED_M     PIN_C1
#define LED_S     PIN_C2
#define DIR_M1    PIN_D0
#define DIR_M2    PIN_D1
#define DIR_M3    PIN_D2
#define DIR_M4    PIN_D3
#define DIR_M5    PIN_D4
#define DIR_M6    PIN_D5
#define STEP_M1   PIN_B0
#define STEP_M2   PIN_B1
#define STEP_M3   PIN_B2
#define STEP_M4   PIN_B3
#define STEP_M5   PIN_B4
#define STEP_M6   PIN_B5
#define HOME_M1   PIN_A0
#define HOME_M2   PIN_A1
#define HOME_M3   PIN_A2
#define HOME_M4   PIN_A3
#define HOME_M5   PIN_A4
#define HOME_M6   PIN_A5

#define PRIMERO 1
#define OTRO 0
/*------------- DECLARACION DE VARIABLES -------------*/

int const lenbuff = 50; // Longitud de buffer
int xbuff = 0x00;       // Índice: siguiente char en cbuff
char cbuff[lenbuff];    // Buffer
char rcvchar = 0x00;    // Ultimo caracter recibido
int cantCaracteres = 0; // Contador de caracteres recibidos para determinar cantidad de paquetes
int cantPaquetes = 0;   // Cantidad de paquetes recibidos
char modoOperacion = 0x00; // Almacena una letra que representa un modo de operacion

unsigned char flagComando = 0;      // Flag que indica comando disponible
unsigned char flagAsterisco = 0;    // Flag que indica que llegó el asterisco
unsigned char flagNumeral = 0;      // Flag que indica que llegó el numeral
unsigned char flagDollar = 0;       // Flag que indica que llegó el signo dollar
unsigned char flagEstirar = 0;      // Flag para iniciar la funcion estirar()
unsigned char flagEstirar2 = 0;     // Flag auxiliar  
unsigned char flagFlanco[6] = {0, 0, 0, 0, 0, 0}; // Flags para tomar un paso en el flanco de subida
unsigned char flagTimer = 0;        // Flag para iniciar la interrupcion del Timer 0
unsigned char flagHome = 0;         // Flag para iniciar la funcion home()
unsigned char flagS = 0;            // Flag para indicar inicio de modo secuencia por puerto serie
unsigned char flagF = 0;            // Flag para indicar fin de modo secuencia por puerto serie
unsigned char flagArmarPaquete = 0; // Flag para iniciar la funcion armarPaquete()
unsigned char flagPasosDados = 0;   // Flag para iniciar la funcion calcularPasosDados()
unsigned char flagCrearSecuenciaInit = 0; // Flag para iniciar la funcion crearSecInit()
unsigned char flagPaquetePasosDados = 0; // Flag para armar el paquete con los pasos dados del motor

// Matriz que almacena los datos de cada motor
char motor[6][7] = {
    {0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
    {0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
    {0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
    {0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
    {0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
    {0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00}
};

char i = 0x00; 
int j = 0;

// En modo Jog: vale 0 o 1 e indica al motor que se detenga o se mueva
// En modo Manual: almacena la cantidad de pasos que debe moverse el motor
signed int32 pasos[6] = {0, 0, 0, 0, 0, 0};

int8 velocidad[6] = {0, 0, 0, 0, 0, 0}; // Vector que almacena los valores de las velocidades de los motores
int8 velofija[6] = {0, 0, 0, 0, 0, 0};  // Auxiliar del vetor velocidad
signed int32 contPasos[6] = {0, 0, 0, 0, 0, 0}; // Cuenta la cantidad de pasos que se mueve el motor
signed int32 pasosAnteriores[6] = {5190, 2500 , 22250, 0, 6800, 0};
signed int32 pasosActuales[6] = {0, 0, 0, 0, 0, 0};
signed int32 pasosDados[6] = {0, 0, 0, 0, 0, 0};
signed int32 arrayPasos[6] = {0, 0, 0, 0, 0, 0};
char provi[6] = {0x00, 0x00, 0x00, 0x00, 0x00, 0x00}; // Auxiliar de la matriz motores
char veloprovi = 0; // Auxiliar del vector velocidad
int interrupVel = 150; // Velocidad de la interrupcion del Timer 0
int16 veloAjuste = 1000;
signed int32 pasosmax[6] = {10379, 4707 , 44501, 4500, 13593, 6400}; // Pasos maximos de cada motor
signed int32 pasosmin[6] = {0, 0 ,0, 0, 0, 0};
char signoPasos[6] = "++++++";
int16 pasosEstirado[6] = {5190, 2500, 22250, 0, 6800, 0};

/*------------- DECLARACION DE FUNCIONES -------------*/

void inicbuff(void);            // Borra buffer 
void procesa_comando(void);     // Procesa el paquete recivido 
void mover_motor(char nMotor);  // Mueve el motor seleccionado
void cleanAll(void);            // Reinicia las variables
void estirar(void);             // Estira el brazo

// El robot se va a home.
// primerHome = 1 -> Es el primer home del robot. Los motores hacen unos paso para atras para detectar el sensor
// primerHome = 0 -> Los siguientes home luego del primero. Los motores no hacen los pasos para atras
void home(int primerHome);      
                                
void crearSecInit(void);        // Crea Secuencias
void calcularPasosDados(void);  // Calcula los pasos dados del motor
void armarPaquete(void);        // Arma el paquete y lo envía por puerto serie

/*------------- FUNCIONES -------------*/

void cleanAll(void) {

    inicbuff();

    for (i = 0; i < 6; i++) {

        pasos[i] = 0x00;
        velocidad[i] = 0x00;
        velofija [i] = 0x00;
        contPasos[i] = 0x00;
        pasosAnteriores[i] = 0x00;

        for (j = 0; j < 6; j++) {
            motor[i][j] = 0x00;
        }

    }

}

void home(int primerHome) {

    disable_interrupts(INT_RDA);

    int primeraVueltaMotor1 = 1;
    int primeraVueltaMotor2 = 1;
    int primeraVueltaMotor3 = 1;
    int primeraVueltaMotor4 = 1;
    int primeraVueltaMotor5 = 1;
    int primeraVueltaMotor6 = 1;

    int motor1Activo = 0; //Variables que indican si se movió un motor. Esto es para agregar un retardo entre articulaciones
    int motor2Activo = 0; //solo si la articulacion anterior se movió
    int motor3Activo = 0;
    int motor4Activo = 0;
    int motor5Activo = 0;
    int motor6Activo = 0;

    while ((input(HOME_M1) == 1) || (input(HOME_M2)) == 1 || (input(HOME_M3)) == 1 || (input(HOME_M4)) == 1 || (input(HOME_M5)) == 1 || (input(HOME_M6)) == 1) {

        if (input(HOME_M6) == 1) {
            
            veloAjuste = 1000;
            motor6Activo = 1;
            
            if (primerHome == 1) {
                if (primeraVueltaMotor6 == 1) {
                    for (int contadorHome = 0; contadorHome < 100; contadorHome++) {
                        output_low(DIR_M6);
                        output_high(STEP_M6);
                        delay_us(5);
                        output_low(STEP_M6);
                        delay_us(5);
                        delay_us(veloAjuste);
                    }
                    primeraVueltaMotor6 = 0;
                }
            }

            output_high(DIR_M6);
            output_high(STEP_M6);
            delay_us(5);
            output_low(STEP_M6);
            delay_us(5);

        } else if (input(HOME_M5) == 1) {
            
            veloAjuste = 800;
            
            if (motor6Activo == 1) {
                delay_ms(500);
                motor5Activo = 1;
                motor6Activo = 0;
            }
            
            if (primerHome == 1) {
                if (primeraVueltaMotor5 == 1) {
                    for (int contadorHome = 0; contadorHome < 100; contadorHome++) {
                        output_low(DIR_M5);
                        output_high(STEP_M5);
                        delay_us(5);
                        output_low(STEP_M5);
                        delay_us(5);
                        delay_us(veloAjuste);
                    }
                    primeraVueltaMotor5 = 0;
                }
            }

            output_high(DIR_M5);
            output_high(STEP_M5);
            delay_us(5);
            output_low(STEP_M5);
            delay_us(5);

        } else if (input(HOME_M4) == 1) {
            
            veloAjuste = 6000;
            
            if (motor5Activo == 1) {
                delay_ms(500);
                motor4Activo = 1;
                motor5Activo = 0;
            }
            
            if (primerHome == 1) {
                if (primeraVueltaMotor4 == 1) {
                    for (int contadorHome = 0; contadorHome < 100; contadorHome++) {
                        output_low(DIR_M4);
                        output_high(STEP_M4);
                        delay_us(5);
                        output_low(STEP_M4);
                        delay_us(5);
                        delay_us(veloAjuste);
                    }
                    primeraVueltaMotor4 = 0;
                }
            }

            output_high(DIR_M4);
            output_high(STEP_M4);
            delay_us(5);
            output_low(STEP_M4);
            delay_us(5);

        } else if (input(HOME_M3) == 1) {
            
            veloAjuste = 400;
            
            if (motor4Activo == 1) {
                delay_ms(1000);
                motor3Activo = 1;
                motor4Activo = 0;
            }
            
            if (primerHome == 1) {
                if (primeraVueltaMotor3 == 1) {
                    for (int contadorHome = 0; contadorHome < 100; contadorHome++) {
                        output_low(DIR_M3);
                        output_high(STEP_M3);
                        delay_us(5);
                        output_low(STEP_M3);
                        delay_us(5);
                        delay_us(veloAjuste);
                    }
                    primeraVueltaMotor3 = 0;
                }
            }

            output_high(DIR_M3);
            output_high(STEP_M3);
            delay_us(5);
            output_low(STEP_M3);
            delay_us(5);

        } else if (input(HOME_M2) == 1) {
            
            veloAjuste = 3200;
            //veloAjuste = 700;
            
            if (motor3Activo == 1) {
                delay_ms(500);
                motor2Activo = 1;
                motor3Activo = 0;
            }
            
            if (primerHome == 1) {
                if (primeraVueltaMotor2 == 1) {
                    for (int contadorHome = 0; contadorHome < 100; contadorHome++) {
                        output_low(DIR_M2);
                        output_high(STEP_M2);
                        delay_us(5);
                        output_low(STEP_M2);
                        delay_us(5);
                        delay_us(7000);
                        //delay_us(1750);
                    }
                    primeraVueltaMotor2 = 0;
                }
            }

            output_high(DIR_M2);
            output_high(STEP_M2);
            delay_us(5);
            output_low(STEP_M2);
            delay_us(5);

        } else if (input(HOME_M1) == 1) {
            
            veloAjuste = 1000;
            
            if (motor2Activo == 1) {
                delay_ms(500);
                motor1Activo = 1;
                motor2Activo = 0;
            }
            
            if (primerHome == 1) {
                if (primeraVueltaMotor1 == 1) {
                    for (int contadorHome = 0; contadorHome < 150; contadorHome++) {
                        output_low(DIR_M1);
                        output_high(STEP_M1);
                        delay_us(5);
                        output_low(STEP_M1);
                        delay_us(5);
                        delay_us(3000);
                    }
                    primeraVueltaMotor1 = 0;
                }
            }
            
            output_high(DIR_M1);
            output_high(STEP_M1);
            delay_us(5);
            output_low(STEP_M1);
            delay_us(5);

        }

        delay_us(veloAjuste);

    }

    cleanAll();
    enable_interrupts(INT_RDA);

}

void mover_motor(char nMotor) {

    unsigned int STEP_MOTOR[6] = {STEP_M1, STEP_M2, STEP_M3, STEP_M4, STEP_M5, STEP_M6};
    unsigned int DIR_MOTOR[6] = {DIR_M1, DIR_M2, DIR_M3, DIR_M4, DIR_M5, DIR_M6};

    velocidad[nMotor] = velocidad[nMotor] - 1;
  
    if (velocidad[nMotor] == 0 && pasos[nMotor] != 0) {

        //Direccion
        if (pasos[nMotor] > 0) {
            output_low(DIR_MOTOR[nMotor]);
        } else output_high(DIR_MOTOR[nMotor]);

        if (pasosmin[nMotor] < contPasos[nMotor] && contPasos[nMotor] < pasosmax[nMotor]) {

            //////////PASO///////////          
            output_toggle(STEP_MOTOR[nMotor]);

            if (flagFlanco[nMotor] == 0) {
                flagFlanco[nMotor] = 1;
                if (pasos[nMotor] > 0) {
                    if (contPasos < pasosmax[nMotor]) {
                        contPasos[nMotor] = contPasos[nMotor] + 1;
                        if (modoOperacion == 'M' || modoOperacion == 'R' || flagEstirar2 == 1) pasos[nMotor] = pasos[nMotor] - 1;
                    }
                } else {
                    contPasos[nMotor] = contPasos[nMotor] - 1;
                    if (modoOperacion == 'M' || modoOperacion == 'R' || flagEstirar2 == 1) pasos[nMotor] = pasos[nMotor] + 1;
                }
            } else flagFlanco[nMotor] = 0;

        } else if (contPasos[nMotor] == pasosmin[nMotor]) {

            if (pasos[nMotor] > 0) {
                output_toggle(STEP_MOTOR[nMotor]);
                if (flagFlanco[nMotor] == 0) {
                    flagFlanco[nMotor] = 1;
                } else {
                    flagFlanco[nMotor] = 0;
                    contPasos[nMotor] = contPasos[nMotor] + 1;
                    if (modoOperacion == 'M' || modoOperacion == 'R' || flagEstirar2 == 1) pasos[nMotor] = pasos[nMotor] - 1;
                }
            }

        } else if (contPasos[nMotor] == pasosmax[nMotor]) {
            if (pasos[nMotor] < 0) {
                output_toggle(STEP_MOTOR[nMotor]);
                if (flagFlanco[nMotor] == 0) {
                    flagFlanco[nMotor] = 1;
                } else {
                    flagFlanco[nMotor] = 0;
                    contPasos[nMotor] = contPasos[nMotor] - 1;
                    if (modoOperacion == 'M' || modoOperacion == 'R' || flagEstirar2 == 1) pasos[nMotor] = pasos[nMotor] + 1;
                }
            }
        }

        velocidad[nMotor] = velofija[nMotor];

    } else if (pasos[nMotor] == 0) output_low(STEP_MOTOR[nMotor]);


}

void estirar(void) {

    int8 nMotor;

    for (nMotor = 0; nMotor < 6; nMotor++) {

        pasos[nMotor] = pasosEstirado[nMotor] - contPasos[nMotor];

        switch (nMotor) {

            case 0:
                velocidad[0] = 5;
                break;

            case 1:
                velocidad[1] = 12;
                //velocidad[1] = 3;
                break;

            case 2:
                velocidad[2] = 1;
                break;

            case 3:
                velocidad[3] = 50;
                break;

            case 4:
                velocidad[4] = 5;
                break;

            case 5:
                velocidad[5] = 5;
                break;

        }

        velofija[nMotor] = velocidad[nMotor];

    }
    
    flagEstirar2 = 1;
    flagTimer = 1;
    inicbuff();

}

void inicbuff(void) {

    for (int i = 0; i < lenbuff; i++) { // Bucle que pone a 0 todos los
        cbuff[ i ] = 0x00; // caracteres en el buffer
    }
    xbuff = 0x00; // Inicializo el indice de siguiente caracter

}

void crearSecInit(void) {
    
    for (int i = 0; i < 6; i++) {
        
        pasosAnteriores[i] = pasosEstirado[i];
        pasosActuales[i] = 0;
        pasosDados[i] = 0;
        arrayPasos[i] = 0;
        signoPasos[i] = '+';
        
    }
    
}

void calcularPasosDados(void) {
    
    for (int i = 0; i < 6; i++) {
        
        pasosActuales[i] = contPasos[i];
        
        if (pasosActuales[i] >= pasosAnteriores[i]) {
            //Mov Positivo
            pasosDados[i] = pasosActuales[i] - pasosAnteriores[i];
            signoPasos[i] = '+';
        } else {
            //Mov Negativo
            pasosDados[i] = pasosAnteriores[i] - pasosActuales[i];
            signoPasos[i] = '-';
        }
        
        pasosAnteriores[i] = pasosActuales[i];
        
    }
    
    flagArmarPaquete = 1;
    flagPaquetePasosDados = 1;

}

void procesa_comando(void) {

    int i;
    int h = 0;
    int k = 0;
    int w = 0;

    for (w = 0; w < cantPaquetes; w++) {

        i = cbuff[h];
        j = i - 49; //Transforma de ASCII a decimal y resta 1 para referise a la posicion del vector

        for (k = 0; k < 7; k++) { // 7 es la longitud del PAQUETE
            motor[j][k] = cbuff[h + 1];
            h = h + 1;
        }

        h = h + 1;

    }

    for (i = 0; i < 6; i++) {

        provi[0] = motor[i][0];
        provi[1] = motor[i][1];
        provi[2] = motor[i][2];
        provi[3] = motor[i][3];
        provi[4] = motor[i][4];
        provi[5] = motor[i][5];

        pasos[i] = (signed int32)atof(provi);
        veloprovi = motor[i][6];
        velocidad[i] = veloprovi - 48;          
        
        //Correccion de velocidades
        if (i == 0) velocidad[0] = velocidad[0] * 3;
        if (i == 1) velocidad[1] = velocidad[1] * 2;
        if (i == 3) velocidad[3] = velocidad[3] * 10;

        veloprovi = 0;
        velofija[i] = velocidad[i];

    }
 
    flagTimer = 1;
    cantCaracteres = 0;
    inicbuff();
    set_timer0(interrupVel);
    enable_interrupts(INT_RDA);
    flagComando = 0; // Desactivo flag de comando pendiente.

}

void armarPaquete(void) {

    char paqueteBase[51] = "*1+0000032+0000033+0000034+0000035+0000036+000003*";
    char bufferPasos[6] = "00000";

    for (int j = 0; j < 6; j++) {
        
        if (flagPaquetePasosDados == 1) {
            arrayPasos[j] = pasosDados[j];
        } else {
            arrayPasos[j] = contPasos[j];
        }
        
    }

    flagPaquetePasosDados = 0;

    for (int l = 0; l < 6; l++) {

        itoa(arrayPasos[l], 10, bufferPasos);

        if (arrayPasos[l] >= 10000) {
            paqueteBase[l * 8 + 3] = bufferPasos[0];
            paqueteBase[l * 8 + 4] = bufferPasos[1];
            paqueteBase[l * 8 + 5] = bufferPasos[2];
            paqueteBase[l * 8 + 6] = bufferPasos[3];
            paqueteBase[l * 8 + 7] = bufferPasos[4];
        } else if (arrayPasos[l] < 10000 && arrayPasos[l] > 999) {
            paqueteBase[l * 8 + 3] = '0';
            paqueteBase[l * 8 + 4] = bufferPasos[0];
            paqueteBase[l * 8 + 5] = bufferPasos[1];
            paqueteBase[l * 8 + 6] = bufferPasos[2];
            paqueteBase[l * 8 + 7] = bufferPasos[3];
        } else if (arrayPasos[l] < 1000 && arrayPasos[l] > 99) {
            paqueteBase[l * 8 + 3] = '0';
            paqueteBase[l * 8 + 4] = '0';
            paqueteBase[l * 8 + 5] = bufferPasos[0];
            paqueteBase[l * 8 + 6] = bufferPasos[1];
            paqueteBase[l * 8 + 7] = bufferPasos[2];
        } else if (arrayPasos[l] < 100 && arrayPasos[l] > 9) {
            paqueteBase[l * 8 + 3] = '0';
            paqueteBase[l * 8 + 4] = '0';
            paqueteBase[l * 8 + 5] = '0';
            paqueteBase[l * 8 + 6] = bufferPasos[0];
            paqueteBase[l * 8 + 7] = bufferPasos[1];
        } else if (arrayPasos[l] < 10 && arrayPasos[l] > 0) {
            paqueteBase[l * 8 + 3] = '0';
            paqueteBase[l * 8 + 4] = '0';
            paqueteBase[l * 8 + 5] = '0';
            paqueteBase[l * 8 + 6] = '0';
            paqueteBase[l * 8 + 7] = bufferPasos[0];
        } else if (arrayPasos[l] == 0) {
            paqueteBase[l * 8 + 3] = '0';
            paqueteBase[l * 8 + 4] = '0';
            paqueteBase[l * 8 + 5] = '0';
            paqueteBase[l * 8 + 6] = '0';
            paqueteBase[l * 8 + 7] = '0';
        }

        paqueteBase[l * 8 + 2] = signoPasos[l];
        bufferPasos = "00000";

    }

    for (int i = 0; i < 6; i++) {
        signoPasos[i] = '+';
    }

    printf("%s", paqueteBase);

}

/*------------- INTERRUPCIONES -------------*/

#int_rda

void serial_isr() { // Interrupción recepción serie USART

    disable_interrupts(INT_TIMER0);
    
    rcvchar = 0x00; // Inicializo caracter recibido            
    rcvchar = getc(); // Almacena caracter

    // Abrir mensaje
    if (rcvchar == '#' && flagNumeral == 0) {
        flagNumeral = 1;
        return;
    } else if (rcvchar == '*' && flagAsterisco == 0) {
        flagAsterisco = 1;
        return;
    } else if (rcvchar == '$' && flagDollar == 0) {
        flagDollar = 1;
        return;
    }

    // Contenido mensaje
    if (rcvchar != '#' && flagNumeral == 1) {

        modoOperacion = rcvchar;

    } else if (rcvchar != '*' && flagAsterisco == 1) {

        cbuff[xbuff++] = rcvchar; // Añade caracter recibido al Buffer
        cantCaracteres++;

    } else if (rcvchar != '$' && flagDollar == 1) {

        if (rcvchar == 'I') {
            flagEstirar = 1;
            return;
        } else if (rcvchar == '0') {
            flagHome = 1;
            return;
        } else if (rcvchar == 'F') {
            flagEstirar = 1;
            flagF = 1;
            return;
        } else if (rcvchar == 'S') {
            flagEstirar = 1;
            flagS = 1;
            return;
        } else if (rcvchar == 'E') {
            flagPasosDados = 1;
            return;
        }

    }

    // Cerrar mensaje
    if (rcvchar == '#' && flagNumeral == 1) {

        printf("#OK-");
        printf(&modoOperacion);
        printf("#");

        if (modoOperacion == 'J') {
            output_high(LED_J);
            output_low(LED_M);
            output_low(LED_S);
        } else if (modoOperacion == 'M') {
            output_high(LED_M);
            output_low(LED_J);
            output_low(LED_S);
        } else if (modoOperacion == 'C') {
            output_low(LED_M);
            output_high(LED_J);
            output_high(LED_S);
        } else if (modoOperacion == 'R') {
            output_low(LED_M);
            output_high(LED_J);
            output_high(LED_S);
        }

        flagNumeral = 0;
        flagEstirar = 1;
        return;

    } else if (rcvchar == '*' && flagAsterisco == 1) {
        flagAsterisco = 0;
        flagComando = 1;
        cantPaquetes = cantCaracteres / 8;
        disable_interrupts(INT_RDA);
        return;

    } else if (rcvchar == '$' && flagDollar == 1) {
        flagDollar = 0;
        return;
    }

}


#int_TIMER0

void TIMER0_isr(void) {

    mover_motor(0);
    mover_motor(1);
    mover_motor(2);
    mover_motor(3);
    mover_motor(4);
    mover_motor(5);

    if (pasos[0] == 0 && pasos[1] == 0 && pasos[2] == 0 && pasos[3] == 0 && pasos[4] == 0 && pasos[5] == 0) {

        if (flagEstirar2 == 1) {
            
            if (flagS == 1) {
                printf("$S$");
                flagS = 0;
                flagCrearSecuenciaInit = 1;
            } else if (flagF == 1) {
                printf("$F$");
                flagCrearSecuenciaInit = 1;
                flagF = 0;
            } else{ 
                printf("$OK$");
            }
            
            pasosmax[1] = 4300;
            pasosmax[2] = 35000;
            pasosmin[1] = 1000;
            pasosmin[2] = 5700; 
            
            flagEstirar2 = 0;
            
        } else flagArmarPaquete = 1;

        disable_interrupts(INT_TIMER0);
        flagTimer = 0;
        inicbuff();
        j = 0;

        for (j = 0; j < 6; j++) {
            for (i = 0; i < 6; i++) {
                motor[i][j] = 0;
            }
        }

    }

    set_timer0(interrupVel);
    flagTimer = 0;

}

// main /////////////////////////////////////////////////////

void main() {

    inicbuff(); // Borra buffer al inicio

    output_high(LED_M);
    output_high(LED_J);
    output_high(LED_S);

    delay_ms(3000);

    home(PRIMERO);
    
    setup_timer_0(RTCC_INTERNAL | RTCC_8_BIT | RTCC_DIV_1); //Configuración timer0
    enable_interrupts(GLOBAL); //Habilita interrupción general
    enable_interrupts(INT_RDA); // Habilita Interrupción RDA

    while (1) {

        if (flagArmarPaquete == 1) {
            flagArmarPaquete = 0;
            armarPaquete();
        }

        if (flagHome == 1) {
            home(OTRO);
            flagHome = 0;
        }

        if (flagEstirar == 1) {
            estirar();
            flagEstirar = 0;
        }

        if (flagComando == 1) { // Si hay comando pendiente
            procesa_comando(); // de procesar ... lo procesa.
        }

        if (flagTimer == 1) {
            enable_interrupts(INT_TIMER0); //Habilita interrupción timer0
        }

        if (flagCrearSecuenciaInit == 1) {
            flagCrearSecuenciaInit = 0;
            crearSecInit();
        }

        if (flagPasosDados == 1) {
            flagPasosDados = 0;
            calcularPasosDados();
        }

    }

}