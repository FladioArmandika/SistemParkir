Public Class Mobil

    Private tarif As Integer
    Public Property tarif_mobil As Integer
        Get
            Return tarif
        End Get
        Set(value As Integer)
            tarif = value
        End Set
    End Property


    Private kuota As Integer
    Public Property kuota_mobil As Integer
        Get
            Return kuota
        End Get
        Set(value As Integer)
            kuota = value
        End Set
    End Property

End Class
