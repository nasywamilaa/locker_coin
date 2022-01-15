<<<<<<< HEAD
﻿Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class User

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "locker_coin"

    Private TripleDes As New TripleDESCryptoServiceProvider
    Private realUsername As String
    Private realPassword As String


    Private DataUsers As New ArrayList()
    Public Function addDatausers(realUsername As String,
                                 realPassword As String,
                                 realEmail As String)
        DataUsers.Add({realUsername,
                       Encrypdata(realPassword),
                       realEmail})
    End Function

    Public Function removeDatatusers(index As Integer)
        DataUsers.RemoveAt(index)
    End Function

    Public ReadOnly Property getDataUsers() As ArrayList
        Get
            Return DataUsers
        End Get
    End Property

    Public Property realUsernameProperty() As String
        Get
            Return realUsername
        End Get
        Set(ByVal value As String)
            realUsername = value
        End Set
    End Property

    Public Property realPasswordProperty() As String
        Get
            Return realPassword
        End Get
        Set(ByVal value As String)
            realPassword = value
        End Set
    End Property


    Public Function Encrypdata(ByVal plaintext As String) As String
        ' Convert the plaintext string to a byte array
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)
        'Create the stream
        Dim ms As New System.IO.MemoryStream
        'Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        'Use The Crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        'Convert the encrypted stream to a printable string.

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function CheckAuth(plainUsername As String, ByRef plainPassword As String) As String
        'Static Password

        For Each user_data In getDataUsers()
            Dim username_table As String = user_data(1)
            Dim password_table As String = user_data(2)
            If String.Compare(username_table, plainUsername) = 0 Then
                If String.Compare(username_table, plainUsername) = 0 And String.Compare(Encrypdata(plainPassword), password_table) = 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Next

        Return False
    End Function

    Public Function EncryptMD5(ByRef password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)

        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function AddUsersDatabase(username_regist As String, password_regist As String, email_regist As String)
        Try
            Dim today = Date.Now()

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database=" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO USER( username, password, email) VALUE('" & username_regist & "', '" & EncryptMD5(password_regist) & "', '" & email_regist & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()

        End Try
    End Function

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database=" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM user
                         WHERE username='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())

                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
=======
﻿
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class User

        Public Shared dbConn As New MySqlConnection
        Public Shared sqlCommand As New MySqlCommand
        Public Shared sqlRead As MySqlDataReader
        Private sqlQuery As String

        Private server As String = "localhost"
        Private username_db As String = "root"
        Private password_db As String = ""
        Private database As String = "locker_coin"

        Private TripleDes As New TripleDESCryptoServiceProvider
        Private realUsername As String
        Private realPassword As String

        Private DataUsers As New ArrayList()
        Public Function addDatausers(realUsername As String,
                                     realPassword As String,
                                     realEmail As String)
            DataUsers.Add({realUsername,
                           Encrypdata(realPassword),
                           realEmail})
        End Function

        Public Function removeDatatusers(index As Integer)
            DataUsers.RemoveAt(index)
        End Function

        Public ReadOnly Property getDataUsers() As ArrayList
            Get
                Return DataUsers
            End Get
        End Property

        Public Property realUsernameProperty() As String
            Get
                Return realUsername
            End Get
            Set(ByVal value As String)
                realUsername = value
            End Set
        End Property

        Public Property realPasswordProperty() As String
            Get
                Return realPassword
            End Get
            Set(ByVal value As String)
                realPassword = value
            End Set
        End Property

        Public Function Encrypdata(ByVal plaintext As String) As String
            ' Convert the plaintext string to a byte array
            Dim plaintextBytes() As Byte =
                System.Text.Encoding.Unicode.GetBytes(plaintext)
            'Create the stream
            Dim ms As New System.IO.MemoryStream
            'Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms,
                TripleDes.CreateEncryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

            'Use The Crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            'Convert the encrypted stream to a printable string.

            Return Convert.ToBase64String(ms.ToArray)
        End Function

        Public Function CheckAuth(plainUsername As String, ByRef plainPassword As String) As String
            'Static Password

            For Each user_data In getDataUsers()
                Dim username_table As String = user_data(1)
                Dim password_table As String = user_data(2)
                If String.Compare(username_table, plainUsername) = 0 Then
                    If String.Compare(username_table, plainUsername) = 0 And String.Compare(Encrypdata(plainPassword), password_table) = 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Next

            Return False
        End Function

        Public Function EncryptMD5(ByRef password As String)
            Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
            Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            bs = x.ComputeHash(bs)

            Dim s As New System.Text.StringBuilder()
            For Each b As Byte In bs
                s.Append(b.ToString("x2").ToLower())
            Next
            Return s.ToString()
        End Function

        Public Function AddUsersDatabase(username_regist As String, password_regist As String, email_regist As String)
            Try
                Dim today = Date.Now()

                dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database=" + database

                dbConn.Open()

                sqlCommand.Connection = dbConn
                sqlQuery = "INSERT INTO USER( username, password, email) VALUE('" & username_regist & "', '" & EncryptMD5(password_regist) & "', '" & email_regist & "')"

                Debug.WriteLine(sqlQuery)

                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlRead = sqlCommand.ExecuteReader

                sqlRead.Close()
                dbConn.Close()

            Catch ex As Exception
                Return ex.Message
            Finally
                dbConn.Dispose()

            End Try
        End Function

        Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
            Try
                Dim result As New List(Of String)

                dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" + "password=" + password_db + ";" + "database=" + database
                dbConn.Open()
                sqlCommand.Connection = dbConn

                Dim queryAuth = "SELECT id, username FROM user
                         WHERE username='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"

                sqlCommand.CommandText = queryAuth
                Debug.WriteLine(queryAuth)
                sqlRead = sqlCommand.ExecuteReader

                If sqlRead.HasRows Then
                    While sqlRead.Read
                        result.Add(sqlRead.GetString(0).ToString())
                        result.Add(sqlRead.GetString(1).ToString())

                    End While
                End If

                sqlRead.Close()
                dbConn.Close()
                Return result

            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            Finally
                dbConn.Dispose()
            End Try
        End Function

>>>>>>> mfahrul-zy
End Class
