Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Jenis_Ukuran
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private DataJenisUkuran As New ArrayList()

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "locker_coin"

    Private ukuran As String
    Private ListJenis As New List(Of String)

    Public Property ukuranProperty() As String
        Get
            Return ukuran
        End Get
        Set(ByVal value As String)
            ukuran = value
        End Set
    End Property

    Private biaya As String
    Public Property biayaProperty() As String
        Get
            Return biaya
        End Get
        Set(ByVal value As String)
            biaya = value
        End Set
    End Property

    Public Function AddJenis(Value As String)
        ListJenis.Add(Value)
        Return ""
    End Function
    '---------------------------------------------------------------------------------------------------------
    'Bagian pembuatan DATA GRID VIEW

    Public Function addDataJenisUkuran(ukuran As String,
                                       biaya As Integer)

        DataJenisUkuran.Add({ukuran,
                            biaya})

    End Function

    Public Function removeDataJenisUkuran(index As Integer)
        DataJenisUkuran.RemoveAt(index)
    End Function

    Public ReadOnly Property getDataJenisUkuran() As ArrayList
        Get
            Return DataJenisUkuran
        End Get
    End Property

    Public Function GetDataJenisUkuranDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_ukuran AS 'ID',
                                  ukuran AS 'Ukuran',
                                  biaya AS 'Biaya'
                                  FROM jenis_ukuran"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function addDataJenisUkuranDatabase(ukuran As String,
                                               biaya As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password= " + password_db + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = " INSERT INTO JENIS_UKURAN (ukuran, biaya)
                        VALUE
                        (
                        '" & ukuran & "' ,
                        '" & biaya & "')"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataJenisUkuranByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT *
                                  FROM jenis_ukuran
                                  WHERE id_ukuran='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())

        End While

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function UpdateDataJenisUkuranByIDDatabase(ID As Integer,
                                                       ukuran As String,
                                                       biaya As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE jenis_ukuran SET " &
                        "ukuran='" & ukuran & "'," &
                        "biaya='" & biaya & "'" &
                        "WHERE id_ukuran='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()


            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function DeleteDataJenisUkuranByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM jenis_ukuran " &
                        "WHERE id_ukuran='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()

        End Try
    End Function
End Class