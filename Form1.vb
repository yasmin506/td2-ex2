Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        Dim somme As Integer
        Dim diff As Integer
        Dim prod As Integer
        Dim quoti As Integer


        x = InputBox("entres x ")
        y = InputBox(" entre y")
        somme = x + y
        diff = x - y
        prod = x * y
        quoti = x / y

        MessageBox.Show("x+y=" & somme & vbCrLf & "x-y=" & diff & vbCrLf & "x*y=" & prod & vbCrLf & "x/y=" & quoti)




    End Sub
End Class
