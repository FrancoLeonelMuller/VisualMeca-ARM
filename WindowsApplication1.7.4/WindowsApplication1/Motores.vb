
Public Class Motor
#Region "Declaraciones"
    Private _motorJOG As Boolean = False
    Private _AntMotorJOG As Boolean = False
    Private _DirMotorJOG As Char = "+"

    Private _motorJOGJOY As Boolean = False
    Private _AntMotorJOGJOY As Boolean = False

#End Region

#Region "Metodos JOG Teclas"
    Public Sub MoverJOG(ByVal Direccion As Char)
        _motorJOG = True
        _DirMotorJOG = Direccion
    End Sub
    Public Sub PararJOG()
        _motorJOG = False
    End Sub
    Public Sub IgualarEstadosJOG()
        _AntMotorJOG = _motorJOG
    End Sub
#End Region
#Region "Metodos JOG Joystick"
    Public Sub MoverJOGJOY(ByVal Direccion As Char)
        _motorJOGJOY = True
        _DirMotorJOG = Direccion
    End Sub
    Public Sub PararJOGJOY()
        _motorJOGJOY = False
    End Sub
    Public Sub IgualarEstadosJOGJOY()
        _AntMotorJOGJOY = _motorJOGJOY
    End Sub

#End Region



#Region "Propiedades"

    'Logica JOG con teclas
    Public ReadOnly Property EstadoMotorJOG() As Boolean
        Get
            EstadoMotorJOG = _motorJOG
        End Get
    End Property
    Public ReadOnly Property DireccionMotorJOG() As Char
        Get
            DireccionMotorJOG = _DirMotorJOG
        End Get
    End Property
    Public ReadOnly Property EstAntMotorJOG() As Boolean
        Get
            EstAntMotorJOG = _AntMotorJOG
        End Get
    End Property

    Public ReadOnly Property DifEstadoJOG() As Boolean
        Get
            If _motorJOG <> _AntMotorJOG Then
                DifEstadoJOG = True
            Else
                DifEstadoJOG = False
            End If
        End Get
    End Property

    'Logica JOG con joystick
    Public ReadOnly Property EstadoMotorJOGJOY() As Boolean
        Get
            EstadoMotorJOGJOY = _motorJOGJOY
        End Get
    End Property
    Public ReadOnly Property EstAntMotorJOGJOY() As Boolean
        Get
            EstAntMotorJOGJOY = _AntMotorJOGJOY
        End Get
    End Property

    Public ReadOnly Property DifEstadoJOGJOY() As Boolean
        Get
            If _motorJOGJOY <> _AntMotorJOGJOY Then
                DifEstadoJOGJOY = True
            Else
                DifEstadoJOGJOY = False
            End If
        End Get
    End Property




#End Region
End Class
