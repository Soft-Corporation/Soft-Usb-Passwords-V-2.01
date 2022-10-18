Public Class _4

    Dim NuovP As System.Drawing.Point
    Dim x, p As Integer

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        x = Control.MousePosition.X - Me.Location.X
        p = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub _4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Timer2.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Timer3.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Timer4.Start()
        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Timer5.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Timer6.Start()
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Gold") Then
            Timer8.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.RoyalBlue)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Red)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Green)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Orange)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Purple)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Panel5.BackColor = Color.FromArgb(TrackBar1.Value, Color.Gold)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        If My.Computer.FileSystem.DirectoryExists("H:\") Then
            Dim salva As New System.IO.StreamWriter("H:\Pass\P4")
            salva.Write(y2.Text)
            salva.Close()

            Dim sal As New System.IO.StreamWriter("H:\Pass\Dp4")
            sal.Write(y.Text)
            sal.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("D:\") Then
            Dim salva2 As New System.IO.StreamWriter("D:\Pass\P4")

            salva2.Write(y2.Text)

            salva2.Close()




            Dim sal2 As New System.IO.StreamWriter("D:\Pass\Dp4")
            sal2.Write(y.Text)
            sal2.Close()

        ElseIf My.Computer.FileSystem.DirectoryExists("E:\") Then
            Dim salva3 As New System.IO.StreamWriter("E:\Pass\P4")

            salva3.Write(y2.Text)

            salva3.Close()




            Dim sal3 As New System.IO.StreamWriter("E:\Pass\Dp4")
            sal3.Write(y.Text)
            sal3.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("F:\") Then
            Dim salva4 As New System.IO.StreamWriter("F:\Pass\P4")

            salva4.Write(y2.Text)

            salva4.Close()




            Dim sal4 As New System.IO.StreamWriter("F:\Pass\Dp4")
            sal4.Write(y.Text)
            sal4.Close()
        ElseIf My.Computer.FileSystem.DirectoryExists("G:\") Then
            Dim salva5 As New System.IO.StreamWriter("G:\Pass\P4")

            salva5.Write(y2.Text)

            salva5.Close()




            Dim sal5 As New System.IO.StreamWriter("G:\Pass\Dp4")
            sal5.Write(y.Text)
            sal5.Close()
        End If



        MsgBox("Salvato")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NuovP = Control.MousePosition
            NuovP.X -= (x)
            NuovP.Y -= (p)
            Me.Location = NuovP
        End If
    End Sub
End Class