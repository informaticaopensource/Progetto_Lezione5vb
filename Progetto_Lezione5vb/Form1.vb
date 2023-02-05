Public Class Form1
    Public st1 As Studente = New Studente("", "", "01/01/2000", "", "")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "cognome"
        Label2.Text = "nome"
        Label3.Text = "data nascita"
        Label4.Text = "luogo di nascita"
        Label5.Text = "provincia di nascita"
        btnaggiungi.Text = "Aggiungi dati"
        btnvisualizza.Text = "Visualizza dati"
        btnfine.Text = "Fine Programma"
        btncancella.Text = "Cancella dati"
    End Sub

    Private Sub btnaggiungi_Click(sender As Object, e As EventArgs) Handles btnaggiungi.Click
        Dim st As Studente = New Studente(txtcognome.Text, txtnome.Text, CDate(txtdatanascita.Text), txtluogonascita.Text, txtprovincia.Text)
        st1 = st
    End Sub



    Private Sub btnfine_Click(sender As Object, e As EventArgs) Handles btnfine.Click
        Me.Close()
    End Sub

    Private Sub btncancella_Click(sender As Object, e As EventArgs) Handles btncancella.Click
        txtcognome.Text = ""
        txtnome.Text = ""
        txtdatanascita.Text = ""
        txtluogonascita.Text = ""
        txtprovincia.Text = ""

    End Sub
End Class
