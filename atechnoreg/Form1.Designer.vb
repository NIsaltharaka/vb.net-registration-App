<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CusTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AtechnoregDataSet1 = New atechnoreg.atechnoregDataSet1()
        Me.CusTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AtechnoregDataSet = New atechnoreg.atechnoregDataSet()
        Me.CusTable_1TableAdapter = New atechnoreg.atechnoregDataSetTableAdapters.cusTable_1TableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtdebit = New System.Windows.Forms.TextBox()
        Me.txtcredit = New System.Windows.Forms.TextBox()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txttid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CusTable_1TableAdapter1 = New atechnoreg.atechnoregDataSet1TableAdapters.cusTable_1TableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CusTable1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtechnoregDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CusTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AtechnoregDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtdate)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(27, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 242)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Registration"
        '
        'txtdate
        '
        Me.txtdate.CustomFormat = ""
        Me.txtdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdate.Location = New System.Drawing.Point(131, 200)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(240, 22)
        Me.txtdate.TabIndex = 7
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(132, 163)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(240, 22)
        Me.txtemail.TabIndex = 2
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(132, 130)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(240, 22)
        Me.txtphone.TabIndex = 2
        '
        'txtadd
        '
        Me.txtadd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd.Location = New System.Drawing.Point(133, 96)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(240, 22)
        Me.txtadd.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(133, 66)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(240, 22)
        Me.txtname.TabIndex = 6
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(133, 35)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(240, 22)
        Me.txtid.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date         :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Email        :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Phone       :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address    :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name        :"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(32, 38)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(83, 18)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID              :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(105, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(211, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(317, 321)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 29)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexit.AutoSize = True
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(862, 322)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 29)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(-1, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 3)
        Me.Panel1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(381, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(226, 39)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "A - TECHNO"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CusTable1BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(14, 377)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(958, 170)
        Me.DataGridView1.TabIndex = 6
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 175
        '
        'DebitDataGridViewTextBoxColumn
        '
        Me.DebitDataGridViewTextBoxColumn.DataPropertyName = "debit"
        Me.DebitDataGridViewTextBoxColumn.HeaderText = "Debit"
        Me.DebitDataGridViewTextBoxColumn.Name = "DebitDataGridViewTextBoxColumn"
        Me.DebitDataGridViewTextBoxColumn.ReadOnly = True
        Me.DebitDataGridViewTextBoxColumn.Width = 70
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "credit"
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreditDataGridViewTextBoxColumn.Width = 70
        '
        'CusTable1BindingSource1
        '
        Me.CusTable1BindingSource1.DataMember = "cusTable_1"
        Me.CusTable1BindingSource1.DataSource = Me.AtechnoregDataSet1
        '
        'AtechnoregDataSet1
        '
        Me.AtechnoregDataSet1.DataSetName = "atechnoregDataSet1"
        Me.AtechnoregDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CusTable1BindingSource
        '
        Me.CusTable1BindingSource.DataMember = "cusTable_1"
        Me.CusTable1BindingSource.DataSource = Me.AtechnoregDataSet
        '
        'AtechnoregDataSet
        '
        Me.AtechnoregDataSet.DataSetName = "atechnoregDataSet"
        Me.AtechnoregDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CusTable_1TableAdapter
        '
        Me.CusTable_1TableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(-1, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1002, 3)
        Me.Panel2.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtdebit)
        Me.GroupBox2.Controls.Add(Me.txtcredit)
        Me.GroupBox2.Controls.Add(Me.txtdescription)
        Me.GroupBox2.Controls.Add(Me.txttid)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(521, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 242)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transactions"
        '
        'txtdebit
        '
        Me.txtdebit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdebit.Location = New System.Drawing.Point(140, 200)
        Me.txtdebit.Name = "txtdebit"
        Me.txtdebit.Size = New System.Drawing.Size(240, 22)
        Me.txtdebit.TabIndex = 11
        Me.txtdebit.Text = "0.00"
        '
        'txtcredit
        '
        Me.txtcredit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcredit.Location = New System.Drawing.Point(140, 163)
        Me.txtcredit.Name = "txtcredit"
        Me.txtcredit.Size = New System.Drawing.Size(240, 22)
        Me.txtcredit.TabIndex = 10
        Me.txtcredit.Text = "0.00"
        '
        'txtdescription
        '
        Me.txtdescription.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(140, 66)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(240, 88)
        Me.txtdescription.TabIndex = 9
        '
        'txttid
        '
        Me.txttid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttid.Location = New System.Drawing.Point(140, 29)
        Me.txttid.Name = "txttid"
        Me.txttid.Size = New System.Drawing.Size(240, 22)
        Me.txttid.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 18)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "ID                     :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Debit              :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Credit             :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Description    :"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(689, 322)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 29)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Add Transaction"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CusTable_1TableAdapter1
        '
        Me.CusTable_1TableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImage = Global.atechnoreg.My.Resources.Resources._956caa4658a9d6e289a193ac6e290de8
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(986, 561)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CusTable1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtechnoregDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CusTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AtechnoregDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ID As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtadd As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AtechnoregDataSet As atechnoregDataSet
    Friend WithEvents CusTable1BindingSource As BindingSource
    Friend WithEvents CusTable_1TableAdapter As atechnoregDataSetTableAdapters.cusTable_1TableAdapter
    Friend WithEvents txtdate As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents txttid As TextBox
    Friend WithEvents txtdebit As TextBox
    Friend WithEvents txtcredit As TextBox
    Friend WithEvents AtechnoregDataSet1 As atechnoregDataSet1
    Friend WithEvents CusTable1BindingSource1 As BindingSource
    Friend WithEvents CusTable_1TableAdapter1 As atechnoregDataSet1TableAdapters.cusTable_1TableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
