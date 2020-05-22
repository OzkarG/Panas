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


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label3.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Visible = False
        PictureBox2.Visible = False
        Label6.Visible = False




    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Label6.Visible = True


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        PictureBox2.Visible = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            LinkLabel1.Visible = False

        End If

        If CheckBox1.Checked = False Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = False
            Label6.Visible = False
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            LinkLabel1.Visible = True

        End If



    End Sub

    Private Sub btnAños_Click(sender As Object, e As EventArgs) Handles btnAños.Click
        MessageBox.Show(NumericUpDown1.Value & " años sin bañarte jsjsjs")
    End Sub
End Class