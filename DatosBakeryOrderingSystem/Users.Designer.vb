<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OrderLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatosBakeryDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosBakeryDataSet = New DatosBakeryOrderingSystem.datosBakeryDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.comboState = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtNoPhone = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TblOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCustomerTableAdapter = New DatosBakeryOrderingSystem.datosBakeryDataSetTableAdapters.tblCustomerTableAdapter()
        Me.TblOrderTableAdapter = New DatosBakeryOrderingSystem.datosBakeryDataSetTableAdapters.tblOrderTableAdapter()
        Me.DatosBakeryDataSet1 = New DatosBakeryOrderingSystem.datosBakeryDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustPostcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustUsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DatosBakeryDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosBakeryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TblOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosBakeryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1485, 28)
        Me.MenuStrip1.TabIndex = 1
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Linen
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label1.Location = New System.Drawing.Point(32, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "USERS"
        '
        'DatosBakeryDataSetBindingSource
        '
        Me.DatosBakeryDataSetBindingSource.DataSource = Me.DatosBakeryDataSet
        Me.DatosBakeryDataSetBindingSource.Position = 0
        '
        'DatosBakeryDataSet
        '
        Me.DatosBakeryDataSet.DataSetName = "datosBakeryDataSet"
        Me.DatosBakeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.Thistle
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Controls.Add(Me.txtUsername)
        Me.GroupBox2.Controls.Add(Me.comboState)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnLast)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblCustID)
        Me.GroupBox2.Controls.Add(Me.btnPrevious)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnFirst)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.txtPostcode)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.txtNoPhone)
        Me.GroupBox2.Controls.Add(Me.txtFullName)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 441)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1392, 321)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Password :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(112, 90)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 20)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Username :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "custPassword", True))
        Me.txtPassword.Location = New System.Drawing.Point(237, 133)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(308, 22)
        Me.txtPassword.TabIndex = 26
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(237, 90)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(308, 22)
        Me.txtUsername.TabIndex = 25
        '
        'comboState
        '
        Me.comboState.FormattingEnabled = True
        Me.comboState.Items.AddRange(New Object() {"Kuala Lumpur", "Labuan", "Putrajaya", "Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Perak", "Perlis", "Penang", "Sabah", "Sarawak", "Selangor", "Terengganu"})
        Me.comboState.Location = New System.Drawing.Point(737, 166)
        Me.comboState.Margin = New System.Windows.Forms.Padding(4)
        Me.comboState.Name = "comboState"
        Me.comboState.Size = New System.Drawing.Size(308, 24)
        Me.comboState.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Thistle
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label10.Location = New System.Drawing.Point(1181, 42)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "TOOLBOX"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Thistle
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label9.Location = New System.Drawing.Point(477, 236)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "NAVIGATION BUTTON"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(652, 167)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "State :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(617, 121)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Postcode :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(627, 76)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Address :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(611, 210)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No Phone :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Full Name :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustID
        '
        Me.lblCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustID.Location = New System.Drawing.Point(175, 42)
        Me.lblCustID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(152, 25)
        Me.lblCustID.TabIndex = 7
        Me.lblCustID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label2.Location = New System.Drawing.Point(557, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DETAILS SECTION"
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
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(737, 121)
        Me.txtPostcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(308, 22)
        Me.txtPostcode.TabIndex = 4
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
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(737, 76)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(308, 22)
        Me.txtAddress.TabIndex = 3
        '
        'txtNoPhone
        '
        Me.txtNoPhone.Location = New System.Drawing.Point(737, 210)
        Me.txtNoPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoPhone.Name = "txtNoPhone"
        Me.txtNoPhone.Size = New System.Drawing.Size(308, 22)
        Me.txtNoPhone.TabIndex = 2
        '
        'txtFullName
        '
        Me.txtFullName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblCustomerBindingSource, "custName", True))
        Me.txtFullName.Location = New System.Drawing.Point(237, 174)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(308, 22)
        Me.txtFullName.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1485, 789)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Linen
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1485, 789)
        Me.Panel2.TabIndex = 0
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
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
        'TblOrderBindingSource
        '
        Me.TblOrderBindingSource.DataMember = "tblOrder"
        Me.TblOrderBindingSource.DataSource = Me.DatosBakeryDataSetBindingSource
        '
        'TblCustomerTableAdapter
        '
        Me.TblCustomerTableAdapter.ClearBeforeFill = True
        '
        'TblOrderTableAdapter
        '
        Me.TblOrderTableAdapter.ClearBeforeFill = True
        '
        'DatosBakeryDataSet1
        '
        Me.DatosBakeryDataSet1.DataSetName = "datosBakeryDataSet"
        Me.DatosBakeryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustIDDataGridViewTextBoxColumn, Me.CustNameDataGridViewTextBoxColumn, Me.CustPhoneDataGridViewTextBoxColumn, Me.CustAddressDataGridViewTextBoxColumn, Me.CustPostcodeDataGridViewTextBoxColumn, Me.CustStateDataGridViewTextBoxColumn, Me.CustEmailDataGridViewTextBoxColumn, Me.CustUsernameDataGridViewTextBoxColumn, Me.CustPasswordDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblCustomerBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.MediumVioletRed
        Me.DataGridView1.Location = New System.Drawing.Point(55, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1232, 284)
        Me.DataGridView1.TabIndex = 6
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataMember = "tblCustomer"
        Me.TblCustomerBindingSource.DataSource = Me.DatosBakeryDataSet1
        '
        'CustIDDataGridViewTextBoxColumn
        '
        Me.CustIDDataGridViewTextBoxColumn.DataPropertyName = "custID"
        Me.CustIDDataGridViewTextBoxColumn.HeaderText = "custID"
        Me.CustIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn"
        '
        'CustNameDataGridViewTextBoxColumn
        '
        Me.CustNameDataGridViewTextBoxColumn.DataPropertyName = "custName"
        Me.CustNameDataGridViewTextBoxColumn.HeaderText = "custName"
        Me.CustNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustNameDataGridViewTextBoxColumn.Name = "CustNameDataGridViewTextBoxColumn"
        '
        'CustPhoneDataGridViewTextBoxColumn
        '
        Me.CustPhoneDataGridViewTextBoxColumn.DataPropertyName = "custPhone"
        Me.CustPhoneDataGridViewTextBoxColumn.HeaderText = "custPhone"
        Me.CustPhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustPhoneDataGridViewTextBoxColumn.Name = "CustPhoneDataGridViewTextBoxColumn"
        '
        'CustAddressDataGridViewTextBoxColumn
        '
        Me.CustAddressDataGridViewTextBoxColumn.DataPropertyName = "custAddress"
        Me.CustAddressDataGridViewTextBoxColumn.HeaderText = "custAddress"
        Me.CustAddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustAddressDataGridViewTextBoxColumn.Name = "CustAddressDataGridViewTextBoxColumn"
        '
        'CustPostcodeDataGridViewTextBoxColumn
        '
        Me.CustPostcodeDataGridViewTextBoxColumn.DataPropertyName = "custPostcode"
        Me.CustPostcodeDataGridViewTextBoxColumn.HeaderText = "custPostcode"
        Me.CustPostcodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustPostcodeDataGridViewTextBoxColumn.Name = "CustPostcodeDataGridViewTextBoxColumn"
        '
        'CustStateDataGridViewTextBoxColumn
        '
        Me.CustStateDataGridViewTextBoxColumn.DataPropertyName = "custState"
        Me.CustStateDataGridViewTextBoxColumn.HeaderText = "custState"
        Me.CustStateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustStateDataGridViewTextBoxColumn.Name = "CustStateDataGridViewTextBoxColumn"
        '
        'CustEmailDataGridViewTextBoxColumn
        '
        Me.CustEmailDataGridViewTextBoxColumn.DataPropertyName = "custEmail"
        Me.CustEmailDataGridViewTextBoxColumn.HeaderText = "custEmail"
        Me.CustEmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustEmailDataGridViewTextBoxColumn.Name = "CustEmailDataGridViewTextBoxColumn"
        '
        'CustUsernameDataGridViewTextBoxColumn
        '
        Me.CustUsernameDataGridViewTextBoxColumn.DataPropertyName = "custUsername"
        Me.CustUsernameDataGridViewTextBoxColumn.HeaderText = "custUsername"
        Me.CustUsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustUsernameDataGridViewTextBoxColumn.Name = "CustUsernameDataGridViewTextBoxColumn"
        '
        'CustPasswordDataGridViewTextBoxColumn
        '
        Me.CustPasswordDataGridViewTextBoxColumn.DataPropertyName = "custPassword"
        Me.CustPasswordDataGridViewTextBoxColumn.HeaderText = "custPassword"
        Me.CustPasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustPasswordDataGridViewTextBoxColumn.Name = "CustPasswordDataGridViewTextBoxColumn"
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1485, 789)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Users"
        Me.Text = "Users"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DatosBakeryDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosBakeryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TblOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosBakeryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OrderLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLast As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCustID As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtNoPhone As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents comboState As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DatosBakeryDataSetBindingSource As BindingSource
    Friend WithEvents DatosBakeryDataSet As datosBakeryDataSet
    Friend WithEvents TblCustomerTableAdapter As datosBakeryDataSetTableAdapters.tblCustomerTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents TblOrderBindingSource As BindingSource
    Friend WithEvents TblOrderTableAdapter As datosBakeryDataSetTableAdapters.tblOrderTableAdapter
    Friend WithEvents DatosBakeryDataSet1 As datosBakeryDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TblCustomerBindingSource As BindingSource
    Friend WithEvents CustIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustPostcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustStateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustUsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
