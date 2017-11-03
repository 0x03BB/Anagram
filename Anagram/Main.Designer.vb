<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.lblAnagram = New System.Windows.Forms.Label()
        Me.txtAnagram = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(12, 9)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(33, 13)
        Me.lblWord.TabIndex = 0
        Me.lblWord.Text = "Word"
        '
        'txtWord
        '
        Me.txtWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWord.Location = New System.Drawing.Point(15, 28)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(176, 20)
        Me.txtWord.TabIndex = 1
        '
        'lblAnagram
        '
        Me.lblAnagram.AutoSize = True
        Me.lblAnagram.Location = New System.Drawing.Point(12, 51)
        Me.lblAnagram.Name = "lblAnagram"
        Me.lblAnagram.Size = New System.Drawing.Size(54, 13)
        Me.lblAnagram.TabIndex = 3
        Me.lblAnagram.Text = "Anagrams"
        '
        'txtAnagram
        '
        Me.txtAnagram.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnagram.Location = New System.Drawing.Point(15, 67)
        Me.txtAnagram.Multiline = True
        Me.txtAnagram.Name = "txtAnagram"
        Me.txtAnagram.Size = New System.Drawing.Size(257, 182)
        Me.txtAnagram.TabIndex = 4
        '
        'btnFind
        '
        Me.btnFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFind.Location = New System.Drawing.Point(197, 26)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtAnagram)
        Me.Controls.Add(Me.lblAnagram)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblWord)
        Me.Name = "Main"
        Me.Text = "Anagram"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWord As Label
    Friend WithEvents txtWord As TextBox
    Friend WithEvents lblAnagram As Label
    Friend WithEvents txtAnagram As TextBox
    Friend WithEvents btnFind As Button
End Class
