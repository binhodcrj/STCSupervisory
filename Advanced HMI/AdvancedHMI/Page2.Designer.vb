<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FormChangeButton1 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.SuspendLayout()
        '
        'FormChangeButton1
        '
        Me.FormChangeButton1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.FormChangeButton1.ComComponent = Nothing
        Me.FormChangeButton1.ForeColor = System.Drawing.Color.Black
        Me.FormChangeButton1.FormToOpen = GetType(MfgControl.AdvancedHMI.MainForm)
        Me.FormChangeButton1.KeypadWidth = 300
        Me.FormChangeButton1.Location = New System.Drawing.Point(419, 290)
        Me.FormChangeButton1.Name = "FormChangeButton1"
        Me.FormChangeButton1.Passcode = Nothing
        Me.FormChangeButton1.PasswordChar = False
        Me.FormChangeButton1.PLCAddressVisible = ""
        Me.FormChangeButton1.Size = New System.Drawing.Size(122, 44)
        Me.FormChangeButton1.TabIndex = 5
        Me.FormChangeButton1.Text = "FormChangeButton1"
        Me.FormChangeButton1.UseVisualStyleBackColor = False
        '
        'Page2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(630, 382)
        Me.Controls.Add(Me.FormChangeButton1)
        Me.Name = "Page2"
        Me.Tag = "2"
        Me.Text = "Page 2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormChangeButton1 As FormChangeButton
End Class
