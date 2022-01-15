Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Penyewaan
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private DataLocker As New ArrayList()

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "tugasakhir"

    Private waktu_sewa As String
    Public Property waktu_sewaproperty() As String
        Get
            Return waktu_sewa
        End Get
        Set(ByVal value As String)
            waktu_sewa = value
        End Set
    End Property

    Private waktu_kembali As String
    Public Property waktu_kembaliProperty() As String
        Get
            Return waktu_kembali
        End Get
        Set(ByVal value As String)
            waktu_kembali = value
        End Set
    End Property

    Private bayar_sebelum_pinjam As String
    Public Property bayar_sebelum_pinjamProperty() As String
        Get
            Return bayar_sebelum_pinjam
        End Get
        Set(ByVal value As String)
            bayar_sebelum_pinjam = value
        End Set
    End Property

    Private rencana_pinjam As String
    Public Property rencana_pinjamProperty() As String
        Get
            Return rencana_pinjam
        End Get
        Set(ByVal value As String)
            rencana_pinjam = value
        End Set
    End Property

    Private kelebihan_pinjam As String
    Public Property kelebihan_pinjamProperty() As String
        Get
            Return kelebihan_pinjam
        End Get
        Set(ByVal value As String)
            kelebihan_pinjam = value
        End Set
    End Property

    Private total_biaya As String
    Public Property total_biayaProperty() As String
        Get
            Return total_biaya
        End Get
        Set(ByVal value As String)
            total_biaya = value
        End Set
    End Property

    Public Function addDataSewaDatabase(id_locker As Integer,
                                        waktu_sewa As String,
                                        bayar_sebelum_pinjam As Integer,
                                        rencana_pinjam As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password= " + password_db + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = " INSERT INTO PENYEWAAN (id_locker, waktu_sewa, bayar_sebelum_pinjam, rencana_pinjam)
                        VALUE
                        (
                        '" & id_locker & "', 
                        '" & waktu_sewa & "' , 
                        '" & bayar_sebelum_pinjam & "',
                        '" & rencana_pinjam & "')"

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
    Public Function GetDataKembaliDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT RS.id_sewa AS 'id_sewa',
                                  RS.waktu_sewa AS 'waktu_sewa',
                                  RS.waktu_kembali AS 'waktu_kembali',
                                  RS.bayar_sebelum_pinjam AS 'bayar_sebelum_pinjam',
                                  RS.rencana_pinjam AS 'rencana_pinjam',
                                  RS.kelebihan_pinjam AS 'kelebihan_pinjam',
                                  RS.total_bayar AS 'total_bayar'
                                  FROM penyewaan RS
                                  JOIN locker lk ON RS.id_locker = lk.id_locker
                                  order by id_sewa"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function addDataRentDatabase(id_locker As Integer,
                                    waktu_sewa As String,
                                    bayar_sebelum_pinjam As Integer,
                                    rencana_pinjam As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password= " + password_db + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = " INSERT INTO PENYEWAAN (id_locker, waktu_sewa, bayar_sebelum_pinjam, rencana_pinjam)
                        VALUE
                        (
                        '" & id_locker & "', 
                        '" & waktu_sewa & "' , 
                        '" & bayar_sebelum_pinjam & "',
                        '" & rencana_pinjam & "')"

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

    Public Function GetDataRentDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT RS.id_sewa AS 'id_sewa',
                                  RS.id_locker AS 'id_locker',
                                  RS.waktu_sewa AS 'waktu_sewa',
                                  RS.bayar_sebelum_pinjam AS 'bayar_sebelum_pinjam',
                                  RS.rencana_pinjam AS 'rencana_pinjam'
                                  FROM penyewaan AS RS
                                  JOIN locker AS lk ON RS. id_locker = lk.id_locker
                                  order by id_sewa"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataSewaDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT RS.id_sewa AS 'id_sewa',
                                  RS.waktu_sewa AS 'waktu_sewa',
                                  RS.bayar_sebelum_pinjam AS 'bayar_sebelum_pinjam',
                                  RS.rencana_pinjam AS 'rencana_pinjam'
                                  FROM penyewaan AS RS
                                  JOIN locker AS lk ON  RS. id_locker = lk.id_locker
                                  order by id_sewa"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataRentByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT RS.id_sewa AS 'id_sewa',
                                  RS.waktu_sewa AS 'waktu_sewa',
                                  RS.bayar_sebelum_pinjam AS 'bayar_sebelum_pinjam',
                                  RS.rencana_pinjam AS 'rencana_pinjam',
                                  FROM penyewaan AS RS
                                  JOIN locker AS lk ON RS.id_sewa = lk.id_locker"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())

        End While

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function GetDataKembaliByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT RS.waktu_kembali AS 'waktu_kembali',
                                  RS.kelebihan_pinjam AS 'kelebihan_pinjam',
                                  RS.total_bayar AS 'total_bayar',
                                  FROM penyewaan AS RS
                                  JOIN locker AS lk ON RS.id_sewa = lk.id_locker"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())

        End While

        sqlRead.Close()
        dbConn.Close()

        Return result
    End Function

    Public Function UpdateDataKembaliDatabase(id_sewa As Integer,
                                             waktu_kembali As String,
                                            kelebihan_pinjam As Integer,
                                            total_bayar As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password= " + password_db + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = " UPDATE PENYEWAAN SET " &
                        "waktu_kembali='" & waktu_kembali & "'," &
                        "kelebihan_pinjam='" & kelebihan_pinjam & "'," &
                        "total_bayar='" & total_bayar & "'" &
                        "WHERE id_sewa='" & id_sewa & "'"

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