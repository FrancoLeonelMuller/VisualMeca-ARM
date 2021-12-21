Imports System.Runtime.InteropServices

Public Class Ventana

    Dim estado As Boolean = True        'variable para estado del boton
    Dim Direccion As String
    Dim Instrucciones As String         'Instrucciones para los motores
    Dim NumeroMotor As Integer

    Dim EStadoModoMAN As Boolean = False
    Dim EstadoModoJOG As Boolean = False
    Dim EStadoModoSEC As Boolean = False


    Dim clienteTCP As Cliente = New Cliente

    Dim Motor1 As Motor = New Motor
    Dim Motor2 As Motor = New Motor
    Dim Motor3 As Motor = New Motor
    Dim Motor4 As Motor = New Motor
    Dim Motor5 As Motor = New Motor
    Dim Motor6 As Motor = New Motor

    Dim PaqueteJOG As String

    Dim AntRecibido As String

#Region "Modo Manual"
    Private Sub BtnHab_Man_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHab_Man.Click
        HabilitarModoMAN()
        DeshabilitarModoJOG()
    End Sub
    Private Sub BtnPosOrigenMan_Click(sender As Object, e As EventArgs) Handles btnPosOrigenMan.Click
        PosicionOrigen()
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
        cmbVelocidadMan.Value = "0"
        DeshabilitarMotor()
        estado = True
    End Sub
    Private Sub BtnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSend.Click
        clienteTCP.EnviarDatos(TextBox1.Text)
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
#End Region
#End Region

#Region "Modo JOG"
    Private Sub BtnHabJOG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHabJOG.Click
        HabilitarModoJOG()
        DeshabilitarModoMAN()
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


        RichTextBox2.Text = PaqueteJOG

        If Motor1.DifEstadoJOG = True Or Motor2.DifEstadoJOG = True Or Motor3.DifEstadoJOG = True Or Motor4.DifEstadoJOG = True Or Motor5.DifEstadoJOG = True Or Motor6.DifEstadoJOG = True Then
            clienteTCP.EnviarDatos(PaqueteJOG)
        End If
        If Motor1.DifEstadoJOGJOY = True Or Motor2.DifEstadoJOGJOY = True Or Motor3.DifEstadoJOGJOY = True Or Motor4.DifEstadoJOGJOY = True Or Motor5.DifEstadoJOGJOY = True Or Motor6.DifEstadoJOGJOY = True Then
            clienteTCP.EnviarDatos(PaqueteJOG)
        End If


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

#Region "Manejo de Tabs"
    Private Sub BtnTabHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTabHome.Click
        Screens.SelectTab(TabHome)
    End Sub

    Private Sub BtnTabConexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTabConexion.Click
        Screens.SelectTab(TabConexion)
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
    Function DeshabilitarMotor() As Integer      'inhabilita manipulacion de ejes
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
        Return 0
    End Function
    Function DeshabilitarModoJOG() As Integer
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
        Return 0
    End Function
    Function DeshabilitarModoMAN() As Integer
        btnMotor1.Enabled = False
        btnMotor2.Enabled = False
        btnMotor3.Enabled = False
        btnMotor4.Enabled = False
        btnMotor5.Enabled = False
        btnMotor6.Enabled = False
        btnPosOrigenMan.Enabled = False
        Clock.Enabled = False
        cmbVelocidadMan.Enabled = False
        TextBox1.Enabled = False
        Clear.Enabled = False
        BtnSend.Enabled = False
        Return 0
    End Function
    Function Inicializar() As Integer
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
        TextBox1.Enabled = False
        Clear.Enabled = False
        BtnSend.Enabled = False

        Return 0
    End Function
    Function HabilitarModoJOG() As Integer
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

        Return 0
    End Function
    Function HabilitarModoMAN() As Integer
        btnMotor1.Enabled = True
        btnMotor2.Enabled = True
        btnMotor3.Enabled = True
        btnMotor4.Enabled = True
        btnMotor5.Enabled = True
        btnMotor6.Enabled = True
        btnPosOrigenMan.Enabled = True
        Clock.Enabled = True
        cmbVelocidadMan.Enabled = True
        TextBox1.Enabled = True
        Clear.Enabled = True
        BtnSend.Enabled = True
        clienteTCP.EnviarDatos("#M#")
        Return 0
    End Function
#End Region

#Region "Conectar Robot"
    Private Sub BtnConnectRobot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConnectRobot.Click
        clienteTCP.IpRemota = TBox_IpRobot.Text
        clienteTCP.PuertoRemoto = TBox_PortRobot.Text

        Try
            clienteTCP.Conectar()
            EstadoIP_Robot.Text = "Conectado"
            EstadoPingRobot.Image = My.Resources.ConectadoRobot
        Catch ex As Exception
            MsgBox("No se pudo conectar al equipo con IP: " + TBox_IpRobot.Text + ":" + TBox_PortRobot.Text)
        End Try
    End Sub
    Private Sub BtnDesconectar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDesconectar.Click
        clienteTCP.Desconectar()
        EstadoIP_Robot.Text = "Desconectado"
        EstadoPingRobot.Image = My.Resources.ErrorPing
    End Sub
#End Region

    Function PosicionOrigen() As Integer
        clienteTCP.EnviarDatos("*0-000000*")
        Return 0
    End Function

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myjoyEX.dwSize = 64
        myjoyEX.dwFlags = &HFF ' All information

        Timer1.Interval = 1         'Seteo Timmer en 1ms
        Timer1.Enabled = True       'Habilito timmer
        DeshabilitarMotor()
        DeshabilitarModoJOG()
        Inicializar()
    End Sub



    Private Sub While_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'todo lo que este aca se repite cada 1ms
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
        TextBox1.Text = Instrucciones



        If EstadoModoJOG = True Then
            Joystick()
            GenerarPaqueteJOG()
            Screens.SelectTab(TabJOG)
        End If
        If EStadoModoMAN = True Then
            Screens.SelectTab(TabControlManual)
        End If
        If EStadoModoSEC = True Then
            Screens.SelectTab(TabSecuencia)
        End If





        If clienteTCP.IsConected() = False Then
            clienteTCP.Desconectar()
            EstadoIP_Robot.Text = "Desconectado"
            EstadoPingRobot.Image = My.Resources.ErrorPing
        End If






        'RichTextBox1.Text = RichTextBox1.Text + clienteTCP.BufferAcumulado()

        Try
            If clienteTCP.BufferAcumulado().Contains("#OK-J#") = True Then
                EstadoModoJOG = True
                EStadoModoMAN = False
                EStadoModoSEC = False
            End If
            If clienteTCP.BufferAcumulado().Contains("#OK-M#") = True Then
                EstadoModoJOG = False
                EStadoModoMAN = True
                EStadoModoSEC = False
            End If
            If clienteTCP.BufferAcumulado().Contains("#OK-C#") = True Then
                EstadoModoJOG = False
                EStadoModoMAN = False
                EStadoModoSEC = True
            End If
            If clienteTCP.BufferAcumulado().Contains("#OK-R#") = True Then
                EstadoModoJOG = False
                EStadoModoMAN = False
                EStadoModoSEC = True
            End If
            If clienteTCP.BufferAcumulado().Contains("*LIBRE*") = True Then
                EstadoModoJOG = False
                EStadoModoMAN = False
                EStadoModoSEC = False
            End If


        Catch Ebuffer As Exception
        End Try




    End Sub



    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click

        Const fichero As String = "Prueba.txt"
        Dim texto As String = "ACA van las secuencias"
        Dim a As New System.IO.StreamWriter(fichero)
        a.WriteLine(texto)
        a.WriteLine("NE")
        a.Close()


        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(fichero)
        MsgBox(fileReader)
        RichTextBox1.Text = fileReader





    End Sub





End Class
