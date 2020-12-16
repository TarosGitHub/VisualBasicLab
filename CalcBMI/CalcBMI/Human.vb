Public Class Human
    Private height As Double ' m
    Private height_cm As Double ' cm
    Private weight As Double ' kg

    ''' コンストラクタ
    ''' @param height 身長[cm]
    ''' @param weight 体重[kg]
    Public Sub New(height As Double, weight As Double)
        Me.height = height / 100
        Me.height_cm = height
        Me.weight = weight
    End Sub

    Public ReadOnly Property BMI() As Double
        Get
            Return Me.CalcBMI()
        End Get
    End Property

    Public Function GetBMIMessage() As String
        Dim message
        Dim bmi = Me.CalcBMI()

        If bmi < 18.5 Then
            message = "やせ"
        ElseIf bmi < 25 Then
            message = "標準"
        ElseIf bmi < 30 Then
            message = "軽肥満"
        Else
            message = "肥満"
        End If

        Return message
    End Function

    Private Function CalcBMI() As Double
        Return Me.weight / (Me.height * Me.height)
    End Function
End Class
