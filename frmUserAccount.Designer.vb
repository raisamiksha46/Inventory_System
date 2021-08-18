<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAccount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblCP1 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.chkSupervisor = New System.Windows.Forms.CheckBox()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblCP2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name :"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(145, 58)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(197, 23)
        Me.txtUserName.TabIndex = 1
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(145, 87)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(197, 23)
        Me.txtOldPassword.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(20, 90)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 18)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password :"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(145, 114)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(197, 23)
        Me.txtNewPassword.TabIndex = 5
        '
        'lblCP1
        '
        Me.lblCP1.AutoSize = True
        Me.lblCP1.Location = New System.Drawing.Point(20, 117)
        Me.lblCP1.Name = "lblCP1"
        Me.lblCP1.Size = New System.Drawing.Size(122, 18)
        Me.lblCP1.TabIndex = 4
        Me.lblCP1.Text = "Confirm password :"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label27.Location = New System.Drawing.Point(77, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(298, 34)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Change Password"
        '
        'chkSupervisor
        '
        Me.chkSupervisor.AutoSize = True
        Me.chkSupervisor.Location = New System.Drawing.Point(145, 172)
        Me.chkSupervisor.Name = "chkSupervisor"
        Me.chkSupervisor.Size = New System.Drawing.Size(89, 22)
        Me.chkSupervisor.TabIndex = 8
        Me.chkSupervisor.Text = "Supervisor"
        Me.chkSupervisor.UseVisualStyleBackColor = True
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(201, 223)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(105, 39)
        Me.cmdCreate.TabIndex = 9
        Me.cmdCreate.Text = "Create"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(312, 223)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(105, 39)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(145, 143)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(197, 23)
        Me.txtConfirmPassword.TabIndex = 7
        '
        'lblCP2
        '
        Me.lblCP2.AutoSize = True
        Me.lblCP2.Location = New System.Drawing.Point(20, 146)
        Me.lblCP2.Name = "lblCP2"
        Me.lblCP2.Size = New System.Drawing.Size(122, 18)
        Me.lblCP2.TabIndex = 6
        Me.lblCP2.Text = "Confirm password :"
        '
        'frmUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(427, 273)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.lblCP2)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.chkSupervisor)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.lblCP1)
        Me.Controls.Add(Me.txtOldPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTORY :: User Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblCP1 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents chkSupervisor As System.Windows.Forms.CheckBox
    Friend WithEvents cmdCreate As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblCP2 As System.Windows.Forms.Label
End Class
