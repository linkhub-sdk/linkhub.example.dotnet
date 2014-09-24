Imports Linkhub


Public Class frmExmaple

    Dim ServiceID As String = "POPBILL_TEST"
    Dim LinkID As String = "TESTER"
    Dim SecretKey As String = "lPyb3alKnKOPEzbigVix/W/1JLiF2Hs71ey15bYCewI="

    Private Auth As Authority


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim token As Token
        Dim scopes As List(Of String) = New List(Of String)
        scopes.Add("110")

        Try
            token = Auth.getToken(ServiceID, "1231212312", scopes, Nothing)
            MsgBox(token.session_token)
            TextBox1.Text = token.session_token
        Catch ex As LinkhubException
            MsgBox(ex.code.ToString() + " | " + ex.Message)

        End Try


    End Sub

    Private Sub frmExmaple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Auth = New Authority(LinkID, SecretKey)
        'Auth.IsTest = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            Dim remainPoint As Double = Auth.getBalance(TextBox1.Text, ServiceID)
            MsgBox(remainPoint)
        Catch ex As LinkhubException
            MsgBox(ex.code.ToString() + " | " + ex.Message)

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try
            Dim remainPoint As Double = Auth.getPartnerBalance(TextBox1.Text, ServiceID)
            MsgBox(remainPoint)
        Catch ex As LinkhubException
            MsgBox(ex.code.ToString() + " | " + ex.Message)

        End Try
    End Sub
End Class
