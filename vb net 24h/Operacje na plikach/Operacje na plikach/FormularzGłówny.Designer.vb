<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularzGłówny
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
        Me.txtPlikŹródłowy = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOtwórzPlik = New System.Windows.Forms.Button()
        Me.btnZapiszPlik = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtPlikDocelowy = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPlikŹródłowy
        '
        Me.txtPlikŹródłowy.Location = New System.Drawing.Point(34, 75)
        Me.txtPlikŹródłowy.Name = "txtPlikŹródłowy"
        Me.txtPlikŹródłowy.Size = New System.Drawing.Size(238, 20)
        Me.txtPlikŹródłowy.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOtwórzPlik
        '
        Me.btnOtwórzPlik.Location = New System.Drawing.Point(34, 117)
        Me.btnOtwórzPlik.Name = "btnOtwórzPlik"
        Me.btnOtwórzPlik.Size = New System.Drawing.Size(238, 23)
        Me.btnOtwórzPlik.TabIndex = 1
        Me.btnOtwórzPlik.Text = "Plik źródłowy"
        Me.btnOtwórzPlik.UseVisualStyleBackColor = True
        '
        'btnZapiszPlik
        '
        Me.btnZapiszPlik.Location = New System.Drawing.Point(34, 207)
        Me.btnZapiszPlik.Name = "btnZapiszPlik"
        Me.btnZapiszPlik.Size = New System.Drawing.Size(238, 23)
        Me.btnZapiszPlik.TabIndex = 3
        Me.btnZapiszPlik.Text = "Zapisz plik"
        Me.btnZapiszPlik.UseVisualStyleBackColor = True
        '
        'txtPlikDocelowy
        '
        Me.txtPlikDocelowy.Location = New System.Drawing.Point(34, 159)
        Me.txtPlikDocelowy.Name = "txtPlikDocelowy"
        Me.txtPlikDocelowy.Size = New System.Drawing.Size(238, 20)
        Me.txtPlikDocelowy.TabIndex = 4
        '
        'FormularzGłówny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 351)
        Me.Controls.Add(Me.txtPlikDocelowy)
        Me.Controls.Add(Me.btnZapiszPlik)
        Me.Controls.Add(Me.btnOtwórzPlik)
        Me.Controls.Add(Me.txtPlikŹródłowy)
        Me.Name = "FormularzGłówny"
        Me.Text = "Operacje na plikach"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlikŹródłowy As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOtwórzPlik As System.Windows.Forms.Button
    Friend WithEvents btnZapiszPlik As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtPlikDocelowy As System.Windows.Forms.TextBox

End Class
