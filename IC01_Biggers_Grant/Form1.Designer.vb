<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.BtnEq = New System.Windows.Forms.Button()
        Me.BtnPer = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.BtnPM = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.BtnP = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.BtnM = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.BtnX = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(312, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'btn1
        '
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(12, 326)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(68, 68)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(13, 52)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(13, 13)
        Me.lblDisplay.TabIndex = 2
        Me.lblDisplay.Text = "0"
        '
        'Btn2
        '
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.Location = New System.Drawing.Point(86, 326)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(68, 68)
        Me.Btn2.TabIndex = 3
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'BtnEq
        '
        Me.BtnEq.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEq.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEq.Location = New System.Drawing.Point(232, 400)
        Me.BtnEq.Name = "BtnEq"
        Me.BtnEq.Size = New System.Drawing.Size(68, 68)
        Me.BtnEq.TabIndex = 4
        Me.BtnEq.Text = "="
        Me.BtnEq.UseVisualStyleBackColor = True
        '
        'BtnPer
        '
        Me.BtnPer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPer.Location = New System.Drawing.Point(160, 400)
        Me.BtnPer.Name = "BtnPer"
        Me.BtnPer.Size = New System.Drawing.Size(68, 68)
        Me.BtnPer.TabIndex = 5
        Me.BtnPer.Text = "."
        Me.BtnPer.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.Location = New System.Drawing.Point(160, 326)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(68, 68)
        Me.Btn3.TabIndex = 6
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'BtnPM
        '
        Me.BtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPM.Location = New System.Drawing.Point(12, 400)
        Me.BtnPM.Name = "BtnPM"
        Me.BtnPM.Size = New System.Drawing.Size(68, 68)
        Me.BtnPM.TabIndex = 7
        Me.BtnPM.Text = "+/-"
        Me.BtnPM.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.Location = New System.Drawing.Point(86, 400)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(68, 68)
        Me.Btn0.TabIndex = 8
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.Location = New System.Drawing.Point(12, 252)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(68, 68)
        Me.Btn4.TabIndex = 9
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'BtnP
        '
        Me.BtnP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnP.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnP.Location = New System.Drawing.Point(232, 326)
        Me.BtnP.Name = "BtnP"
        Me.BtnP.Size = New System.Drawing.Size(68, 68)
        Me.BtnP.TabIndex = 10
        Me.BtnP.Text = "+"
        Me.BtnP.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.Location = New System.Drawing.Point(86, 252)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(68, 68)
        Me.Btn5.TabIndex = 11
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.Location = New System.Drawing.Point(160, 252)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(68, 68)
        Me.Btn6.TabIndex = 12
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'BtnM
        '
        Me.BtnM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnM.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnM.Location = New System.Drawing.Point(232, 252)
        Me.BtnM.Name = "BtnM"
        Me.BtnM.Size = New System.Drawing.Size(68, 68)
        Me.BtnM.TabIndex = 13
        Me.BtnM.Text = "-"
        Me.BtnM.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.Location = New System.Drawing.Point(12, 178)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(68, 68)
        Me.Btn7.TabIndex = 14
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.Location = New System.Drawing.Point(86, 178)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(68, 68)
        Me.Btn8.TabIndex = 15
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.Location = New System.Drawing.Point(160, 178)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(68, 68)
        Me.Btn9.TabIndex = 16
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'BtnX
        '
        Me.BtnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnX.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnX.Location = New System.Drawing.Point(232, 178)
        Me.BtnX.Name = "BtnX"
        Me.BtnX.Size = New System.Drawing.Size(68, 68)
        Me.BtnX.TabIndex = 17
        Me.BtnX.Text = "x"
        Me.BtnX.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 480)
        Me.Controls.Add(Me.BtnX)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.BtnM)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.BtnP)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn0)
        Me.Controls.Add(Me.BtnPM)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.BtnPer)
        Me.Controls.Add(Me.BtnEq)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btn1 As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents Btn2 As Button
    Friend WithEvents BtnEq As Button
    Friend WithEvents BtnPer As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents BtnPM As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents BtnP As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents BtnM As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents BtnX As Button
End Class
