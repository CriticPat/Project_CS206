<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class Login
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
    Friend WithEvents txtbUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtbPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtbUsername = New System.Windows.Forms.TextBox()
        Me.txtbPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnPassShow = New System.Windows.Forms.Button()
        Me.pctbUsername = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.pctbUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbUsername
        '
        Me.txtbUsername.Location = New System.Drawing.Point(198, 246)
        Me.txtbUsername.Name = "txtbUsername"
        Me.txtbUsername.Size = New System.Drawing.Size(220, 22)
        Me.txtbUsername.TabIndex = 1
        '
        'txtbPassword
        '
        Me.txtbPassword.HideSelection = False
        Me.txtbPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtbPassword.Location = New System.Drawing.Point(198, 292)
        Me.txtbPassword.Name = "txtbPassword"
        Me.txtbPassword.Size = New System.Drawing.Size(220, 22)
        Me.txtbPassword.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Location = New System.Drawing.Point(252, 345)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(105, 32)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(490, 23)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'btnPassShow
        '
        Me.btnPassShow.BackColor = System.Drawing.Color.Transparent
        Me.btnPassShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPassShow.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnPassShow.FlatAppearance.BorderSize = 0
        Me.btnPassShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPassShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPassShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassShow.Image = CType(resources.GetObject("btnPassShow.Image"), System.Drawing.Image)
        Me.btnPassShow.Location = New System.Drawing.Point(424, 289)
        Me.btnPassShow.Name = "btnPassShow"
        Me.btnPassShow.Size = New System.Drawing.Size(31, 25)
        Me.btnPassShow.TabIndex = 6
        Me.btnPassShow.UseVisualStyleBackColor = False
        Me.btnPassShow.Visible = False
        '
        'pctbUsername
        '
        Me.pctbUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctbUsername.BackColor = System.Drawing.Color.Transparent
        Me.pctbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctbUsername.ErrorImage = Nothing
        Me.pctbUsername.Image = CType(resources.GetObject("pctbUsername.Image"), System.Drawing.Image)
        Me.pctbUsername.InitialImage = CType(resources.GetObject("pctbUsername.InitialImage"), System.Drawing.Image)
        Me.pctbUsername.Location = New System.Drawing.Point(167, 246)
        Me.pctbUsername.Name = "pctbUsername"
        Me.pctbUsername.Size = New System.Drawing.Size(25, 25)
        Me.pctbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbUsername.TabIndex = 7
        Me.pctbUsername.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(167, 289)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(144, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(327, 218)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 420)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctbUsername)
        Me.Controls.Add(Me.btnPassShow)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtbPassword)
        Me.Controls.Add(Me.txtbUsername)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.pctbUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPassShow As Button
    Friend WithEvents pctbUsername As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents PictureBox2 As PictureBox
End Class
