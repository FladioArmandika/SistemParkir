<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PintuKeluarForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelTab = New System.Windows.Forms.Panel()
        Me.btPintuMasuk = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelTbNoKendaraan = New System.Windows.Forms.Panel()
        Me.tbNoKendaraan = New System.Windows.Forms.TextBox()
        Me.tbNoTiket = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btCetakTiket = New System.Windows.Forms.Button()
        Me.btReset = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTbNoKendaraan.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(186, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(142, 24)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "PINTU KELUAR"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.panelTab)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.btPintuMasuk)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 72)
        Me.Panel1.TabIndex = 1
        '
        'panelTab
        '
        Me.panelTab.Location = New System.Drawing.Point(173, 62)
        Me.panelTab.Name = "panelTab"
        Me.panelTab.Size = New System.Drawing.Size(165, 10)
        Me.panelTab.TabIndex = 10
        '
        'btPintuMasuk
        '
        Me.btPintuMasuk.AutoSize = True
        Me.btPintuMasuk.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPintuMasuk.ForeColor = System.Drawing.Color.Silver
        Me.btPintuMasuk.Location = New System.Drawing.Point(29, 39)
        Me.btPintuMasuk.Name = "btPintuMasuk"
        Me.btPintuMasuk.Size = New System.Drawing.Size(138, 24)
        Me.btPintuMasuk.TabIndex = 8
        Me.btPintuMasuk.Text = "PINTU MASUK"
        Me.btPintuMasuk.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(540, 309)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(586, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "No Kendaraan"
        '
        'panelTbNoKendaraan
        '
        Me.panelTbNoKendaraan.BackColor = System.Drawing.Color.White
        Me.panelTbNoKendaraan.Controls.Add(Me.tbNoKendaraan)
        Me.panelTbNoKendaraan.Location = New System.Drawing.Point(590, 217)
        Me.panelTbNoKendaraan.Name = "panelTbNoKendaraan"
        Me.panelTbNoKendaraan.Size = New System.Drawing.Size(330, 50)
        Me.panelTbNoKendaraan.TabIndex = 7
        '
        'tbNoKendaraan
        '
        Me.tbNoKendaraan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNoKendaraan.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoKendaraan.Location = New System.Drawing.Point(15, 12)
        Me.tbNoKendaraan.Name = "tbNoKendaraan"
        Me.tbNoKendaraan.Size = New System.Drawing.Size(298, 20)
        Me.tbNoKendaraan.TabIndex = 0
        '
        'tbNoTiket
        '
        Me.tbNoTiket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNoTiket.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNoTiket.Location = New System.Drawing.Point(15, 12)
        Me.tbNoTiket.Name = "tbNoTiket"
        Me.tbNoTiket.Size = New System.Drawing.Size(298, 20)
        Me.tbNoTiket.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.tbNoTiket)
        Me.Panel2.Location = New System.Drawing.Point(590, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 50)
        Me.Panel2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(586, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "No Tiket"
        '
        'btCetakTiket
        '
        Me.btCetakTiket.FlatAppearance.BorderSize = 0
        Me.btCetakTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCetakTiket.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCetakTiket.ForeColor = System.Drawing.Color.White
        Me.btCetakTiket.Location = New System.Drawing.Point(703, 273)
        Me.btCetakTiket.Name = "btCetakTiket"
        Me.btCetakTiket.Size = New System.Drawing.Size(217, 51)
        Me.btCetakTiket.TabIndex = 12
        Me.btCetakTiket.Text = "SUBMIT"
        Me.btCetakTiket.UseVisualStyleBackColor = True
        '
        'btReset
        '
        Me.btReset.FlatAppearance.BorderSize = 0
        Me.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReset.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReset.ForeColor = System.Drawing.Color.White
        Me.btReset.Location = New System.Drawing.Point(590, 273)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(107, 51)
        Me.btReset.TabIndex = 11
        Me.btReset.Text = "RESET"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(590, 330)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(330, 129)
        Me.Panel3.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TARIF TOTAL "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(172, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jam Masuk :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(172, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tanggal : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = " No Tiket : "
        '
        'PintuKeluarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 566)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btCetakTiket)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelTbNoKendaraan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PintuKeluarForm"
        Me.Text = "Sistem Parkir "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTbNoKendaraan.ResumeLayout(False)
        Me.panelTbNoKendaraan.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label21 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelTab As Panel
    Friend WithEvents btPintuMasuk As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents panelTbNoKendaraan As Panel
    Friend WithEvents tbNoKendaraan As TextBox
    Friend WithEvents tbNoTiket As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btCetakTiket As Button
    Friend WithEvents btReset As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
