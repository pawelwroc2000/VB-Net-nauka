﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularzGłówny))
        Me.txtRysowanie = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.drawButton = New System.Windows.Forms.Button()
        Me.draw2Button = New System.Windows.Forms.Button()
        Me.LoadBMPtoPictureBox1Button = New System.Windows.Forms.Button()
        Me.SaveToFileButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rain_PictureBox = New System.Windows.Forms.PictureBox()
        Me.snow_PictureBox = New System.Windows.Forms.PictureBox()
        Me.main_PictureBox = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rain_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.snow_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.main_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRysowanie
        '
        Me.txtRysowanie.Location = New System.Drawing.Point(605, 12)
        Me.txtRysowanie.Name = "txtRysowanie"
        Me.txtRysowanie.Size = New System.Drawing.Size(282, 20)
        Me.txtRysowanie.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(1046, 430)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 600)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'drawButton
        '
        Me.drawButton.Location = New System.Drawing.Point(605, 50)
        Me.drawButton.Name = "drawButton"
        Me.drawButton.Size = New System.Drawing.Size(282, 23)
        Me.drawButton.TabIndex = 4
        Me.drawButton.Text = "draw"
        Me.drawButton.UseVisualStyleBackColor = True
        '
        'draw2Button
        '
        Me.draw2Button.Location = New System.Drawing.Point(605, 79)
        Me.draw2Button.Name = "draw2Button"
        Me.draw2Button.Size = New System.Drawing.Size(282, 23)
        Me.draw2Button.TabIndex = 6
        Me.draw2Button.Text = "draw2"
        Me.draw2Button.UseVisualStyleBackColor = True
        '
        'LoadBMPtoPictureBox1Button
        '
        Me.LoadBMPtoPictureBox1Button.Location = New System.Drawing.Point(605, 108)
        Me.LoadBMPtoPictureBox1Button.Name = "LoadBMPtoPictureBox1Button"
        Me.LoadBMPtoPictureBox1Button.Size = New System.Drawing.Size(282, 23)
        Me.LoadBMPtoPictureBox1Button.TabIndex = 7
        Me.LoadBMPtoPictureBox1Button.Text = "Load BMP to PictureBox1"
        Me.LoadBMPtoPictureBox1Button.UseVisualStyleBackColor = True
        '
        'SaveToFileButton
        '
        Me.SaveToFileButton.Location = New System.Drawing.Point(605, 137)
        Me.SaveToFileButton.Name = "SaveToFileButton"
        Me.SaveToFileButton.Size = New System.Drawing.Size(282, 23)
        Me.SaveToFileButton.TabIndex = 8
        Me.SaveToFileButton.Text = "save bmp to file"
        Me.SaveToFileButton.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Location = New System.Drawing.Point(215, 154)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'rain_PictureBox
        '
        Me.rain_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.rain_PictureBox.Location = New System.Drawing.Point(1046, 155)
        Me.rain_PictureBox.Name = "rain_PictureBox"
        Me.rain_PictureBox.Size = New System.Drawing.Size(100, 100)
        Me.rain_PictureBox.TabIndex = 11
        Me.rain_PictureBox.TabStop = False
        '
        'snow_PictureBox
        '
        Me.snow_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.snow_PictureBox.Location = New System.Drawing.Point(1046, 31)
        Me.snow_PictureBox.Name = "snow_PictureBox"
        Me.snow_PictureBox.Size = New System.Drawing.Size(100, 100)
        Me.snow_PictureBox.TabIndex = 12
        Me.snow_PictureBox.TabStop = False
        '
        'main_PictureBox
        '
        Me.main_PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.main_PictureBox.Location = New System.Drawing.Point(1046, 286)
        Me.main_PictureBox.Name = "main_PictureBox"
        Me.main_PictureBox.Size = New System.Drawing.Size(100, 100)
        Me.main_PictureBox.TabIndex = 13
        Me.main_PictureBox.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'FormularzGłówny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1505, 1042)
        Me.Controls.Add(Me.main_PictureBox)
        Me.Controls.Add(Me.snow_PictureBox)
        Me.Controls.Add(Me.rain_PictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.SaveToFileButton)
        Me.Controls.Add(Me.LoadBMPtoPictureBox1Button)
        Me.Controls.Add(Me.draw2Button)
        Me.Controls.Add(Me.drawButton)
        Me.Controls.Add(Me.txtRysowanie)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormularzGłówny"
        Me.Text = "Przykładowa grafika"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rain_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.snow_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.main_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRysowanie As System.Windows.Forms.TextBox
    Friend WithEvents drawButton As System.Windows.Forms.Button
    Friend WithEvents draw2Button As System.Windows.Forms.Button
    Friend WithEvents LoadBMPtoPictureBox1Button As System.Windows.Forms.Button
    Friend WithEvents SaveToFileButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rain_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents snow_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents main_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
