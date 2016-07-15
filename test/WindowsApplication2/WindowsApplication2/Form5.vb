Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        MessageBox.Show("told you not to click me", ".....", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class