﻿Public Class Form1
    Dim calcs As Decimal = 0    'secondary number
    Dim operat As Char = ""   'operator for doing arithmatic
    Dim hist As Decimal = 0     'primary number
    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click
        Resultbox.Text += "0"   'sends 0 to Resultbox
    End Sub

    Private Sub Deci_Click(sender As Object, e As EventArgs) Handles Deci.Click
        If (Resultbox.Text <> ".") Then 'checks for a "." already in line before 
            Resultbox.Text += "."       'sends "." to Resultbox if there is no decimal already there
        End If

    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Resultbox.Text += "1"   'sends 1 to Resultbox

    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Resultbox.Text += "2"   'sends 2 to Resultbox

    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Resultbox.Text += "3"   'sends 3 to Resultbox

    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        Resultbox.Text += "4"   'sends 4 to Resultbox

    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        Resultbox.Text += "5"   'sends 5 to Resultbox

    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        Resultbox.Text += "6"   'sends 6 to the Resultbox

    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        Resultbox.Text += "7"   'sends 7 to the Resultbox

    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        Resultbox.Text += "8"   'sends 8 to the Resultbox

    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        Resultbox.Text += "9"   'sends 9 to the Resultbox

    End Sub

    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        Resultbox.Clear()   'resets Resulbox value
        operat = 0          'resets variable
        hist = 0            'resets variable
        calcs = 0           'resets variable
    End Sub

    Private Sub Tqls_Click(sender As Object, e As EventArgs) Handles Teql.Click, Teql.Click
        If (operat = "+") Then          'checks operators for arithmatic operations
            hist = Resultbox.Text       'holds primary number
            History.Text += calcs & operat & hist & " = "  'coalates history values
            Resultbox.Text += calcs     'addition operation
            History.Text += Resultbox.Text & vbCrLf     'sends Resultbox to History, makes new line with vbCrLf, displays calculation in history
        ElseIf (operat = "-") Then
            hist = Resultbox.Text       'holds first number
            History.Text += calcs & operat & hist & " = "  'coalates history values
            Resultbox.Text = calcs - hist     'subtraction operation looks backwards but works to output correctly
            History.Text += Resultbox.Text & vbCrLf     'holds result of operation in entirety, makes new line with vbCrLf
        ElseIf (operat = "*") Then
            hist = Resultbox.Text       'holds first number
            History.Text += calcs & operat & hist & " = "  'coalates history values
            Resultbox.Text *= calcs     'multiplication operation
            History.Text += Resultbox.Text & vbCrLf     'holds result of operation in entirety, makes new line with vbCrLf
        ElseIf (operat = "/") Then
            hist = Resultbox.Text       'holds first number
            History.Text += calcs & operat & hist & " = "  'coalates history values
            Resultbox.Text = calcs / hist     'division operation
            History.Text += Resultbox.Text & vbCrLf     'holds result of operation in entirety, makes new line with vbCrLf
        End If
        calcs = 0                       'reset variable
        operat = ""                     'reset variable
    End Sub

    Private Sub Bksp_Click(sender As Object, e As EventArgs) Handles Bksp.Click
        Dim result As String = Resultbox.Text   'stores textbox value
        Dim ilenght As Integer = Resultbox.TextLength - 1   'gets length of string to trim last number
        If (Resultbox.TextLength > 0) Then  'checking for 0 length to prevent crashing while backspacing
            result = result.Substring(0, ilenght)   'backspace
            Resultbox.Text = result                 'update textbox value
        End If
    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        calcs = Resultbox.Text          'gets textbox value
        operat = "+"                    'assign operator
        Resultbox.Clear()               'clears textbox
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        calcs = Resultbox.Text          'gets textbox value
        operat = "-"                    'gets operator value
        Resultbox.Clear()               'clears textbox
    End Sub

    Private Sub Times_Click(sender As Object, e As EventArgs) Handles Times.Click
        calcs = Resultbox.Text  'stores secondary number
        operat = "*"            'stores operator
        Resultbox.Clear()       'clears Resulttbox
    End Sub

    Private Sub Divi_Click(sender As Object, e As EventArgs) Handles Divi.Click
        calcs = Resultbox.Text  'stores secondary number
        operat = "/"            'stores operator
        Resultbox.Clear()       'clears Resulttbox
    End Sub

    Private Sub PM_Click(sender As Object, e As EventArgs) Handles PM.Click
        hist = Resultbox.Text   'stores number
        Resultbox.Text = -hist  'switch positive and negative in Resultbox
        hist = 0                'clear hist variable
    End Sub
End Class
