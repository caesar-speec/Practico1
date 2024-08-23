Public Class Form1
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim apellido As String = TextBox1.Text ' Assuming TextBox1 is for Apellido
        Dim nombre As String = TextBox2.Text ' Assuming TextBox2 is for Nombre

        ' Display the concatenated string in the third TextBox
        TextBox3.Text = apellido & " " & nombre
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TextBox3.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
