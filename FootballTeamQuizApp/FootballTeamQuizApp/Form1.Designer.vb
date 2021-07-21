<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.teamComboBox = New System.Windows.Forms.ComboBox()
        Me.teamPictureBox = New System.Windows.Forms.PictureBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.correctLabel = New System.Windows.Forms.Label()
        Me.incorrectLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.teamPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teamComboBox
        '
        Me.teamComboBox.FormattingEnabled = True
        Me.teamComboBox.Location = New System.Drawing.Point(194, 28)
        Me.teamComboBox.Name = "teamComboBox"
        Me.teamComboBox.Size = New System.Drawing.Size(121, 21)
        Me.teamComboBox.TabIndex = 0
        '
        'teamPictureBox
        '
        Me.teamPictureBox.Location = New System.Drawing.Point(12, 28)
        Me.teamPictureBox.Name = "teamPictureBox"
        Me.teamPictureBox.Size = New System.Drawing.Size(158, 141)
        Me.teamPictureBox.TabIndex = 1
        Me.teamPictureBox.TabStop = False
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(194, 72)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(121, 35)
        Me.submitButton.TabIndex = 2
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'correctLabel
        '
        Me.correctLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.correctLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.correctLabel.Location = New System.Drawing.Point(176, 147)
        Me.correctLabel.Name = "correctLabel"
        Me.correctLabel.Size = New System.Drawing.Size(81, 31)
        Me.correctLabel.TabIndex = 3
        Me.correctLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'incorrectLabel
        '
        Me.incorrectLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.incorrectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.incorrectLabel.Location = New System.Drawing.Point(269, 147)
        Me.incorrectLabel.Name = "incorrectLabel"
        Me.incorrectLabel.Size = New System.Drawing.Size(81, 31)
        Me.incorrectLabel.TabIndex = 3
        Me.incorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Correct:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(269, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Incorrect:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 201)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.incorrectLabel)
        Me.Controls.Add(Me.correctLabel)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.teamPictureBox)
        Me.Controls.Add(Me.teamComboBox)
        Me.Name = "Form1"
        Me.Text = "NFL Teams Quiz"
        CType(Me.teamPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teamComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents teamPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents correctLabel As System.Windows.Forms.Label
    Friend WithEvents incorrectLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
