Public Class Form1
    Dim currentPhotoIndex As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnClick.Click
        Select Case currentPhotoIndex
            Case 0
                PictureBox1.Visible = True
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
            Case 1
                PictureBox1.Visible = False
                PictureBox2.Visible = True
                PictureBox3.Visible = False
                PictureBox4.Visible = False
            Case 2
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = True
                PictureBox4.Visible = False
            Case 3
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = True
            Case Else
                ' Reset the currentPhotoIndex to 0 if it exceeds 3
                currentPhotoIndex = 0
                PictureBox1.Visible = True
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
        End Select

        ' Increment the currentPhotoIndex for the next click
        currentPhotoIndex += 1
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
