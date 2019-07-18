'Luke Gitchel
'1/25/2018
'Visual Basic Project - IQ Lab

Option Explicit On
Option Strict On
Option Infer On

Imports System.Globalization


Public Class IQSplashPage

   

    Private Sub IQSplashTimer_Tick(sender As Object, e As EventArgs) Handles IQSplashTimer.Tick

        'Display the IQSplashPage for 8 seconds then load the StartPage 
        IQSplashTimer.Enabled = False

        Me.Hide()

        MainMenu.ShowDialog()

        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles uiPrintButton.Click

        'Print the IQSplashForm
        IQSplashPrintForm.PrintAction = Printing.PrintAction.PrintToPreview
        IQSplashPrintForm.Print()


    End Sub

    

    
End Class
