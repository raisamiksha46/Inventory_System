Public Class frmUserAccount

    Dim dtTemp As DataTable
    Dim sqlText As String

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub frmUserAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.End Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub frmUserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkSupervisor.Enabled = supervisor
        If Me.Tag = "NEW" Then
            txtUserName.Focus()
            txtOldPassword.Visible = False
            lblPassword.Visible = False
            lblCP1.Text = "Password :"
        ElseIf Me.Tag = "EDIT" Then
            sqlText = "SELECT user_password,supervisor FROM LoginUser WHERE user_name='" & user_name & "'"
            dtTemp = GetRecord(sqlText)
            If dtTemp.Rows.Count > 0 Then
                With dtTemp.Rows(0)
                    txtOldPassword.Tag = .Item("user_password")
                    chkSupervisor.Checked = .Item("supervisor")
                End With
            End If

            txtUserName.Text = user_name
            txtUserName.ReadOnly = True
            lblPassword.Text = "Old Password :"
            lblCP1.Text = "New  Password :"
            cmdCreate.Text = "Update"
            txtOldPassword.Focus()
        End If
    End Sub

    Private Sub cmdCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        If Me.Tag = "NEW" Then
            If Trim(txtUserName.Text) = "" Then
                MessageBox.Show("Please enter user name.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If txtNewPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Password is not match!", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            sqlText = "INSERT INTO LoginUser(user_name,user_password,supervisor) " & _
                    "VALUES('" & Trim(txtUserName.Text) & "','" & txtConfirmPassword.Text & "'," & Math.Abs(Val(chkSupervisor.Checked)) & ")"
            If ExecuteQuery(sqlText) > 0 Then
                MessageBox.Show("New User Account is successfully created.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            If txtOldPassword.Text <> txtOldPassword.Tag Then
                MessageBox.Show("Old password is incorrect!" & vbCr & "Please try again.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If txtNewPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("Password is not match!", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            sqlText = "UPDATE LoginUser SET user_password='" & txtConfirmPassword.Text & "' WHERE user_name='" & txtUserName.Text & "'"
            If ExecuteQuery(sqlText) > 0 Then
                MessageBox.Show("User Account is successfully updated.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub Label27_Click(sender As System.Object, e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class