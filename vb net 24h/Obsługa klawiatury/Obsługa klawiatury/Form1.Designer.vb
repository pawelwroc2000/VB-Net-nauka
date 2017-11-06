<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularzKlawiatury
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
        Me.SuspendLayout()
        '
        'txtDane
        '
        Me.txtDane.Location = New System.Drawing.Point(86, 60)
        Me.txtDane.Multiline = True
        Me.txtDane.Name = "txtDane"
        Me.txtDane.Size = New System.Drawing.Size(100, 20)
        Me.txtDane.TabIndex = 0
        '
        'FormularzKlawiatury
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtDane)
        Me.Name = "FormularzKlawiatury"
        Me.Text = "Obsługa klawiatury"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDane As System.Windows.Forms.TextBox

End Class
