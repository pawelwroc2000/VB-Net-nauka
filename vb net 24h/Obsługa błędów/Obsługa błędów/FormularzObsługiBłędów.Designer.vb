<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularzObsługiBłędów
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
        Me.btnPrzechwyćWyjątek = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPrzechwyćWyjątek
        '
        Me.btnPrzechwyćWyjątek.Location = New System.Drawing.Point(12, 12)
        Me.btnPrzechwyćWyjątek.Name = "btnPrzechwyćWyjątek"
        Me.btnPrzechwyćWyjątek.Size = New System.Drawing.Size(75, 23)
        Me.btnPrzechwyćWyjątek.TabIndex = 0
        Me.btnPrzechwyćWyjątek.Text = "Przechwyć wyjątek"
        Me.btnPrzechwyćWyjątek.UseVisualStyleBackColor = True
        '
        'FormularzObsługiBłędów
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnPrzechwyćWyjątek)
        Me.Name = "FormularzObsługiBłędów"
        Me.Text = "Obsługa błędów"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrzechwyćWyjątek As System.Windows.Forms.Button

End Class
