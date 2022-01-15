Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Locker
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private DataLocker As New ArrayList()

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "locker_coin"

    Private ListLocker As New List(Of String)

    Private lokasi As String
    Public Property lokasiproperty() As String
        Get
            Return lokasi
        End Get
        Set(ByVal value As String)
            lokasi = value
        End Set
    End Property

    Private nama_locker As String
    Public Property nama_lockerProperty() As String
        Get
            Return nama_locker
        End Get
        Set(ByVal value As String)
            nama_locker = value
        End Set
    End Property
    Public Function AddLocker(Value As String)
        ListLocker.Add(Value)
        Return ""
    End Function
    Public Function addDatalocker(nama_locker As String,
                                  lokasi As String)

        DataLocker.Add({nama_locker,
                        lokasi})

    End Function
    Public ReadOnly Property getDataLocker() As ArrayList
        Get
            Return DataLocker
        End Get
    End Property

    Public Function GetDataLockerDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT lk.id_locker AS 'id_locker',
                                  lk.nama_locker AS 'nama_locker',
                                  lk.lokasi AS 'lokasi',
                                  ju.biaya AS 'biaya'
                                  FROM locker AS lk
                                  JOIN jenis_ukuran AS ju ON lk.id_ukuran = ju.id_ukuran"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function
    Public Function GetDataJenisUkuranByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT lk.id_locker AS 'id_locker',
                                  lk.nama_locker AS 'nama_locker',
                                  lk.lokasi AS 'lokasi',
                                  ju.biaya AS 'biaya'
                                  FROM locker AS lk
                                  JOIN jenis_ukuran AS ju ON lk.id_ukuran = ju.id_ukuran"


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

    Public Function addDataLockerDatabase(id_ukuran As Integer,
                                         nama_locker As String,
                                          lokasi As String
                                           )
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password= " + password_db + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = " INSERT INTO LOCKER (id_ukuran, nama_locker, lokasi)
                        VALUE
                        (
                        '" & id_ukuran & "', 
                        '" & nama_locker & "' ,
                        '" & lokasi & "')"

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

    Public Function UpdateDataLockerByIDDatabase(id_locker As Integer,
                                                      nama_locker As String,
                                                      lokasi As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE locker SET " &
                        "nama_locker='" & nama_locker & "'," &
                        "lokasi='" & lokasi & "'" &
                        "WHERE id_locker='" & id_locker & "'"

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
    Public Function GetDataLockerByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "Select *
                                  From locker
                                  Where id_locker ='" & ID & "'"


        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())

        End While

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function DeleteDataLockerByIDDatabase(id_locker As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM locker " &
                        "WHERE id_locker='" & id_locker & "'"

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
End Class