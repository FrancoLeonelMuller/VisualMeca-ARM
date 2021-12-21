Imports System, System.Net, System.Net.Sockets
Imports System.Threading
Imports System.Text, System.IO

Public Class Cliente

#Region "Declaraciones"
    'Objetos
    Private MiStream As NetworkStream
    Private MiClienteTCP As TcpClient

    'Variables usadas para las propiedades
    Private _IPRemota As String
    Private _PuertoRemoto As String

    'Variables Locales
    Private _BufferAcumulado As String
#End Region

#Region "Eventos"
    Public Event Conectado(ByVal Sender As Cliente)
    Public Event Desconectado(ByVal Sender As Cliente)
    Public Event DatosRecibidos(ByVal Sender As Cliente, ByVal datos As String)
    Public Event ErrorOcurrido(ByVal Sender As Cliente, ByVal MyEx As String, ByVal Metodo As String)
#End Region

#Region "Metodos Publicos"

    Public Sub Conectar()
        'Try
        Dim NewThread As Thread

        MiClienteTCP = New TcpClient()
        MiClienteTCP.Connect(_IPRemota, _PuertoRemoto)
        MiStream = MiClienteTCP.GetStream()

        NewThread = New Thread(AddressOf DoRead)
        NewThread.IsBackground = True
        NewThread.Name = _IPRemota & " Ciclo Lectura"
        NewThread.Start()

        'Catch ex As Exception
        '    RaiseEvent ErrorOcurrido(Me, ex.Message, "Conectar")

        'End Try
    End Sub

    Public Sub EnviarDatos(ByVal Datos As String)
        Try
            Dim Buffer() As Byte
            Buffer = Encoding.ASCII.GetBytes(Datos)
            If Not (MiStream Is Nothing) Then
                MiStream.Write(Buffer, 0, Buffer.Length)
            End If
        Catch ex As Exception
            RaiseEvent ErrorOcurrido(Me, ex.Source, "EnviarDatos")
        End Try
    End Sub

    Public Sub Desconectar()
        Try
            MiClienteTCP.GetStream().Close()
            MiClienteTCP.Close()
        Catch ex As Exception
            RaiseEvent ErrorOcurrido(Me, ex.Message, "Conectar")
        End Try
    End Sub
#End Region

#Region "Funciones y Procedimientos Privados"
    Private Sub DoRead()
        Dim Buffer() As Byte
        While True
            Try
                If (MiClienteTCP.Client.Poll(10, System.Net.Sockets.SelectMode.SelectRead) And (MiClienteTCP.Client.Available = 0)) Then
                    'El Socket esta Desconectado
                    Exit While
                End If
                Buffer = New Byte(1024) {}
                Dim Bytes As Int32 = MiStream.Read(Buffer, 0, Buffer.Length)

                If Bytes > 0 Then 'Si los Bytes recibidos es mayor a 0 lanzamos el evento
                    _BufferAcumulado = Encoding.ASCII.GetString(Buffer)
                    ProcesaDatos()
                End If
            Catch e As Exception
                Exit While
            End Try
        End While

        MiClienteTCP.Close() 'Me aseguro de que cierre la conexion
        ProcesaDesconectado()
    End Sub

    'ToDo's:
    '- Lanzar los eventos desde Threads Nuevos

    Sub ProcesaConectado()
        RaiseEvent Conectado(Me)
    End Sub

    Sub ProcesaDesconectado()
        RaiseEvent Desconectado(Me)
    End Sub

    Sub ProcesaDatos()
        RaiseEvent DatosRecibidos(Me, _BufferAcumulado)
    End Sub
#End Region

#Region "Propiedades"
    Public Property IpRemota() As String
        Get
            IpRemota = _IPRemota
        End Get

        Set(ByVal Value As String)
            _IPRemota = Value
        End Set
    End Property

    Public Property PuertoRemoto() As String
        Get
            PuertoRemoto = _PuertoRemoto
        End Get

        Set(ByVal Value As String)
            _PuertoRemoto = Value
        End Set
    End Property

    Public Property BufferAcumulado() As String
        Get
            BufferAcumulado = _BufferAcumulado
        End Get

        Set(ByVal Value As String)
            _BufferAcumulado = Value
        End Set
    End Property

    Public ReadOnly Property IsConected() As Boolean
        Get
            Try
                If Not MiClienteTCP Is Nothing AndAlso Me.MiClienteTCP.Connected Then
                    Return True
                Else
                    Return False
                End If
            Catch e As Exception
                Return False
            End Try
        End Get
    End Property

#End Region

End Class
