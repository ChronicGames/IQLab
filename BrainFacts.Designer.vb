<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrainFacts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrainFacts))
        Me.Title = New System.Windows.Forms.Label()
        Me.BrainFactOne = New System.Windows.Forms.Label()
        Me.BrainFactTwo = New System.Windows.Forms.Label()
        Me.BrainFactThree = New System.Windows.Forms.Label()
        Me.BrainFactFour = New System.Windows.Forms.Label()
        Me.uiMoreFactsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("SketchFlow Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(124, 18)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(287, 25)
        Me.Title.TabIndex = 0
        Me.Title.Text = "FACTS ABOUT THE BRAIN"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BrainFactOne
        '
        Me.BrainFactOne.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrainFactOne.Location = New System.Drawing.Point(27, 113)
        Me.BrainFactOne.Name = "BrainFactOne"
        Me.BrainFactOne.Size = New System.Drawing.Size(192, 85)
        Me.BrainFactOne.TabIndex = 1
        Me.BrainFactOne.Text = "The average adult human brain weighs three pounds, has a texture like firm jelly " & _
    "and is made up of 75 percent water. "
        '
        'BrainFactTwo
        '
        Me.BrainFactTwo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrainFactTwo.Location = New System.Drawing.Point(290, 113)
        Me.BrainFactTwo.Name = "BrainFactTwo"
        Me.BrainFactTwo.Size = New System.Drawing.Size(192, 103)
        Me.BrainFactTwo.TabIndex = 2
        Me.BrainFactTwo.Text = "Every time your heart beats, your arteries carry 20 to 25 percent of your blood t" & _
    "o the brain. The harder you think, the more oxygen and fuel your brain will use " & _
    "from your blood – up to 50 percent."
        '
        'BrainFactThree
        '
        Me.BrainFactThree.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrainFactThree.Location = New System.Drawing.Point(27, 272)
        Me.BrainFactThree.Name = "BrainFactThree"
        Me.BrainFactThree.Size = New System.Drawing.Size(192, 103)
        Me.BrainFactThree.TabIndex = 3
        Me.BrainFactThree.Text = "Every time you recall a memory or have a new thought, you create a connection in " & _
    "the brain. "
        '
        'BrainFactFour
        '
        Me.BrainFactFour.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrainFactFour.Location = New System.Drawing.Point(290, 272)
        Me.BrainFactFour.Name = "BrainFactFour"
        Me.BrainFactFour.Size = New System.Drawing.Size(192, 103)
        Me.BrainFactFour.TabIndex = 4
        Me.BrainFactFour.Text = resources.GetString("BrainFactFour.Text")
        '
        'uiMoreFactsButton
        '
        Me.uiMoreFactsButton.Location = New System.Drawing.Point(447, 377)
        Me.uiMoreFactsButton.Name = "uiMoreFactsButton"
        Me.uiMoreFactsButton.Size = New System.Drawing.Size(75, 23)
        Me.uiMoreFactsButton.TabIndex = 5
        Me.uiMoreFactsButton.Text = "&More Facts.."
        Me.uiMoreFactsButton.UseVisualStyleBackColor = True
        '
        'BrainFacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(534, 412)
        Me.Controls.Add(Me.uiMoreFactsButton)
        Me.Controls.Add(Me.BrainFactFour)
        Me.Controls.Add(Me.BrainFactThree)
        Me.Controls.Add(Me.BrainFactTwo)
        Me.Controls.Add(Me.BrainFactOne)
        Me.Controls.Add(Me.Title)
        Me.Name = "BrainFacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BrainFacts"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents BrainFactOne As System.Windows.Forms.Label
    Friend WithEvents BrainFactTwo As System.Windows.Forms.Label
    Friend WithEvents BrainFactThree As System.Windows.Forms.Label
    Friend WithEvents BrainFactFour As System.Windows.Forms.Label
    Friend WithEvents uiMoreFactsButton As System.Windows.Forms.Button
End Class
