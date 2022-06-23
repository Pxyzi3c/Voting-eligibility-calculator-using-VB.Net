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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.btnGreet = New System.Windows.Forms.Button()
        Me.txtGreeting = New System.Windows.Forms.TextBox()
        Me.lblGreetings = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.picLogo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 50)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "HARVY JONES PONTILLAS (DICT22)"
        '
        'btnMinimize
        '
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = Global.LaboratoryExercise2.My.Resources.Resources.minimizeIcon
        Me.btnMinimize.Location = New System.Drawing.Point(635, 9)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.LaboratoryExercise2.My.Resources.Resources.closeIcon
        Me.btnClose.Location = New System.Drawing.Point(674, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 536)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(386, 11)
        Me.Panel2.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(49, 129)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(58, 21)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.txtName.Location = New System.Drawing.Point(51, 152)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(306, 40)
        Me.txtName.TabIndex = 4
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGender.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.txtGender.Location = New System.Drawing.Point(51, 229)
        Me.txtGender.Multiline = True
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(141, 40)
        Me.txtGender.TabIndex = 6
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(49, 207)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(116, 21)
        Me.lblGender.TabIndex = 5
        Me.lblGender.Text = "Gender (M/F)"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAge.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.txtAge.Location = New System.Drawing.Point(216, 229)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(141, 40)
        Me.txtAge.TabIndex = 8
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAge.Location = New System.Drawing.Point(213, 207)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(44, 21)
        Me.lblAge.TabIndex = 7
        Me.lblAge.Text = "Age"
        '
        'btnGreet
        '
        Me.btnGreet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGreet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGreet.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGreet.ForeColor = System.Drawing.Color.White
        Me.btnGreet.Location = New System.Drawing.Point(51, 309)
        Me.btnGreet.Name = "btnGreet"
        Me.btnGreet.Size = New System.Drawing.Size(306, 40)
        Me.btnGreet.TabIndex = 9
        Me.btnGreet.Text = "Greet"
        Me.btnGreet.UseVisualStyleBackColor = True
        '
        'txtGreeting
        '
        Me.txtGreeting.BackColor = System.Drawing.Color.White
        Me.txtGreeting.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGreeting.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGreeting.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.txtGreeting.Location = New System.Drawing.Point(392, 172)
        Me.txtGreeting.Multiline = True
        Me.txtGreeting.Name = "txtGreeting"
        Me.txtGreeting.Size = New System.Drawing.Size(318, 97)
        Me.txtGreeting.TabIndex = 11
        Me.txtGreeting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGreetings
        '
        Me.lblGreetings.AutoSize = True
        Me.lblGreetings.BackColor = System.Drawing.Color.White
        Me.lblGreetings.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGreetings.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblGreetings.Location = New System.Drawing.Point(497, 80)
        Me.lblGreetings.Name = "lblGreetings"
        Me.lblGreetings.Size = New System.Drawing.Size(107, 24)
        Me.lblGreetings.TabIndex = 10
        Me.lblGreetings.Text = "Greetings"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(49, 385)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(308, 40)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(392, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(318, 147)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel4.Location = New System.Drawing.Point(29, 84)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(260, 1)
        Me.Panel4.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.LaboratoryExercise2.My.Resources.Resources.cheering_people
        Me.PictureBox1.Location = New System.Drawing.Point(392, 229)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(318, 306)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.LaboratoryExercise2.My.Resources.Resources.Group_5
        Me.picLogo.Location = New System.Drawing.Point(10, 4)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(40, 40)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 14
        Me.picLogo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BackgroundImage = Global.LaboratoryExercise2.My.Resources.Resources.ranger_4df6c1b6
        Me.ClientSize = New System.Drawing.Size(710, 547)
        Me.Controls.Add(Me.txtGreeting)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblGreetings)
        Me.Controls.Add(Me.btnGreet)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "HARVY JONES PONTILLAS (DICT 22)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents btnGreet As Button
    Friend WithEvents txtGreeting As TextBox
    Friend WithEvents lblGreetings As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picLogo As PictureBox
End Class
