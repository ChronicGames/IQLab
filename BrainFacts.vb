'Luke Gitchel
'1/25/2018
'Visual Basic Project - IQ Lab

Option Explicit On
Option Strict On
Option Infer On

Imports System.Globalization


Public Class BrainFacts

    
    Private Sub uiMoreFactsButton_Click(sender As Object, e As EventArgs) Handles uiMoreFactsButton.Click

        'Hide brain facts form
        Me.Hide()
        'Show brain facts 2 form
        BrainFactsTwo.ShowDialog()

    End Sub
End Class