<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manual
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manual))
        Me.btnPosOrigen = New System.Windows.Forms.Button()
        Me.nupMotor1 = New System.Windows.Forms.NumericUpDown()
        Me.btnMotor1 = New System.Windows.Forms.Button()
        Me.nupMotor2 = New System.Windows.Forms.NumericUpDown()
        Me.nupMotor3 = New System.Windows.Forms.NumericUpDown()
        Me.nupMotor4 = New System.Windows.Forms.NumericUpDown()
        Me.nupMotor5 = New System.Windows.Forms.NumericUpDown()
        Me.cmbVelocidad = New System.Windows.Forms.NumericUpDown()
        Me.lblVelocidad = New System.Windows.Forms.Label()
        Me.lblMotor1 = New System.Windows.Forms.Label()
        Me.lblMotor2 = New System.Windows.Forms.Label()
        Me.lblMotor3 = New System.Windows.Forms.Label()
        Me.lblMotor4 = New System.Windows.Forms.Label()
        Me.lblMotor5 = New System.Windows.Forms.Label()
        Me.lblMotor6 = New System.Windows.Forms.Label()
        Me.nupMotor6 = New System.Windows.Forms.NumericUpDown()
        Me.btnMotor2 = New System.Windows.Forms.Button()
        Me.btnMotor3 = New System.Windows.Forms.Button()
        Me.btnMotor4 = New System.Windows.Forms.Button()
        Me.btnMotor5 = New System.Windows.Forms.Button()
        Me.btnMotor6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Clock = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Clear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AumPosMotor1 = New System.Windows.Forms.Button()
        Me.DisPosMotor1 = New System.Windows.Forms.Button()
        Me.DisPosMotor2 = New System.Windows.Forms.Button()
        Me.AumPosMotor2 = New System.Windows.Forms.Button()
        Me.DisPosMotor3 = New System.Windows.Forms.Button()
        Me.AumPosMotor3 = New System.Windows.Forms.Button()
        Me.DisPosMotor4 = New System.Windows.Forms.Button()
        Me.AumPosMotor4 = New System.Windows.Forms.Button()
        Me.DisPosMotor5 = New System.Windows.Forms.Button()
        Me.AumPosMotor5 = New System.Windows.Forms.Button()
        Me.DisPosMotor6 = New System.Windows.Forms.Button()
        Me.AumPosMotor6 = New System.Windows.Forms.Button()
        Me.TextBox_IpRobot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nupMotor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMotor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMotor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMotor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMotor5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVelocidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMotor6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPosOrigen
        '
        Me.btnPosOrigen.Location = New System.Drawing.Point(46, 22)
        Me.btnPosOrigen.Name = "btnPosOrigen"
        Me.btnPosOrigen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPosOrigen.Size = New System.Drawing.Size(120, 55)
        Me.btnPosOrigen.TabIndex = 0
        Me.btnPosOrigen.Text = "Posicion Origen"
        Me.btnPosOrigen.UseVisualStyleBackColor = True
        '
        'nupMotor1
        '
        Me.nupMotor1.Location = New System.Drawing.Point(349, 26)
        Me.nupMotor1.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nupMotor1.Name = "nupMotor1"
        Me.nupMotor1.Size = New System.Drawing.Size(59, 20)
        Me.nupMotor1.TabIndex = 1
        '
        'btnMotor1
        '
        Me.btnMotor1.ForeColor = System.Drawing.Color.Black
        Me.btnMotor1.Image = CType(resources.GetObject("btnMotor1.Image"), System.Drawing.Image)
        Me.btnMotor1.Location = New System.Drawing.Point(258, 16)
        Me.btnMotor1.Name = "btnMotor1"
        Me.btnMotor1.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor1.TabIndex = 2
        Me.btnMotor1.UseVisualStyleBackColor = True
        '
        'nupMotor2
        '
        Me.nupMotor2.Location = New System.Drawing.Point(349, 75)
        Me.nupMotor2.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nupMotor2.Name = "nupMotor2"
        Me.nupMotor2.Size = New System.Drawing.Size(59, 20)
        Me.nupMotor2.TabIndex = 7
        '
        'nupMotor3
        '
        Me.nupMotor3.Location = New System.Drawing.Point(349, 124)
        Me.nupMotor3.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nupMotor3.Name = "nupMotor3"
        Me.nupMotor3.Size = New System.Drawing.Size(59, 20)
        Me.nupMotor3.TabIndex = 8
        '
        'nupMotor4
        '
        Me.nupMotor4.Location = New System.Drawing.Point(349, 173)
        Me.nupMotor4.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nupMotor4.Name = "nupMotor4"
        Me.nupMotor4.Size = New System.Drawing.Size(59, 20)
        Me.nupMotor4.TabIndex = 9
        '
        'nupMotor5
        '
        Me.nupMotor5.Location = New System.Drawing.Point(349, 222)
        Me.nupMotor5.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nupMotor5.Name = "nupMotor5"
        Me.nupMotor5.Size = New System.Drawing.Size(59, 20)
        Me.nupMotor5.TabIndex = 10
        '
        'cmbVelocidad
        '
        Me.cmbVelocidad.Location = New System.Drawing.Point(46, 98)
        Me.cmbVelocidad.Name = "cmbVelocidad"
        Me.cmbVelocidad.Size = New System.Drawing.Size(120, 20)
        Me.cmbVelocidad.TabIndex = 11
        '
        'lblVelocidad
        '
        Me.lblVelocidad.AutoSize = True
        Me.lblVelocidad.Location = New System.Drawing.Point(79, 129)
        Me.lblVelocidad.Name = "lblVelocidad"
        Me.lblVelocidad.Size = New System.Drawing.Size(54, 13)
        Me.lblVelocidad.TabIndex = 12
        Me.lblVelocidad.Text = "Velocidad"
        '
        'lblMotor1
        '
        Me.lblMotor1.AutoSize = True
        Me.lblMotor1.Location = New System.Drawing.Point(310, 30)
        Me.lblMotor1.Name = "lblMotor1"
        Me.lblMotor1.Size = New System.Drawing.Size(31, 13)
        Me.lblMotor1.TabIndex = 13
        Me.lblMotor1.Text = "Eje 1"
        '
        'lblMotor2
        '
        Me.lblMotor2.AutoSize = True
        Me.lblMotor2.Location = New System.Drawing.Point(310, 79)
        Me.lblMotor2.Name = "lblMotor2"
        Me.lblMotor2.Size = New System.Drawing.Size(31, 13)
        Me.lblMotor2.TabIndex = 14
        Me.lblMotor2.Text = "Eje 2"
        '
        'lblMotor3
        '
        Me.lblMotor3.AutoSize = True
        Me.lblMotor3.Location = New System.Drawing.Point(310, 128)
        Me.lblMotor3.Name = "lblMotor3"
        Me.lblMotor3.Size = New System.Drawing.Size(31, 13)
        Me.lblMotor3.TabIndex = 15
        Me.lblMotor3.Text = "Eje 3"
        '
        'lblMotor4
        '
        Me.lblMotor4.AutoSize = True
        Me.lblMotor4.Location = New System.Drawing.Point(310, 177)
        Me.lblMotor4.Name = "lblMotor4"
        Me.lblMotor4.Size = New System.Drawing.Size(31, 13)
        Me.lblMotor4.TabIndex = 16
        Me.lblMotor4.Text = "Eje 4"
        '
        'lblMotor5
        '
        Me.lblMotor5.AutoSize = True
        Me.lblMotor5.Location = New System.Drawing.Point(310, 226)
        Me.lblMotor5.Name = "lblMotor5"
        Me.lblMotor5.Size = New System.Drawing.Size(31, 13)
        Me.lblMotor5.TabIndex = 17
        Me.lblMotor5.Text = "Eje 5"
        '
        'lblMotor6
        '
        Me.lblMotor6.AutoSize = True
        Me.lblMotor6.Location = New System.Drawing.Point(310, 275)
        Me.lblMotor6.Name = "lblMotor6"
        Me.lblMotor6.Size = New System.Drawing.Size(31, 13)
        Me.lblMotor6.TabIndex = 20
        Me.lblMotor6.Text = "Eje 6"
        '
        'nupMotor6
        '
        Me.nupMotor6.Location = New System.Drawing.Point(349, 271)
        Me.nupMotor6.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nupMotor6.Name = "nupMotor6"
        Me.nupMotor6.Size = New System.Drawing.Size(59, 20)
        Me.nupMotor6.TabIndex = 19
        '
        'btnMotor2
        '
        Me.btnMotor2.ForeColor = System.Drawing.Color.Black
        Me.btnMotor2.Image = CType(resources.GetObject("btnMotor2.Image"), System.Drawing.Image)
        Me.btnMotor2.Location = New System.Drawing.Point(258, 65)
        Me.btnMotor2.Name = "btnMotor2"
        Me.btnMotor2.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor2.TabIndex = 21
        Me.btnMotor2.UseVisualStyleBackColor = True
        '
        'btnMotor3
        '
        Me.btnMotor3.ForeColor = System.Drawing.Color.Black
        Me.btnMotor3.Image = CType(resources.GetObject("btnMotor3.Image"), System.Drawing.Image)
        Me.btnMotor3.Location = New System.Drawing.Point(258, 114)
        Me.btnMotor3.Name = "btnMotor3"
        Me.btnMotor3.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor3.TabIndex = 22
        Me.btnMotor3.UseVisualStyleBackColor = True
        '
        'btnMotor4
        '
        Me.btnMotor4.ForeColor = System.Drawing.Color.Black
        Me.btnMotor4.Image = CType(resources.GetObject("btnMotor4.Image"), System.Drawing.Image)
        Me.btnMotor4.Location = New System.Drawing.Point(258, 163)
        Me.btnMotor4.Name = "btnMotor4"
        Me.btnMotor4.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor4.TabIndex = 23
        Me.btnMotor4.UseVisualStyleBackColor = True
        '
        'btnMotor5
        '
        Me.btnMotor5.ForeColor = System.Drawing.Color.Black
        Me.btnMotor5.Image = CType(resources.GetObject("btnMotor5.Image"), System.Drawing.Image)
        Me.btnMotor5.Location = New System.Drawing.Point(258, 212)
        Me.btnMotor5.Name = "btnMotor5"
        Me.btnMotor5.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor5.TabIndex = 24
        Me.btnMotor5.UseVisualStyleBackColor = True
        '
        'btnMotor6
        '
        Me.btnMotor6.ForeColor = System.Drawing.Color.Black
        Me.btnMotor6.Image = CType(resources.GetObject("btnMotor6.Image"), System.Drawing.Image)
        Me.btnMotor6.Location = New System.Drawing.Point(258, 261)
        Me.btnMotor6.Name = "btnMotor6"
        Me.btnMotor6.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor6.TabIndex = 25
        Me.btnMotor6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(37, 223)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 26
        '
        'Clock
        '
        Me.Clock.Location = New System.Drawing.Point(82, 157)
        Me.Clock.Name = "Clock"
        Me.Clock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Clock.Size = New System.Drawing.Size(48, 55)
        Me.Clock.TabIndex = 27
        Me.Clock.Text = "Clock"
        Me.Clock.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(29, 259)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 28
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AumPosMotor1
        '
        Me.AumPosMotor1.Location = New System.Drawing.Point(433, 21)
        Me.AumPosMotor1.Name = "AumPosMotor1"
        Me.AumPosMotor1.Size = New System.Drawing.Size(30, 30)
        Me.AumPosMotor1.TabIndex = 30
        Me.AumPosMotor1.Text = "+"
        Me.AumPosMotor1.UseVisualStyleBackColor = True
        '
        'DisPosMotor1
        '
        Me.DisPosMotor1.Location = New System.Drawing.Point(475, 21)
        Me.DisPosMotor1.Name = "DisPosMotor1"
        Me.DisPosMotor1.Size = New System.Drawing.Size(30, 30)
        Me.DisPosMotor1.TabIndex = 31
        Me.DisPosMotor1.Text = "-"
        Me.DisPosMotor1.UseVisualStyleBackColor = True
        '
        'DisPosMotor2
        '
        Me.DisPosMotor2.Location = New System.Drawing.Point(475, 70)
        Me.DisPosMotor2.Name = "DisPosMotor2"
        Me.DisPosMotor2.Size = New System.Drawing.Size(30, 30)
        Me.DisPosMotor2.TabIndex = 33
        Me.DisPosMotor2.Text = "-"
        Me.DisPosMotor2.UseVisualStyleBackColor = True
        '
        'AumPosMotor2
        '
        Me.AumPosMotor2.Location = New System.Drawing.Point(433, 70)
        Me.AumPosMotor2.Name = "AumPosMotor2"
        Me.AumPosMotor2.Size = New System.Drawing.Size(30, 30)
        Me.AumPosMotor2.TabIndex = 32
        Me.AumPosMotor2.Text = "+"
        Me.AumPosMotor2.UseVisualStyleBackColor = True
        '
        'DisPosMotor3
        '
        Me.DisPosMotor3.Location = New System.Drawing.Point(475, 119)
        Me.DisPosMotor3.Name = "DisPosMotor3"
        Me.DisPosMotor3.Size = New System.Drawing.Size(30, 30)
        Me.DisPosMotor3.TabIndex = 35
        Me.DisPosMotor3.Text = "-"
        Me.DisPosMotor3.UseVisualStyleBackColor = True
        '
        'AumPosMotor3
        '
        Me.AumPosMotor3.Location = New System.Drawing.Point(433, 119)
        Me.AumPosMotor3.Name = "AumPosMotor3"
        Me.AumPosMotor3.Size = New System.Drawing.Size(30, 30)
        Me.AumPosMotor3.TabIndex = 34
        Me.AumPosMotor3.Text = "+"
        Me.AumPosMotor3.UseVisualStyleBackColor = True
        '
        'DisPosMotor4
        '
        Me.DisPosMotor4.Location = New System.Drawing.Point(475, 168)
        Me.DisPosMotor4.Name = "DisPosMotor4"
        Me.DisPosMotor4.Size = New System.Drawing.Size(30, 30)
        Me.DisPosMotor4.TabIndex = 37
        Me.DisPosMotor4.Text = "-"
        Me.DisPosMotor4.UseVisualStyleBackColor = True
        '
        'AumPosMotor4
        '
        Me.AumPosMotor4.Location = New System.Drawing.Point(433, 168)
        Me.AumPosMotor4.Name = "AumPosMotor4"
        Me.AumPosMotor4.Size = New System.Drawing.Size(30, 30)
        Me.AumPosMotor4.TabIndex = 36
        Me.AumPosMotor4.Text = "+"
        Me.AumPosMotor4.UseVisualStyleBackColor = True
        '
        'DisPosMotor5
        '
        Me.DisPosMotor5.Location = New System.Drawing.Point(475, 217)
        Me.DisPosMotor5.Name = "DisPosMotor5"
        Me.DisPosMotor5.Size = New System.Drawing.Size(30, 30)
        Me.DisPosMotor5.TabIndex = 39
        Me.DisPosMotor5.Text = "-"
        Me.DisPosMotor5.UseVisualStyleBackColor = True
        '
        'AumPosMotor5
        '
        Me.AumPosMotor5.Location = New System.Drawing.Point(433, 217)
        Me.AumPosMotor5.Name = "AumPosMotor5"
        Me.AumPosMotor5.Size = New System.Drawing.Size(30, 30)
        Me.AumPosMotor5.TabIndex = 38
        Me.AumPosMotor5.Text = "+"
        Me.AumPosMotor5.UseVisualStyleBackColor = True
        '
        'DisPosMotor6
        '
        Me.DisPosMotor6.Location = New System.Drawing.Point(475, 266)
        Me.DisPosMotor6.Name = "DisPosMotor6"
        Me.DisPosMotor6.Size = New System.Drawing.Size(30, 30)
        Me.DisPosMotor6.TabIndex = 41
        Me.DisPosMotor6.Text = "-"
        Me.DisPosMotor6.UseVisualStyleBackColor = True
        '
        'AumPosMotor6
        '
        Me.AumPosMotor6.Location = New System.Drawing.Point(433, 266)
        Me.AumPosMotor6.Name = "AumPosMotor6"
        Me.AumPosMotor6.Size = New System.Drawing.Size(30, 30)
        Me.AumPosMotor6.TabIndex = 40
        Me.AumPosMotor6.Text = "+"
        Me.AumPosMotor6.UseVisualStyleBackColor = True
        '
        'TextBox_IpRobot
        '
        Me.TextBox_IpRobot.Location = New System.Drawing.Point(64, 298)
        Me.TextBox_IpRobot.Name = "TextBox_IpRobot"
        Me.TextBox_IpRobot.Size = New System.Drawing.Size(139, 20)
        Me.TextBox_IpRobot.TabIndex = 42
        Me.TextBox_IpRobot.Text = "192.168.0.177"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "IP:"
        '
        'Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 388)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_IpRobot)
        Me.Controls.Add(Me.DisPosMotor6)
        Me.Controls.Add(Me.AumPosMotor6)
        Me.Controls.Add(Me.DisPosMotor5)
        Me.Controls.Add(Me.AumPosMotor5)
        Me.Controls.Add(Me.DisPosMotor4)
        Me.Controls.Add(Me.AumPosMotor4)
        Me.Controls.Add(Me.DisPosMotor3)
        Me.Controls.Add(Me.AumPosMotor3)
        Me.Controls.Add(Me.DisPosMotor2)
        Me.Controls.Add(Me.AumPosMotor2)
        Me.Controls.Add(Me.DisPosMotor1)
        Me.Controls.Add(Me.AumPosMotor1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Clock)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnMotor6)
        Me.Controls.Add(Me.btnMotor5)
        Me.Controls.Add(Me.btnMotor4)
        Me.Controls.Add(Me.btnMotor3)
        Me.Controls.Add(Me.btnMotor2)
        Me.Controls.Add(Me.lblMotor6)
        Me.Controls.Add(Me.nupMotor6)
        Me.Controls.Add(Me.lblMotor5)
        Me.Controls.Add(Me.lblMotor4)
        Me.Controls.Add(Me.lblMotor3)
        Me.Controls.Add(Me.lblMotor2)
        Me.Controls.Add(Me.lblMotor1)
        Me.Controls.Add(Me.lblVelocidad)
        Me.Controls.Add(Me.cmbVelocidad)
        Me.Controls.Add(Me.nupMotor5)
        Me.Controls.Add(Me.nupMotor4)
        Me.Controls.Add(Me.nupMotor3)
        Me.Controls.Add(Me.nupMotor2)
        Me.Controls.Add(Me.btnMotor1)
        Me.Controls.Add(Me.nupMotor1)
        Me.Controls.Add(Me.btnPosOrigen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Manual"
        Me.Text = "Manual"
        CType(Me.nupMotor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMotor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMotor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMotor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMotor5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVelocidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMotor6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPosOrigen As System.Windows.Forms.Button
    Friend WithEvents nupMotor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnMotor1 As System.Windows.Forms.Button
    Friend WithEvents nupMotor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupMotor3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupMotor4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupMotor5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbVelocidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblVelocidad As System.Windows.Forms.Label
    Friend WithEvents lblMotor1 As System.Windows.Forms.Label
    Friend WithEvents lblMotor2 As System.Windows.Forms.Label
    Friend WithEvents lblMotor3 As System.Windows.Forms.Label
    Friend WithEvents lblMotor4 As System.Windows.Forms.Label
    Friend WithEvents lblMotor5 As System.Windows.Forms.Label
    Friend WithEvents lblMotor6 As System.Windows.Forms.Label
    Friend WithEvents nupMotor6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnMotor2 As System.Windows.Forms.Button
    Friend WithEvents btnMotor3 As System.Windows.Forms.Button
    Friend WithEvents btnMotor4 As System.Windows.Forms.Button
    Friend WithEvents btnMotor5 As System.Windows.Forms.Button
    Friend WithEvents btnMotor6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Clock As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AumPosMotor1 As Button
    Friend WithEvents DisPosMotor1 As Button
    Friend WithEvents DisPosMotor2 As Button
    Friend WithEvents AumPosMotor2 As Button
    Friend WithEvents DisPosMotor3 As Button
    Friend WithEvents AumPosMotor3 As Button
    Friend WithEvents DisPosMotor4 As Button
    Friend WithEvents AumPosMotor4 As Button
    Friend WithEvents DisPosMotor5 As Button
    Friend WithEvents AumPosMotor5 As Button
    Friend WithEvents DisPosMotor6 As Button
    Friend WithEvents AumPosMotor6 As Button
    Friend WithEvents TextBox_IpRobot As TextBox
    Friend WithEvents Label1 As Label
End Class
