<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.rollButton = New System.Windows.Forms.Button()
        Me.rollStatBlockButton = New System.Windows.Forms.Button()
        Me.clearQuantitiesButton = New System.Windows.Forms.Button()
        Me.percentageButton = New System.Windows.Forms.Button()
        Me.clearResultsButton = New System.Windows.Forms.Button()
        Me.d2QuantityBox = New System.Windows.Forms.TextBox()
        Me.outputBox = New System.Windows.Forms.TextBox()
        Me.d2ModBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.d3QuantityBox = New System.Windows.Forms.TextBox()
        Me.d3ModBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.d4QuantityBox = New System.Windows.Forms.TextBox()
        Me.d4ModBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.d6QuantityBox = New System.Windows.Forms.TextBox()
        Me.d6ModBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.d8QuantityBox = New System.Windows.Forms.TextBox()
        Me.d8ModBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.d10QuantityBox = New System.Windows.Forms.TextBox()
        Me.d10ModBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.d12QuantityBox = New System.Windows.Forms.TextBox()
        Me.d12ModBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.d20QuantityBox = New System.Windows.Forms.TextBox()
        Me.d20ModBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.d100QuantityBox = New System.Windows.Forms.TextBox()
        Me.d100ModBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.escButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rollButton
        '
        Me.rollButton.Location = New System.Drawing.Point(15, 259)
        Me.rollButton.Name = "rollButton"
        Me.rollButton.Size = New System.Drawing.Size(129, 66)
        Me.rollButton.TabIndex = 0
        Me.rollButton.Text = "Roll!"
        Me.rollButton.UseVisualStyleBackColor = True
        '
        'rollStatBlockButton
        '
        Me.rollStatBlockButton.Location = New System.Drawing.Point(150, 259)
        Me.rollStatBlockButton.Name = "rollStatBlockButton"
        Me.rollStatBlockButton.Size = New System.Drawing.Size(105, 30)
        Me.rollStatBlockButton.TabIndex = 1
        Me.rollStatBlockButton.Text = "Roll Stat Block"
        Me.rollStatBlockButton.UseVisualStyleBackColor = True
        '
        'clearQuantitiesButton
        '
        Me.clearQuantitiesButton.Location = New System.Drawing.Point(150, 295)
        Me.clearQuantitiesButton.Name = "clearQuantitiesButton"
        Me.clearQuantitiesButton.Size = New System.Drawing.Size(105, 30)
        Me.clearQuantitiesButton.TabIndex = 2
        Me.clearQuantitiesButton.Text = "Clear Quantities"
        Me.clearQuantitiesButton.UseVisualStyleBackColor = True
        '
        'percentageButton
        '
        Me.percentageButton.Location = New System.Drawing.Point(261, 259)
        Me.percentageButton.Name = "percentageButton"
        Me.percentageButton.Size = New System.Drawing.Size(105, 30)
        Me.percentageButton.TabIndex = 3
        Me.percentageButton.Text = "Roll Percentage"
        Me.percentageButton.UseVisualStyleBackColor = True
        '
        'clearResultsButton
        '
        Me.clearResultsButton.Location = New System.Drawing.Point(261, 295)
        Me.clearResultsButton.Name = "clearResultsButton"
        Me.clearResultsButton.Size = New System.Drawing.Size(105, 30)
        Me.clearResultsButton.TabIndex = 4
        Me.clearResultsButton.Text = "Clear Results"
        Me.clearResultsButton.UseVisualStyleBackColor = True
        '
        'd2QuantityBox
        '
        Me.d2QuantityBox.Location = New System.Drawing.Point(15, 25)
        Me.d2QuantityBox.Name = "d2QuantityBox"
        Me.d2QuantityBox.Size = New System.Drawing.Size(43, 20)
        Me.d2QuantityBox.TabIndex = 5
        '
        'outputBox
        '
        Me.outputBox.Location = New System.Drawing.Point(150, 12)
        Me.outputBox.Multiline = True
        Me.outputBox.Name = "outputBox"
        Me.outputBox.Size = New System.Drawing.Size(216, 241)
        Me.outputBox.TabIndex = 6
        '
        'd2ModBox
        '
        Me.d2ModBox.Location = New System.Drawing.Point(92, 25)
        Me.d2ModBox.Name = "d2ModBox"
        Me.d2ModBox.Size = New System.Drawing.Size(43, 20)
        Me.d2ModBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "d2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Modifier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantity"
        '
        'd3QuantityBox
        '
        Me.d3QuantityBox.Location = New System.Drawing.Point(15, 51)
        Me.d3QuantityBox.Name = "d3QuantityBox"
        Me.d3QuantityBox.Size = New System.Drawing.Size(43, 20)
        Me.d3QuantityBox.TabIndex = 5
        '
        'd3ModBox
        '
        Me.d3ModBox.Location = New System.Drawing.Point(92, 51)
        Me.d3ModBox.Name = "d3ModBox"
        Me.d3ModBox.Size = New System.Drawing.Size(43, 20)
        Me.d3ModBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "d3:"
        '
        'd4QuantityBox
        '
        Me.d4QuantityBox.Location = New System.Drawing.Point(15, 77)
        Me.d4QuantityBox.Name = "d4QuantityBox"
        Me.d4QuantityBox.Size = New System.Drawing.Size(43, 20)
        Me.d4QuantityBox.TabIndex = 5
        '
        'd4ModBox
        '
        Me.d4ModBox.Location = New System.Drawing.Point(92, 77)
        Me.d4ModBox.Name = "d4ModBox"
        Me.d4ModBox.Size = New System.Drawing.Size(43, 20)
        Me.d4ModBox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "d4:"
        '
        'd6QuantityBox
        '
        Me.d6QuantityBox.Location = New System.Drawing.Point(15, 103)
        Me.d6QuantityBox.Name = "d6QuantityBox"
        Me.d6QuantityBox.Size = New System.Drawing.Size(43, 20)
        Me.d6QuantityBox.TabIndex = 5
        '
        'd6ModBox
        '
        Me.d6ModBox.Location = New System.Drawing.Point(92, 103)
        Me.d6ModBox.Name = "d6ModBox"
        Me.d6ModBox.Size = New System.Drawing.Size(43, 20)
        Me.d6ModBox.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "d6:"
        '
        'd8QuantityBox
        '
        Me.d8QuantityBox.Location = New System.Drawing.Point(15, 129)
        Me.d8QuantityBox.Name = "d8QuantityBox"
        Me.d8QuantityBox.Size = New System.Drawing.Size(43, 20)
        Me.d8QuantityBox.TabIndex = 5
        '
        'd8ModBox
        '
        Me.d8ModBox.Location = New System.Drawing.Point(92, 129)
        Me.d8ModBox.Name = "d8ModBox"
        Me.d8ModBox.Size = New System.Drawing.Size(43, 20)
        Me.d8ModBox.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "d8:"
        '
        'd10QuantityBox
        '
        Me.d10QuantityBox.Location = New System.Drawing.Point(15, 155)
        Me.d10QuantityBox.Name = "d10QuantityBox"
        Me.d10QuantityBox.Size = New System.Drawing.Size(43, 20)
        Me.d10QuantityBox.TabIndex = 5
        '
        'd10ModBox
        '
        Me.d10ModBox.Location = New System.Drawing.Point(92, 155)
        Me.d10ModBox.Name = "d10ModBox"
        Me.d10ModBox.Size = New System.Drawing.Size(43, 20)
        Me.d10ModBox.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "d10:"
        '
        'd12QuantityBox
        '
        Me.d12QuantityBox.Location = New System.Drawing.Point(15, 181)
        Me.d12QuantityBox.Name = "d12QuantityBox"
        Me.d12QuantityBox.Size = New System.Drawing.Size(43, 20)
        Me.d12QuantityBox.TabIndex = 5
        '
        'd12ModBox
        '
        Me.d12ModBox.Location = New System.Drawing.Point(92, 181)
        Me.d12ModBox.Name = "d12ModBox"
        Me.d12ModBox.Size = New System.Drawing.Size(43, 20)
        Me.d12ModBox.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "d12:"
        '
        'd20QuantityBox
        '
        Me.d20QuantityBox.Location = New System.Drawing.Point(15, 207)
        Me.d20QuantityBox.Name = "d20QuantityBox"
        Me.d20QuantityBox.Size = New System.Drawing.Size(43, 20)
        Me.d20QuantityBox.TabIndex = 5
        '
        'd20ModBox
        '
        Me.d20ModBox.Location = New System.Drawing.Point(92, 207)
        Me.d20ModBox.Name = "d20ModBox"
        Me.d20ModBox.Size = New System.Drawing.Size(43, 20)
        Me.d20ModBox.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "d20:"
        '
        'd100QuantityBox
        '
        Me.d100QuantityBox.Location = New System.Drawing.Point(15, 233)
        Me.d100QuantityBox.Name = "d100QuantityBox"
        Me.d100QuantityBox.Size = New System.Drawing.Size(43, 20)
        Me.d100QuantityBox.TabIndex = 5
        '
        'd100ModBox
        '
        Me.d100ModBox.Location = New System.Drawing.Point(92, 233)
        Me.d100ModBox.Name = "d100ModBox"
        Me.d100ModBox.Size = New System.Drawing.Size(43, 20)
        Me.d100ModBox.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(59, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "d100:"
        '
        'escButton
        '
        Me.escButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.escButton.Location = New System.Drawing.Point(372, 269)
        Me.escButton.Name = "escButton"
        Me.escButton.Size = New System.Drawing.Size(0, 0)
        Me.escButton.TabIndex = 10
        Me.escButton.Text = "esc"
        Me.escButton.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AcceptButton = Me.rollButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.escButton
        Me.ClientSize = New System.Drawing.Size(377, 335)
        Me.Controls.Add(Me.escButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.d100ModBox)
        Me.Controls.Add(Me.d20ModBox)
        Me.Controls.Add(Me.d12ModBox)
        Me.Controls.Add(Me.d10ModBox)
        Me.Controls.Add(Me.d8ModBox)
        Me.Controls.Add(Me.d6ModBox)
        Me.Controls.Add(Me.d4ModBox)
        Me.Controls.Add(Me.d3ModBox)
        Me.Controls.Add(Me.d2ModBox)
        Me.Controls.Add(Me.outputBox)
        Me.Controls.Add(Me.d100QuantityBox)
        Me.Controls.Add(Me.d20QuantityBox)
        Me.Controls.Add(Me.d12QuantityBox)
        Me.Controls.Add(Me.d10QuantityBox)
        Me.Controls.Add(Me.d8QuantityBox)
        Me.Controls.Add(Me.d6QuantityBox)
        Me.Controls.Add(Me.d4QuantityBox)
        Me.Controls.Add(Me.d3QuantityBox)
        Me.Controls.Add(Me.d2QuantityBox)
        Me.Controls.Add(Me.clearResultsButton)
        Me.Controls.Add(Me.percentageButton)
        Me.Controls.Add(Me.clearQuantitiesButton)
        Me.Controls.Add(Me.rollStatBlockButton)
        Me.Controls.Add(Me.rollButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "Dice Roller"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents rollButton As System.Windows.Forms.Button
    Friend WithEvents rollStatBlockButton As System.Windows.Forms.Button
    Friend WithEvents clearQuantitiesButton As System.Windows.Forms.Button
    Friend WithEvents percentageButton As System.Windows.Forms.Button
    Friend WithEvents clearResultsButton As System.Windows.Forms.Button
    Friend WithEvents d2QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents outputBox As System.Windows.Forms.TextBox
    Friend WithEvents d2ModBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents d3QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents d3ModBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents d4QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents d4ModBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents d6QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents d6ModBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents d8QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents d8ModBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents d10QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents d10ModBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents d12QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents d12ModBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents d20QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents d20ModBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents d100QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents d100ModBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents escButton As System.Windows.Forms.Button

End Class
