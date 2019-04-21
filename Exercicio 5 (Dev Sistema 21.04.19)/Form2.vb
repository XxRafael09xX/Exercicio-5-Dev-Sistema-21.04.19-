Public Class Form2

    Dim cont As Int16
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Value += 10
        cont += 1
        Timer1.Interval = 1

        If cont = 200 Then
            Timer1.Stop()
            Timer1.Enabled = False

            Form1.Enabled = True
            Close()
        End If

    End Sub
End Class