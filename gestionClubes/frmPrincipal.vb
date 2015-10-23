Public Class frmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)
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



    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Process.Start("http://www.clubfernandovarela.es/Padel-Admin")
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmListadoSocios As frmListadoSocios
        frmListadoSocios = New frmListadoSocios
        frmListadoSocios.Show()
    End Sub

    Private Sub CuotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuotasToolStripMenuItem.Click
        Dim frmListadoSocios As frmListadoSocios
        frmListadoSocios = New frmListadoSocios
        frmListadoSocios.Show()
    End Sub

    Private Sub SociosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SociosToolStripMenuItem1.Click
        Dim frmAltaSocio As frmAltaSocio
        frmAltaSocio = New frmAltaSocio
        frmAltaSocio.Show()
    End Sub

    Private Sub ListadoDeSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeSociosToolStripMenuItem.Click
        Dim frmListadoSocios As frmListadoSocios
        frmListadoSocios = New frmListadoSocios
        frmListadoSocios.Show()
    End Sub

    Private Sub ImpresiónDeCarnetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresiónDeCarnetsToolStripMenuItem.Click
        Dim frmCarnet As frmCarnet
        frmCarnet = New frmCarnet
        frmCarnet.Show()
    End Sub
End Class
