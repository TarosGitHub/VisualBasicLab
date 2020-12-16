Public Class MainForm
    Private Sub BMI_Button_Click(sender As Object, e As EventArgs) Handles BMIButton.Click
        Try
            ' 身長[cm]の取得
            Dim height = Double.Parse(HeightTextBox.Text)

            ' 体重[kg]の取得
            Dim weight = Double.Parse(WeightTextBox.Text)

            ' 結果欄にメッセージを設定
            Dim human As New Human(height, weight)
            ResultsTextBox.Text = String.Format("{0}" & vbCr & vbLf & "BMI: {1:#.#}", human.GetBMIMessage(), human.BMI)

        Catch ex As Exception
            ResultsTextBox.Text = ex.Message
        End Try
    End Sub
End Class
