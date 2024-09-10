Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports DatosBakeryOrderingSystem.datosBakeryDataSetTableAdapters

Public Class orderLogAdmin

    Private printTitle As String = "Order Log"
    Private rowIndex As Integer = 0

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        ProductAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub orderLogAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Load data into tblOrder DataGridView
            Me.TblOrderTableAdapter.Fill(Me.DatosBakeryDataSet.tblOrder)

            ' Optionally, configure column headers or other properties
            'grdOrder.Columns("orderID").HeaderText = "Order ID"
            'grdOrder.Columns("custID").HeaderText = "Customer ID"
            'grdOrder.Columns("productID").HeaderText = "Product ID"
            'grdOrder.Columns("service").HeaderText = "Service"
            'grdOrder.Columns("payment").HeaderText = "Payment"
            'grdOrder.Columns("amount").HeaderText = "Amount"

            ' Set up PrintPreviewDialog
            PrintPreviewDialog1.Document = PrintDocument1
        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading the order log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Cancel"
            TblOrderBindingSource.AddNew()
        Else
            btnAdd.Text = "Add"
            TblOrderBindingSource.CancelEdit()
            TblOrderTableAdapter.Update(DatosBakeryDataSet.tblOrder)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Cancel"
            TblOrderTableAdapter.Update(DatosBakeryDataSet.tblOrder)
        Else
            btnUpdate.Text = "Update"
            TblOrderBindingSource.CancelEdit()
            TblOrderTableAdapter.Update(DatosBakeryDataSet.tblOrder)
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnAdd.Text = "Add"
        btnUpdate.Text = "Update"
        TblOrderBindingSource.EndEdit()
        TblOrderTableAdapter.Update(DatosBakeryDataSet.tblOrder)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show(Me, " Do you want to DELETE?", "Confirmation",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            TblOrderBindingSource.RemoveCurrent()
            TblOrderTableAdapter.Update(DatosBakeryDataSet.tblOrder)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOrderID.Text = ""
        lblCustomerID.Text = ""
        lblProductID.Text = ""
        cmbService.Text = ""
        cmbPayment.Text = ""
        txtTotalPrice.Text = ""

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        BindingSourceOrder.MoveFirst()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        BindingSourceOrder.MoveLast()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BindingSourceOrder.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingSourceOrder.MoveNext()
    End Sub

    Private Sub printDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titleFont As New Font("Arial", 24, FontStyle.Bold)
        Dim bodyFont As New Font("Arial", 12)
        Dim titleHeight As Single = e.Graphics.MeasureString(printTitle, titleFont).Height
        Dim yPos As Single = e.MarginBounds.Top

        ' Draw the title
        e.Graphics.DrawString(printTitle, titleFont, Brushes.Black, e.MarginBounds.Left, yPos)
        yPos += titleHeight + 20 ' Adding 20 for some space between title and data

        ' Draw the DataGridView column headers
        Dim columnHeaderHeight As Single = bodyFont.GetHeight(e.Graphics) + 10
        Dim columnXPos As Single = e.MarginBounds.Left

        For Each column As DataGridViewColumn In grdOrder.Columns
            e.Graphics.DrawString(column.HeaderText, bodyFont, Brushes.Black, columnXPos, yPos)
            columnXPos += column.Width + 10 ' Adding 10 for some space between columns
        Next

        yPos += columnHeaderHeight

        ' Draw the DataGridView rows
        Dim rowHeight As Single = bodyFont.GetHeight(e.Graphics) + 10

        While rowIndex < grdOrder.Rows.Count
            Dim columnXPosRow As Single = e.MarginBounds.Left
            Dim row As DataGridViewRow = grdOrder.Rows(rowIndex)

            For Each cell As DataGridViewCell In row.Cells
                e.Graphics.DrawString(cell.FormattedValue.ToString(), bodyFont, Brushes.Black, columnXPosRow, yPos)
                columnXPosRow += cell.Size.Width + 10 ' Adding 10 for some space between cells
            Next

            yPos += rowHeight
            rowIndex += 1

            ' Check if we need to break for a new page
            If yPos + rowHeight > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Exit Sub
            End If
        End While

        e.HasMorePages = False
        rowIndex = 0 ' Reset row index for next print
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Show the Print Dialog
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            ' If the user clicked OK in the print dialog, show the print preview dialog
            If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
                ' Print the document
                PrintDocument1.Print()
            End If
        End If
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Users.Show()
        Me.Hide()
    End Sub

    Private Sub grdOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdOrder.CellContentClick

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class