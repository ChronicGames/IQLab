'Luke Gitchel
'1/25/2018
'Visual Basic Project - IQ Lab

Option Explicit On
Option Infer On
Option Strict On


Imports System.Globalization


Public Class TestMyIQPage

    
    Private IQ As Integer
    
    Private Sub TestMyIQPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub uiMainForBrainFoodButton_Click(sender As Object, e As EventArgs) Handles uiMainForBrainFoodButton.Click

        'Hide Test My IQ Page
        Me.Hide()

        'Return to the Main Menu
        MainMenu.Show()



    End Sub
End Class