Public Class Manual
    Dim estado As Boolean = True        'variable para estado del boton
    Dim Direccion As Boolean = True
    Dim BtSClock As String              'Convert Bool to String de direccion
    Dim Instrucciones As String         'Instrucciones para los motores
    Dim NumeroMotor As Integer
    Dim IpRobot As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1         'Seteo Timmer en 1ms
        Timer1.Enabled = True       'Habilito timmer
        DeshabilitarMotor()

    End Sub

    Function MandarPaquete(ByVal IpRobot As String, ByVal Mensaje As String) As Integer
        Dim Paquete As String

        IpRobot = "http://" + IpRobot + "/"
        Paquete = IpRobot + Mensaje

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(Paquete)


        Return 0
    End Function
    Function DeshabilitarMotor() As Integer
        nupMotor1.Enabled = False
        nupMotor2.Enabled = False
        nupMotor3.Enabled = False
        nupMotor4.Enabled = False
        nupMotor5.Enabled = False
        nupMotor6.Enabled = False

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

        nupMotor1.Value = "0"
        nupMotor2.Value = "0"
        nupMotor3.Value = "0"
        nupMotor4.Value = "0"
        nupMotor5.Value = "0"
        nupMotor6.Value = "0"
        NumeroMotor = 0
        Direccion = True
        BtSClock = "0"
        Return 0
    End Function 'inhabilita manipulacion de ejes



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'todo lo que este aca se repite cada 1ms
        Dim Velocidad As String
        Dim VelocidadLenght As Integer
        Dim Posicion As String = 0
        Dim PosicionLenght As Integer

        Velocidad = CStr(cmbVelocidad.Value)
        VelocidadLenght = Velocidad.Length

        Select Case NumeroMotor
            Case 1
                Posicion = CStr(nupMotor1.Value)
            Case 2
                Posicion = CStr(nupMotor2.Value)
            Case 3
                Posicion = CStr(nupMotor3.Value)
            Case 4
                Posicion = CStr(nupMotor4.Value)
            Case 5
                Posicion = CStr(nupMotor5.Value)
            Case 6
                Posicion = CStr(nupMotor6.Value)
        End Select

        PosicionLenght = Posicion.Length

        Select Case VelocidadLenght
            Case 1
                Velocidad = "00" + Velocidad
            Case 2
                Velocidad = "0" + Velocidad
        End Select

        Select Case PosicionLenght
            Case 1
                Posicion = "00" + Posicion
            Case 2
                Posicion = "0" + Posicion
        End Select


        Instrucciones = CStr(NumeroMotor) + "-" + BtSClock + "-" + Posicion + "-" + Velocidad
        TextBox1.Text = Instrucciones

    End Sub

    Private Sub Clock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock.Click

        If Direccion = True Then
            Direccion = False
            BtSClock = "1"
            Clock.Text = "AntiClock"
        Else
            Direccion = True
            BtSClock = "0"
            Clock.Text = "Clock"
        End If
    End Sub
    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        cmbVelocidad.Value = "0"
        DeshabilitarMotor()
        estado = True
    End Sub
    Private Sub Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        IpRobot = TextBox_IpRobot.Text
        MandarPaquete(IpRobot, Instrucciones)
        NumeroMotor = 0
        DeshabilitarMotor()
        estado = True
    End Sub
    Private Sub BtnPosOrigen_Click(sender As Object, e As EventArgs) Handles btnPosOrigen.Click
        Dim PosicionOrigen As String = "0-0-000-000"
        DeshabilitarMotor()
        estado = True
        NumeroMotor = 0
        IpRobot = TextBox_IpRobot.Text
        MandarPaquete(IpRobot, PosicionOrigen)

    End Sub

    Private Sub btnMotor1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotor1.Click
        NumeroMotor = 1
        If estado = True Then
            estado = False
            AumPosMotor1.Enabled = True
            DisPosMotor1.Enabled = True
            nupMotor1.Enabled = True
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
            nupMotor2.Enabled = True
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
            nupMotor3.Enabled = True
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
            nupMotor4.Enabled = True
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
            nupMotor5.Enabled = True
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
            nupMotor6.Enabled = True
            btnMotor6.Image = My.Resources.CandadoAbierto
        Else
            estado = True
            DeshabilitarMotor()
        End If
    End Sub

    Private Sub AumPosMotor1_Click(sender As Object, e As EventArgs) Handles AumPosMotor1.Click
        nupMotor1.Value = nupMotor1.Value + 1
    End Sub
    Private Sub AumPosMotor2_Click(sender As Object, e As EventArgs) Handles AumPosMotor2.Click
        nupMotor2.Value = nupMotor2.Value + 1
    End Sub
    Private Sub AumPosMotor3_Click(sender As Object, e As EventArgs) Handles AumPosMotor3.Click
        nupMotor3.Value = nupMotor3.Value + 1
    End Sub
    Private Sub AumPosMotor4_Click(sender As Object, e As EventArgs) Handles AumPosMotor4.Click
        nupMotor4.Value = nupMotor4.Value + 1
    End Sub
    Private Sub AumPosMotor5_Click(sender As Object, e As EventArgs) Handles AumPosMotor5.Click
        nupMotor5.Value = nupMotor5.Value + 1
    End Sub
    Private Sub AumPosMotor6_Click(sender As Object, e As EventArgs) Handles AumPosMotor6.Click
        nupMotor6.Value = nupMotor6.Value + 1
    End Sub

    Private Sub DisPosMotor1_Click(sender As Object, e As EventArgs) Handles DisPosMotor1.Click
        If nupMotor1.Value <> 0 Then
            nupMotor1.Value = nupMotor1.Value - 1
        End If
    End Sub
    Private Sub DisPosMotor2_Click(sender As Object, e As EventArgs) Handles DisPosMotor2.Click
        If nupMotor2.Value <> 0 Then
            nupMotor2.Value = nupMotor2.Value - 1
        End If
    End Sub
    Private Sub DisPosMotor3_Click(sender As Object, e As EventArgs) Handles DisPosMotor3.Click
        If nupMotor3.Value <> 0 Then
            nupMotor3.Value = nupMotor3.Value - 1
        End If
    End Sub
    Private Sub DisPosMotor4_Click(sender As Object, e As EventArgs) Handles DisPosMotor4.Click
        If nupMotor4.Value <> 0 Then
            nupMotor4.Value = nupMotor4.Value - 1
        End If
    End Sub
    Private Sub DisPosMotor5_Click(sender As Object, e As EventArgs) Handles DisPosMotor5.Click
        If nupMotor5.Value <> 0 Then
            nupMotor5.Value = nupMotor5.Value - 1
        End If
    End Sub
    Private Sub DisPosMotor6_Click(sender As Object, e As EventArgs) Handles DisPosMotor6.Click
        If nupMotor6.Value <> 0 Then
            nupMotor6.Value = nupMotor6.Value - 1
        End If
    End Sub


End Class
