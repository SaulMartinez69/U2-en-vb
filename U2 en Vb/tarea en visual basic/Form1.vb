Public Class Form1
    Private p As Persona()

    Private c As Contacto()
    Private index As Integer = 0
    Private lengtch As Integer = 10
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If index = lengtch Then
            Return
        End If
        c = New Contacto(lengtch - 1) {}
        c(index) = New Contacto()
        c(index).NombreProp = txtNombre.Text
        c(index).FechaNacimiento = dtpFechaDeNacimiento.Value
        dtpFechaDeNacimiento.Value = Date.Now
        c(index).telefonoProp = txtTelefono.Text
        c(index)._correo = txtCorreo.Text
        Dim espacio As String = c(index).ToString() & Environment.NewLine
        Label5.Text = Label5.Text & espacio
        index += 1
    End Sub
End Class
