Public Class Sewa
    Dim strsql As String
    Dim info As String
    Private _idbayar As Integer
    Private _kode_bayar As Integer
    Private _nama As String
    Private _usia As Integer
    Private _alamat As String
    Private _pilihan_paket As String
    Private _harga As String
    Public InsertState As Boolean = False
    Public UpdateState As Boolean = False
    Public DeleteState As Boolean = False

    Public Property kode_bayar()
        Get
            Return _kode_bayar
        End Get
        Set(ByVal value)
            _kode_bayar = value
        End Set
    End Property

    Public Property nama()
        Get
            Return _nama
        End Get
        Set(ByVal value)
            _nama = value
        End Set
    End Property

    Public Property usia()
        Get
            Return _usia
        End Get
        Set(ByVal value)
            _usia = value
        End Set
    End Property

    Public Property alamat()
        Get
            Return _alamat
        End Get
        Set(ByVal value)
            _alamat = value
        End Set
    End Property

    Public Property pilihan_paket()
        Get
            Return _pilihan_paket
        End Get
        Set(ByVal value)
            _pilihan_paket = value
        End Set
    End Property

    Public Property harga()
        Get
            Return _harga
        End Get
        Set(ByVal value)
            _harga = value
        End Set
    End Property


    Public Sub Simpan()
        Dim info As String
        DBConnect()
        If (sewa_baru = True) Then
            strsql = "Insert into sewa(kode_bayar,nama,usia,alamat,pilihan_paket,harga) values ('" & _kode_bayar & "','" & _nama & "','" & _usia & "','" & _alamat & "','" & _pilihan_paket & "','" & _harga & "')"
            info = "INSERT"
        Else
            strsql = "update sewa set kode_bayar='" & _kode_bayar & "', nama='" & _nama & "', usia='" & _usia & "', alamat='" & _alamat & "', pilihan_paket='" & _pilihan_paket & "', harga='" & _harga & "' where kode_bayar='" & _kode_bayar & "'"
            info = "UPDATE"
        End If

        myCommand.Connection = conn
        myCommand.CommandText = strsql

        Try
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
            If (info = "INSERT") Then
                InsertState = False
            ElseIf (info = "UPDATE") Then
                UpdateState = False
            Else
            End If
        Finally
            If (info = "INSERT") Then
                InsertState = True
            ElseIf (info = "UPDATE") Then
                UpdateState = True
            Else
            End If
        End Try
        DBDisconnect()
    End Sub

    Public Sub Carisewa(ByVal skode_bayar As Integer)
        DBConnect()
        strsql = "SELECT * FROM sewa WHERE kode_bayar='" & skode_bayar & "'"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        DR = myCommand.ExecuteReader
        If (DR.HasRows = True) Then
            sewa_baru = False
            DR.Read()
            kode_bayar = Convert.ToString((DR("kode_bayar")))
            nama = Convert.ToString((DR("nama")))
            usia = Convert.ToString((DR("usia")))
            alamat = Convert.ToString((DR("alamat")))
            pilihan_paket = Convert.ToString((DR("pilihan_paket")))
            harga = Convert.ToString((DR("harga")))

        Else
            MessageBox.Show("Data Tidak Ditemukan.")
            sewa_baru = True
        End If
        DBDisconnect()
    End Sub

    Public Sub Hapus(ByVal skode_bayar As String)
        Dim info As String
        DBConnect()
        strsql = "DELETE FROM sewa WHERE kode_bayar='" & skode_bayar & "'"
        info = "DELETE"
        myCommand.Connection = conn
        myCommand.CommandText = strsql
        Try
            myCommand.ExecuteNonQuery()
            DeleteState = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        DBDisconnect()
    End Sub

    Public Sub getAllData(ByVal dg As DataGridView)
        Try
            DBConnect()
            strsql = "SELECT * FROM sewa"
            myCommand.Connection = conn
            myCommand.CommandText = strsql
            myData.Clear()
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            With dg
                .DataSource = myData
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DBDisconnect()
        End Try
    End Sub
End Class
