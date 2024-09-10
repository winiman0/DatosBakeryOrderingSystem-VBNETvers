<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class orderLogAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orderLogAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OrderLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.TblOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosBakeryDataSet = New DatosBakeryOrderingSystem.datosBakeryDataSet()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.cmbService = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grdOrder = New System.Windows.Forms.DataGridView()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblOrderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosBakeryDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EmployeeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TblOrderTableAdapter = New DatosBakeryOrderingSystem.datosBakeryDataSetTableAdapters.tblOrderTableAdapter()
        Me.BindingSourceOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDialog2 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TblOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosBakeryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOrderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosBakeryDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderLogToolStripMenuItem, Me.UsersToolStripMenuItem, Me.ProductToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1485, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OrderLogToolStripMenuItem
        '
        Me.OrderLogToolStripMenuItem.Name = "OrderLogToolStripMenuItem"
        Me.OrderLogToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.OrderLogToolStripMenuItem.Text = "Order Log"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Linen
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.grdOrder)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1485, 789)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.BackColor = System.Drawing.Color.Moccasin
        Me.GroupBox3.Controls.Add(Me.lblProductID)
        Me.GroupBox3.Controls.Add(Me.lblCustomerID)
        Me.GroupBox3.Controls.Add(Me.lblOrderID)
        Me.GroupBox3.Controls.Add(Me.cmbPayment)
        Me.GroupBox3.Controls.Add(Me.cmbService)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.btnNext)
        Me.GroupBox3.Controls.Add(Me.btnPrint)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.btnLast)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.btnPrevious)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.btnFirst)
        Me.GroupBox3.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(44, 441)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1401, 321)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'lblProductID
        '
        Me.lblProductID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrderBindingSource, "productID", True))
        Me.lblProductID.Location = New System.Drawing.Point(195, 162)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(100, 23)
        Me.lblProductID.TabIndex = 28
        '
        'TblOrderBindingSource
        '
        Me.TblOrderBindingSource.DataMember = "tblOrder"
        Me.TblOrderBindingSource.DataSource = Me.DatosBakeryDataSet
        '
        'DatosBakeryDataSet
        '
        Me.DatosBakeryDataSet.DataSetName = "datosBakeryDataSet"
        Me.DatosBakeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCustomerID
        '
        Me.lblCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrderBindingSource, "custID", True))
        Me.lblCustomerID.Location = New System.Drawing.Point(195, 116)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(100, 23)
        Me.lblCustomerID.TabIndex = 27
        '
        'lblOrderID
        '
        Me.lblOrderID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrderBindingSource, "orderID", True))
        Me.lblOrderID.Location = New System.Drawing.Point(200, 80)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(48, 16)
        Me.lblOrderID.TabIndex = 26
        '
        'cmbPayment
        '
        Me.cmbPayment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrderBindingSource, "payment", True))
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Items.AddRange(New Object() {"Cash", "Transfer"})
        Me.cmbPayment.Location = New System.Drawing.Point(737, 121)
        Me.cmbPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(308, 24)
        Me.cmbPayment.TabIndex = 25
        '
        'cmbService
        '
        Me.cmbService.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrderBindingSource, "service", True))
        Me.cmbService.FormattingEnabled = True
        Me.cmbService.Items.AddRange(New Object() {"Delivery", "Pick Up"})
        Me.cmbService.Location = New System.Drawing.Point(737, 76)
        Me.cmbService.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbService.Name = "cmbService"
        Me.cmbService.Size = New System.Drawing.Size(308, 24)
        Me.cmbService.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Moccasin
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1181, 42)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "TOOLBOX"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Moccasin
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(477, 236)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(171, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "NAVIGATION BUTTON"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1248, 166)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 39)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1248, 121)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(117, 39)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(717, 256)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(117, 39)
        Me.btnNext.TabIndex = 19
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(1248, 274)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(117, 39)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "Print Record"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(559, 166)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 20)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Total Price (RM) :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(624, 121)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 20)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Payment :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(1105, 166)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 39)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(633, 76)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 20)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Service :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(73, 162)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 20)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Product ID :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(443, 256)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(117, 39)
        Me.btnLast.TabIndex = 16
        Me.btnLast.Text = "Last Record"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(59, 119)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 20)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Customer ID :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(89, 78)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 20)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Order ID :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(580, 256)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(117, 39)
        Me.btnPrevious.TabIndex = 15
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(557, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(241, 29)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "DETAILS SECTION"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(300, 256)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(117, 39)
        Me.btnFirst.TabIndex = 13
        Me.btnFirst.Text = "First Record"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrderBindingSource, "amount", True))
        Me.txtTotalPrice.Location = New System.Drawing.Point(737, 166)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(308, 22)
        Me.txtTotalPrice.TabIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1105, 119)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 39)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1105, 73)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 39)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grdOrder
        '
        Me.grdOrder.AllowUserToOrderColumns = True
        Me.grdOrder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdOrder.AutoGenerateColumns = False
        Me.grdOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdOrder.BackgroundColor = System.Drawing.Color.MistyRose
        Me.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.CustIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.ServiceDataGridViewTextBoxColumn, Me.PaymentDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.grdOrder.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BindingSourceOrder, "orderID", True))
        Me.grdOrder.DataSource = Me.BindingSourceOrder
        Me.grdOrder.Location = New System.Drawing.Point(44, 97)
        Me.grdOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.grdOrder.Name = "grdOrder"
        Me.grdOrder.RowHeadersWidth = 51
        Me.grdOrder.Size = New System.Drawing.Size(1401, 321)
        Me.grdOrder.TabIndex = 7
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "orderID"
        Me.OrderIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        '
        'CustIDDataGridViewTextBoxColumn
        '
        Me.CustIDDataGridViewTextBoxColumn.DataPropertyName = "custID"
        Me.CustIDDataGridViewTextBoxColumn.HeaderText = "custID"
        Me.CustIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "productID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "productID"
        Me.ProductIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'ServiceDataGridViewTextBoxColumn
        '
        Me.ServiceDataGridViewTextBoxColumn.DataPropertyName = "service"
        Me.ServiceDataGridViewTextBoxColumn.HeaderText = "service"
        Me.ServiceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ServiceDataGridViewTextBoxColumn.Name = "ServiceDataGridViewTextBoxColumn"
        '
        'PaymentDataGridViewTextBoxColumn
        '
        Me.PaymentDataGridViewTextBoxColumn.DataPropertyName = "payment"
        Me.PaymentDataGridViewTextBoxColumn.HeaderText = "payment"
        Me.PaymentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaymentDataGridViewTextBoxColumn.Name = "PaymentDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'TblOrderBindingSource1
        '
        Me.TblOrderBindingSource1.DataMember = "tblOrder"
        Me.TblOrderBindingSource1.DataSource = Me.DatosBakeryDataSetBindingSource
        '
        'DatosBakeryDataSetBindingSource
        '
        Me.DatosBakeryDataSetBindingSource.DataSource = Me.DatosBakeryDataSet
        Me.DatosBakeryDataSetBindingSource.Position = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label11.Location = New System.Drawing.Point(37, 58)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(198, 39)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "ORDER LOG"
        '
        'EmployeeDataSet
        '

        '
        'EmployeeDataSetBindingSource
        '
        Me.EmployeeDataSetBindingSource.Position = 0
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'TblOrderTableAdapter
        '
        Me.TblOrderTableAdapter.ClearBeforeFill = True
        '
        'BindingSourceOrder
        '
        Me.BindingSourceOrder.DataSource = Me.TblOrderBindingSource
        '
        'PrintDialog2
        '
        Me.PrintDialog2.UseEXDialog = True
        '
        'orderLogAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1485, 789)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "orderLogAdmin"
        Me.Text = "Order Log"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TblOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosBakeryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOrderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosBakeryDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OrderLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeDataSetBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbPayment As ComboBox
    Friend WithEvents cmbService As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnLast As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents btnFirst As Button
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents grdOrder As DataGridView
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DatosBakeryDataSetBindingSource As BindingSource
    Friend WithEvents DatosBakeryDataSet As datosBakeryDataSet
    Friend WithEvents TblOrderBindingSource As BindingSource
    Friend WithEvents TblOrderTableAdapter As datosBakeryDataSetTableAdapters.tblOrderTableAdapter
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingSourceOrder As BindingSource
    Friend WithEvents PrintDialog2 As PrintDialog
    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents TblOrderBindingSource1 As BindingSource
End Class
