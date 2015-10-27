Public Class frmListadoSocios


    Private Sub frmListadoSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VarelaDataSet.Table' Puede moverla o quitarla según sea necesario.
        Me.TableTableAdapter.Fill(Me.VarelaDataSet.Table)

    End Sub

    Private Sub txtSocio_TextChanged(sender As Object, e As EventArgs) Handles txtSocio.TextChanged
        TableBindingSource.Filter = "nombre like '*" & txtSocio.Text & "*' or apellidos like '*" & txtSocio.Text & "*' or dni like '*" & txtSocio.Text & "*' or email like '*" & txtSocio.Text & "*'"
    End Sub

    Private Sub dtgListadoSocios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgListadoSocios.CellDoubleClick
        Dim frmCuotas As frmCuotas
        frmCuotas = New frmCuotas
        frmCuotas.Show()
    End Sub

End Class