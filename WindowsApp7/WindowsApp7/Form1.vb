Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'lar meg utløse dette når jeg klikker
        Dim mass = TextBox1.Text 'tar ut masse
        Dim velocity = TextBox2.Text 'tar ut hastighet
        Dim energy = 0.001 * 0.5 * mass * velocity * velocity 'Ganger masse i gram med en halv og hastighet^2 og definerer det som energi
        MessageBox.Show(energy) 'Viser energien vi får
    End Sub
End Class