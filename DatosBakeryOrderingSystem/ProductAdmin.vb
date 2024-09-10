Imports System.Drawing.Printing
Imports DatosBakeryOrderingSystem.datosBakeryDataSetTableAdapters

Public Class ProductAdmin

    'Button to print the form of customer list
    Private Bitmap As Bitmap
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim panel As New Panel()
        Me.Controls.Add(panel)

        Dim grp As Graphics = panel.CreateGraphics
        Dim formSize As Size = Me.ClientSize
        Bitmap = New Bitmap(formSize.Width, formSize.Height, grp)
        grp = Graphics.FromImage(Bitmap)

        Dim panelLocation As Point = PointToScreen(panel.Location)
        grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize)

        'Print Preview Dialog
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show(Me, "Are you sure, you want to DELETE?", "Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            TblProductBindingSource.RemoveCurrent()
            TblProductTableAdapter.Update(DatosBakeryDataSet.tblProduct)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnAdd.Text = "Add"
        btnUpdate.Text = "Update"
        TblProductBindingSource.EndEdit()
        TblProductTableAdapter.Update(DatosBakeryDataSet.tblProduct)
        MessageBox.Show(Me, "Data has been updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.None)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Cancel"
            TblProductTableAdapter.Update(DatosBakeryDataSet.tblProduct)
        Else
            btnUpdate.Text = "Update"
            TblProductBindingSource.CancelEdit()
            TblProductTableAdapter.Update(DatosBakeryDataSet.tblProduct)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Cancel"
            TblProductBindingSource.AddNew()
        Else
            btnAdd.Text = "Add"
            TblProductBindingSource.CancelEdit()
            TblProductTableAdapter.Update(DatosBakeryDataSet.tblProduct)
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        BindingSourceProduct.MoveFirst()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        BindingSourceProduct.MoveLast()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BindingSourceProduct.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingSourceProduct.MoveNext()
    End Sub

    Private Sub ProductAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblProduct' table. You can move, or remove it, as needed.
        Me.TblProductTableAdapter.Fill(Me.DatosBakeryDataSet.tblProduct)

    End Sub

    Private Sub gdProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdProduct.CellContentClick

    End Sub
End Class