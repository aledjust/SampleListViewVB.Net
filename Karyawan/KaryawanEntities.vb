Public Class KaryawanEntities
    Dim _nik, _nama, _jabatan, _status, _imgUri As String
    Dim _gajiPokok, _tunjanganIstri, _tunjanganAnak, _pajak, _totalGaji As Double
    Dim _jamLembur As Integer


    Public Property Nik As String
        Get
            Return _nik
        End Get
        Set(ByVal value As String)
            _nik = value
        End Set
    End Property

    Public Property Nama As String
        Get
            Return _nama
        End Get
        Set(ByVal value As String)
            _nama = value
        End Set
    End Property

    Public Property Jabatan As String
        Get
            Return _jabatan
        End Get
        Set(ByVal value As String)
            _jabatan = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Public Property ImgUri As String
        Get
            Return Me._imgUri
        End Get
        Set(value As String)
            Me._imgUri = value
        End Set
    End Property

    Public Property GajiPokok As Double
        Get
            Return _gajiPokok
        End Get
        Set(ByVal value As Double)
            _gajiPokok = value
        End Set
    End Property

    Public Property TunjanganIstri As Double
        Get
            Return _tunjanganIstri
        End Get
        Set(ByVal value As Double)
            _tunjanganIstri = value
        End Set
    End Property

    Public Property TunjanganAnak As Double
        Get
            Return _tunjanganAnak
        End Get
        Set(ByVal value As Double)
            _tunjanganAnak = value
        End Set
    End Property

    Public Property JamLembur As Integer
        Get
            Return _jamLembur
        End Get
        Set(ByVal value As Integer)
            _jamLembur = value
        End Set
    End Property

    Public Property Pajak As Double
        Get
            Return _pajak
        End Get
        Set(ByVal value As Double)
            _pajak = value
        End Set
    End Property

    Public Property TotalGaji As Integer
        Get
            Return _totalGaji
        End Get
        Set(ByVal value As Integer)
            _totalGaji = value
        End Set
    End Property
End Class
