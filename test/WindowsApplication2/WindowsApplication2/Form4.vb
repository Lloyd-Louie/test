Public Class Form4

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Timer1.Enabled = True Then

            ProgressBar1.Value = ProgressBar1.Value + 2

            If ProgressBar1.Value = 100 Then
                Timer1.Enabled = False
                MessageBox.Show("Welcome to the game", "yo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Form2.Show()

                Me.Hide()





            End If



        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


    End Sub
End Class