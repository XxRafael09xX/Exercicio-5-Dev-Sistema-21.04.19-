Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = vbNullString Or TextBox2.Text = vbNullString Then

            TextBox1.ResetText()
            TextBox2.ResetText()
            MessageBox.Show("Existe Campos em Branco. Preencha corretamente!")

        Else

            ListBox1.Items.Add("Nome: " & TextBox1.Text & ", Telefone: " & TextBox2.Text)
            TextBox4.Text = ListBox1.Items.Count
            If ProgressBar1.Value < 100 Then
                ProgressBar1.Value += 1
                porcen.Text = ProgressBar1.Value & "%"
            End If
            TextBox1.ResetText()
            TextBox2.ResetText()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox3.Text = ListBox1.SelectedIndex + 1
        If ListBox1.SelectedItem = vbNullString Then
            MessageBox.Show("Selecione algum contato!")
        End If
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        TextBox4.Text = ListBox1.Items.Count
        If ProgressBar1.Value > 0 Then
            ProgressBar1.Value -= 1
            porcen.Text = ProgressBar1.Value & "%"
        End If

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Deseja Sair?", MsgBoxStyle.YesNo, "Atenção") = Windows.Forms.DialogResult.Yes Then
            End

        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Form2.Show()
        Form2.Activate()
        Enabled = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox3.Text = ListBox1.SelectedIndex + 1
    End Sub
End Class
