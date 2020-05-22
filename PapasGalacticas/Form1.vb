Public Class Form1
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("www.youtube.com/watch?v=Lt0Hnm_h32Q")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "Fumar foco"
        PictureBox1.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "comer palomas"
        Label5.Visible = True
        PictureBox2.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label3.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Visible = False
        PictureBox2.Visible = False





    End Sub
End Class