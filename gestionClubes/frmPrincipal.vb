Public Class frmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim frmAltaSocio As frmAltaSocio
        frmAltaSocio = New frmAltaSocio
        frmAltaSocio.Show()
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        Dim frmConfiguracion As frmConfiguracion
        frmConfiguracion = New frmConfiguracion
        frmConfiguracion.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        Dim frmListadoSocios As frmListadoSocios
        frmListadoSocios = New frmListadoSocios
        frmListadoSocios.Show()
    End Sub
End Class
