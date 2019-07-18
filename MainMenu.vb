'Luke Gitchel
'1/25/2018
'Visual Basic Project - IQ Lab

Option Explicit On
Option Strict On
Option Infer On

Imports System.Globalization
Public Class MainMenu

    Private Sub uiTestMyIQ_Click(sender As Object, e As EventArgs) Handles uiTestMyIQButton.Click

        'Hide the Main Menu
        Me.Hide()

        'Open Test My IQ
        TestMyIQPage.ShowDialog()


    End Sub

    Private Sub uiBrainFactsButton_Click(sender As Object, e As EventArgs) Handles uiBrainFactsButton.Click
        'Hide start page
        Me.Hide()
        'Show the next form
        BrainFacts.ShowDialog()

    End Sub

    

    Private Sub StartPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Ask if the user is sure that they want to close the program
        Dim button As DialogResult

        button = MessageBox.Show("Are you sure that you want to close IQ Lab?", "IQ Lab Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If button = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub uiBrainFoodButton_Click(sender As Object, e As EventArgs) Handles uiBrainFoodButton.Click

        'Hide the Main Menu
        Me.Hide()

        'Take the user to Brain Food
        BrainFood.ShowDialog()


    End Sub

    
    Private Sub uiExitButton_Click(sender As Object, e As EventArgs) Handles uiExitButton.Click

        Me.Close()


    End Sub
End Class