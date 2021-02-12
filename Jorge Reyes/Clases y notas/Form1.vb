Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim cantidad_alumnos As Integer
        Dim nota1, nota2, promedio As Double
        Dim nombre, apellido, clase, institucion, observacion As String
        Dim promedio_mayor, promedio_general, suma_promedios As Double
        Dim eleccion As DialogResult
        Dim cantidad_promedio As Integer

        suma_promedios = 0
        cantidad_promedio = 0

        Do
            clase = InputBox("Digite el nombre de la clase")
            cantidad_alumnos = InputBox("Ingrese la cantidad de los alumnos")

            For i = 1 To cantidad_alumnos Step 1

                Do
                    nombre = InputBox("Ingrese el nombre del alumno " & i)
                    apellido = InputBox("Ingrese el apellido del alumno" & i)
                    institucion = InputBox("Ingrese el nombre de la institucion")
                    nota1 = InputBox("Ingrese la primera nota")
                    nota2 = InputBox("Ingrese la segunda nota")

                    promedio = (nota1 + nota2) / 2

                    If (promedio >= 60) Then
                        observacion = "Aprobo"
                    Else
                        observacion = "Reprobo"
                    End If

                    If (promedio < 91) Then
                        lbReporte.Items.Add(nombre & " " & apellido & " " & clase & " " & institucion & ", " & nota1 & " " & nota2 & " | " & "promedio: " & promedio & "%" & " " & observacion)
                    ElseIf (promedio >= 91) Then
                        lbAlumnosdestacados.Items.Add(nombre & " " & apellido & " " & clase & " " & institucion & " " & nota1 & " " & nota2 & " | " & "promedio: " & promedio & "%" & " " & observacion)
                    Else
                        Print("Error")
                    End If
                    suma_promedios += promedio
                    cantidad_promedio += 1
                Loop While (cantidad_alumnos < 0)
                If (promedio_mayor = vbEmpty) Then
                    promedio_mayor = promedio
                ElseIf (promedio_mayor < promedio) Then
                    promedio_mayor = promedio
                End If
            Next
            eleccion = MessageBox.Show("Desea continuar?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (eleccion = DialogResult.Yes) Then

            ElseIf (eleccion = DialogResult.No) Then

                promedio_general = suma_promedios / cantidad_promedio ' <- porque cada alumno tiene su promedio
                txtPromediogeneral.Text = promedio_general & "%"
                txtMejorpromedio.Text = promedio_mayor & "%"
            End If
        Loop While (eleccion = DialogResult.Yes)
    End Sub
End Class
