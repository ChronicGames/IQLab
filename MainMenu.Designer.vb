<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.title = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.Label()
        Me.uiTestMyIQButton = New System.Windows.Forms.Button()
        Me.uiBrainFactsButton = New System.Windows.Forms.Button()
        Me.uiBrainFoodButton = New System.Windows.Forms.Button()
        Me.uiBrainGamesButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.uiExitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(205, 46)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(124, 35)
        Me.title.TabIndex = 0
        Me.title.Text = "IQ Lab"
        Me.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'author
        '
        Me.author.AutoSize = True
        Me.author.Location = New System.Drawing.Point(12, 390)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(40, 13)
        Me.author.TabIndex = 1
        Me.author.Text = "Gitchel"
        '
        'uiTestMyIQButton
        '
        Me.uiTestMyIQButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uiTestMyIQButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiTestMyIQButton.Location = New System.Drawing.Point(39, 149)
        Me.uiTestMyIQButton.Name = "uiTestMyIQButton"
        Me.uiTestMyIQButton.Size = New System.Drawing.Size(134, 44)
        Me.uiTestMyIQButton.TabIndex = 2
        Me.uiTestMyIQButton.Text = "&Test My IQ"
        Me.uiTestMyIQButton.UseVisualStyleBackColor = False
        '
        'uiBrainFactsButton
        '
        Me.uiBrainFactsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uiBrainFactsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiBrainFactsButton.Location = New System.Drawing.Point(361, 149)
        Me.uiBrainFactsButton.Name = "uiBrainFactsButton"
        Me.uiBrainFactsButton.Size = New System.Drawing.Size(134, 44)
        Me.uiBrainFactsButton.TabIndex = 3
        Me.uiBrainFactsButton.Text = "Brain &Facts"
        Me.uiBrainFactsButton.UseVisualStyleBackColor = False
        '
        'uiBrainFoodButton
        '
        Me.uiBrainFoodButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uiBrainFoodButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiBrainFoodButton.Location = New System.Drawing.Point(39, 219)
        Me.uiBrainFoodButton.Name = "uiBrainFoodButton"
        Me.uiBrainFoodButton.Size = New System.Drawing.Size(134, 44)
        Me.uiBrainFoodButton.TabIndex = 4
        Me.uiBrainFoodButton.Text = "&Brain Food"
        Me.uiBrainFoodButton.UseVisualStyleBackColor = False
        '
        'uiBrainGamesButton
        '
        Me.uiBrainGamesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uiBrainGamesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiBrainGamesButton.Location = New System.Drawing.Point(361, 219)
        Me.uiBrainGamesButton.Name = "uiBrainGamesButton"
        Me.uiBrainGamesButton.Size = New System.Drawing.Size(134, 44)
        Me.uiBrainGamesButton.TabIndex = 5
        Me.uiBrainGamesButton.Text = "Brain &Games"
        Me.uiBrainGamesButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.IQ_Lab.My.Resources.Resources.brain_front
        Me.PictureBox1.Location = New System.Drawing.Point(183, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'uiExitButton
        '
        Me.uiExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uiExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiExitButton.Location = New System.Drawing.Point(202, 330)
        Me.uiExitButton.Name = "uiExitButton"
        Me.uiExitButton.Size = New System.Drawing.Size(130, 29)
        Me.uiExitButton.TabIndex = 7
        Me.uiExitButton.Text = "&Exit"
        Me.uiExitButton.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AcceptButton = Me.uiTestMyIQButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(534, 412)
        Me.Controls.Add(Me.uiExitButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.uiBrainGamesButton)
        Me.Controls.Add(Me.uiBrainFoodButton)
        Me.Controls.Add(Me.uiBrainFactsButton)
        Me.Controls.Add(Me.uiTestMyIQButton)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.title)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IQ Lab"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents author As System.Windows.Forms.Label
    Friend WithEvents uiTestMyIQButton As System.Windows.Forms.Button
    Friend WithEvents uiBrainFactsButton As System.Windows.Forms.Button
    Friend WithEvents uiBrainFoodButton As System.Windows.Forms.Button
    Friend WithEvents uiBrainGamesButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents uiExitButton As System.Windows.Forms.Button
End Class
