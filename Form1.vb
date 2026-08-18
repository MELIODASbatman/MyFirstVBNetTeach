Public Class Form1
    Private Sub lblname_Click(sender As Object, e As EventArgs) Handles lblname.Click

    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        'MessageBox.Show("Name: " & txtname.Text)
        'MessageBox.Show("Course:" & txtcourse.Text)
        'MessageBox.Show("Collage:" & txtcollage.Text)
        MessageBox.Show("Name: " & txtname.Text & vbCrLf & "Course: " & txtcourse.Text & vbCrLf & "Collage: " & txtcollage.Text)
        '(vbCrLf Is used To add a New line In the message box, so that each piece of information appears on a separate line.)
    End Sub
End Class
