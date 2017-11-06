<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularzObiektowy
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
        Me.components = New System.ComponentModel.Container()
        Me.btnUtwórzObiekt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'btnUtwórzObiekt
        '
        Me.btnUtwórzObiekt.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnUtwórzObiekt.Location = New System.Drawing.Point(91, 94)
        Me.btnUtwórzObiekt.Name = "btnUtwórzObiekt"
        Me.btnUtwórzObiekt.Size = New System.Drawing.Size(94, 23)
        Me.btnUtwórzObiekt.TabIndex = 0
        Me.btnUtwórzObiekt.Text = "Utwórz Obiekt"
        Me.btnUtwórzObiekt.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "read only"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormularzObiektowy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUtwórzObiekt)
        Me.Name = "FormularzObiektowy"
        Me.Text = "Programowanie obiektowe"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUtwórzObiekt As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort

End Class
