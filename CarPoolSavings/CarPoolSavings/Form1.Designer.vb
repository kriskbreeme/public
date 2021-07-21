<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarPoolSavingsApp
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
        Me.milesdrivenTextBox = New System.Windows.Forms.TextBox()
        Me.costpergallonTextBox = New System.Windows.Forms.TextBox()
        Me.mpgTextBox = New System.Windows.Forms.TextBox()
        Me.parkingfeesTextBox = New System.Windows.Forms.TextBox()
        Me.tollsTextBox = New System.Windows.Forms.TextBox()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'milesdrivenTextBox
        '
        Me.milesdrivenTextBox.Location = New System.Drawing.Point(223, 32)
        Me.milesdrivenTextBox.Name = "milesdrivenTextBox"
        Me.milesdrivenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.milesdrivenTextBox.TabIndex = 0
        '
        'costpergallonTextBox
        '
        Me.costpergallonTextBox.Location = New System.Drawing.Point(223, 71)
        Me.costpergallonTextBox.Name = "costpergallonTextBox"
        Me.costpergallonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.costpergallonTextBox.TabIndex = 1
        '
        'mpgTextBox
        '
        Me.mpgTextBox.Location = New System.Drawing.Point(223, 108)
        Me.mpgTextBox.Name = "mpgTextBox"
        Me.mpgTextBox.Size = New System.Drawing.Size(100, 20)
        Me.mpgTextBox.TabIndex = 2
        '
        'parkingfeesTextBox
        '
        Me.parkingfeesTextBox.Location = New System.Drawing.Point(223, 142)
        Me.parkingfeesTextBox.Name = "parkingfeesTextBox"
        Me.parkingfeesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.parkingfeesTextBox.TabIndex = 3
        '
        'tollsTextBox
        '
        Me.tollsTextBox.Location = New System.Drawing.Point(223, 180)
        Me.tollsTextBox.Name = "tollsTextBox"
        Me.tollsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.tollsTextBox.TabIndex = 4
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.resultLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultLabel.Location = New System.Drawing.Point(223, 220)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(100, 23)
        Me.resultLabel.TabIndex = 5
        Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter miles driven per day:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enter cost per gallon (in cents):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Enter miles per gallon:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Enter parking fees per day (in dollars):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Enter tolls per day (in dollars):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Your daily driving cost is:"
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(338, 29)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(108, 23)
        Me.calculateButton.TabIndex = 12
        Me.calculateButton.Text = "Calculate Cost"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'CarPoolSavingsApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 289)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.tollsTextBox)
        Me.Controls.Add(Me.parkingfeesTextBox)
        Me.Controls.Add(Me.mpgTextBox)
        Me.Controls.Add(Me.costpergallonTextBox)
        Me.Controls.Add(Me.milesdrivenTextBox)
        Me.Name = "CarPoolSavingsApp"
        Me.Text = "Car Pool Savings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents milesdrivenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents costpergallonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents mpgTextBox As System.Windows.Forms.TextBox
    Friend WithEvents parkingfeesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tollsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents resultLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class
