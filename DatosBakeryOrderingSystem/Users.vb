Imports DatosBakeryOrderingSystem.datosBakeryDataSetTableAdapters

Public Class Users

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatosBakeryDataSet1.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet1.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet1.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet1.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet1.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet1.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet1.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet1.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblOrder' table. You can move, or remove it, as needed.
        Me.TblOrderTableAdapter.Fill(Me.DatosBakeryDataSet.tblOrder)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblOrder' table. You can move, or remove it, as needed.
        Me.TblOrderTableAdapter.Fill(Me.DatosBakeryDataSet.tblOrder)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblOrder' table. You can move, or remove it, as needed.
        Me.TblOrderTableAdapter.Fill(Me.DatosBakeryDataSet.tblOrder)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet.tblCustomer)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblOrder' table. You can move, or remove it, as needed.
        Me.TblOrderTableAdapter.Fill(Me.DatosBakeryDataSet.tblOrder)
        'TODO: This line of code loads data into the 'DatosBakeryDataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.DatosBakeryDataSet.tblCustomer)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Cancel"
            TblCustomerBindingSource.AddNew()
        Else
            btnAdd.Text = "Add"
            TblCustomerBindingSource.CancelEdit()
            TblCustomerTableAdapter.Update(DatosBakeryDataSet.tblCustomer)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Cancel"
            TblCustomerTableAdapter.Update(DatosBakeryDataSet.tblCustomer)
        Else
            btnUpdate.Text = "Update"
            TblCustomerBindingSource.CancelEdit()
            TblCustomerTableAdapter.Update(DatosBakeryDataSet.tblCustomer)
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnAdd.Text = "Add"
        btnUpdate.Text = "Update"
        TblCustomerBindingSource.EndEdit()
        TblCustomerTableAdapter.Update(DatosBakeryDataSet.tblCustomer)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show(Me, " Do you want to DELETE?", "Confirmation",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            TblCustomerBindingSource.RemoveCurrent()
            TblCustomerTableAdapter.Update(DatosBakeryDataSet.tblCustomer)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtFullName.Text = ""
        comboState.Text = ""
        txtPostcode.Text = ""
        txtAddress.Text = ""
        txtNoPhone.Text = ""

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        TblCustomerBindingSource.MoveFirst()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        TblCustomerBindingSource.MoveLast()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        TblCustomerBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        TblCustomerBindingSource.MoveNext()
    End Sub

    Private Sub OrderLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderLogToolStripMenuItem.Click
        orderLogAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        ProductAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class