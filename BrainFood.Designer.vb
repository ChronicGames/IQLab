<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrainFood
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
        Me.author = New System.Windows.Forms.Label()
        Me.uiMainForBrainFoodButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'uiMainForBrainFoodButton
        '
        Me.uiMainForBrainFoodButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uiMainForBrainFoodButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiMainForBrainFoodButton.Location = New System.Drawing.Point(392, 371)
        Me.uiMainForBrainFoodButton.Name = "uiMainForBrainFoodButton"
        Me.uiMainForBrainFoodButton.Size = New System.Drawing.Size(130, 29)
        Me.uiMainForBrainFoodButton.TabIndex = 8
        Me.uiMainForBrainFoodButton.Text = "&Main Menu"
        Me.uiMainForBrainFoodButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IQ_Lab.My.Resources.Resources.spinach_picture
        Me.PictureBox1.Location = New System.Drawing.Point(30, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Mistral", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Spinach"
        '
        'BrainFood
        '
        Me.AcceptButton = Me.uiMainForBrainFoodButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(534, 412)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.uiMainForBrainFoodButton)
        Me.Controls.Add(Me.author)
        Me.Name = "BrainFood"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brain Food"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents author As System.Windows.Forms.Label
    Friend WithEvents uiMainForBrainFoodButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
