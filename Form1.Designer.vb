<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        B1 = New Button()
        Resultbox = New TextBox()
        B2 = New Button()
        B3 = New Button()
        B4 = New Button()
        B5 = New Button()
        B6 = New Button()
        B7 = New Button()
        B8 = New Button()
        B9 = New Button()
        B0 = New Button()
        ClrBtn = New Button()
        Teql = New Button()
        Deci = New Button()
        Bksp = New Button()
        Plus = New Button()
        Minus = New Button()
        Times = New Button()
        Divi = New Button()
        History = New RichTextBox()
        History_Label = New Label()
        PM = New Button()
        MPer = New Button()
        Curnt = New TextBox()
        SuspendLayout()
        ' 
        ' B1
        ' 
        B1.Location = New Point(17, 144)
        B1.Name = "B1"
        B1.Size = New Size(42, 23)
        B1.TabIndex = 0
        B1.Text = "1"
        B1.UseVisualStyleBackColor = True
        ' 
        ' Resultbox
        ' 
        Resultbox.Font = New Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Resultbox.Location = New Point(12, 12)
        Resultbox.Name = "Resultbox"
        Resultbox.PlaceholderText = "0"
        Resultbox.Size = New Size(193, 37)
        Resultbox.TabIndex = 1
        Resultbox.TextAlign = HorizontalAlignment.Right
        Resultbox.WordWrap = False
        ' 
        ' B2
        ' 
        B2.Location = New Point(65, 144)
        B2.Name = "B2"
        B2.Size = New Size(42, 23)
        B2.TabIndex = 2
        B2.Text = "2"
        B2.UseVisualStyleBackColor = True
        ' 
        ' B3
        ' 
        B3.Location = New Point(113, 144)
        B3.Name = "B3"
        B3.Size = New Size(43, 23)
        B3.TabIndex = 3
        B3.Text = "3"
        B3.UseVisualStyleBackColor = True
        ' 
        ' B4
        ' 
        B4.Location = New Point(17, 115)
        B4.Name = "B4"
        B4.Size = New Size(42, 23)
        B4.TabIndex = 4
        B4.Text = "4"
        B4.UseVisualStyleBackColor = True
        ' 
        ' B5
        ' 
        B5.Location = New Point(65, 115)
        B5.Name = "B5"
        B5.Size = New Size(42, 23)
        B5.TabIndex = 5
        B5.Text = "5"
        B5.UseVisualStyleBackColor = True
        ' 
        ' B6
        ' 
        B6.Location = New Point(113, 115)
        B6.Name = "B6"
        B6.Size = New Size(43, 23)
        B6.TabIndex = 6
        B6.Text = "6"
        B6.UseVisualStyleBackColor = True
        ' 
        ' B7
        ' 
        B7.Location = New Point(17, 86)
        B7.Name = "B7"
        B7.Size = New Size(42, 23)
        B7.TabIndex = 7
        B7.Text = "7"
        B7.UseVisualStyleBackColor = True
        ' 
        ' B8
        ' 
        B8.Location = New Point(65, 86)
        B8.Name = "B8"
        B8.Size = New Size(42, 23)
        B8.TabIndex = 8
        B8.Text = "8"
        B8.UseVisualStyleBackColor = True
        ' 
        ' B9
        ' 
        B9.Location = New Point(113, 86)
        B9.Name = "B9"
        B9.Size = New Size(43, 23)
        B9.TabIndex = 9
        B9.Text = "9"
        B9.UseVisualStyleBackColor = True
        ' 
        ' B0
        ' 
        B0.Location = New Point(65, 173)
        B0.Name = "B0"
        B0.Size = New Size(42, 23)
        B0.TabIndex = 10
        B0.Text = "0"
        B0.UseVisualStyleBackColor = True
        ' 
        ' ClrBtn
        ' 
        ClrBtn.BackColor = Color.Red
        ClrBtn.Location = New Point(12, 55)
        ClrBtn.Name = "ClrBtn"
        ClrBtn.Size = New Size(47, 23)
        ClrBtn.TabIndex = 11
        ClrBtn.Text = "C"
        ClrBtn.UseVisualStyleBackColor = False
        ' 
        ' Teql
        ' 
        Teql.BackColor = Color.Chartreuse
        Teql.Location = New Point(113, 173)
        Teql.Name = "Teql"
        Teql.Size = New Size(43, 23)
        Teql.TabIndex = 12
        Teql.Text = "="
        Teql.UseVisualStyleBackColor = False
        ' 
        ' Deci
        ' 
        Deci.BackColor = Color.LightCyan
        Deci.Location = New Point(17, 173)
        Deci.Name = "Deci"
        Deci.Size = New Size(42, 23)
        Deci.TabIndex = 13
        Deci.Text = "."
        Deci.UseVisualStyleBackColor = False
        ' 
        ' Bksp
        ' 
        Bksp.BackColor = Color.Red
        Bksp.Location = New Point(65, 55)
        Bksp.Name = "Bksp"
        Bksp.Size = New Size(42, 23)
        Bksp.TabIndex = 14
        Bksp.Text = "<<"
        Bksp.UseVisualStyleBackColor = False
        ' 
        ' Plus
        ' 
        Plus.BackColor = SystemColors.Highlight
        Plus.ForeColor = Color.Gold
        Plus.Location = New Point(162, 86)
        Plus.Name = "Plus"
        Plus.Size = New Size(43, 23)
        Plus.TabIndex = 15
        Plus.Text = "+"
        Plus.UseVisualStyleBackColor = False
        ' 
        ' Minus
        ' 
        Minus.BackColor = SystemColors.Highlight
        Minus.ForeColor = Color.Gold
        Minus.Location = New Point(162, 115)
        Minus.Name = "Minus"
        Minus.Size = New Size(43, 23)
        Minus.TabIndex = 16
        Minus.Text = "-"
        Minus.UseVisualStyleBackColor = False
        ' 
        ' Times
        ' 
        Times.BackColor = SystemColors.Highlight
        Times.ForeColor = Color.Gold
        Times.Location = New Point(162, 144)
        Times.Name = "Times"
        Times.Size = New Size(43, 23)
        Times.TabIndex = 17
        Times.Text = "*"
        Times.UseVisualStyleBackColor = False
        ' 
        ' Divi
        ' 
        Divi.BackColor = SystemColors.Highlight
        Divi.ForeColor = Color.Gold
        Divi.Location = New Point(162, 173)
        Divi.Name = "Divi"
        Divi.Size = New Size(43, 23)
        Divi.TabIndex = 18
        Divi.Text = "/"
        Divi.UseVisualStyleBackColor = False
        ' 
        ' History
        ' 
        History.BackColor = Color.AliceBlue
        History.Location = New Point(17, 258)
        History.Name = "History"
        History.Size = New Size(186, 68)
        History.TabIndex = 19
        History.Text = ""' 
        ' History_Label
        ' 
        History_Label.AutoSize = True
        History_Label.BackColor = Color.Transparent
        History_Label.ForeColor = Color.AliceBlue
        History_Label.Location = New Point(10, 240)
        History_Label.Name = "History_Label"
        History_Label.Size = New Size(45, 15)
        History_Label.TabIndex = 20
        History_Label.Text = "History"' 
        ' PM
        ' 
        PM.BackColor = Color.Red
        PM.Location = New Point(113, 55)
        PM.Name = "PM"
        PM.Size = New Size(43, 23)
        PM.TabIndex = 21
        PM.Text = "+/-"
        PM.UseVisualStyleBackColor = False
        ' 
        ' MPer
        ' 
        MPer.BackColor = SystemColors.Highlight
        MPer.ForeColor = Color.Gold
        MPer.Location = New Point(162, 55)
        MPer.Name = "MPer"
        MPer.Size = New Size(43, 23)
        MPer.TabIndex = 22
        MPer.Text = "%"
        MPer.UseVisualStyleBackColor = False
        ' 
        ' Curnt
        ' 
        Curnt.BackColor = Color.LightGoldenrodYellow
        Curnt.Location = New Point(17, 214)
        Curnt.Name = "Curnt"
        Curnt.PlaceholderText = "current"
        Curnt.RightToLeft = RightToLeft.Yes
        Curnt.Size = New Size(188, 23)
        Curnt.TabIndex = 23
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._5Cd36I1
        ClientSize = New Size(217, 338)
        Controls.Add(Curnt)
        Controls.Add(MPer)
        Controls.Add(PM)
        Controls.Add(History_Label)
        Controls.Add(History)
        Controls.Add(Divi)
        Controls.Add(Times)
        Controls.Add(Minus)
        Controls.Add(Plus)
        Controls.Add(Bksp)
        Controls.Add(Deci)
        Controls.Add(Teql)
        Controls.Add(ClrBtn)
        Controls.Add(B0)
        Controls.Add(B9)
        Controls.Add(B8)
        Controls.Add(B7)
        Controls.Add(B6)
        Controls.Add(B5)
        Controls.Add(B4)
        Controls.Add(B3)
        Controls.Add(B2)
        Controls.Add(Resultbox)
        Controls.Add(B1)
        Cursor = Cursors.Hand
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents B1 As Button
    Friend WithEvents Resultbox As TextBox
    Friend WithEvents B2 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B6 As Button
    Friend WithEvents B7 As Button
    Friend WithEvents B8 As Button
    Friend WithEvents B9 As Button
    Friend WithEvents B0 As Button
    Friend WithEvents ClrBtn As Button
    Friend WithEvents Teql As Button
    Friend WithEvents Deci As Button
    Friend WithEvents Bksp As Button
    Friend WithEvents Plus As Button
    Friend WithEvents Minus As Button
    Friend WithEvents Times As Button
    Friend WithEvents Divi As Button
    Friend WithEvents History As RichTextBox
    Friend WithEvents History_Label As Label
    Friend WithEvents PM As Button
    Friend WithEvents MPer As Button
    Friend WithEvents Curnt As TextBox
End Class
