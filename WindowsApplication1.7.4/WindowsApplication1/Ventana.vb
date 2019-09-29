Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Ventana

#Region "Variables"
    Dim estado As Boolean = True        'variable para estado del boton
    Dim Direccion As String
    Dim Instrucciones As String         'Instrucciones para los motores
    Dim NumeroMotor As Integer

    Dim EStadoModoMAN As Boolean = False
    Dim EstadoModoJOG As Boolean = False
    Dim EstadoModoRSEC As Boolean = False
    Dim EstadoModoCSEC As Boolean = False


    Dim clienteTCP As Cliente = New Cliente

    Dim Motor1 As Motor = New Motor
    Dim Motor2 As Motor = New Motor
    Dim Motor3 As Motor = New Motor
    Dim Motor4 As Motor = New Motor
    Dim Motor5 As Motor = New Motor
    Dim Motor6 As Motor = New Motor

    Dim PaqueteJOG As String
    Dim AntPaqueteJOG As String

    Dim TimerJOG As Integer
    Dim PosicionActual(5) As String

    Dim buffer As String
    Dim Posbuffer As String

    Dim AntRecibido As String


    Dim repSec As Boolean = False
    Dim SecAct As String
    Dim PasoSecAct As Integer = 0
    Dim DelaySec As Integer = 0
    Dim puedoMandarSIGSEC As Boolean = False

    Dim cambioVelocidadEjeJOG As Integer = 1
    Dim estadoJOGJOY8 As Boolean = False
    Dim estadoJOGJOY4 As Boolean = False
    Dim estadoJOGJOY2 As Boolean = False
    Dim estadoJOGJOY1 As Boolean = False
    Dim estadoJOGJOY1024 As Boolean = False
    Dim estadoJOGJOY2048 As Boolean = False
    Dim estadoSIGJOGJOY As Boolean = False

    Dim TimmerGripper As Integer = 0
    Dim GripperAndaPOSJOY As Boolean = False
    Dim GripperAndaNEGJOY As Boolean = False
    Dim GripperAndaPOSKEY As Boolean = False
    Dim GripperAndaNEGKEY As Boolean = False





#End Region

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myjoyEX.dwSize = 64
        myjoyEX.dwFlags = &HFF ' All information

        Timer1.Interval = 1         'Seteo Timmer en 1ms
        Timer1.Enabled = True       'Habilito timmer

        DeshabilitarMotor()
        DeshabilitarModoJOG()
        Inicializar()
        PosicionesACero()


#Region "Style Button"


        StyleButton(btnCrearSec)
        StyleButton(btnCamDirSEC)
        StyleButton(btnCargarSec)
        StyleButton(btnPararSec)
        StyleButton(btnEjecSec)


        StyleButton(BtnTabHome)
        StyleButton(BtnTabCtrlManual)
        StyleButton(BtnTabJOG)
        StyleButton(btnTabSec)
        StyleButton(BtnTabConfig)

        StyleButton(btnE1_POS_JOG)
        StyleButton(btnE1_NEG_JOG)
        StyleButton(btnE2_POS_JOG)
        StyleButton(btnE2_NEG_JOG)
        StyleButton(btnE3_POS_JOG)
        StyleButton(btnE3_NEG_JOG)
        StyleButton(btnE4_POS_JOG)
        StyleButton(btnE4_NEG_JOG)
        StyleButton(btnE5_POS_JOG)
        StyleButton(btnE5_NEG_JOG)
        StyleButton(btnE6_POS_JOG)
        StyleButton(btnE6_NEG_JOG)
        StyleButton(btnGripperOFF)
        StyleButton(btnGripperON)

        StyleButton(BtnConnectRobot)
        StyleButton(BtnDesconectar)
        StyleButton(btnCargarConf)

        StyleButton(BtnSend)
        StyleButton(Clear)
        StyleButton(AumPosMotor1)
        StyleButton(DisPosMotor1)
        StyleButton(AumPosMotor2)
        StyleButton(DisPosMotor2)
        StyleButton(AumPosMotor3)
        StyleButton(DisPosMotor3)
        StyleButton(AumPosMotor4)
        StyleButton(DisPosMotor4)
        StyleButton(AumPosMotor5)
        StyleButton(DisPosMotor5)
        StyleButton(AumPosMotor6)
        StyleButton(DisPosMotor6)
#End Region
    End Sub



#Region "Modo Manual"
    Private Sub BtnHab_Man_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHab_Man.Click
        HabilitarModoMAN()
        DeshabilitarModoJOG()
    End Sub
    Private Sub BtnPosOrigenJOG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPosOrigenJOG.Click
        Home()
    End Sub


#Region "btn Comando Manual"
    Private Sub Clock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock.Click
        If Direccion = "+" Then
            Direccion = "-"
            Clock.Image = My.Resources.Anticlk
        Else
            Direccion = "+"
            Clock.Image = My.Resources.Clk
        End If
    End Sub
    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        cmbVelocidadMan.Value = "1"
        DeshabilitarMotor()
        estado = True
    End Sub
    Private Sub BtnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSend.Click
        clienteTCP.EnviarDatos(PrevManual.Text)
    End Sub
#End Region

#Region "btn Bloquear Motor Manual"
    Private Sub btnMotor1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotor1.Click
        NumeroMotor = 1
        If estado = True Then
            estado = False
            AumPosMotor1.Enabled = True
            DisPosMotor1.Enabled = True
            nupMotor1Man.Enabled = True
            btnMotor1.Image = My.Resources.CandadoAbierto
        Else
            estado = True
            DeshabilitarMotor()
        End If
    End Sub
    Private Sub btnMotor2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotor2.Click
        NumeroMotor = 2

        If estado = True Then
            estado = False
            AumPosMotor2.Enabled = True
            DisPosMotor2.Enabled = True
            nupMotor2Man.Enabled = True
            btnMotor2.Image = My.Resources.CandadoAbierto
        Else
            estado = True
            DeshabilitarMotor()
        End If
    End Sub
    Private Sub btnMotor3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotor3.Click
        NumeroMotor = 3
        If estado = True Then
            estado = False
            AumPosMotor3.Enabled = True
            DisPosMotor3.Enabled = True
            nupMotor3Man.Enabled = True
            btnMotor3.Image = My.Resources.CandadoAbierto
        Else
            estado = True
            DeshabilitarMotor()
        End If
    End Sub
    Private Sub btnMotor4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotor4.Click
        NumeroMotor = 4
        If estado = True Then
            estado = False
            AumPosMotor4.Enabled = True
            DisPosMotor4.Enabled = True
            nupMotor4Man.Enabled = True
            btnMotor4.Image = My.Resources.CandadoAbierto
        Else
            estado = True
            DeshabilitarMotor()
        End If
    End Sub
    Private Sub btnMotor5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotor5.Click
        NumeroMotor = 5
        If estado = True Then
            estado = False
            AumPosMotor5.Enabled = True
            DisPosMotor5.Enabled = True
            nupMotor5Man.Enabled = True
            btnMotor5.Image = My.Resources.CandadoAbierto
        Else
            estado = True
            DeshabilitarMotor()
        End If
    End Sub
    Private Sub btnMotor6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotor6.Click
        NumeroMotor = 6
        If estado = True Then
            estado = False
            AumPosMotor6.Enabled = True
            DisPosMotor6.Enabled = True
            nupMotor6Man.Enabled = True
            btnMotor6.Image = My.Resources.CandadoAbierto
        Else
            estado = True
            DeshabilitarMotor()
        End If
    End Sub
#End Region

#Region "Posicion Manual"
    Private Sub AumPosMotor1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AumPosMotor1.Click
        nupMotor1Man.Value = nupMotor1Man.Value + 1
    End Sub
    Private Sub AumPosMotor2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AumPosMotor2.Click
        nupMotor2Man.Value = nupMotor2Man.Value + 1
    End Sub
    Private Sub AumPosMotor3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AumPosMotor3.Click
        nupMotor3Man.Value = nupMotor3Man.Value + 1
    End Sub
    Private Sub AumPosMotor4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AumPosMotor4.Click
        nupMotor4Man.Value = nupMotor4Man.Value + 1
    End Sub
    Private Sub AumPosMotor5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AumPosMotor5.Click
        nupMotor5Man.Value = nupMotor5Man.Value + 1
    End Sub
    Private Sub AumPosMotor6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AumPosMotor6.Click
        nupMotor6Man.Value = nupMotor6Man.Value + 1
    End Sub

    Private Sub DisPosMotor1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisPosMotor1.Click
        If nupMotor1Man.Value <> 0 Then
            nupMotor1Man.Value = nupMotor1Man.Value - 1
        End If
    End Sub
    Private Sub DisPosMotor2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisPosMotor2.Click
        If nupMotor2Man.Value <> 0 Then
            nupMotor2Man.Value = nupMotor2Man.Value - 1
        End If
    End Sub
    Private Sub DisPosMotor3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisPosMotor3.Click
        If nupMotor3Man.Value <> 0 Then
            nupMotor3Man.Value = nupMotor3Man.Value - 1
        End If
    End Sub
    Private Sub DisPosMotor4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisPosMotor4.Click
        If nupMotor4Man.Value <> 0 Then
            nupMotor4Man.Value = nupMotor4Man.Value - 1
        End If
    End Sub
    Private Sub DisPosMotor5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisPosMotor5.Click
        If nupMotor5Man.Value <> 0 Then
            nupMotor5Man.Value = nupMotor5Man.Value - 1
        End If
    End Sub
    Private Sub DisPosMotor6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DisPosMotor6.Click
        If nupMotor6Man.Value <> 0 Then
            nupMotor6Man.Value = nupMotor6Man.Value - 1
        End If
    End Sub

    Public Sub RefeshManual()
        Dim Velocidad As String
        Dim VelocidadLenght As Integer
        Dim Posicion As String = 0
        Dim PosicionLenght As Integer

        Velocidad = CStr(cmbVelocidadMan.Value)
        VelocidadLenght = Velocidad.Length

        Select Case NumeroMotor
            Case 1
                Posicion = CStr(nupMotor1Man.Value)
            Case 2
                Posicion = CStr(nupMotor2Man.Value)
            Case 3
                Posicion = CStr(nupMotor3Man.Value)
            Case 4
                Posicion = CStr(nupMotor4Man.Value)
            Case 5
                Posicion = CStr(nupMotor5Man.Value)
            Case 6
                Posicion = CStr(nupMotor6Man.Value)
        End Select

        PosicionLenght = Posicion.Length


        Select Case PosicionLenght
            Case 1
                Posicion = "0000" + Posicion
            Case 2
                Posicion = "000" + Posicion
            Case 3
                Posicion = "00" + Posicion
            Case 4
                Posicion = "0" + Posicion
        End Select


        Instrucciones = "*" + CStr(NumeroMotor) + Direccion + Posicion + Velocidad + "*"
        PrevManual.Text = Instrucciones
    End Sub
#End Region
#End Region

#Region "Modo JOG"
    Private Sub BtnHabJOG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHabJOG.Click

        HabilitarModoJOG()
        DeshabilitarModoMAN()
        PosicionesACero()
    End Sub
    Private Sub btnPosOrigenMan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPosOrigenMan.Click
        Home()
    End Sub


#Region "Teclas JOG"
    Private Sub JOD_KEYDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Screens.KeyDown
        If EstadoModoJOG = True Then
            If e.KeyCode = Keys.Q Then
                Motor1.MoverJOG("+")
                btnE1_POS_JOG.Enabled = False
            End If
            If e.KeyCode = Keys.W Then
                Motor2.MoverJOG("+")
                btnE2_POS_JOG.Enabled = False
            End If
            If e.KeyCode = Keys.E Then
                Motor3.MoverJOG("+")
                btnE3_POS_JOG.Enabled = False
            End If
            If e.KeyCode = Keys.R Then
                Motor4.MoverJOG("+")
                btnE4_POS_JOG.Enabled = False
            End If
            If e.KeyCode = Keys.T Then
                Motor5.MoverJOG("+")
                btnE5_POS_JOG.Enabled = False
            End If
            If e.KeyCode = Keys.Y Then
                Motor6.MoverJOG("+")
                btnE6_POS_JOG.Enabled = False
            End If


            If e.KeyCode = Keys.A Then
                Motor1.MoverJOG("-")
                btnE1_NEG_JOG.Enabled = False
            End If
            If e.KeyCode = Keys.S Then
                Motor2.MoverJOG("-")
                btnE2_NEG_JOG.Enabled = False
            End If
            If e.KeyCode = Keys.D Then
                Motor3.MoverJOG("-")
                btnE3_NEG_JOG.Enabled = False
            End If
            If e.KeyCode = Keys.F Then
                Motor4.MoverJOG("-")
                btnE4_NEG_JOG.Enabled = False
            End If
            If e.KeyCode = Keys.G Then
                Motor5.MoverJOG("-")
                btnE5_NEG_JOG.Enabled = False
            End If
            If e.KeyCode = Keys.H Then
                Motor6.MoverJOG("-")
                btnE6_NEG_JOG.Enabled = False
            End If

        End If

    End Sub
    Private Sub JOD_KEYUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Screens.KeyUp
        If EstadoModoJOG = True Then
            If e.KeyCode = Keys.Q Then
                Motor1.PararJOG()
                btnE1_POS_JOG.Enabled = True
            End If
            If e.KeyCode = Keys.W Then
                Motor2.PararJOG()
                btnE2_POS_JOG.Enabled = True
            End If
            If e.KeyCode = Keys.E Then
                Motor3.PararJOG()
                btnE3_POS_JOG.Enabled = True
            End If
            If e.KeyCode = Keys.R Then
                Motor4.PararJOG()
                btnE4_POS_JOG.Enabled = True
            End If
            If e.KeyCode = Keys.T Then
                Motor5.PararJOG()
                btnE5_POS_JOG.Enabled = True
            End If
            If e.KeyCode = Keys.Y Then
                Motor6.PararJOG()
                btnE6_POS_JOG.Enabled = True
            End If

            If e.KeyCode = Keys.A Then
                Motor1.PararJOG()
                btnE1_NEG_JOG.Enabled = True
            End If
            If e.KeyCode = Keys.S Then
                Motor2.PararJOG()
                btnE2_NEG_JOG.Enabled = True
            End If
            If e.KeyCode = Keys.D Then
                Motor3.PararJOG()
                btnE3_NEG_JOG.Enabled = True
            End If
            If e.KeyCode = Keys.F Then
                Motor4.PararJOG()
                btnE4_NEG_JOG.Enabled = True
            End If
            If e.KeyCode = Keys.G Then
                Motor5.PararJOG()
                btnE5_NEG_JOG.Enabled = True
            End If
            If e.KeyCode = Keys.H Then
                Motor6.PararJOG()
                btnE6_NEG_JOG.Enabled = True
            End If
        End If

    End Sub
#End Region
#Region "btn JOG"
#Region "btn JOG Eje1"
    Private Sub BtnE1_POS_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE1_POS_JOG.MouseDown
        Motor1.MoverJOG("+")
    End Sub
    Private Sub BtnE1_POS_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE1_POS_JOG.MouseUp
        Motor1.PararJOG()
    End Sub
    Private Sub BtnE1_NEG_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE1_NEG_JOG.MouseDown
        Motor1.MoverJOG("-")
    End Sub

    Private Sub BtnE1_NEG_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE1_NEG_JOG.MouseUp
        Motor1.PararJOG()
    End Sub
#End Region
#Region "btn JOG Eje2"
    Private Sub BtnE2_POS_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE2_POS_JOG.MouseDown
        Motor2.MoverJOG("+")
    End Sub
    Private Sub BtnE2_POS_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE2_POS_JOG.MouseUp
        Motor2.PararJOG()
    End Sub
    Private Sub BtnE2_NEG_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE2_NEG_JOG.MouseDown
        Motor2.MoverJOG("-")
    End Sub
    Private Sub BtnE2_NEG_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE2_NEG_JOG.MouseUp
        Motor2.PararJOG()
    End Sub
#End Region
#Region "btn JOG Eje3"
    Private Sub BtnE3_POS_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE3_POS_JOG.MouseDown
        Motor3.MoverJOG("+")
    End Sub
    Private Sub BtnE3_POS_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE3_POS_JOG.MouseUp
        Motor3.PararJOG()
    End Sub
    Private Sub BtnE3_NEG_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE3_NEG_JOG.MouseDown
        Motor3.MoverJOG("-")
    End Sub
    Private Sub BtnE3_NEG_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE3_NEG_JOG.MouseUp
        Motor3.PararJOG()
    End Sub
#End Region
#Region "btn JOG Eje4"
    Private Sub BtnE4_POS_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE4_POS_JOG.MouseDown
        Motor4.MoverJOG("+")
    End Sub
    Private Sub BtnE4_POS_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE4_POS_JOG.MouseUp
        Motor4.PararJOG()
    End Sub
    Private Sub BtnE4_NEG_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE4_NEG_JOG.MouseDown
        Motor4.MoverJOG("-")
    End Sub
    Private Sub BtnE4_NEG_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE4_NEG_JOG.MouseUp
        Motor4.PararJOG()
    End Sub

#End Region
#Region "btn JOG Eje5"
    Private Sub BtnE5_POS_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE5_POS_JOG.MouseDown
        Motor5.MoverJOG("+")
    End Sub
    Private Sub BtnE5_POS_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE5_POS_JOG.MouseUp
        Motor5.PararJOG()
    End Sub
    Private Sub BtnE5_NEG_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE5_NEG_JOG.MouseDown
        Motor5.MoverJOG("-")
    End Sub
    Private Sub BtnE5_NEG_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE5_NEG_JOG.MouseUp
        Motor5.PararJOG()
    End Sub
#End Region
#Region "btn JOG Eje6"
    Private Sub BtnE6_POS_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE6_POS_JOG.MouseDown
        Motor6.MoverJOG("+")
    End Sub
    Private Sub BtnE6_POS_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE6_POS_JOG.MouseUp
        Motor6.PararJOG()
    End Sub
    Private Sub BtnE6_NEG_JOG_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE6_NEG_JOG.MouseDown
        Motor6.MoverJOG("-")
    End Sub
    Private Sub BtnE6_NEG_JOG_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE6_NEG_JOG.MouseUp
        Motor6.PararJOG()
    End Sub
#End Region
#End Region
#Region "Joystick"
    Declare Function joyGetPosEx Lib "winmm.dll" (ByVal uJoyID As Integer, ByRef pji As JOYINFOEX) As Integer
    <StructLayout(LayoutKind.Sequential)>
    Public Structure JOYINFOEX
        Public dwSize As Integer
        Public dwFlags As Integer
        Public dwXpos As Integer
        Public dwYpos As Integer
        Public dwZpos As Integer
        Public dwRpos As Integer
        Public dwUpos As Integer
        Public dwVpos As Integer
        Public dwButtons As Integer
        Public dwButtonNumber As Integer
        Public dwPOV As Integer
        Public dwReserved1 As Integer
        Public dwReserved2 As Integer
    End Structure
    Dim myjoyEX As JOYINFOEX


    Function Joystick() As Integer      '
        Dim JoyXpos As String
        Dim JoyYpos As String
        Dim JoyZpos As String
        Dim JoyRpos As String
        Dim JoyButtons As String
        Dim JoyButtonNumber As String
        Dim JoyPOV As String
        ' SR   SL  Star/Selec R2 L2 R1 L1 4 3 2 1
        '2048/1024  /512/256/128/64/32/16/8/4/2/1

        'Eje1 -> R1/L1 
        'Eje2 -> SL
        'Eje3 -> SR
        'Eje4 -> R2/L2
        'Eje5 -> POV_U/D
        'Eje6 -> POV_R/L

        ' Get the joystick information
        Call joyGetPosEx(0, myjoyEX)

        With myjoyEX
            JoyXpos = .dwXpos.ToString          'Up to six axis supported
            JoyYpos = .dwYpos.ToString
            JoyZpos = .dwZpos.ToString
            JoyRpos = .dwRpos.ToString
            JoyButtons = .dwButtons.ToString 'Print in Hex, so can see the individual bits associated with the buttons
            JoyButtonNumber = .dwButtonNumber.ToString 'number of buttons pressed at the same time
            JoyPOV = .dwPOV.ToString 'POV hat (in 1/100ths of degrees, so divided by 100 to give degrees)

            LabelJOY1.Text = JoyXpos
            LabelJOY2.Text = JoyYpos
            LabelJOY3.Text = JoyZpos
            LabelJOY4.Text = JoyRpos
            LabelJOY5.Text = JoyButtons
            LabelJOY6.Text = JoyButtonNumber
            LabelJOY7.Text = JoyPOV
        End With





        If JoyYpos <> 0 Or JoyRpos <> 0 Or JoyPOV <> 0 Or JoyButtons <> 0 Then

            'Eje1
            Dim BtnJoyEje1Pos As Integer
            BtnJoyEje1Pos = CInt(JoyButtons) And 32
            If BtnJoyEje1Pos = 32 Then
                Motor1.MoverJOGJOY("+")
            End If
            Dim BtnJoyEje1Neg As Integer
            BtnJoyEje1Neg = CInt(JoyButtons) And 16
            If BtnJoyEje1Neg = 16 Then
                Motor1.MoverJOGJOY("-")
            End If
            If BtnJoyEje1Pos <> 32 And BtnJoyEje1Neg <> 16 Then
                Motor1.PararJOGJOY()
            End If

            'Eje2
            If JoyYpos < 32767 Then
                Motor2.MoverJOGJOY("+")
            End If
            If JoyYpos > 32767 Then
                Motor2.MoverJOGJOY("-")
            End If
            If JoyYpos = 32767 Then
                Motor2.PararJOGJOY()
            End If

            'Eje3
            If JoyRpos < 32767 Then
                Motor3.MoverJOGJOY("+")
            End If
            If JoyRpos > 32767 Then
                Motor3.MoverJOGJOY("-")
            End If
            If JoyRpos = 32767 Then
                Motor3.PararJOGJOY()
            End If

            'Eje4
            Dim BtnJoyEje4Pos As Integer
            BtnJoyEje4Pos = CInt(JoyButtons) And 128
            If BtnJoyEje4Pos = 128 Then
                Motor4.MoverJOGJOY("+")
            End If
            Dim BtnJoyEje4Neg As Integer
            BtnJoyEje4Neg = CInt(JoyButtons) And 64
            If BtnJoyEje4Neg = 64 Then
                Motor4.MoverJOGJOY("-")
            End If
            If BtnJoyEje4Pos <> 128 And BtnJoyEje4Neg <> 64 Then
                Motor4.PararJOGJOY()
            End If

            'Eje 5y6
            Select Case JoyPOV
                Case 0
                    Motor5.MoverJOGJOY("+")
                Case 4500
                    Motor5.MoverJOGJOY("+")
                    Motor6.MoverJOGJOY("+")
                Case 9000
                    Motor6.MoverJOGJOY("+")
                Case 13500
                    Motor5.MoverJOGJOY("-")
                    Motor6.MoverJOGJOY("+")
                Case 18000
                    Motor5.MoverJOGJOY("-")
                Case 22500
                    Motor5.MoverJOGJOY("-")
                    Motor6.MoverJOGJOY("-")
                Case 27000
                    Motor6.MoverJOGJOY("-")
                Case 31500
                    Motor5.MoverJOGJOY("+")
                    Motor6.MoverJOGJOY("-")
                Case Else
                    Motor5.PararJOGJOY()
                    Motor6.PararJOGJOY()
            End Select


        End If

#Region "Cambio Velocidad JOG JOY"
        If JoyButtons = 0 Then
            estadoSIGJOGJOY = True
            GripperAndaPOSJOY = False
            GripperAndaNEGJOY = False
        End If

        If JoyButtons = 8 And estadoJOGJOY8 = False And estadoSIGJOGJOY = True Then
            estadoJOGJOY8 = True
            estadoSIGJOGJOY = False
        End If
        If JoyButtons = 4 And estadoJOGJOY4 = False And estadoSIGJOGJOY = True Then
            estadoJOGJOY4 = True
            estadoSIGJOGJOY = False
        End If
        If JoyButtons = 2 And estadoJOGJOY2 = False And estadoSIGJOGJOY = True Then
            estadoJOGJOY2 = True
            estadoSIGJOGJOY = False
        End If
        If JoyButtons = 1 And estadoJOGJOY1 = False And estadoSIGJOGJOY = True Then
            estadoJOGJOY1 = True
            estadoSIGJOGJOY = False
        End If

        If JoyButtons = 2048 And estadoJOGJOY2048 = False And estadoSIGJOGJOY = True Then
            estadoJOGJOY2048 = True
            estadoSIGJOGJOY = False
        End If

        If JoyButtons = 1024 And estadoJOGJOY1024 = False And estadoSIGJOGJOY = True Then
            estadoJOGJOY1024 = True
            estadoSIGJOGJOY = False
        End If

        If estadoJOGJOY1024 = True Then
            estadoJOGJOY1024 = False
            GripperAndaNEGJOY = True
        End If
        If estadoJOGJOY2048 = True Then
            estadoJOGJOY2048 = False
            GripperAndaPOSJOY = True
        End If



        If estadoJOGJOY8 = True And cambioVelocidadEjeJOG < 6 Then
            cambioVelocidadEjeJOG += 1
            estadoJOGJOY8 = False
        End If
        If estadoJOGJOY8 = True And cambioVelocidadEjeJOG = 6 Then
            cambioVelocidadEjeJOG = 1
            estadoJOGJOY8 = False
        End If

        If estadoJOGJOY4 = True And cambioVelocidadEjeJOG > 1 Then
            cambioVelocidadEjeJOG -= 1
            estadoJOGJOY4 = False
        End If

        If estadoJOGJOY4 = True And cambioVelocidadEjeJOG = 1 Then
            cambioVelocidadEjeJOG = 6
            estadoJOGJOY4 = False
        End If




        Select Case cambioVelocidadEjeJOG
            Case 1
                If estadoJOGJOY1 = True And cmbVelocidadJOG1.Value < 9 Then
                    cmbVelocidadJOG1.Value += 1
                    estadoJOGJOY1 = False
                End If
                If estadoJOGJOY2 = True And cmbVelocidadJOG1.Value > 1 Then
                    cmbVelocidadJOG1.Value -= 1
                    estadoJOGJOY2 = False
                End If
                FlechaVelJOGJoy.Location = New Point(106, 111)

            Case 2
                If estadoJOGJOY1 = True And cmbVelocidadJOG2.Value < 9 Then
                    cmbVelocidadJOG2.Value += 1
                    estadoJOGJOY1 = False
                End If
                If estadoJOGJOY2 = True And cmbVelocidadJOG2.Value > 1 Then
                    cmbVelocidadJOG2.Value -= 1
                    estadoJOGJOY2 = False
                End If
                FlechaVelJOGJoy.Location = New Point(106, 155)

            Case 3
                If estadoJOGJOY1 = True And cmbVelocidadJOG3.Value < 9 Then
                    cmbVelocidadJOG3.Value += 1
                    estadoJOGJOY1 = False
                End If
                If estadoJOGJOY2 = True And cmbVelocidadJOG3.Value > 1 Then
                    cmbVelocidadJOG3.Value -= 1
                    estadoJOGJOY2 = False
                End If
                FlechaVelJOGJoy.Location = New Point(106, 199)

            Case 4
                If estadoJOGJOY1 = True And cmbVelocidadJOG4.Value < 9 Then
                    cmbVelocidadJOG4.Value += 1
                    estadoJOGJOY1 = False
                End If
                If estadoJOGJOY2 = True And cmbVelocidadJOG4.Value > 1 Then
                    cmbVelocidadJOG4.Value -= 1
                    estadoJOGJOY2 = False
                End If
                FlechaVelJOGJoy.Location = New Point(106, 243)

            Case 5
                If estadoJOGJOY1 = True And cmbVelocidadJOG5.Value < 9 Then
                    cmbVelocidadJOG5.Value += 1
                    estadoJOGJOY1 = False
                End If
                If estadoJOGJOY2 = True And cmbVelocidadJOG5.Value > 1 Then
                    cmbVelocidadJOG5.Value -= 1
                    estadoJOGJOY2 = False
                End If
                FlechaVelJOGJoy.Location = New Point(106, 287)

            Case 6
                If estadoJOGJOY1 = True And cmbVelocidadJOG6.Value < 9 Then
                    cmbVelocidadJOG6.Value += 1
                    estadoJOGJOY1 = False
                End If
                If estadoJOGJOY2 = True And cmbVelocidadJOG6.Value > 1 Then
                    cmbVelocidadJOG6.Value -= 1
                    estadoJOGJOY2 = False
                End If
                FlechaVelJOGJoy.Location = New Point(106, 331)

        End Select



#End Region



        Return 0
    End Function
#End Region
#Region "Generar PaqueteJOG"
    Function GenerarPaqueteJOG() As String
        If Motor1.EstadoMotorJOG = True Or Motor1.EstadoMotorJOGJOY = True Then
            PaqueteJOG = "*" + "1" + Motor1.DireccionMotorJOG + "00001" + CStr(cmbVelocidadJOG1.Value)
        Else
            PaqueteJOG = "*" + "1" + "+" + "00000" + CStr(cmbVelocidadJOG1.Value)
        End If

        If Motor2.EstadoMotorJOG = True Or Motor2.EstadoMotorJOGJOY = True Then
            PaqueteJOG = PaqueteJOG + "2" + Motor2.DireccionMotorJOG + "00001" + CStr(cmbVelocidadJOG2.Value)
        Else
            PaqueteJOG = PaqueteJOG + "2" + "+" + "00000" + CStr(cmbVelocidadJOG2.Value)
        End If

        If Motor3.EstadoMotorJOG = True Or Motor3.EstadoMotorJOGJOY = True Then
            PaqueteJOG = PaqueteJOG + "3" + Motor3.DireccionMotorJOG + "00001" + CStr(cmbVelocidadJOG3.Value)
        Else
            PaqueteJOG = PaqueteJOG + "3" + "+" + "00000" + CStr(cmbVelocidadJOG3.Value)
        End If

        If Motor4.EstadoMotorJOG = True Or Motor4.EstadoMotorJOGJOY = True Then
            PaqueteJOG = PaqueteJOG + "4" + Motor4.DireccionMotorJOG + "00001" + CStr(cmbVelocidadJOG4.Value)
        Else
            PaqueteJOG = PaqueteJOG + "4" + "+" + "00000" + CStr(cmbVelocidadJOG4.Value)
        End If

        If Motor5.EstadoMotorJOG = True Or Motor5.EstadoMotorJOGJOY = True Then
            PaqueteJOG = PaqueteJOG + "5" + Motor5.DireccionMotorJOG + "00001" + CStr(cmbVelocidadJOG5.Value)
        Else
            PaqueteJOG = PaqueteJOG + "5" + "+" + "00000" + CStr(cmbVelocidadJOG5.Value)
        End If

        If Motor6.EstadoMotorJOG = True Or Motor6.EstadoMotorJOGJOY = True Then
            PaqueteJOG = PaqueteJOG + "6" + Motor6.DireccionMotorJOG + "00001" + CStr(cmbVelocidadJOG6.Value) + "*"
        Else
            PaqueteJOG = PaqueteJOG + "6" + "+" + "00000" + CStr(cmbVelocidadJOG6.Value) + "*"
        End If


        tboxModoAct.Text = PaqueteJOG



        'If TimerJOG > 100 Then

        'If Motor1.DifEstadoJOG = True Or Motor2.DifEstadoJOG = True Or Motor3.DifEstadoJOG = True Or Motor4.DifEstadoJOG = True Or Motor5.DifEstadoJOG = True Or Motor6.DifEstadoJOG = True Then
        'clienteTCP.EnviarDatos(PaqueteJOG)
        'End If
        'If Motor1.DifEstadoJOGJOY = True Or Motor2.DifEstadoJOGJOY = True Or Motor3.DifEstadoJOGJOY = True Or Motor4.DifEstadoJOGJOY = True Or Motor5.DifEstadoJOGJOY = True Or Motor6.DifEstadoJOGJOY = True Then
        'clienteTCP.EnviarDatos(PaqueteJOG)
        'End If

        'TimerJOG = 0
        'End If





        Motor1.IgualarEstadosJOG()
        Motor2.IgualarEstadosJOG()
        Motor3.IgualarEstadosJOG()
        Motor4.IgualarEstadosJOG()
        Motor5.IgualarEstadosJOG()
        Motor6.IgualarEstadosJOG()
        Motor1.IgualarEstadosJOGJOY()
        Motor2.IgualarEstadosJOGJOY()
        Motor3.IgualarEstadosJOGJOY()
        Motor4.IgualarEstadosJOGJOY()
        Motor5.IgualarEstadosJOGJOY()
        Motor6.IgualarEstadosJOGJOY()

        Return 0
    End Function
#End Region
#End Region

#Region "Secuencia"

#Region "Reproducir"
    Public Sub ReiniciarSEC()
        repSec = False
        puedoMandarSIGSEC = False
        PasoSecAct = 0
        'clienteTCP.EnviarDatos("*F*")
    End Sub

    Public Sub ReproducirSecuencia()
        If repSec Then
            If PasoSecAct < File.ReadAllLines(SecAct).Length Then
                If File.ReadAllLines(SecAct).ElementAt(PasoSecAct).ToString() = "*S*" Then
                    clienteTCP.EnviarDatos(File.ReadAllLines(SecAct).ElementAt(PasoSecAct).ToString())
                    PasoSecAct += 1
                End If

                If PasoSecAct = 1 And buffer.Contains("*S*") Then
                    clienteTCP.EnviarDatos(File.ReadAllLines(SecAct).ElementAt(PasoSecAct).ToString())

                    PasoSecAct += 1
                    puedoMandarSIGSEC = True
                End If
                If File.ReadAllLines(SecAct).ElementAt(PasoSecAct).ToString() = "*F*" Then
                    ReiniciarSEC()
                    MsgBox("Secuencia completa")

                End If

                If File.ReadAllLines(SecAct).ElementAt(PasoSecAct).ToString().Contains("delay(") Then

                    tboxSecAct.Text = File.ReadAllLines(SecAct).ElementAt(PasoSecAct).ToString().Substring(6, 2)
                    DelaySec = CInt(tboxSecAct.Text) '* 10
                    PasoSecAct += 1

                ElseIf DelaySec = 0 Then
                    If puedoMandarSIGSEC Then
                        clienteTCP.EnviarDatos(File.ReadAllLines(SecAct).ElementAt(PasoSecAct).ToString())
                        PasoSecAct += 1
                        puedoMandarSIGSEC = False
                    End If

                    If Posbuffer = File.ReadAllLines(SecAct).ElementAt(PasoSecAct).ToString() And puedoMandarSIGSEC = False And PasoSecAct > 1 Then

                        PasoSecAct += 1
                        puedoMandarSIGSEC = True
                    End If

                Else : DelaySec -= 1
                End If
            Else
                repSec = False
            End If
        Else
            EstadoModoRSEC = False
        End If
    End Sub
    Private Sub BtnCamDirSEC_Click(sender As Object, e As EventArgs) Handles btnCamDirSEC.Click
        FolderBrowserSEC.ShowDialog()

        ListSEC_Select.DataSource = Directory.GetFiles(FolderBrowserSEC.SelectedPath, "*.SEC")

    End Sub


    Private Sub BtnCargarSec_Click(sender As Object, e As EventArgs) Handles btnCargarSec.Click
        tboxNomSecAct.Text = ""
        lboxSecAct.Items.Clear()
        ReiniciarSEC()

        tboxNomSecAct.Text = My.Computer.FileSystem.GetName(ListSEC_Select.SelectedItem.ToString)

        lboxSecAct.Items.AddRange(File.ReadAllLines(ListSEC_Select.SelectedItem.ToString))

    End Sub

    Private Sub BtnEjecSec_Click(sender As Object, e As EventArgs) Handles btnEjecSec.Click
        ReiniciarSEC()
        clienteTCP.EnviarDatos("#R#")

        SecAct = ListSEC_Select.SelectedItem.ToString
        repSec = True
        PasoSecAct = 0
    End Sub

    Private Sub BtnPararSec_Click(sender As Object, e As EventArgs) Handles btnPararSec.Click
        ReiniciarSEC()
        clienteTCP.EnviarDatos("*F*")
    End Sub

#End Region
#Region "Crear"

#End Region
#End Region

#Region "Manejo de Tabs"
    Private Sub BtnTabHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTabHome.Click
        Screens.SelectTab(TabHome)
    End Sub

    Private Sub BtnTabConfig_Click(sender As Object, e As EventArgs) Handles BtnTabConfig.Click
        Screens.SelectTab(TabConfiguracion)
    End Sub
    Private Sub BtnTabJOG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTabJOG.Click
        Screens.SelectTab(TabJOG)
    End Sub
    Private Sub BtnTabCtrlManual_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTabCtrlManual.Click
        Screens.SelectTab(TabControlManual)
    End Sub
    Private Sub BtnDesrollador_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDesrollador.Click
        Screens.SelectTab(TabDesarrollador)
    End Sub
    Private Sub btnTabSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTabSec.Click
        Screens.SelectTab(TabSecuencia)
    End Sub
#End Region

#Region "Funciones Visuales"
    Public Sub Home()
        clienteTCP.EnviarDatos("*0*")
        PosicionesACero()
    End Sub
    Public Sub CambiarLEDModo()
        Try
            If buffer.Contains("#OK-J#") Then
                RED_LED_Mode.Image = My.Resources.Led_Red_ON
                YEL_LED_Mode.Image = My.Resources.Led_Yel_OFF
                GRE_LED_Mode.Image = My.Resources.Led_Gre_OFF
                tboxModoAct.Text = "Modo JOG activado"
                EstadoModoJOG = True
                EStadoModoMAN = False
                EstadoModoCSEC = False
                EstadoModoRSEC = False
            End If
            If buffer.Contains("#OK-M#") Then
                RED_LED_Mode.Image = My.Resources.Led_Red_OFF
                YEL_LED_Mode.Image = My.Resources.Led_Yel_ON
                GRE_LED_Mode.Image = My.Resources.Led_Gre_OFF
                tboxModoAct.Text = "Modo Manual activado"
                EstadoModoJOG = False
                EStadoModoMAN = True
                EstadoModoCSEC = False
                EstadoModoRSEC = False

            End If
            If buffer.Contains("#OK-C#") Then
                RED_LED_Mode.Image = My.Resources.Led_Red_ON
                YEL_LED_Mode.Image = My.Resources.Led_Yel_OFF
                GRE_LED_Mode.Image = My.Resources.Led_Gre_ON
                tboxModoAct.Text = "Modo crear secuencia activado"
                EstadoModoJOG = False
                EStadoModoMAN = False
                EstadoModoCSEC = True
                EstadoModoRSEC = False

            End If
            If buffer.Contains("#OK-R#") Then
                RED_LED_Mode.Image = My.Resources.Led_Red_OFF
                YEL_LED_Mode.Image = My.Resources.Led_Yel_ON
                GRE_LED_Mode.Image = My.Resources.Led_Gre_ON
                tboxModoAct.Text = "Modo reproducir secuencia activado"
                EstadoModoJOG = False
                EStadoModoMAN = False
                EstadoModoCSEC = False
                EstadoModoRSEC = True

            End If
        Catch Ebuffer As Exception
        End Try




    End Sub
    Public Sub DeshabilitarMotor()      'inhabilita manipulacion de ejes
        nupMotor1Man.Enabled = False
        nupMotor2Man.Enabled = False
        nupMotor3Man.Enabled = False
        nupMotor4Man.Enabled = False
        nupMotor5Man.Enabled = False
        nupMotor6Man.Enabled = False

        AumPosMotor1.Enabled = False
        AumPosMotor2.Enabled = False
        AumPosMotor3.Enabled = False
        AumPosMotor4.Enabled = False
        AumPosMotor5.Enabled = False
        AumPosMotor6.Enabled = False

        DisPosMotor1.Enabled = False
        DisPosMotor2.Enabled = False
        DisPosMotor3.Enabled = False
        DisPosMotor4.Enabled = False
        DisPosMotor5.Enabled = False
        DisPosMotor6.Enabled = False

        btnMotor1.Image = My.Resources.CandadoCerrado
        btnMotor2.Image = My.Resources.CandadoCerrado
        btnMotor3.Image = My.Resources.CandadoCerrado
        btnMotor4.Image = My.Resources.CandadoCerrado
        btnMotor5.Image = My.Resources.CandadoCerrado
        btnMotor6.Image = My.Resources.CandadoCerrado

        nupMotor1Man.Value = "0"
        nupMotor2Man.Value = "0"
        nupMotor3Man.Value = "0"
        nupMotor4Man.Value = "0"
        nupMotor5Man.Value = "0"
        nupMotor6Man.Value = "0"

        NumeroMotor = 0
        Direccion = "+"
        Clock.Image = My.Resources.Clk

    End Sub
    Public Sub DeshabilitarModoJOG()
        cmbVelocidadJOG1.Enabled = False
        btnE1_POS_JOG.Enabled = False
        btnE1_NEG_JOG.Enabled = False
        cmbVelocidadJOG2.Enabled = False
        btnE2_POS_JOG.Enabled = False
        btnE2_NEG_JOG.Enabled = False
        cmbVelocidadJOG3.Enabled = False
        btnE3_POS_JOG.Enabled = False
        btnE3_NEG_JOG.Enabled = False
        cmbVelocidadJOG4.Enabled = False
        btnE4_POS_JOG.Enabled = False
        btnE4_NEG_JOG.Enabled = False
        cmbVelocidadJOG5.Enabled = False
        btnE5_POS_JOG.Enabled = False
        btnE5_NEG_JOG.Enabled = False
        cmbVelocidadJOG6.Enabled = False
        btnE6_POS_JOG.Enabled = False
        btnE6_NEG_JOG.Enabled = False
        EstadoModoJOG = False

    End Sub
    Public Sub DeshabilitarModoMAN()
        btnMotor1.Enabled = False
        btnMotor2.Enabled = False
        btnMotor3.Enabled = False
        btnMotor4.Enabled = False
        btnMotor5.Enabled = False
        btnMotor6.Enabled = False
        btnPosOrigenMan.Enabled = False
        Clock.Enabled = False
        cmbVelocidadMan.Enabled = False
        PrevManual.Enabled = False
        Clear.Enabled = False
        BtnSend.Enabled = False
        EStadoModoMAN = False

    End Sub
    Public Sub Inicializar()
        tboxHomeEstadoEJE1.Enabled = False
        tboxHomeEstadoEJE2.Enabled = False
        tboxHomeEstadoEJE3.Enabled = False
        tboxHomeEstadoEJE4.Enabled = False
        tboxHomeEstadoEJE5.Enabled = False
        tboxHomeEstadoEJE6.Enabled = False
        tboxJOGEstadoEJE1.Enabled = False
        tboxJOGEstadoEJE2.Enabled = False
        tboxJOGEstadoEJE3.Enabled = False
        tboxJOGEstadoEJE4.Enabled = False
        tboxJOGEstadoEJE5.Enabled = False
        tboxJOGEstadoEJE6.Enabled = False
        btnMotor1.Enabled = False
        btnMotor2.Enabled = False
        btnMotor3.Enabled = False
        btnMotor4.Enabled = False
        btnMotor5.Enabled = False
        btnMotor6.Enabled = False
        btnPosOrigenMan.Enabled = False
        Clock.Enabled = False
        cmbVelocidadMan.Enabled = False
        PrevManual.Enabled = False
        Clear.Enabled = False
        BtnSend.Enabled = False
        cmbStepEje1.SelectedItem = "32"
        cmbStepEje2.SelectedItem = "32"
        cmbStepEje3.SelectedItem = "32"
        cmbStepEje4.SelectedItem = "32"
        cmbStepEje5.SelectedItem = "32"
        cmbStepEje6.SelectedItem = "32"


    End Sub
    Public Sub HabilitarModoJOG()
        EstadoModoJOG = True
        cmbVelocidadJOG1.Enabled = True
        btnE1_POS_JOG.Enabled = True
        btnE1_NEG_JOG.Enabled = True
        cmbVelocidadJOG2.Enabled = True
        btnE2_POS_JOG.Enabled = True
        btnE2_NEG_JOG.Enabled = True
        cmbVelocidadJOG3.Enabled = True
        btnE3_POS_JOG.Enabled = True
        btnE3_NEG_JOG.Enabled = True
        cmbVelocidadJOG4.Enabled = True
        btnE4_POS_JOG.Enabled = True
        btnE4_NEG_JOG.Enabled = True
        cmbVelocidadJOG5.Enabled = True
        btnE5_POS_JOG.Enabled = True
        btnE5_NEG_JOG.Enabled = True
        cmbVelocidadJOG6.Enabled = True
        btnE6_POS_JOG.Enabled = True
        btnE6_NEG_JOG.Enabled = True
        clienteTCP.EnviarDatos("#J#")

    End Sub
    Public Sub HabilitarModoMAN()
        clienteTCP.EnviarDatos("#M#")
        EStadoModoMAN = True
        btnMotor1.Enabled = True
        btnMotor2.Enabled = True
        btnMotor3.Enabled = True
        btnMotor4.Enabled = True
        btnMotor5.Enabled = True
        btnMotor6.Enabled = True
        btnPosOrigenMan.Enabled = True
        Clock.Enabled = True
        cmbVelocidadMan.Enabled = True
        Clear.Enabled = True
        BtnSend.Enabled = True

    End Sub

    Public Sub StyleButton(ByVal Button)
        Button.FlatStyle = FlatStyle.Flat
        Button.FlatAppearance.BorderSize = 0
        'Button.BackColor = Color.Gray

        Dim ellipseRadius As New Drawing2D.GraphicsPath
        ellipseRadius.StartFigure()
        ellipseRadius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        ellipseRadius.AddLine(20, 0, Button.Width - 20, 0)
        ellipseRadius.AddArc(New Rectangle(Button.Width - 20, 0, 20, 20), -90, 90)
        ellipseRadius.AddLine(Button.Width, 20, Button.Width, Button.Height - 20)
        ellipseRadius.AddArc(New Rectangle(Button.Width - 20, Button.Height - 20, 20, 20), 0, 90)
        ellipseRadius.AddLine(Button.Width - 20, Button.Height, 20, Button.Height)
        ellipseRadius.AddArc(New Rectangle(0, Button.Height - 20, 20, 20), 90, 90)
        ellipseRadius.CloseFigure()
        Button.Region = New Region(ellipseRadius)
    End Sub
#End Region

#Region "Conectar Robot"
    Private Sub BtnConnectRobot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConnectRobot.Click
        PosicionesACero()

        clienteTCP.IpRemota = TBox_IpRobot.Text
        clienteTCP.PuertoRemoto = TBox_PortRobot.Text

        Try
            clienteTCP.Conectar()
            EstadoIP_Robot.Text = "Conectado"
            EstadoPingRobot.Image = My.Resources.ConectadoRobot
        Catch ex As Exception
            MsgBox("No se pudo conectar al equipo con IP: " + TBox_IpRobot.Text + ":" + TBox_PortRobot.Text)
        End Try

        ConfMicroSteps()
        clienteTCP.EnviarDatos("&2&")
    End Sub
    Private Sub BtnDesconectar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDesconectar.Click
        clienteTCP.Desconectar()
        EstadoIP_Robot.Text = "Desconectado"
        EstadoPingRobot.Image = My.Resources.ErrorPing
    End Sub

    Public Sub ConfMicroSteps()
        Dim PaqueteMicroStep As String
        Dim TraduccionPasos(5) As Char
        TraduccionPasos(0) = "A"
        TraduccionPasos(1) = "B"
        TraduccionPasos(2) = "C"
        TraduccionPasos(3) = "D"
        TraduccionPasos(4) = "E"
        TraduccionPasos(5) = "F"


        PaqueteMicroStep = "$"
        PaqueteMicroStep += TraduccionPasos(cmbStepEje1.SelectedIndex)
        PaqueteMicroStep += TraduccionPasos(cmbStepEje2.SelectedIndex)
        PaqueteMicroStep += TraduccionPasos(cmbStepEje3.SelectedIndex)
        PaqueteMicroStep += TraduccionPasos(cmbStepEje4.SelectedIndex)
        PaqueteMicroStep += TraduccionPasos(cmbStepEje5.SelectedIndex)
        PaqueteMicroStep += TraduccionPasos(cmbStepEje6.SelectedIndex)
        PaqueteMicroStep += "$"

        clienteTCP.EnviarDatos(PaqueteMicroStep)

    End Sub

    Private Sub btnCargarConf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarConf.Click
        ConfMicroSteps()
    End Sub
#End Region

#Region "Posicion"
    Public Sub bloquearPantalla()
        RichTextBox1.Text = RichTextBox1.Text + "<PANTALLA BLOQUEADA>"
    End Sub

    Public Sub desbloquearPantalla()
        RichTextBox1.Text = RichTextBox1.Text + "<PANTALLA DESBLOQUEADA>"
    End Sub

    Public Sub actualizarPosicion(ByVal buffer)
        PosicionActual(0) = buffer.Substring(3, 5)
        PosicionActual(1) = buffer.Substring(11, 5)
        PosicionActual(2) = buffer.Substring(19, 5)
        PosicionActual(3) = buffer.Substring(27, 5)
        PosicionActual(4) = buffer.Substring(35, 5)
        PosicionActual(5) = buffer.Substring(43, 5)

        tboxJOGEstadoEJE1.Text = (PosicionActual(0) * (360 / (cmbStepEje1.SelectedItem.ToString * 200 * 11.11))).ToString("0.00º")
        tboxJOGEstadoEJE2.Text = (PosicionActual(1) * (360 / (cmbStepEje2.SelectedItem.ToString * 200 * 6.01))).ToString("0.00º")
        tboxJOGEstadoEJE3.Text = (PosicionActual(2) * (360 / (cmbStepEje3.SelectedItem.ToString * 200 * 23.73))).ToString("0.00º")
        tboxJOGEstadoEJE4.Text = (PosicionActual(3) * (360 / (cmbStepEje4.SelectedItem.ToString * 200 * 1.0))).ToString("0.00º")
        tboxJOGEstadoEJE5.Text = (PosicionActual(4) * (360 / (cmbStepEje5.SelectedItem.ToString * 200 * 4.88))).ToString("0.00º")
        tboxJOGEstadoEJE6.Text = (PosicionActual(5) * (360 / (cmbStepEje6.SelectedItem.ToString * 200 * 1.0))).ToString("0.00º")

        tboxHomeEstadoEJE1.Text = tboxJOGEstadoEJE1.Text
        tboxHomeEstadoEJE2.Text = tboxJOGEstadoEJE2.Text
        tboxHomeEstadoEJE3.Text = tboxJOGEstadoEJE3.Text
        tboxHomeEstadoEJE4.Text = tboxJOGEstadoEJE4.Text
        tboxHomeEstadoEJE5.Text = tboxJOGEstadoEJE5.Text
        tboxHomeEstadoEJE6.Text = tboxJOGEstadoEJE6.Text

    End Sub

    Public Sub PosicionesACero()
        actualizarPosicion("*1+0000032+0000033+0000034+0000035+0000036+000003*")
    End Sub

#End Region

#Region "Gripper"
    Private Sub BtnGripperON_MouseUp(sender As Object, e As MouseEventArgs) Handles btnGripperON.MouseUp
        GripperAndaPOSKEY = False
    End Sub
    Private Sub BtnGripperON_MouseDown(sender As Object, e As MouseEventArgs) Handles btnGripperON.MouseDown
        GripperAndaPOSKEY = True
    End Sub
    Private Sub BtnGripperOFF_MouseUp(sender As Object, e As MouseEventArgs) Handles btnGripperOFF.MouseUp
        GripperAndaNEGKEY = False
    End Sub
    Private Sub BtnGripperOFF_MouseDown(sender As Object, e As MouseEventArgs) Handles btnGripperOFF.MouseDown
        GripperAndaNEGKEY = True
    End Sub

    Function Gripper(ByVal Estado As Boolean) As Integer
        If Estado Then
            If TimmerGripper < 51 Then
                TimmerGripper += 1
            End If
        ElseIf TimmerGripper > 0 Then
            TimmerGripper -= 1
        End If
        ProgressBarGripper.Value = TimmerGripper

        Select Case TimmerGripper
            Case 10
                clienteTCP.EnviarDatos("&2&")
            Case 20
                clienteTCP.EnviarDatos("&4&")
            Case 30
                clienteTCP.EnviarDatos("&6&")
            Case 40
                clienteTCP.EnviarDatos("&8&")
            Case 50
                clienteTCP.EnviarDatos("&9&")
        End Select

        Return 0
    End Function
#End Region



    Private Sub While_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'todo lo que este aca se repite cada 1ms
        CambiarLEDModo()

        If GripperAndaPOSKEY Or GripperAndaPOSJOY Then
            Gripper(True)
        End If
        If GripperAndaNEGKEY Or GripperAndaNEGJOY Then
            Gripper(False)
        End If





        If EStadoModoMAN = True Then
            RefeshManual()
        End If


        If EstadoModoJOG = True Then
            Joystick()
            GenerarPaqueteJOG()

            TimerJOG += 1
            If TimerJOG > 40 Then
                If AntPaqueteJOG <> PaqueteJOG Then
                    clienteTCP.EnviarDatos(PaqueteJOG)
                    AntPaqueteJOG = PaqueteJOG
                    TimerJOG = 0
                End If
            End If
        End If


        Try
            If EstadoModoRSEC Then
                ReproducirSecuencia()
                lboxSecAct.SelectedIndex = PasoSecAct - 1
            End If
        Catch ex As Exception
            ReiniciarSEC()
            MsgBox("Ocurrio un error en reproducir la secuencia, reiniciando modo")
        End Try





        If clienteTCP.IsConected() = False Then
            clienteTCP.Desconectar()
            EstadoIP_Robot.Text = "Desconectado"
            EstadoPingRobot.Image = My.Resources.ErrorPing
        End If


        Dim flagMensajeNuevo As Boolean
        flagMensajeNuevo = False
        clienteTCP.ProcesaDatos()
        buffer = clienteTCP.BufferAcumulado()
        If AntRecibido <> buffer Then
            RichTextBox1.Text = RichTextBox1.Text + buffer
            AntRecibido = buffer
            flagMensajeNuevo = True
        End If


        Try
            If buffer.Contains("*1+") Then
                Posbuffer = buffer.Substring(0, 50)
                actualizarPosicion(Posbuffer)
            End If
        Catch Ebuffer As Exception
        End Try






    End Sub








    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Const fichero As String = "Prueba.sec"
        Dim texto As String = "ACA van las secuencias"
        Dim a As New System.IO.StreamWriter(fichero)

        a.WriteLine("a")
        a.WriteLine("b")
        a.WriteLine(texto)
        a.Close()


        'Dim line As String

        'Using reader As StreamReader = New StreamReader("Prueba.txt", True)
        'line = reader.ReadLine
        'End Using

        '       RichTextBox4.Text = line

        tboxSecAct.Text = File.ReadAllLines(fichero).ElementAt(0).ToString()

    End Sub


    Private Sub BtnCrearSec_Click(sender As Object, e As EventArgs) Handles btnCrearSec.Click
        clienteTCP.EnviarDatos("*S*")
        Dim tempSEC As New System.IO.StreamWriter("temp.sec")
        tempSEC.WriteLine("*S*")
        tempSEC.Close()
        Screens.SelectTab(TabJOG)



    End Sub

    Private Sub BtnGuardarMov_Click(sender As Object, e As EventArgs) Handles btnGuardarMov.Click
        clienteTCP.EnviarDatos("*E*")
        Using writer As New StreamWriter("temp.sec", True)
            writer.WriteLine(tboxModoAct.Text)
        End Using


    End Sub

    Private Sub BtnGuardarSec_Click(sender As Object, e As EventArgs) Handles btnGuardarSec.Click
        Try
            SaveSec.ShowDialog()
            Dim TempDirectory As New System.IO.StreamWriter(SaveSec.FileName)
            TempDirectory.Close()

            Using writer As New StreamWriter("temp.sec", True)
                writer.WriteLine("*F*")
            End Using

            'Dim Directory As String = System.IO.Path.GetDirectoryName(SaveSec.FileName)
            'My.Computer.FileSystem.MoveFile(SaveSec.FileName, "C:\Users\z003te6n\Desktop\WindowsApplication1.6.3")
            'My.Computer.FileSystem.RenameFile("temp.sec", System.IO.Path.GetFileName(SaveSec.FileName))

            File.Replace("temp.sec", SaveSec.FileName, "Temp.temp")

            File.Delete("Temp.temp")

            MsgBox("Guardado exitoso")
        Catch ex As Exception
            MsgBox("Error en guardado")
        End Try

    End Sub


End Class
