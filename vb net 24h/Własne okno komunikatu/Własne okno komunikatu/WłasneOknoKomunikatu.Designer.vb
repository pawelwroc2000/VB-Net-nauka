<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WłasneOknoKomunikatu
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
        Me.txtWłasnyKomunikat = New System.Windows.Forms.TextBox()
        Me.btnAnuluj = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtWłasnyKomunikat
        '
        Me.txtWłasnyKomunikat.Location = New System.Drawing.Point(43, 40)
        Me.txtWłasnyKomunikat.Multiline = True
        Me.txtWłasnyKomunikat.Name = "txtWłasnyKomunikat"
        Me.txtWłasnyKomunikat.ReadOnly = True
        Me.txtWłasnyKomunikat.Size = New System.Drawing.Size(190, 100)
        Me.txtWłasnyKomunikat.TabIndex = 3
        Me.txtWłasnyKomunikat.Text = "Treść własnego komunikatu"
        '
        'btnAnuluj
        '
        Me.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnuluj.Location = New System.Drawing.Point(43, 188)
        Me.btnAnuluj.Name = "btnAnuluj"
        Me.btnAnuluj.Size = New System.Drawing.Size(75, 23)
        Me.btnAnuluj.TabIndex = 4
        Me.btnAnuluj.Text = "Anuluj"
        Me.btnAnuluj.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(43, 146)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'WłasneOknoKomunikatu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnAnuluj)
        Me.Controls.Add(Me.txtWłasnyKomunikat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "WłasneOknoKomunikatu"
        Me.Text = "WłasneOknoKomunikatu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWłasnyKomunikat As System.Windows.Forms.TextBox
    Friend WithEvents btnAnuluj As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
