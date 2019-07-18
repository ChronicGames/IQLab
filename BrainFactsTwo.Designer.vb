<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrainFactsTwo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrainFactsTwo))
        Me.Title = New System.Windows.Forms.Label()
        Me.BrainFactOne = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.uiMainMenuButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("SketchFlow Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(124, 22)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(287, 25)
        Me.Title.TabIndex = 1
        Me.Title.Text = "FACTS ABOUT THE BRAIN"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BrainFactOne
        '
        Me.BrainFactOne.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrainFactOne.Location = New System.Drawing.Point(39, 84)
        Me.BrainFactOne.Name = "BrainFactOne"
        Me.BrainFactOne.Size = New System.Drawing.Size(192, 85)
        Me.BrainFactOne.TabIndex = 2
        Me.BrainFactOne.Text = "Size doesn’t matter in the brain. There is no evidence that a larger brain is sma" & _
    "rter than a smaller brain." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 85)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 85)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "There are 100,000 miles of blood vessels in the brain. The distance around the wo" & _
    "rld at the equator is 24,900 miles."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 85)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "According to a study published in The New England Journal of Medicine, adults who" & _
    " participated in mind-challenging activities were 63 percent less likely to deve" & _
    "lop dementia."
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 104)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 85)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'uiMainMenuButton
        '
        Me.uiMainMenuButton.Location = New System.Drawing.Point(447, 377)
        Me.uiMainMenuButton.Name = "uiMainMenuButton"
        Me.uiMainMenuButton.Size = New System.Drawing.Size(75, 23)
        Me.uiMainMenuButton.TabIndex = 9
        Me.uiMainMenuButton.Text = "&Main Menu"
        Me.uiMainMenuButton.UseVisualStyleBackColor = True
        '
        'BrainFactsTwo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(534, 412)
        Me.Controls.Add(Me.uiMainMenuButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BrainFactOne)
        Me.Controls.Add(Me.Title)
        Me.Name = "BrainFactsTwo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BrainFactsTwo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents BrainFactOne As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents uiMainMenuButton As System.Windows.Forms.Button
End Class
