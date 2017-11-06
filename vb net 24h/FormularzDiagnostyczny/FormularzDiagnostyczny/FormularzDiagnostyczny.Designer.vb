<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularzDiagnostyczny
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
        Me.txtDane = New System.Windows.Forms.TextBox()
        Me.btnWykonajDzielenie = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDane
        '
        Me.txtDane.Location = New System.Drawing.Point(214, 134)
        Me.txtDane.Name = "txtDane"
        Me.txtDane.Size = New System.Drawing.Size(184, 20)
        Me.txtDane.TabIndex = 0
        '
        'btnWykonajDzielenie
        '
        Me.btnWykonajDzielenie.Location = New System.Drawing.Point(214, 185)
        Me.btnWykonajDzielenie.Name = "btnWykonajDzielenie"
        Me.btnWykonajDzielenie.Size = New System.Drawing.Size(184, 23)
        Me.btnWykonajDzielenie.TabIndex = 1
        Me.btnWykonajDzielenie.Text = "Wykonaj dzielenie"
        Me.btnWykonajDzielenie.UseVisualStyleBackColor = True
        '
        'FormularzDiagnostyczny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 362)
        Me.Controls.Add(Me.btnWykonajDzielenie)
        Me.Controls.Add(Me.txtDane)
        Me.Name = "FormularzDiagnostyczny"
        Me.Text = "Diagnostyka"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDane As System.Windows.Forms.TextBox
    Friend WithEvents btnWykonajDzielenie As System.Windows.Forms.Button

End Class
