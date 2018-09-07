Public Class Loro
    Private _nombre As String
    Private _fechaNacimiento As Date
    Private _edad As Short
    Private _memoria As Queue(Of String)
    Private texto As String

    Public Sub New()
        Me.New("", "")
    End Sub

    Sub New(nombre As String, fechanacimiento As Date)
        Me.Nombre = nombre
        Me.fechaNacimiento = fechanacimiento
        _memoria = New Queue(Of String)
        texto = ""
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property fechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Function CalcularEdad() As UShort
        Return Now.Year - fechaNacimiento.Year
    End Function


    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    Public Sub Escuchar(Value As String)
        _memoria.Enqueue(Value)
    End Sub
    Public Function Hablar() As String
        While _memoria.Count > 0
            texto = texto & _memoria.Dequeue & ""
        End While
        Return texto
    End Function
End Class
