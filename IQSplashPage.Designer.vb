<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IQSplashPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IQSplashPage))
        Me.IQSplashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.author = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.uiPrintButton = New System.Windows.Forms.Button()
        Me.IQSplashPrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IQSplashTimer
        '
        Me.IQSplashTimer.Enabled = True
        Me.IQSplashTimer.Interval = 8000
        '
        'author
        '
        Me.author.AutoSize = True
        Me.author.Location = New System.Drawing.Point(12, 390)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(40, 13)
        Me.author.TabIndex = 2
        Me.author.Text = "Gitchel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(442, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Copyright 2018"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 390)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Version 1.0"
        '
        'uiPrintButton
        '
        Me.uiPrintButton.Location = New System.Drawing.Point(97, 385)
        Me.uiPrintButton.Name = "uiPrintButton"
        Me.uiPrintButton.Size = New System.Drawing.Size(75, 23)
        Me.uiPrintButton.TabIndex = 1
        Me.uiPrintButton.Text = "&Print"
        Me.uiPrintButton.UseVisualStyleBackColor = True
        '
        'IQSplashPrintForm
        '
        Me.IQSplashPrintForm.DocumentName = "document"
        Me.IQSplashPrintForm.Form = Me
        Me.IQSplashPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.IQSplashPrintForm.PrinterSettings = CType(resources.GetObject("IQSplashPrintForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.IQSplashPrintForm.PrintFileName = Nothing
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("SketchFlow Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(216, 10)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(102, 25)
        Me.Title.TabIndex = 6
        Me.Title.Text = "IQ LAB"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IQSplashPage
        '
        Me.AcceptButton = Me.uiPrintButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImage = Global.IQ_Lab.My.Resources.Resources.brain_front
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(534, 412)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.uiPrintButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.author)
        Me.DoubleBuffered = True
        Me.Name = "IQSplashPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IQ Lab"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IQSplashTimer As System.Windows.Forms.Timer
    Friend WithEvents author As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents uiPrintButton As System.Windows.Forms.Button
    Friend WithEvents IQSplashPrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Title As System.Windows.Forms.Label

End Class
