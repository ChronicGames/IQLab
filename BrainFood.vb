'Luke Gitchel
'1/25/2018
'Visual Basic Project - IQ Lab

Option Explicit On
Option Strict On
Option Infer On

Imports System.Globalization

Public Class BrainFood


    
    Private Sub uiMainForBrainFoodButton_Click(sender As Object, e As EventArgs) Handles uiMainForBrainFoodButton.Click

        'Hide the brain food
        Me.Hide()

        'Send the user back to the main menu
        MainMenu.Show()


    End Sub
End Class