Public Class frmsupplier1

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
        txtName.DataBindings.Clear()
        txtName.Text = ""

        txtaddress.DataBindings.Clear()
        txtaddress.Text = ""


        txtcontactno.DataBindings.Clear()
        txtcontactno.Text = ""
        txtName.ReadOnly = False
        txtcontactno.ReadOnly = False
        txtaddress.ReadOnly = False
        'Button Access
        cmdNew.Enabled = False
        cmdUpdate.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        txtName.Focus()
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        'Validate
        If Trim(txtName.Text) = "" Then
            MessageBox.Show("Name cannot be blank!", "Visitor Master", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlText As String
        If (cmdUpdate.Tag = "S") Then
            txtSerialNo.Text = GetNewCode("SELECT MAX(supplier_id) FROM supplier_detail").ToString("D5")
            sqlText = "INSERT INTO supplier_Detail(supplier_id,supplier_Name,supplier_Contact_No,Address)  VALUES('" & txtSerialNo.Text & "','" & Trim(txtName.Text) & "','" & _
                        txtcontactno.Text & "','" & txtaddress.Text & "')"
        Else
            sqlText = "UPDATE supplier_Detail SET supplier_Name='" & Trim(txtName.Text) & "',supplier_Contact_No='" & Trim("" & txtcontactno.Text) & "'," & _
                        "address='" & txtaddress.Text & "' where supplier_id = '" & Me.txtSerialNo.Text & "'"

        End If
        If ExecuteQuery(sqlText) > 0 Then
            MessageBox.Show("Record saved successfully.", "Staff Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
            processBind()
        End If
    End Sub

    Private Sub processBind()
        Dim sqlText As String
        sqlText = "SELECT * FROM supplier_Detail"

        DGVPrvList.Enabled = True
        dtTemp = GetRecord(sqlText)
        cmTemp = CType(Me.BindingContext(dtTemp), CurrencyManager)
        DGVPrvList.DataSource = dtTemp

        If dtTemp.Rows.Count > 0 Then

            txtSerialNo.DataBindings.Clear()
            txtSerialNo.DataBindings.Add("Text", dtTemp, "supplier_id")
            txtName.DataBindings.Clear()
            txtName.DataBindings.Add("Text", dtTemp, "supplier_Name")
            txtaddress.DataBindings.Clear()
            txtaddress.DataBindings.Add("Text", dtTemp, "address")
            txtcontactno.DataBindings.Clear()
            txtcontactno.DataBindings.Add("Text", dtTemp, "supplier_contact_no")
            txtName.Focus()
        End If
        txtSerialNo.ReadOnly = True
        txtName.ReadOnly = True
        txtName.ReadOnly = True
        txtaddress.ReadOnly = True
        txtaddress.ReadOnly = True
        txtcontactno.ReadOnly = True
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
        txtName.ReadOnly = False
        txtcontactno.ReadOnly = False
        txtaddress.ReadOnly = False
        DGVPrvList.Enabled = False
        'Button Access
        cmdNew.Enabled = False
        cmdUpdate.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        txtName.Focus()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Delete? supplier_Detail : " & txtName.Text & vbCrLf & " Are you sure?", "supplier_Detail Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sqlText As String
            sqlText = "DELETE FROM supplier_Detail WHERE supplier_id='" & txtSerialNo.Text & "'"
            If executeQuery(sqlText) > 0 Then
                MessageBox.Show("Record deleted successfully.", "supplier_Detail Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        processBind()
    End Sub

End Class