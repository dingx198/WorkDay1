Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String = txtFullName.Text
        Dim st As String
        st = fullname.Trim()
        Dim n As Integer
        n = st.IndexOf(" ")
        Dim firstname As String
        firstname = st.Substring(0, n)
        txtFirstName.Text = firstname

    End Sub
End Class
