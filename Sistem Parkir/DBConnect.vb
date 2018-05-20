Imports MySql.Data.MySqlClient

Public Class DBConnect

    Dim conn As MySqlConnection
    Dim server = "localhost"
    Dim Username As String = "fladioarmandika"
    Dim Password As String = "91378531"


    Public Function connect() As MySqlConnection
        Try
            conn = New MySqlConnection("datasource=" & server & ";username=" & Username & ";password=" & Password & ";database=sistemparkir;")
            conn.Open()
            Return conn
        Catch ex As Exception
            MessageBox.Show("Cannot connect to database: " & ex.Message)
        End Try
    End Function


    Public Function close()
        conn.Close()
        conn.Dispose()
    End Function


End Class
