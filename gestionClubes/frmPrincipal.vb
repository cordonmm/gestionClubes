Public Class frmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim frmAltaSocio As frmAltaSocio
        frmAltaSocio = New frmAltaSocio
        frmAltaSocio.Show()
    End Sub
End Class
