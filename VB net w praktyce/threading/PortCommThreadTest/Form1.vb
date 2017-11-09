Imports System
Imports System.Windows.Forms
Imports System.IO

Imports System.IO.Ports
Imports System.Text

Public Class Form1

    Dim comm_buffer(50000) As Byte
    Dim read_ptr As Int16
    Dim write_ptr As Int16
    Dim bm As New Bitmap(300, 300)
    Dim grafika As Graphics = Graphics.FromImage(bm)




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler SerialPort1.DataReceived, AddressOf DataReceviedHandler


        Try
            SerialPort1.PortName = "COM7"
            SerialPort1.BaudRate = "115200"
            SerialPort1.DataBits = 8
            SerialPort1.DiscardNull = False
            SerialPort1.DtrEnable = False
            SerialPort1.Handshake = Handshake.None
            SerialPort1.Parity = Parity.None
            SerialPort1.ParityReplace = 63
            SerialPort1.ReadBufferSize = 200
            SerialPort1.WriteBufferSize = 100
            SerialPort1.ReadTimeout = 100
            SerialPort1.WriteTimeout = 100
            SerialPort1.Open()
            SerialPort1.ReadExisting()
        Catch ex As Exception
            MsgBox("nie otwarto portu!")
        End Try
        Debug.Write("#####################################################################################################################################################################################################################################################################################################################################################################################################################################################################################################################################")
    End Sub


    Private Sub DataReceviedHandler(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim indata As String = sp.ReadExisting()
        Debug.Write(indata)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

            Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer2.Start()
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TextBox1.Text = TextBox1.Text & "-" & vbCrLf
        Dim r As New Random(System.DateTime.Now.Millisecond)

        Dim x, y, z As Byte

        Dim i, j As UInteger
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image.Save("D:\" & Date.Now.ToString("HH_mm_ss") & ".bmp")
    End Sub


        For i = 0 To 290
            For j = 0 To 290
                x = r.Next(0, 255)
                y = r.Next(0, 255)
                z = r.Next(0, 255)
                bm.SetPixel(i, j, Color.FromArgb(x, y, z))
            Next
        Next
        Me.PictureBox1.Image = bm
        PictureBox1.Refresh()
    End Sub

End Class
