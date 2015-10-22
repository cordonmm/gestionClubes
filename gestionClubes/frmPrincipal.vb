Public Class frmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim frmAltaSocio As frmAltaSocio
        frmAltaSocio = New frmAltaSocio
        frmAltaSocio.Show()
    End Sub

    Private Sub btnSocios_Click(sender As Object, e As EventArgs) Handles btnSocios.Click
        Dim frmAltaSocio As frmAltaSocio
        frmAltaSocio = New frmAltaSocio
        frmAltaSocio.Show()
    End Sub

    Private Sub btnSacarEntrada_Click(sender As Object, e As EventArgs) Handles btnSacarEntrada.Click
        Process.Start("http://www.clubfernandovarela.es/acceso")
    End Sub

    Private Sub ContabilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContabilidadToolStripMenuItem.Click

    End Sub

    Private Sub btnFaturación_Click(sender As Object, e As EventArgs) Handles btnFaturación.Click

    End Sub

    Private Sub btnPuerta_Click(sender As Object, e As EventArgs) Handles btnPuerta.Click

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Process.Start("http://www.clubfernandovarela.es/Padel-Admin")
    End Sub
End Class
