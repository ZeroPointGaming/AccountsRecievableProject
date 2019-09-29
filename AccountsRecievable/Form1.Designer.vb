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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NewAccountNameTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CreateAccountBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LastPayDateTxt = New System.Windows.Forms.TextBox()
        Me.LastPaymentTxt = New System.Windows.Forms.TextBox()
        Me.AmmountOwedTxt = New System.Windows.Forms.TextBox()
        Me.AccountNameTxt = New System.Windows.Forms.TextBox()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DeleteLastPaymentBtn = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AddIntrestTxt = New System.Windows.Forms.TextBox()
        Me.AddPaymentTxt = New System.Windows.Forms.TextBox()
        Me.AddDebtTxt = New System.Windows.Forms.TextBox()
        Me.AddPaymentBtn = New System.Windows.Forms.Button()
        Me.AddDebtBtn = New System.Windows.Forms.Button()
        Me.AddIntrestBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 320)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accounts"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.ForeColor = System.Drawing.Color.Firebrick
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(3, 18)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(194, 299)
        Me.ListBox1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NewAccountNameTxt)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CreateAccountBtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox2.Location = New System.Drawing.Point(12, 338)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Create Account"
        '
        'NewAccountNameTxt
        '
        Me.NewAccountNameTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.NewAccountNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewAccountNameTxt.ForeColor = System.Drawing.Color.White
        Me.NewAccountNameTxt.Location = New System.Drawing.Point(7, 41)
        Me.NewAccountNameTxt.Name = "NewAccountNameTxt"
        Me.NewAccountNameTxt.Size = New System.Drawing.Size(185, 22)
        Me.NewAccountNameTxt.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Account Name:"
        '
        'CreateAccountBtn
        '
        Me.CreateAccountBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.CreateAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateAccountBtn.Location = New System.Drawing.Point(7, 70)
        Me.CreateAccountBtn.Name = "CreateAccountBtn"
        Me.CreateAccountBtn.Size = New System.Drawing.Size(185, 24)
        Me.CreateAccountBtn.TabIndex = 14
        Me.CreateAccountBtn.Text = "Create Account"
        Me.CreateAccountBtn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LastPayDateTxt)
        Me.GroupBox3.Controls.Add(Me.LastPaymentTxt)
        Me.GroupBox3.Controls.Add(Me.AmmountOwedTxt)
        Me.GroupBox3.Controls.Add(Me.AccountNameTxt)
        Me.GroupBox3.Controls.Add(Me.SettingsBtn)
        Me.GroupBox3.Controls.Add(Me.SaveBtn)
        Me.GroupBox3.Controls.Add(Me.LoadBtn)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox3.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(570, 426)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Account Information"
        '
        'LastPayDateTxt
        '
        Me.LastPayDateTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.LastPayDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastPayDateTxt.ForeColor = System.Drawing.Color.White
        Me.LastPayDateTxt.Location = New System.Drawing.Point(135, 122)
        Me.LastPayDateTxt.Name = "LastPayDateTxt"
        Me.LastPayDateTxt.Size = New System.Drawing.Size(185, 22)
        Me.LastPayDateTxt.TabIndex = 15
        '
        'LastPaymentTxt
        '
        Me.LastPaymentTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.LastPaymentTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastPaymentTxt.ForeColor = System.Drawing.Color.White
        Me.LastPaymentTxt.Location = New System.Drawing.Point(135, 89)
        Me.LastPaymentTxt.Name = "LastPaymentTxt"
        Me.LastPaymentTxt.Size = New System.Drawing.Size(185, 22)
        Me.LastPaymentTxt.TabIndex = 14
        '
        'AmmountOwedTxt
        '
        Me.AmmountOwedTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AmmountOwedTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AmmountOwedTxt.ForeColor = System.Drawing.Color.White
        Me.AmmountOwedTxt.Location = New System.Drawing.Point(135, 57)
        Me.AmmountOwedTxt.Name = "AmmountOwedTxt"
        Me.AmmountOwedTxt.Size = New System.Drawing.Size(185, 22)
        Me.AmmountOwedTxt.TabIndex = 13
        '
        'AccountNameTxt
        '
        Me.AccountNameTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AccountNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccountNameTxt.ForeColor = System.Drawing.Color.White
        Me.AccountNameTxt.Location = New System.Drawing.Point(135, 25)
        Me.AccountNameTxt.Name = "AccountNameTxt"
        Me.AccountNameTxt.Size = New System.Drawing.Size(185, 22)
        Me.AccountNameTxt.TabIndex = 12
        '
        'SettingsBtn
        '
        Me.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SettingsBtn.Location = New System.Drawing.Point(480, 18)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(24, 24)
        Me.SettingsBtn.TabIndex = 10
        Me.SettingsBtn.UseVisualStyleBackColor = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveBtn.Location = New System.Drawing.Point(510, 18)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(24, 24)
        Me.SaveBtn.TabIndex = 9
        Me.SaveBtn.Text = "S"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'LoadBtn
        '
        Me.LoadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LoadBtn.Location = New System.Drawing.Point(540, 18)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(24, 24)
        Me.LoadBtn.TabIndex = 8
        Me.LoadBtn.Text = "L"
        Me.LoadBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Last Payment Date: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last Payment: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ammount Owed: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Account Name: "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DeleteLastPaymentBtn)
        Me.GroupBox5.Controls.Add(Me.ListBox2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox5.Location = New System.Drawing.Point(6, 271)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(558, 149)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Payment History"
        '
        'DeleteLastPaymentBtn
        '
        Me.DeleteLastPaymentBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DeleteLastPaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DeleteLastPaymentBtn.Location = New System.Drawing.Point(6, 115)
        Me.DeleteLastPaymentBtn.Name = "DeleteLastPaymentBtn"
        Me.DeleteLastPaymentBtn.Size = New System.Drawing.Size(147, 28)
        Me.DeleteLastPaymentBtn.TabIndex = 15
        Me.DeleteLastPaymentBtn.Text = "Delete Last Payment"
        Me.DeleteLastPaymentBtn.UseVisualStyleBackColor = False
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.ForeColor = System.Drawing.Color.Firebrick
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.IntegralHeight = False
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(6, 17)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(546, 92)
        Me.ListBox2.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.AddIntrestTxt)
        Me.GroupBox4.Controls.Add(Me.AddPaymentTxt)
        Me.GroupBox4.Controls.Add(Me.AddDebtTxt)
        Me.GroupBox4.Controls.Add(Me.AddPaymentBtn)
        Me.GroupBox4.Controls.Add(Me.AddDebtBtn)
        Me.GroupBox4.Controls.Add(Me.AddIntrestBtn)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox4.Location = New System.Drawing.Point(6, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(558, 113)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Account Managment"
        '
        'AddIntrestTxt
        '
        Me.AddIntrestTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AddIntrestTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddIntrestTxt.ForeColor = System.Drawing.Color.White
        Me.AddIntrestTxt.Location = New System.Drawing.Point(370, 26)
        Me.AddIntrestTxt.Name = "AddIntrestTxt"
        Me.AddIntrestTxt.Size = New System.Drawing.Size(128, 22)
        Me.AddIntrestTxt.TabIndex = 16
        '
        'AddPaymentTxt
        '
        Me.AddPaymentTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AddPaymentTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddPaymentTxt.ForeColor = System.Drawing.Color.White
        Me.AddPaymentTxt.Location = New System.Drawing.Point(113, 61)
        Me.AddPaymentTxt.Name = "AddPaymentTxt"
        Me.AddPaymentTxt.Size = New System.Drawing.Size(126, 22)
        Me.AddPaymentTxt.TabIndex = 15
        '
        'AddDebtTxt
        '
        Me.AddDebtTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AddDebtTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddDebtTxt.ForeColor = System.Drawing.Color.White
        Me.AddDebtTxt.Location = New System.Drawing.Point(89, 26)
        Me.AddDebtTxt.Name = "AddDebtTxt"
        Me.AddDebtTxt.Size = New System.Drawing.Size(150, 22)
        Me.AddDebtTxt.TabIndex = 14
        '
        'AddPaymentBtn
        '
        Me.AddPaymentBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AddPaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddPaymentBtn.Location = New System.Drawing.Point(245, 60)
        Me.AddPaymentBtn.Name = "AddPaymentBtn"
        Me.AddPaymentBtn.Size = New System.Drawing.Size(24, 24)
        Me.AddPaymentBtn.TabIndex = 13
        Me.AddPaymentBtn.Text = "+"
        Me.AddPaymentBtn.UseVisualStyleBackColor = False
        '
        'AddDebtBtn
        '
        Me.AddDebtBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AddDebtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddDebtBtn.Location = New System.Drawing.Point(245, 25)
        Me.AddDebtBtn.Name = "AddDebtBtn"
        Me.AddDebtBtn.Size = New System.Drawing.Size(24, 24)
        Me.AddDebtBtn.TabIndex = 12
        Me.AddDebtBtn.Text = "+"
        Me.AddDebtBtn.UseVisualStyleBackColor = False
        '
        'AddIntrestBtn
        '
        Me.AddIntrestBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.AddIntrestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddIntrestBtn.Location = New System.Drawing.Point(504, 25)
        Me.AddIntrestBtn.Name = "AddIntrestBtn"
        Me.AddIntrestBtn.Size = New System.Drawing.Size(24, 24)
        Me.AddIntrestBtn.TabIndex = 11
        Me.AddIntrestBtn.Text = "+"
        Me.AddIntrestBtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Add Intrest:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Add Payment:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Add Debt:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Accounts Recievable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CreateAccountBtn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents LoadBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DeleteLastPaymentBtn As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents AddPaymentBtn As Button
    Friend WithEvents AddDebtBtn As Button
    Friend WithEvents AddIntrestBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NewAccountNameTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LastPayDateTxt As TextBox
    Friend WithEvents LastPaymentTxt As TextBox
    Friend WithEvents AmmountOwedTxt As TextBox
    Friend WithEvents AccountNameTxt As TextBox
    Friend WithEvents AddIntrestTxt As TextBox
    Friend WithEvents AddPaymentTxt As TextBox
    Friend WithEvents AddDebtTxt As TextBox
End Class
