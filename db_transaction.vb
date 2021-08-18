Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data
Module db_transaction
    ' Global variables
    Public TransactionNo As String
    Public supervisor As Boolean
    Public user_name As String

    'Dim ObjConn As OleDbConnection = New OleDbConnection(connectionString)
    'Dim ObjCmd As OleDbCommand
    'Dim ObjAdp As OleDbDataAdapter
    'Dim ObjDs As DataSet


    Dim oledbCon As OleDbConnection
    Dim oledbCmd As OleDbCommand
    Dim connectionString As String
    Public Sub CreateConnection()
        connectionString = ConfigurationManager.ConnectionStrings("dbConn").ConnectionString
        oledbCon = New OleDbConnection(connectionString)
        oledbCon.Open()
    End Sub
    Public Sub OpenConnection()
        Try
            If oledbCon.State = ConnectionState.Closed Then
                oledbCon.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function getRecord(ByVal sqlText As String) As DataTable
        Dim dtTemp As New DataTable()
        If oledbCon.State = ConnectionState.Closed Then oledbCon.Open()
        Dim sqlAdp As New OleDbDataAdapter(sqlText, oledbCon)
        Try
            sqlAdp.Fill(dtTemp)
            sqlAdp.Dispose()
        Catch ex As Exception    '-- catch exception occur at run time
            If (oledbCon.State = ConnectionState.Open) Then oledbCon.Close()
            Throw ex
        Finally
            oledbCon.Close()
        End Try
        Return dtTemp
    End Function
    Public Sub FillComboBox(ByRef cbo As ComboBox, ByVal sqlText As String)
        Try
            Dim dtTemp As New DataTable
            oledbCmd = New OleDbCommand(sqlText, oledbCon)
            If oledbCon.State = ConnectionState.Closed Then oledbCon.Open()
            Dim drTemp As OleDbDataReader
            drTemp = oledbCmd.ExecuteReader()
            dtTemp.Load(drTemp)
            drTemp.Close()
            cbo.DataSource = dtTemp
            cbo.DisplayMember = "Description"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oledbCon.Close()
        End Try
    End Sub
    Public Sub FillComboBoxsupplier(ByRef cbo As ComboBox, ByVal sqlText As String)
        Try
            Dim dtTemp As New DataTable
            oledbCmd = New OleDbCommand(sqlText, oledbCon)
            If oledbCon.State = ConnectionState.Closed Then oledbCon.Open()
            Dim drTemp As OleDbDataReader
            drTemp = oledbCmd.ExecuteReader()
            dtTemp.Load(drTemp)
            drTemp.Close()
            cbo.DataSource = dtTemp
            cbo.DisplayMember = "Supplier_name"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oledbCon.Close()
        End Try
    End Sub
    Public Sub FillComboBoxcustomer(ByRef cbo As ComboBox, ByVal sqlText As String)
        Try
            Dim dtTemp As New DataTable
            oledbCmd = New OleDbCommand(sqlText, oledbCon)
            If oledbCon.State = ConnectionState.Closed Then oledbCon.Open()
            Dim drTemp As OleDbDataReader
            drTemp = oledbCmd.ExecuteReader()
            dtTemp.Load(drTemp)
            drTemp.Close()
            cbo.DataSource = dtTemp
            cbo.DisplayMember = "customer_name"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oledbCon.Close()
        End Try
    End Sub
    Public Sub FillComboBoxproduct(ByRef cbo As ComboBox, ByVal sqlText As String)
        Try
            Dim dtTemp As New DataTable
            oledbCmd = New OleDbCommand(sqlText, oledbCon)
            If oledbCon.State = ConnectionState.Closed Then oledbCon.Open()
            Dim drTemp As OleDbDataReader
            drTemp = oledbCmd.ExecuteReader()
            dtTemp.Load(drTemp)
            drTemp.Close()
            cbo.DataSource = dtTemp
            cbo.DisplayMember = "product_name"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oledbCon.Close()
        End Try
    End Sub


    Public Function GetRecordValue(ByVal sqlText As String) As Object
        Try
            oledbCmd = New OleDbCommand(sqlText, oledbCon)
            If oledbCon.State = ConnectionState.Closed Then oledbCon.Open()
            GetRecordValue = oledbCmd.ExecuteScalar()
        Catch ex As Exception
            GetRecordValue = Nothing
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oledbCon.Close()
        End Try
    End Function
    Public Function GetNewCode(ByVal sqlText As String) As Integer
        Try
            oledbCmd = New OleDbCommand(sqlText, oledbCon)
            If oledbCon.State = ConnectionState.Closed Then oledbCon.Open()
            GetNewCode = Val("" & oledbCmd.ExecuteScalar()) + 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oledbCon.Close()
        End Try
    End Function
    Public Function executeQuery(ByVal sqlText As String) As Integer
        If (oledbCon.State = ConnectionState.Closed) Then oledbCon.Open()
        oledbCmd = New OleDbCommand(sqlText, oledbCon)
        Try

            oledbCmd.ExecuteNonQuery()
            oledbCon.Close()
            executeQuery = 1
        Catch ex As Exception
            If (oledbCon.State = ConnectionState.Open) Then oledbCon.Close()
            Throw ex
            executeQuery = 0
        Finally
            oledbCon.Close()
        End Try
    End Function
    Public Function FillComboBox(ByVal sqlStr As String) As Data.DataSet

        'Try
        '    FillComboBox = New DataSet

        '    ObjAdp = New OleDbDataAdapter(sqlStr, ObjConn)
        '    ObjAdp.Fill(FillComboBox)

        'Catch ex As Exception
        '    Throw ex
        'End Try

    End Function

End Module
