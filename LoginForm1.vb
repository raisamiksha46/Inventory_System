Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CreateConnection()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Then
            MessageBox.Show("Please enter user name.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            UsernameTextBox.Focus()
            Exit Sub
        End If
        If PasswordTextBox.Text = "" Then
            MessageBox.Show("Please enter Password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            PasswordTextBox.Focus()
            Exit Sub
        End If

        Dim sqlText As String
        Dim validateUser As Boolean = False
        sqlText = "SELECT * FROM LoginUser"
        Dim dtLoginUser As DataTable
        dtLoginUser = GetRecord(sqlText)
        For Each drLoginUser As DataRow In dtLoginUser.Rows
            If drLoginUser("user_name") = UsernameTextBox.Text And drLoginUser("user_password") = PasswordTextBox.Text Then
                validateUser = True
                supervisor = drLoginUser("Supervisor")
                Exit For
            End If
        Next

        If validateUser = True Then
            Dim mdiobj As New frmMDI
            mdiobj.lblUser.Text = "User : " & UsernameTextBox.Text
            user_name = UsernameTextBox.Text
            Me.Hide()
            mdiobj.Show()
        Else
            MessageBox.Show("Invalid user name or Password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
