Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Module MyMod
    Public myCommand As New MySqlCommand
    Public myAdapter As New MySqlDataAdapter
    Public myData As New DataTable
    Public DR As MySql.Data.MySqlClient.MySqlDataReader
    Public SQL As String
    Public conn As New MySql.Data.MySqlClient.MySqlConnection
    Public cn As New Connection

    'Tabel Sewa
    '-------------------------------
    Public sewa_baru As Boolean
    Public oSewa As New Sewa
    '--------------------------------

    'Tabel User
    '--------------------------------
    Public user_baru As Boolean
    Public oUser As New User
    '--------------------------------

    Public login_valid As Boolean

    Public Sub DBConnect()
        cn.Host = "localhost"
        cn.User = "root"
        cn.Password = ""
        cn.DatabaseName = "karaoke"
        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub

    Public Function getMD5Hash(ByVal strToHash As String) As String

        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        Dim b As Byte
        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

End Module
