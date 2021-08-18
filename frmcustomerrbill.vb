Public Class frmcustomerbill

    Dim dtTemp As DataTable
    Dim cmTemp As CurrencyManager

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If cmdExit.Text = "Cancel" Then
            cmdExit.Text = "Exit"
            processBind()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        cmdUpdate.Tag = "S"
        cmdExit.Text = "Cancel"
        DGVPrvList.Enabled = False
        txtSerialNo.DataBindings.Clear()
        txtSerialNo.Text = ""
        cboDepartment.DataBindings.Clear()
        cboDepartment.Text = ""
        cboDepartment.Tag = ""
        cboDesignation.DataBindings.Clear()
        cboDesignation.Text = ""
        cboDesignation.Tag = ""
        txtqty.DataBindings.Clear()
        txtqty.Text = ""
        txtqty.ReadOnly = False
        cboDepartment.Enabled = True
        cboDesignation.Enabled = True
        'Button Access
        cmdNew.Enabled = False
        cmdUpdate.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        cboDepartment.Focus()
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        'Validate
        If Trim(txtqty.Text) = "" Then
            MessageBox.Show("Qty cannot be blank!", "customer BilMaster", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlText As String
        If (cmdUpdate.Tag = "S") Then
            txtSerialNo.Text = GetNewCode("SELECT MAX(bill_no) FROM customer_bill ").ToString("D5")
            sqlText = "INSERT INTO customer_bill (bill_no,customer_name,product_name,qty)" & _
                        "VALUES('" & txtSerialNo.Text & "','" & _
                        Trim(cboDepartment.Text) & "','" & Trim(cboDesignation.Text) & _
                        "'," & Val(txtqty.Text) & ")"
        Else
            sqlText = "UPDATE customer_bill  SET customer_name='" & Trim("" & cboDepartment.Text) & "'," & _
                        "product_name='" & Trim("" & cboDesignation.Text) & "',qty=" & Val(txtqty.Text) & " WHERE bill_no='" & txtSerialNo.Text & "'"

        End If
        If ExecuteQuery(sqlText) > 0 Then
            MessageBox.Show("Record saved successfully.", "customer_bill  Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
            processBind()
        End If
    End Sub

    Private Sub processBind()
        Dim sqlText As String
        sqlText = "SELECT * FROM customer_bill"

        DGVPrvList.Enabled = True
        dtTemp = GetRecord(sqlText)
        cmTemp = CType(Me.BindingContext(dtTemp), CurrencyManager)
        DGVPrvList.DataSource = dtTemp

        If dtTemp.Rows.Count > 0 Then

            txtSerialNo.DataBindings.Clear()
            txtSerialNo.DataBindings.Add("Text", dtTemp, "bill_no")
            cboDepartment.DataBindings.Clear()
            cboDepartment.DataBindings.Add("Text", dtTemp, "customer_name")
            cboDesignation.DataBindings.Clear()
            cboDesignation.DataBindings.Add("Text", dtTemp, "product_name")
            txtqty.DataBindings.Clear()
            txtqty.DataBindings.Add("Text", dtTemp, "qty")
            cboDepartment.Focus()
        End If
        txtSerialNo.ReadOnly = True
        cboDepartment.Enabled = False
        cboDesignation.Enabled = False
        txtqty.ReadOnly = False
        DGVPrvList.Enabled = True
        cmdExit.Text = "Exit"
        'Button Access
        cmdNew.Enabled = True
        cmdUpdate.Enabled = False
        cmdDelete.Enabled = True
        cmdEdit.Enabled = True

        DGVPrvList.Focus()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        cmdUpdate.Tag = "U"
        cmdExit.Text = "Cancel"
        cboDepartment.Enabled = True
        cboDesignation.Enabled = True
        DGVPrvList.Enabled = False
        'Button Access
        cmdNew.Enabled = False
        cmdUpdate.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        cboDepartment.Focus()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Delete? customer_bill : " & txtSerialNo.Text & vbCrLf & " Are you sure?", "customer_bill  Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sqlText As String
            sqlText = "DELETE FROM customer_bill WHERE bill_no='" & txtSerialNo.Text & "'"
            If executeQuery(sqlText) > 0 Then
                MessageBox.Show("Record deleted successfully.", "customer_bill  Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                processBind()
            End If
        End If
    End Sub

    Private Sub frmStaffMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.F4 Then
            cmdNew_Click(sender, e)
        ElseIf e.KeyCode = Keys.F8 Then
            cmdEdit_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            cmdDelete_Click(sender, e)
        ElseIf e.KeyCode = Keys.F5 Then
            cmdUpdate_Click(sender, e)
        ElseIf e.KeyCode = Keys.F9 Then
            cmdExit_Click(sender, e)
        End If
    End Sub


    Private Sub frmStaffMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlText As String

        sqlText = "SELECT customer_id ,customer_name FROM customer_detail"
        FillComboBoxcustomer(cboDepartment, sqlText)
        sqlText = "SELECT product_id ,product_name FROM Product_detail"
        FillComboBoxproduct(cboDesignation, sqlText)

        processBind()
    End Sub

    Private Sub cboDepartment_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartment.LostFocus
        If Trim(cboDepartment.Text) = "" Then
            cboDepartment.Tag = ""
        Else
            Dim sqlText As String = "SELECT customer_id From customer_detail WHERE customer_name='" & Trim(cboDepartment.Text) & "'"
            cboDepartment.Tag = GetRecordValue(sqlText)
        End If
    End Sub

    Private Sub cboDesignation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesignation.LostFocus
        If Trim(cboDesignation.Text) = "" Then
            cboDesignation.Tag = ""
        Else
            Dim sqlText As String = "SELECT product_id From product_detail WHERE product_name='" & Trim(cboDesignation.Text) & "'"
            cboDesignation.Tag = GetRecordValue(sqlText)
        End If
    End Sub
End Class