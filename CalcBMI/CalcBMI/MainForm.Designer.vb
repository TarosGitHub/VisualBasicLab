<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BMIButton = New System.Windows.Forms.Button()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.WeightLabel = New System.Windows.Forms.Label()
        Me.HeightUnitLabel = New System.Windows.Forms.Label()
        Me.WeightUnitLabel = New System.Windows.Forms.Label()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.ResultsTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BMIButton
        '
        Me.BMIButton.Location = New System.Drawing.Point(144, 8)
        Me.BMIButton.Name = "BMIButton"
        Me.BMIButton.Size = New System.Drawing.Size(75, 23)
        Me.BMIButton.TabIndex = 2
        Me.BMIButton.Text = "BMI"
        Me.BMIButton.UseVisualStyleBackColor = True
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(13, 13)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(29, 12)
        Me.HeightLabel.TabIndex = 1
        Me.HeightLabel.Text = "身長"
        '
        'WeightLabel
        '
        Me.WeightLabel.AutoSize = True
        Me.WeightLabel.Location = New System.Drawing.Point(13, 42)
        Me.WeightLabel.Name = "WeightLabel"
        Me.WeightLabel.Size = New System.Drawing.Size(29, 12)
        Me.WeightLabel.TabIndex = 2
        Me.WeightLabel.Text = "体重"
        '
        'HeightUnitLabel
        '
        Me.HeightUnitLabel.AutoSize = True
        Me.HeightUnitLabel.Location = New System.Drawing.Point(118, 13)
        Me.HeightUnitLabel.Name = "HeightUnitLabel"
        Me.HeightUnitLabel.Size = New System.Drawing.Size(20, 12)
        Me.HeightUnitLabel.TabIndex = 3
        Me.HeightUnitLabel.Text = "cm"
        '
        'WeightUnitLabel
        '
        Me.WeightUnitLabel.AutoSize = True
        Me.WeightUnitLabel.Location = New System.Drawing.Point(118, 42)
        Me.WeightUnitLabel.Name = "WeightUnitLabel"
        Me.WeightUnitLabel.Size = New System.Drawing.Size(17, 12)
        Me.WeightUnitLabel.TabIndex = 4
        Me.WeightUnitLabel.Text = "kg"
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Location = New System.Drawing.Point(48, 10)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(64, 19)
        Me.HeightTextBox.TabIndex = 0
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Location = New System.Drawing.Point(48, 39)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(64, 19)
        Me.WeightTextBox.TabIndex = 1
        '
        'ResultsTextBox
        '
        Me.ResultsTextBox.Location = New System.Drawing.Point(12, 64)
        Me.ResultsTextBox.Multiline = True
        Me.ResultsTextBox.Name = "ResultsTextBox"
        Me.ResultsTextBox.ReadOnly = True
        Me.ResultsTextBox.Size = New System.Drawing.Size(207, 53)
        Me.ResultsTextBox.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 129)
        Me.Controls.Add(Me.ResultsTextBox)
        Me.Controls.Add(Me.WeightTextBox)
        Me.Controls.Add(Me.HeightTextBox)
        Me.Controls.Add(Me.WeightUnitLabel)
        Me.Controls.Add(Me.HeightUnitLabel)
        Me.Controls.Add(Me.WeightLabel)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.BMIButton)
        Me.Name = "MainForm"
        Me.Text = "CalcBMI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BMIButton As Button
    Friend WithEvents HeightLabel As Label
    Friend WithEvents WeightLabel As Label
    Friend WithEvents HeightUnitLabel As Label
    Friend WithEvents WeightUnitLabel As Label
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents ResultsTextBox As TextBox
End Class
