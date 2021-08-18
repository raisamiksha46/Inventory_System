<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsupplierbill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsupplierbill))
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.DGVPrvList = New System.Windows.Forms.DataGridView
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtSerialNo = New System.Windows.Forms.TextBox
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.Customer = New System.Windows.Forms.Label
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtrat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtproductname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox7.SuspendLayout()
        CType(Me.DGVPrvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DGVPrvList)
        Me.GroupBox7.Location = New System.Drawing.Point(538, 51)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(367, 328)
        Me.GroupBox7.TabIndex = 29
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Previous List"
        '
        'DGVPrvList
        '
        Me.DGVPrvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPrvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPrvList.Location = New System.Drawing.Point(3, 19)
        Me.DGVPrvList.Name = "DGVPrvList"
        Me.DGVPrvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPrvList.Size = New System.Drawing.Size(361, 306)
        Me.DGVPrvList.TabIndex = 0
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.White
        Me.cmdExit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(443, 328)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 37)
        Me.cmdExit.TabIndex = 28
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.White
        Me.cmdEdit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(224, 328)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 37)
        Me.cmdEdit.TabIndex = 26
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.White
        Me.cmdDelete.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(367, 328)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 37)
        Me.cmdDelete.TabIndex = 24
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.White
        Me.cmdUpdate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(298, 328)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 37)
        Me.cmdUpdate.TabIndex = 22
        Me.cmdUpdate.Text = "Save"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.White
        Me.cmdNew.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(147, 328)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 37)
        Me.cmdNew.TabIndex = 20
        Me.cmdNew.Text = "New"
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 71)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 18)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Bill No"
        '
        'txtSerialNo
        '
        Me.txtSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerialNo.Location = New System.Drawing.Point(106, 68)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.ReadOnly = True
        Me.txtSerialNo.Size = New System.Drawing.Size(71, 23)
        Me.txtSerialNo.TabIndex = 1
        '
        'cboDepartment
        '
        Me.cboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {"Mr.", "Mrs.", "Miss.", "M/S"})
        Me.cboDepartment.Location = New System.Drawing.Point(106, 158)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(235, 26)
        Me.cboDepartment.TabIndex = 7
        '
        'Customer
        '
        Me.Customer.AutoSize = True
        Me.Customer.Location = New System.Drawing.Point(16, 161)
        Me.Customer.Name = "Customer"
        Me.Customer.Size = New System.Drawing.Size(64, 18)
        Me.Customer.TabIndex = 6
        Me.Customer.Text = "Customer"
        '
        'txtqty
        '
        Me.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtqty.Location = New System.Drawing.Point(106, 222)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(104, 23)
        Me.txtqty.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Qty"
        '
        'txtrat
        '
        Me.txtrat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrat.Location = New System.Drawing.Point(106, 251)
        Me.txtrat.Name = "txtrat"
        Me.txtrat.Size = New System.Drawing.Size(104, 23)
        Me.txtrat.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Rate"
        '
        'txtamt
        '
        Me.txtamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamt.Location = New System.Drawing.Point(106, 280)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(104, 23)
        Me.txtamt.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 18)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Amt"
        '
        'txtproductname
        '
        Me.txtproductname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproductname.Location = New System.Drawing.Point(106, 190)
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.Size = New System.Drawing.Size(235, 23)
        Me.txtproductname.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Product Name"
        '
        'frmsupplierbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 397)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtproductname)
        Me.Controls.Add(Me.txtamt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtrat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Customer)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtSerialNo)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmsupplierbill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill"
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DGVPrvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVPrvList As System.Windows.Forms.DataGridView
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Customer As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtrat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtproductname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
