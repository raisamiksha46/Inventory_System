Public Class frmsupplier

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


        txtEmail.DataBindings.Clear()
        txtEmail.Text = ""
        txtcontactno.DataBindings.Clear()
        txtcontactno.Text = ""
        txtName.ReadOnly = False
        txtcontactno.ReadOnly = False
        txtaddress.ReadOnly = False
        txtEmail.ReadOnly = False
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
            sqlText = "INSERT INTO Supplier_Detail(supplier_id,Supplier_Name,Supplier_Contact_No,Address,EmailID)" & _
                        "VALUES('" & txtSerialNo.Text & "','" & Trim(txtName.Text) & "','" & _
                        txtcontactno.Text & "','" & txtaddress.Text & _
                        "','" & txtEmail.Text & "')"
        Else
            sqlText = "UPDATE Supplier_Detail SET Supplier_Name='" & Trim(txtName.Text) & "',Supplier_Contact_No='" & Trim("" & txtcontactno.Text) & "'," & _
                        "address='" & txtaddress.Text & "',EmailID='" & txtEmail.Text & "'"

        End If
        If ExecuteQuery(sqlText) > 0 Then
            MessageBox.Show("Record saved successfully.", "Staff Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
            processBind()
        End If
    End Sub

    Private Sub processBind()
        Dim sqlText As String
        sqlText = "SELECT * FROM Supplier_Detail"

        DGVPrvList.Enabled = True
        dtTemp = GetRecord(sqlText)
        cmTemp = CType(Me.BindingContext(dtTemp), CurrencyManager)
        DGVPrvList.DataSource = dtTemp

        If dtTemp.Rows.Count > 0 Then

            txtSerialNo.DataBindings.Clear()
            txtSerialNo.DataBindings.Add("Text", dtTemp, "Supplier_id")
            txtName.DataBindings.Clear()
            txtName.DataBindings.Add("Text", dtTemp, "Supplier_Name")
            txtaddress.DataBindings.Clear()
            txtaddress.DataBindings.Add("Text", dtTemp, "address")
            txtEmail.DataBindings.Clear()
            txtEmail.DataBindings.Add("Text", dtTemp, "EmailID")
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
        txtEmail.ReadOnly = False
        DGVPrvList.Enabled = False
        'Button Access
        cmdNew.Enabled = False
        cmdUpdate.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        txtName.Focus()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Delete? Supplier_Detail : " & txtName.Text & vbCrLf & " Are you sure?", "Supplier_Detail Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sqlText As String
            sqlText = "DELETE FROM Supplier_Detail WHERE supplier_id='" & txtSerialNo.Text & "'"
            If executeQuery(sqlText) > 0 Then
                MessageBox.Show("Record deleted successfully.", "Supplier_Detail Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
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