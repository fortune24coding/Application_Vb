Public Class Form1
    Public Class FormLogin
        Public Property name As String
        Public Property email As String
        Public Property telephone As String
        Public Property codepostal As String
        Public Property mensuel As String
        Public Property annuel As String
        Public Property password As String
    End Class


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formlogin As New FormLogin()
        Dim form As New Form3
        Dim State = False

        formlogin.name = labelNomcomplet.Text
        formlogin.email = labelAdresseEmail.Text
        formlogin.telephone = labelNumerodetelephone.Text
        formlogin.codepostal = TextBox4.Text
        formlogin.password = TextBox5.Text
        Dim valeur = ""




        If String.IsNullOrEmpty(formlogin.name) Or String.IsNullOrEmpty(formlogin.email) Then
            MsgBox("Les champs nom et email sont vides")
        Else
            MsgBox(" les champs ont ete remplis")
            State = True
        End If
        If String.IsNullOrEmpty(formlogin.telephone) Or String.IsNullOrEmpty(formlogin.codepostal) Or String.IsNullOrEmpty(formlogin.password) Then
            MsgBox("Les champs nom et email sont vides")
        Else
            MsgBox(" les champs ont ete remplis")
            State = True
        End If
        If RadioButton1.Checked Then
            valeur = "mensuel"
        ElseIf RadioButton2.Checked Then
            valeur = "annuel"
        End If
        If (State = True) Then
            form.DataGridView1.Rows.Add(formlogin.name, formlogin.email, formlogin.telephone, formlogin.codepostal, valeur)

            form.Show()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form1 As New Form2
        form1.Show()
    End Sub


End Class
