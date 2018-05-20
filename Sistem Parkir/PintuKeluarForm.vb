Public Class PintuKeluarForm
    Private Sub btPintuMasuk_Click(sender As Object, e As EventArgs) Handles btPintuMasuk.Click
        Me.Hide()
        Dim pintuMasuk As New PintuMasukForm()
        pintuMasuk.Show()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MyBase.BackColor = Color.FromArgb(213, 216, 229)
        btCetakTiket.BackColor = Color.FromArgb(16, 169, 254)
        btReset.BackColor = Color.FromArgb(189, 189, 189)

        panelTab.BackColor = Color.FromArgb(16, 169, 254)

        Dim p1, p2 As New Drawing2D.GraphicsPath

        p1.StartFigure()
        p1.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        p1.AddLine(10, 0, btCetakTiket.Width - 10, 0)
        p1.AddArc(New Rectangle(btCetakTiket.Width - 10, 0, 10, 10), -90, 90)
        p1.AddLine(btCetakTiket.Width, 10, btCetakTiket.Width, btCetakTiket.Height - 10)
        p1.AddArc(New Rectangle(btCetakTiket.Width - 10, btCetakTiket.Height - 10, 10, 10), 0, 90)
        p1.AddLine(btCetakTiket.Width - 10, btCetakTiket.Height, 10, btCetakTiket.Height)
        p1.AddArc(New Rectangle(0, btCetakTiket.Height - 10, 10, 10), 90, 90)
        p1.CloseFigure()
        btCetakTiket.Region = New Region(p1)

        p2.StartFigure()
        p2.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        p2.AddLine(10, 0, btReset.Width - 10, 0)
        p2.AddArc(New Rectangle(btReset.Width - 10, 0, 10, 10), -90, 90)
        p2.AddLine(btReset.Width, 10, btReset.Width, btReset.Height - 10)
        p2.AddArc(New Rectangle(btReset.Width - 10, btReset.Height - 10, 10, 10), 0, 90)
        p2.AddLine(btReset.Width - 10, btReset.Height, 10, btReset.Height)
        p2.AddArc(New Rectangle(0, btReset.Height - 10, 10, 10), 90, 90)
        p2.CloseFigure()
        btReset.Region = New Region(p2)
    End Sub
End Class