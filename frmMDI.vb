Public Class frmMDI

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor.Current = Cursors.WaitCursor
        Dim objDept As New frmDepartment
        objDept.MdiParent = Me
        objDept.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor.Current = Cursors.WaitCursor
        Dim objStaff As New frmProduct
        objStaff.MdiParent = Me
        objStaff.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblDate.Text = Format(Today.Date, "dd/MM/yyyy") & " : " & TimeOfDay

        Dim capslocki, numlocki, scrolli As Integer
        capslocki = My.Computer.Keyboard.CapsLock
        numlocki = My.Computer.Keyboard.NumLock
        scrolli = My.Computer.Keyboard.ScrollLock

        'inserti =My.Computer.Keyboard. GetKeyState(&H2D)

        If scrolli And 1 Then
            lblScollLock.Text = "ScrollLock ON"
        Else
            lblScollLock.Text = "ScrollLock OFF"
        End If

        If capslocki And 1 Then
            lblCapsLock.Text = "CapsLock ON"
        Else
            lblCapsLock.Text = "CapsLock OFF"
        End If

        If numlocki And 1 Then
            lblNumLock.Text = "NumLock ON"
        Else
            lblNumLock.Text = "NumLock OFF"
        End If

    End Sub

    Private Sub frmMDI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub frmMDI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub NewCreateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCreateToolStripMenuItem.Click
        Cursor.Current = Cursors.WaitCursor
        Dim objUA As New frmUserAccount
        objUA.MdiParent = Me
        objUA.Tag = "NEW"
        objUA.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub EditUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditUpdateToolStripMenuItem.Click
        Cursor.Current = Cursors.WaitCursor
        Dim objUA As New frmUserAccount
        objUA.MdiParent = Me
        objUA.Tag = "EDIT"
        objUA.Show()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub SuppllierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppllierToolStripMenuItem.Click
        Cursor.Current = Cursors.WaitCursor
        Dim objStaff As New frmsupplier1
        objStaff.MdiParent = Me
        objStaff.Show()
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        Cursor.Current = Cursors.WaitCursor
        Dim objStaff As New frmcustomer
        objStaff.MdiParent = Me
        objStaff.Show()
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor.Current = Cursors.WaitCursor
        Dim objStaff As New frmProduct
        objStaff.MdiParent = Me
        objStaff.Show()
        Cursor.Current = Cursors.Default

    End Sub


    Private Sub CustomerBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerBillToolStripMenuItem.Click
        Cursor.Current = Cursors.WaitCursor
        Dim objStaff As New frmsupplierbill
        objStaff.MdiParent = Me
        objStaff.Show()
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub VisitorInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class