Public Class Studente
    Dim cognome As String
    Dim nome As String
    Dim data_nascita As Date
    Dim luogo_nascita As String
    Dim prov_nascita As String
    Public Sub New(ByVal _cg As String, ByVal _n As String, ByVal _dn As Date, ByVal _ln As String, ByVal _pr As String)
        cognome = _cg
        nome = _n
        data_nascita = _dn
        luogo_nascita = _ln
        prov_nascita = _pr
    End Sub
    Public Sub Stampa()
        MsgBox("nome:" + nome + vbCrLf + "cogome:" + cognome + vbCrLf + "data nascita:" + data_nascita, vbOKOnly, "Output")
    End Sub
    Public Property _Cognome() As String
        Get
            Return cognome
        End Get


        Set(value As String)
            cognome = value
        End Set
    End Property
End Class
