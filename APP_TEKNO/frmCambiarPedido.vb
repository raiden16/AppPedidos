Imports System.ComponentModel

Public Class frmCambiarPedido

    Public indice As String
    Public pedidoAnt As String

    Private Sub frmCambiarPedido_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCambiarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If dgvCambio.Rows.Count > 0 Then
                dgvCambio.Columns(0).Visible = False
                dgvCambio.Rows(0).Selected = True
                dgvCambio.CurrentCell = dgvCambio.Rows(0).Cells(1)
            Else
                MsgBox("No se encontraron coincidencias con el articulo seleccionado")
                Me.Dispose()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Pedido.dgvPedidos.Rows(indice).Cells("noPedido").Value = dgvCambio.Rows(dgvCambio.CurrentRow.Index).Cells("noPedido").Value.ToString()
        Pedido.dgvPedidos.Rows(dgvCambio.Rows(dgvCambio.CurrentRow.Index).Cells(0).Value).Cells("noPedido").Value = pedidoAnt.ToString()

        For Each dRow As DataGridViewRow In Pedido.dgvPedidos.Rows
            dRow.Cells("noPedido").Value = dRow.Cells("noPedido").Value.ToString()
        Next
        Pedido.Show()
        Pedido.dgvPedidos.Sort(Pedido.dgvPedidos.Columns("noPedido"), ListSortDirection.Ascending)
        Me.Dispose()
    End Sub
End Class