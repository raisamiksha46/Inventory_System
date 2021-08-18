Public Class frmDepartment

    Dim dtTemp As DataTable
    Dim cmTemp As CurrencyManager

    Private Sub frmDepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        processBind()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If cmdExit.Text = "Cancel" Then
            cmdExit.Text = "Exit"
            processBind()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        If cmdNew.Enabled = False Then Exit Sub
        cmdUpdate.Tag = "S"
        cmdExit.Text = "Cancel"
        DGVPrvList.Enabled = False
        txtSerialNo.DataBindings.Clear()
        txtSerialNo.Text = ""
        txtName.DataBindings.Clear()
        txtName.Text = ""
        txtName.ReadOnly = False
        'Button Access
        cmdNew.Enabled = False
        cmdUpdate.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        txtName.Focus()
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If cmdUpdate.Enabled = False Then Exit Sub
        'Validate
        If Trim(txtName.Text) = "" Then
            MessageBox.Show("Name cannot be blank!", "Department Master", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim sqlText As String
        If (cmdUpdate.Tag = "S") Then
            txtSerialNo.Text = GetNewCode("SELECT MAX(Code) FROM Department").ToString("D2")
            sqlText = "INSERT INTO Department (Code,Description)" & _
                        "VALUES('" & txtSerialNo.Text & "','" & Trim(txtName.Text) & "')"
        Else
            sqlText = "UPDATE Department SET Description='" & Trim(txtName.Text) & "' WHERE Code='" & txtSerialNo.Text & "'"

        End If
        If ExecuteQuery(sqlText) > 0 Then
            MessageBox.Show("Record saved successfully.", "Department Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
            processBind()
        End If

    End Sub

    Private Sub processBind()
        Dim sqlText As String
        sqlText = "SELECT * FROM Department"

        DGVPrvList.Enabled = True
        dtTemp = GetRecord(sqlText)
        cmTemp = CType(Me.BindingContext(dtTemp), CurrencyManager)
        DGVPrvList.DataSource = dtTemp

        If dtTemp.Rows.Count > 0 Then
            txtSerialNo.DataBindings.Clear()
            txtSerialNo.DataBindings.Add("Text", dtTemp, "Code")
            txtName.DataBindings.Clear()
            txtName.DataBindings.Add("Text", dtTemp, "Description")
            cmdExit.Text = "Exit"
            txtName.Focus()
        End If
        txtName.ReadOnly = True
        DGVPrvList.Enabled = True
        'Button Access
        cmdNew.Enabled = True
        cmdUpdate.Enabled = False
        cmdDelete.Enabled = True
        cmdEdit.Enabled = True
        DGVPrvList.Focus()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If cmdEdit.Enabled = False Then Exit Sub
        cmdUpdate.Tag = "U"
        cmdExit.Text = "Cancel"
        txtName.ReadOnly = False
        DGVPrvList.Enabled = False
        'Button Access
        cmdNew.Enabled = False
        cmdUpdate.Enabled = True
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        txtName.Focus()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If cmdDelete.Enabled = False Then Exit Sub
        If MessageBox.Show("Delete? Department : " & txtSerialNo.Text & vbCrLf & " Are you sure?", "Department Master", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sqlText As String
            sqlText = "DELETE FROM Department WHERE Code='" & txtSerialNo.Text & "'"
            If ExecuteQuery(sqlText) > 0 Then
                MessageBox.Show("Record deleted successfully.", "Department Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
                processBind()
            End If
        End If
    End Sub

End Class