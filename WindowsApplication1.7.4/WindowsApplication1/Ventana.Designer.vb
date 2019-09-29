<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventana
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControlManual = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnHab_Man = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMotor1 = New System.Windows.Forms.Button()
        Me.nupMotor1Man = New System.Windows.Forms.NumericUpDown()
        Me.nupMotor2Man = New System.Windows.Forms.NumericUpDown()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.DisPosMotor6 = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.nupMotor3Man = New System.Windows.Forms.NumericUpDown()
        Me.Clock = New System.Windows.Forms.Button()
        Me.AumPosMotor6 = New System.Windows.Forms.Button()
        Me.PrevManual = New System.Windows.Forms.TextBox()
        Me.nupMotor4Man = New System.Windows.Forms.NumericUpDown()
        Me.lblVelocidad = New System.Windows.Forms.Label()
        Me.DisPosMotor5 = New System.Windows.Forms.Button()
        Me.cmbVelocidadMan = New System.Windows.Forms.NumericUpDown()
        Me.nupMotor5Man = New System.Windows.Forms.NumericUpDown()
        Me.btnPosOrigenMan = New System.Windows.Forms.Button()
        Me.AumPosMotor5 = New System.Windows.Forms.Button()
        Me.lblMotor1 = New System.Windows.Forms.Label()
        Me.DisPosMotor4 = New System.Windows.Forms.Button()
        Me.lblMotor2 = New System.Windows.Forms.Label()
        Me.AumPosMotor4 = New System.Windows.Forms.Button()
        Me.lblMotor3 = New System.Windows.Forms.Label()
        Me.DisPosMotor3 = New System.Windows.Forms.Button()
        Me.lblMotor4 = New System.Windows.Forms.Label()
        Me.AumPosMotor3 = New System.Windows.Forms.Button()
        Me.lblMotor5 = New System.Windows.Forms.Label()
        Me.DisPosMotor2 = New System.Windows.Forms.Button()
        Me.nupMotor6Man = New System.Windows.Forms.NumericUpDown()
        Me.AumPosMotor2 = New System.Windows.Forms.Button()
        Me.lblMotor6 = New System.Windows.Forms.Label()
        Me.DisPosMotor1 = New System.Windows.Forms.Button()
        Me.btnMotor2 = New System.Windows.Forms.Button()
        Me.AumPosMotor1 = New System.Windows.Forms.Button()
        Me.btnMotor3 = New System.Windows.Forms.Button()
        Me.btnMotor4 = New System.Windows.Forms.Button()
        Me.btnMotor5 = New System.Windows.Forms.Button()
        Me.btnMotor6 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabHome = New System.Windows.Forms.TabPage()
        Me.tboxHomeEstadoEJE6 = New System.Windows.Forms.TextBox()
        Me.tboxHomeEstadoEJE3 = New System.Windows.Forms.TextBox()
        Me.tboxHomeEstadoEJE5 = New System.Windows.Forms.TextBox()
        Me.tboxHomeEstadoEJE2 = New System.Windows.Forms.TextBox()
        Me.tboxHomeEstadoEJE4 = New System.Windows.Forms.TextBox()
        Me.tboxHomeEstadoEJE1 = New System.Windows.Forms.TextBox()
        Me.lblPinza = New System.Windows.Forms.Label()
        Me.lblMano = New System.Windows.Forms.Label()
        Me.lblMuñeca = New System.Windows.Forms.Label()
        Me.lblCodo = New System.Windows.Forms.Label()
        Me.lblHombro = New System.Windows.Forms.Label()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.EstadoPingRobot = New System.Windows.Forms.PictureBox()
        Me.EstadoIP_Robot = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnTabSec = New System.Windows.Forms.Button()
        Me.btnDesrollador = New System.Windows.Forms.Button()
        Me.BtnTabConfig = New System.Windows.Forms.Button()
        Me.BtnTabJOG = New System.Windows.Forms.Button()
        Me.BtnTabHome = New System.Windows.Forms.Button()
        Me.BtnTabCtrlManual = New System.Windows.Forms.Button()
        Me.Screens = New System.Windows.Forms.TabControl()
        Me.TabJOG = New System.Windows.Forms.TabPage()
        Me.btnGripperOFF = New System.Windows.Forms.Button()
        Me.btnGripperON = New System.Windows.Forms.Button()
        Me.FlechaVelJOGJoy = New System.Windows.Forms.PictureBox()
        Me.btnGuardarSec = New System.Windows.Forms.Button()
        Me.btnGuardarMov = New System.Windows.Forms.Button()
        Me.btnPosOrigenJOG = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tboxJOGEstadoEJE6 = New System.Windows.Forms.TextBox()
        Me.tboxJOGEstadoEJE5 = New System.Windows.Forms.TextBox()
        Me.tboxJOGEstadoEJE4 = New System.Windows.Forms.TextBox()
        Me.tboxJOGEstadoEJE3 = New System.Windows.Forms.TextBox()
        Me.tboxJOGEstadoEJE2 = New System.Windows.Forms.TextBox()
        Me.tboxJOGEstadoEJE1 = New System.Windows.Forms.TextBox()
        Me.btnE6_NEG_JOG = New System.Windows.Forms.Button()
        Me.btnE6_POS_JOG = New System.Windows.Forms.Button()
        Me.btnE5_NEG_JOG = New System.Windows.Forms.Button()
        Me.btnE5_POS_JOG = New System.Windows.Forms.Button()
        Me.btnE4_NEG_JOG = New System.Windows.Forms.Button()
        Me.btnE4_POS_JOG = New System.Windows.Forms.Button()
        Me.btnE3_NEG_JOG = New System.Windows.Forms.Button()
        Me.btnE3_POS_JOG = New System.Windows.Forms.Button()
        Me.btnE2_NEG_JOG = New System.Windows.Forms.Button()
        Me.btnE2_POS_JOG = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbVelocidadJOG6 = New System.Windows.Forms.NumericUpDown()
        Me.cmbVelocidadJOG5 = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbVelocidadJOG4 = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbVelocidadJOG3 = New System.Windows.Forms.NumericUpDown()
        Me.cmbVelocidadJOG2 = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbVelocidadJOG1 = New System.Windows.Forms.NumericUpDown()
        Me.lblHabilitar_Jog = New System.Windows.Forms.Label()
        Me.btnHabJOG = New System.Windows.Forms.Button()
        Me.btnE1_NEG_JOG = New System.Windows.Forms.Button()
        Me.btnE1_POS_JOG = New System.Windows.Forms.Button()
        Me.TabConfiguracion = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBox_PortRobot = New System.Windows.Forms.TextBox()
        Me.BtnConnectRobot = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TBox_IpRobot = New System.Windows.Forms.TextBox()
        Me.BtnDesconectar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbStepEje6 = New System.Windows.Forms.ComboBox()
        Me.cmbStepEje5 = New System.Windows.Forms.ComboBox()
        Me.cmbStepEje4 = New System.Windows.Forms.ComboBox()
        Me.cmbStepEje3 = New System.Windows.Forms.ComboBox()
        Me.cmbStepEje2 = New System.Windows.Forms.ComboBox()
        Me.cmbStepEje1 = New System.Windows.Forms.ComboBox()
        Me.btnCargarConf = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TabSecuencia = New System.Windows.Forms.TabPage()
        Me.lboxSecAct = New System.Windows.Forms.ListBox()
        Me.ListSEC_Select = New System.Windows.Forms.ListBox()
        Me.btnCamDirSEC = New System.Windows.Forms.Button()
        Me.btnEjecSec = New System.Windows.Forms.Button()
        Me.btnPararSec = New System.Windows.Forms.Button()
        Me.tboxNomSecAct = New System.Windows.Forms.RichTextBox()
        Me.btnCrearSec = New System.Windows.Forms.Button()
        Me.btnCargarSec = New System.Windows.Forms.Button()
        Me.tboxSecAct = New System.Windows.Forms.RichTextBox()
        Me.TabDesarrollador = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LabelJOY7 = New System.Windows.Forms.Label()
        Me.LabelJOY6 = New System.Windows.Forms.Label()
        Me.LabelJOY5 = New System.Windows.Forms.Label()
        Me.LabelJOY4 = New System.Windows.Forms.Label()
        Me.LabelJOY3 = New System.Windows.Forms.Label()
        Me.LabelJOY2 = New System.Windows.Forms.Label()
        Me.LabelJOY1 = New System.Windows.Forms.Label()
        Me.tboxModoAct = New System.Windows.Forms.RichTextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GRE_LED_Mode = New System.Windows.Forms.PictureBox()
        Me.YEL_LED_Mode = New System.Windows.Forms.PictureBox()
        Me.RED_LED_Mode = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtSecCarg = New System.Windows.Forms.OpenFileDialog()
        Me.SaveSec = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserSEC = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProgressBarGripper = New System.Windows.Forms.ProgressBar()
        Me.TabControlManual.SuspendLayout()
        CType(Me.nupMotor1Man, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMotor2Man, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMotor3Man, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMotor4Man, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVelocidadMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMotor5Man, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupMotor6Man, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabHome.SuspendLayout()
        CType(Me.EstadoPingRobot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Screens.SuspendLayout()
        Me.TabJOG.SuspendLayout()
        CType(Me.FlechaVelJOGJoy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVelocidadJOG6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVelocidadJOG5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVelocidadJOG4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVelocidadJOG3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVelocidadJOG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVelocidadJOG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConfiguracion.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabSecuencia.SuspendLayout()
        Me.TabDesarrollador.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GRE_LED_Mode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YEL_LED_Mode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RED_LED_Mode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'TabControlManual
        '
        Me.TabControlManual.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabControlManual.Controls.Add(Me.Label3)
        Me.TabControlManual.Controls.Add(Me.Label28)
        Me.TabControlManual.Controls.Add(Me.btnHab_Man)
        Me.TabControlManual.Controls.Add(Me.Label2)
        Me.TabControlManual.Controls.Add(Me.btnMotor1)
        Me.TabControlManual.Controls.Add(Me.nupMotor1Man)
        Me.TabControlManual.Controls.Add(Me.nupMotor2Man)
        Me.TabControlManual.Controls.Add(Me.BtnSend)
        Me.TabControlManual.Controls.Add(Me.DisPosMotor6)
        Me.TabControlManual.Controls.Add(Me.Clear)
        Me.TabControlManual.Controls.Add(Me.nupMotor3Man)
        Me.TabControlManual.Controls.Add(Me.Clock)
        Me.TabControlManual.Controls.Add(Me.AumPosMotor6)
        Me.TabControlManual.Controls.Add(Me.PrevManual)
        Me.TabControlManual.Controls.Add(Me.nupMotor4Man)
        Me.TabControlManual.Controls.Add(Me.lblVelocidad)
        Me.TabControlManual.Controls.Add(Me.DisPosMotor5)
        Me.TabControlManual.Controls.Add(Me.cmbVelocidadMan)
        Me.TabControlManual.Controls.Add(Me.nupMotor5Man)
        Me.TabControlManual.Controls.Add(Me.btnPosOrigenMan)
        Me.TabControlManual.Controls.Add(Me.AumPosMotor5)
        Me.TabControlManual.Controls.Add(Me.lblMotor1)
        Me.TabControlManual.Controls.Add(Me.DisPosMotor4)
        Me.TabControlManual.Controls.Add(Me.lblMotor2)
        Me.TabControlManual.Controls.Add(Me.AumPosMotor4)
        Me.TabControlManual.Controls.Add(Me.lblMotor3)
        Me.TabControlManual.Controls.Add(Me.DisPosMotor3)
        Me.TabControlManual.Controls.Add(Me.lblMotor4)
        Me.TabControlManual.Controls.Add(Me.AumPosMotor3)
        Me.TabControlManual.Controls.Add(Me.lblMotor5)
        Me.TabControlManual.Controls.Add(Me.DisPosMotor2)
        Me.TabControlManual.Controls.Add(Me.nupMotor6Man)
        Me.TabControlManual.Controls.Add(Me.AumPosMotor2)
        Me.TabControlManual.Controls.Add(Me.lblMotor6)
        Me.TabControlManual.Controls.Add(Me.DisPosMotor1)
        Me.TabControlManual.Controls.Add(Me.btnMotor2)
        Me.TabControlManual.Controls.Add(Me.AumPosMotor1)
        Me.TabControlManual.Controls.Add(Me.btnMotor3)
        Me.TabControlManual.Controls.Add(Me.btnMotor4)
        Me.TabControlManual.Controls.Add(Me.btnMotor5)
        Me.TabControlManual.Controls.Add(Me.btnMotor6)
        Me.TabControlManual.Controls.Add(Me.Panel1)
        Me.TabControlManual.Location = New System.Drawing.Point(4, 27)
        Me.TabControlManual.Name = "TabControlManual"
        Me.TabControlManual.Padding = New System.Windows.Forms.Padding(3)
        Me.TabControlManual.Size = New System.Drawing.Size(1016, 426)
        Me.TabControlManual.TabIndex = 1
        Me.TabControlManual.Text = "Manual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(251, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 25)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Posición Inicial"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(482, 26)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(91, 25)
        Me.Label28.TabIndex = 128
        Me.Label28.Text = "Estado"
        '
        'btnHab_Man
        '
        Me.btnHab_Man.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHab_Man.Image = Global.VisualRobot.My.Resources.Resources.Manual_2
        Me.btnHab_Man.Location = New System.Drawing.Point(425, 12)
        Me.btnHab_Man.Name = "btnHab_Man"
        Me.btnHab_Man.Size = New System.Drawing.Size(51, 47)
        Me.btnHab_Man.TabIndex = 127
        Me.btnHab_Man.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Sentido:"
        '
        'btnMotor1
        '
        Me.btnMotor1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMotor1.ForeColor = System.Drawing.Color.Black
        Me.btnMotor1.Image = CType(resources.GetObject("btnMotor1.Image"), System.Drawing.Image)
        Me.btnMotor1.Location = New System.Drawing.Point(582, 122)
        Me.btnMotor1.Name = "btnMotor1"
        Me.btnMotor1.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor1.TabIndex = 2
        Me.btnMotor1.UseVisualStyleBackColor = True
        '
        'nupMotor1Man
        '
        Me.nupMotor1Man.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupMotor1Man.Location = New System.Drawing.Point(721, 122)
        Me.nupMotor1Man.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nupMotor1Man.Name = "nupMotor1Man"
        Me.nupMotor1Man.Size = New System.Drawing.Size(69, 33)
        Me.nupMotor1Man.TabIndex = 1
        '
        'nupMotor2Man
        '
        Me.nupMotor2Man.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupMotor2Man.Location = New System.Drawing.Point(721, 171)
        Me.nupMotor2Man.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nupMotor2Man.Name = "nupMotor2Man"
        Me.nupMotor2Man.Size = New System.Drawing.Size(69, 33)
        Me.nupMotor2Man.TabIndex = 7
        '
        'BtnSend
        '
        Me.BtnSend.BackColor = System.Drawing.Color.Gray
        Me.BtnSend.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.Location = New System.Drawing.Point(322, 358)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(96, 40)
        Me.BtnSend.TabIndex = 29
        Me.BtnSend.Text = "Enviar"
        Me.BtnSend.UseVisualStyleBackColor = False
        '
        'DisPosMotor6
        '
        Me.DisPosMotor6.BackColor = System.Drawing.Color.Gray
        Me.DisPosMotor6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisPosMotor6.Location = New System.Drawing.Point(892, 363)
        Me.DisPosMotor6.Name = "DisPosMotor6"
        Me.DisPosMotor6.Size = New System.Drawing.Size(43, 43)
        Me.DisPosMotor6.TabIndex = 41
        Me.DisPosMotor6.Text = "-"
        Me.DisPosMotor6.UseVisualStyleBackColor = False
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.Gray
        Me.Clear.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(212, 358)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(96, 40)
        Me.Clear.TabIndex = 28
        Me.Clear.Text = "Borrar"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'nupMotor3Man
        '
        Me.nupMotor3Man.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupMotor3Man.Location = New System.Drawing.Point(721, 220)
        Me.nupMotor3Man.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nupMotor3Man.Name = "nupMotor3Man"
        Me.nupMotor3Man.Size = New System.Drawing.Size(69, 33)
        Me.nupMotor3Man.TabIndex = 8
        '
        'Clock
        '
        Me.Clock.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clock.Image = Global.VisualRobot.My.Resources.Resources.Clk
        Me.Clock.Location = New System.Drawing.Point(334, 243)
        Me.Clock.Name = "Clock"
        Me.Clock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Clock.Size = New System.Drawing.Size(43, 40)
        Me.Clock.TabIndex = 27
        Me.Clock.UseVisualStyleBackColor = True
        '
        'AumPosMotor6
        '
        Me.AumPosMotor6.BackColor = System.Drawing.Color.Gray
        Me.AumPosMotor6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AumPosMotor6.Location = New System.Drawing.Point(814, 363)
        Me.AumPosMotor6.Name = "AumPosMotor6"
        Me.AumPosMotor6.Size = New System.Drawing.Size(46, 43)
        Me.AumPosMotor6.TabIndex = 40
        Me.AumPosMotor6.Text = "+"
        Me.AumPosMotor6.UseVisualStyleBackColor = False
        '
        'PrevManual
        '
        Me.PrevManual.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrevManual.Location = New System.Drawing.Point(212, 314)
        Me.PrevManual.Name = "PrevManual"
        Me.PrevManual.Size = New System.Drawing.Size(206, 33)
        Me.PrevManual.TabIndex = 26
        '
        'nupMotor4Man
        '
        Me.nupMotor4Man.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupMotor4Man.Location = New System.Drawing.Point(721, 269)
        Me.nupMotor4Man.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nupMotor4Man.Name = "nupMotor4Man"
        Me.nupMotor4Man.Size = New System.Drawing.Size(69, 33)
        Me.nupMotor4Man.TabIndex = 9
        '
        'lblVelocidad
        '
        Me.lblVelocidad.AutoSize = True
        Me.lblVelocidad.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocidad.Location = New System.Drawing.Point(184, 186)
        Me.lblVelocidad.Name = "lblVelocidad"
        Me.lblVelocidad.Size = New System.Drawing.Size(134, 25)
        Me.lblVelocidad.TabIndex = 12
        Me.lblVelocidad.Text = "Velocidad:"
        '
        'DisPosMotor5
        '
        Me.DisPosMotor5.BackColor = System.Drawing.Color.Gray
        Me.DisPosMotor5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisPosMotor5.Location = New System.Drawing.Point(892, 314)
        Me.DisPosMotor5.Name = "DisPosMotor5"
        Me.DisPosMotor5.Size = New System.Drawing.Size(43, 43)
        Me.DisPosMotor5.TabIndex = 39
        Me.DisPosMotor5.Text = "-"
        Me.DisPosMotor5.UseVisualStyleBackColor = False
        '
        'cmbVelocidadMan
        '
        Me.cmbVelocidadMan.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVelocidadMan.Location = New System.Drawing.Point(334, 184)
        Me.cmbVelocidadMan.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.cmbVelocidadMan.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmbVelocidadMan.Name = "cmbVelocidadMan"
        Me.cmbVelocidadMan.Size = New System.Drawing.Size(105, 33)
        Me.cmbVelocidadMan.TabIndex = 11
        Me.cmbVelocidadMan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nupMotor5Man
        '
        Me.nupMotor5Man.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupMotor5Man.Location = New System.Drawing.Point(721, 318)
        Me.nupMotor5Man.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nupMotor5Man.Name = "nupMotor5Man"
        Me.nupMotor5Man.Size = New System.Drawing.Size(69, 33)
        Me.nupMotor5Man.TabIndex = 10
        '
        'btnPosOrigenMan
        '
        Me.btnPosOrigenMan.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPosOrigenMan.Image = Global.VisualRobot.My.Resources.Resources.home
        Me.btnPosOrigenMan.Location = New System.Drawing.Point(189, 98)
        Me.btnPosOrigenMan.Name = "btnPosOrigenMan"
        Me.btnPosOrigenMan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPosOrigenMan.Size = New System.Drawing.Size(56, 55)
        Me.btnPosOrigenMan.TabIndex = 0
        Me.btnPosOrigenMan.UseVisualStyleBackColor = True
        '
        'AumPosMotor5
        '
        Me.AumPosMotor5.BackColor = System.Drawing.Color.Gray
        Me.AumPosMotor5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AumPosMotor5.Location = New System.Drawing.Point(814, 314)
        Me.AumPosMotor5.Name = "AumPosMotor5"
        Me.AumPosMotor5.Size = New System.Drawing.Size(46, 43)
        Me.AumPosMotor5.TabIndex = 38
        Me.AumPosMotor5.Text = "+"
        Me.AumPosMotor5.UseVisualStyleBackColor = False
        '
        'lblMotor1
        '
        Me.lblMotor1.AutoSize = True
        Me.lblMotor1.BackColor = System.Drawing.Color.LightSalmon
        Me.lblMotor1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor1.Location = New System.Drawing.Point(634, 128)
        Me.lblMotor1.Name = "lblMotor1"
        Me.lblMotor1.Size = New System.Drawing.Size(70, 25)
        Me.lblMotor1.TabIndex = 13
        Me.lblMotor1.Text = "Eje 1"
        '
        'DisPosMotor4
        '
        Me.DisPosMotor4.BackColor = System.Drawing.Color.Gray
        Me.DisPosMotor4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisPosMotor4.Location = New System.Drawing.Point(892, 265)
        Me.DisPosMotor4.Name = "DisPosMotor4"
        Me.DisPosMotor4.Size = New System.Drawing.Size(43, 43)
        Me.DisPosMotor4.TabIndex = 37
        Me.DisPosMotor4.Text = "-"
        Me.DisPosMotor4.UseVisualStyleBackColor = False
        '
        'lblMotor2
        '
        Me.lblMotor2.AutoSize = True
        Me.lblMotor2.BackColor = System.Drawing.Color.LightSalmon
        Me.lblMotor2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor2.Location = New System.Drawing.Point(634, 177)
        Me.lblMotor2.Name = "lblMotor2"
        Me.lblMotor2.Size = New System.Drawing.Size(70, 25)
        Me.lblMotor2.TabIndex = 14
        Me.lblMotor2.Text = "Eje 2"
        '
        'AumPosMotor4
        '
        Me.AumPosMotor4.BackColor = System.Drawing.Color.Gray
        Me.AumPosMotor4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AumPosMotor4.Location = New System.Drawing.Point(814, 265)
        Me.AumPosMotor4.Name = "AumPosMotor4"
        Me.AumPosMotor4.Size = New System.Drawing.Size(46, 43)
        Me.AumPosMotor4.TabIndex = 36
        Me.AumPosMotor4.Text = "+"
        Me.AumPosMotor4.UseVisualStyleBackColor = False
        '
        'lblMotor3
        '
        Me.lblMotor3.AutoSize = True
        Me.lblMotor3.BackColor = System.Drawing.Color.LightSalmon
        Me.lblMotor3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor3.Location = New System.Drawing.Point(634, 226)
        Me.lblMotor3.Name = "lblMotor3"
        Me.lblMotor3.Size = New System.Drawing.Size(70, 25)
        Me.lblMotor3.TabIndex = 15
        Me.lblMotor3.Text = "Eje 3"
        '
        'DisPosMotor3
        '
        Me.DisPosMotor3.BackColor = System.Drawing.Color.Gray
        Me.DisPosMotor3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisPosMotor3.Location = New System.Drawing.Point(892, 216)
        Me.DisPosMotor3.Name = "DisPosMotor3"
        Me.DisPosMotor3.Size = New System.Drawing.Size(43, 43)
        Me.DisPosMotor3.TabIndex = 35
        Me.DisPosMotor3.Text = "-"
        Me.DisPosMotor3.UseVisualStyleBackColor = False
        '
        'lblMotor4
        '
        Me.lblMotor4.AutoSize = True
        Me.lblMotor4.BackColor = System.Drawing.Color.LightSalmon
        Me.lblMotor4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor4.Location = New System.Drawing.Point(634, 275)
        Me.lblMotor4.Name = "lblMotor4"
        Me.lblMotor4.Size = New System.Drawing.Size(70, 25)
        Me.lblMotor4.TabIndex = 16
        Me.lblMotor4.Text = "Eje 4"
        '
        'AumPosMotor3
        '
        Me.AumPosMotor3.BackColor = System.Drawing.Color.Gray
        Me.AumPosMotor3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AumPosMotor3.Location = New System.Drawing.Point(814, 216)
        Me.AumPosMotor3.Name = "AumPosMotor3"
        Me.AumPosMotor3.Size = New System.Drawing.Size(46, 43)
        Me.AumPosMotor3.TabIndex = 34
        Me.AumPosMotor3.Text = "+"
        Me.AumPosMotor3.UseVisualStyleBackColor = False
        '
        'lblMotor5
        '
        Me.lblMotor5.AutoSize = True
        Me.lblMotor5.BackColor = System.Drawing.Color.LightSalmon
        Me.lblMotor5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor5.Location = New System.Drawing.Point(634, 324)
        Me.lblMotor5.Name = "lblMotor5"
        Me.lblMotor5.Size = New System.Drawing.Size(70, 25)
        Me.lblMotor5.TabIndex = 17
        Me.lblMotor5.Text = "Eje 5"
        '
        'DisPosMotor2
        '
        Me.DisPosMotor2.BackColor = System.Drawing.Color.Gray
        Me.DisPosMotor2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisPosMotor2.Location = New System.Drawing.Point(892, 167)
        Me.DisPosMotor2.Name = "DisPosMotor2"
        Me.DisPosMotor2.Size = New System.Drawing.Size(43, 43)
        Me.DisPosMotor2.TabIndex = 33
        Me.DisPosMotor2.Text = "-"
        Me.DisPosMotor2.UseVisualStyleBackColor = False
        '
        'nupMotor6Man
        '
        Me.nupMotor6Man.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupMotor6Man.Location = New System.Drawing.Point(721, 367)
        Me.nupMotor6Man.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.nupMotor6Man.Name = "nupMotor6Man"
        Me.nupMotor6Man.Size = New System.Drawing.Size(69, 33)
        Me.nupMotor6Man.TabIndex = 19
        '
        'AumPosMotor2
        '
        Me.AumPosMotor2.BackColor = System.Drawing.Color.Gray
        Me.AumPosMotor2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AumPosMotor2.Location = New System.Drawing.Point(814, 167)
        Me.AumPosMotor2.Name = "AumPosMotor2"
        Me.AumPosMotor2.Size = New System.Drawing.Size(46, 43)
        Me.AumPosMotor2.TabIndex = 32
        Me.AumPosMotor2.Text = "+"
        Me.AumPosMotor2.UseVisualStyleBackColor = False
        '
        'lblMotor6
        '
        Me.lblMotor6.AutoSize = True
        Me.lblMotor6.BackColor = System.Drawing.Color.LightSalmon
        Me.lblMotor6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotor6.Location = New System.Drawing.Point(634, 373)
        Me.lblMotor6.Name = "lblMotor6"
        Me.lblMotor6.Size = New System.Drawing.Size(70, 25)
        Me.lblMotor6.TabIndex = 20
        Me.lblMotor6.Text = "Eje 6"
        '
        'DisPosMotor1
        '
        Me.DisPosMotor1.BackColor = System.Drawing.Color.Gray
        Me.DisPosMotor1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisPosMotor1.Location = New System.Drawing.Point(892, 118)
        Me.DisPosMotor1.Name = "DisPosMotor1"
        Me.DisPosMotor1.Size = New System.Drawing.Size(43, 43)
        Me.DisPosMotor1.TabIndex = 31
        Me.DisPosMotor1.Text = "-"
        Me.DisPosMotor1.UseVisualStyleBackColor = False
        '
        'btnMotor2
        '
        Me.btnMotor2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMotor2.ForeColor = System.Drawing.Color.Black
        Me.btnMotor2.Image = CType(resources.GetObject("btnMotor2.Image"), System.Drawing.Image)
        Me.btnMotor2.Location = New System.Drawing.Point(582, 171)
        Me.btnMotor2.Name = "btnMotor2"
        Me.btnMotor2.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor2.TabIndex = 21
        Me.btnMotor2.UseVisualStyleBackColor = True
        '
        'AumPosMotor1
        '
        Me.AumPosMotor1.BackColor = System.Drawing.Color.Gray
        Me.AumPosMotor1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AumPosMotor1.Location = New System.Drawing.Point(814, 118)
        Me.AumPosMotor1.Name = "AumPosMotor1"
        Me.AumPosMotor1.Size = New System.Drawing.Size(46, 43)
        Me.AumPosMotor1.TabIndex = 30
        Me.AumPosMotor1.Text = "+"
        Me.AumPosMotor1.UseVisualStyleBackColor = False
        '
        'btnMotor3
        '
        Me.btnMotor3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMotor3.ForeColor = System.Drawing.Color.Black
        Me.btnMotor3.Image = CType(resources.GetObject("btnMotor3.Image"), System.Drawing.Image)
        Me.btnMotor3.Location = New System.Drawing.Point(582, 220)
        Me.btnMotor3.Name = "btnMotor3"
        Me.btnMotor3.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor3.TabIndex = 22
        Me.btnMotor3.UseVisualStyleBackColor = True
        '
        'btnMotor4
        '
        Me.btnMotor4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMotor4.ForeColor = System.Drawing.Color.Black
        Me.btnMotor4.Image = CType(resources.GetObject("btnMotor4.Image"), System.Drawing.Image)
        Me.btnMotor4.Location = New System.Drawing.Point(582, 269)
        Me.btnMotor4.Name = "btnMotor4"
        Me.btnMotor4.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor4.TabIndex = 23
        Me.btnMotor4.UseVisualStyleBackColor = True
        '
        'btnMotor5
        '
        Me.btnMotor5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMotor5.ForeColor = System.Drawing.Color.Black
        Me.btnMotor5.Image = CType(resources.GetObject("btnMotor5.Image"), System.Drawing.Image)
        Me.btnMotor5.Location = New System.Drawing.Point(582, 318)
        Me.btnMotor5.Name = "btnMotor5"
        Me.btnMotor5.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor5.TabIndex = 24
        Me.btnMotor5.UseVisualStyleBackColor = True
        '
        'btnMotor6
        '
        Me.btnMotor6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMotor6.ForeColor = System.Drawing.Color.Black
        Me.btnMotor6.Image = CType(resources.GetObject("btnMotor6.Image"), System.Drawing.Image)
        Me.btnMotor6.Location = New System.Drawing.Point(582, 367)
        Me.btnMotor6.Name = "btnMotor6"
        Me.btnMotor6.Size = New System.Drawing.Size(40, 40)
        Me.btnMotor6.TabIndex = 25
        Me.btnMotor6.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(573, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 338)
        Me.Panel1.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSalmon
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 25)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Manejo de Ejes"
        '
        'TabHome
        '
        Me.TabHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabHome.Controls.Add(Me.tboxHomeEstadoEJE6)
        Me.TabHome.Controls.Add(Me.tboxHomeEstadoEJE3)
        Me.TabHome.Controls.Add(Me.tboxHomeEstadoEJE5)
        Me.TabHome.Controls.Add(Me.tboxHomeEstadoEJE2)
        Me.TabHome.Controls.Add(Me.tboxHomeEstadoEJE4)
        Me.TabHome.Controls.Add(Me.tboxHomeEstadoEJE1)
        Me.TabHome.Controls.Add(Me.lblPinza)
        Me.TabHome.Controls.Add(Me.lblMano)
        Me.TabHome.Controls.Add(Me.lblMuñeca)
        Me.TabHome.Controls.Add(Me.lblCodo)
        Me.TabHome.Controls.Add(Me.lblHombro)
        Me.TabHome.Controls.Add(Me.lblBase)
        Me.TabHome.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabHome.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabHome.Location = New System.Drawing.Point(4, 27)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHome.Size = New System.Drawing.Size(1016, 426)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        '
        'tboxHomeEstadoEJE6
        '
        Me.tboxHomeEstadoEJE6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxHomeEstadoEJE6.Location = New System.Drawing.Point(837, 366)
        Me.tboxHomeEstadoEJE6.Name = "tboxHomeEstadoEJE6"
        Me.tboxHomeEstadoEJE6.Size = New System.Drawing.Size(139, 33)
        Me.tboxHomeEstadoEJE6.TabIndex = 57
        '
        'tboxHomeEstadoEJE3
        '
        Me.tboxHomeEstadoEJE3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxHomeEstadoEJE3.Location = New System.Drawing.Point(837, 321)
        Me.tboxHomeEstadoEJE3.Name = "tboxHomeEstadoEJE3"
        Me.tboxHomeEstadoEJE3.Size = New System.Drawing.Size(139, 33)
        Me.tboxHomeEstadoEJE3.TabIndex = 55
        '
        'tboxHomeEstadoEJE5
        '
        Me.tboxHomeEstadoEJE5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxHomeEstadoEJE5.Location = New System.Drawing.Point(509, 364)
        Me.tboxHomeEstadoEJE5.Name = "tboxHomeEstadoEJE5"
        Me.tboxHomeEstadoEJE5.Size = New System.Drawing.Size(139, 33)
        Me.tboxHomeEstadoEJE5.TabIndex = 53
        '
        'tboxHomeEstadoEJE2
        '
        Me.tboxHomeEstadoEJE2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxHomeEstadoEJE2.Location = New System.Drawing.Point(509, 321)
        Me.tboxHomeEstadoEJE2.Name = "tboxHomeEstadoEJE2"
        Me.tboxHomeEstadoEJE2.Size = New System.Drawing.Size(139, 33)
        Me.tboxHomeEstadoEJE2.TabIndex = 51
        '
        'tboxHomeEstadoEJE4
        '
        Me.tboxHomeEstadoEJE4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxHomeEstadoEJE4.Location = New System.Drawing.Point(169, 364)
        Me.tboxHomeEstadoEJE4.Name = "tboxHomeEstadoEJE4"
        Me.tboxHomeEstadoEJE4.Size = New System.Drawing.Size(139, 33)
        Me.tboxHomeEstadoEJE4.TabIndex = 49
        '
        'tboxHomeEstadoEJE1
        '
        Me.tboxHomeEstadoEJE1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxHomeEstadoEJE1.Location = New System.Drawing.Point(169, 321)
        Me.tboxHomeEstadoEJE1.Name = "tboxHomeEstadoEJE1"
        Me.tboxHomeEstadoEJE1.Size = New System.Drawing.Size(139, 33)
        Me.tboxHomeEstadoEJE1.TabIndex = 47
        '
        'lblPinza
        '
        Me.lblPinza.AutoSize = True
        Me.lblPinza.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPinza.Location = New System.Drawing.Point(729, 369)
        Me.lblPinza.Name = "lblPinza"
        Me.lblPinza.Size = New System.Drawing.Size(76, 25)
        Me.lblPinza.TabIndex = 58
        Me.lblPinza.Text = "Pinza"
        '
        'lblMano
        '
        Me.lblMano.AutoSize = True
        Me.lblMano.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMano.Location = New System.Drawing.Point(729, 324)
        Me.lblMano.Name = "lblMano"
        Me.lblMano.Size = New System.Drawing.Size(75, 25)
        Me.lblMano.TabIndex = 56
        Me.lblMano.Text = "Mano"
        '
        'lblMuñeca
        '
        Me.lblMuñeca.AutoSize = True
        Me.lblMuñeca.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMuñeca.Location = New System.Drawing.Point(401, 367)
        Me.lblMuñeca.Name = "lblMuñeca"
        Me.lblMuñeca.Size = New System.Drawing.Size(102, 25)
        Me.lblMuñeca.TabIndex = 54
        Me.lblMuñeca.Text = "Muñeca"
        '
        'lblCodo
        '
        Me.lblCodo.AutoSize = True
        Me.lblCodo.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodo.Location = New System.Drawing.Point(401, 324)
        Me.lblCodo.Name = "lblCodo"
        Me.lblCodo.Size = New System.Drawing.Size(70, 25)
        Me.lblCodo.TabIndex = 52
        Me.lblCodo.Text = "Codo"
        '
        'lblHombro
        '
        Me.lblHombro.AutoSize = True
        Me.lblHombro.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHombro.Location = New System.Drawing.Point(61, 367)
        Me.lblHombro.Name = "lblHombro"
        Me.lblHombro.Size = New System.Drawing.Size(105, 25)
        Me.lblHombro.TabIndex = 50
        Me.lblHombro.Text = "Hombro"
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(61, 324)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(68, 25)
        Me.lblBase.TabIndex = 48
        Me.lblBase.Text = "Base"
        '
        'EstadoPingRobot
        '
        Me.EstadoPingRobot.Image = Global.VisualRobot.My.Resources.Resources.ErrorPing
        Me.EstadoPingRobot.Location = New System.Drawing.Point(785, 10)
        Me.EstadoPingRobot.Name = "EstadoPingRobot"
        Me.EstadoPingRobot.Size = New System.Drawing.Size(40, 40)
        Me.EstadoPingRobot.TabIndex = 79
        Me.EstadoPingRobot.TabStop = False
        '
        'EstadoIP_Robot
        '
        Me.EstadoIP_Robot.Enabled = False
        Me.EstadoIP_Robot.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoIP_Robot.Location = New System.Drawing.Point(840, 14)
        Me.EstadoIP_Robot.Name = "EstadoIP_Robot"
        Me.EstadoIP_Robot.Size = New System.Drawing.Size(173, 33)
        Me.EstadoIP_Robot.TabIndex = 61
        Me.EstadoIP_Robot.Text = "Desconectado"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.btnTabSec)
        Me.Panel3.Controls.Add(Me.btnDesrollador)
        Me.Panel3.Controls.Add(Me.BtnTabConfig)
        Me.Panel3.Controls.Add(Me.BtnTabJOG)
        Me.Panel3.Controls.Add(Me.BtnTabHome)
        Me.Panel3.Controls.Add(Me.BtnTabCtrlManual)
        Me.Panel3.Location = New System.Drawing.Point(-2, 483)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1024, 56)
        Me.Panel3.TabIndex = 65
        '
        'btnTabSec
        '
        Me.btnTabSec.BackColor = System.Drawing.Color.OrangeRed
        Me.btnTabSec.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTabSec.Location = New System.Drawing.Point(604, 7)
        Me.btnTabSec.Name = "btnTabSec"
        Me.btnTabSec.Size = New System.Drawing.Size(156, 40)
        Me.btnTabSec.TabIndex = 64
        Me.btnTabSec.Text = "Secuencia"
        Me.btnTabSec.UseVisualStyleBackColor = False
        '
        'btnDesrollador
        '
        Me.btnDesrollador.Location = New System.Drawing.Point(985, 20)
        Me.btnDesrollador.Name = "btnDesrollador"
        Me.btnDesrollador.Size = New System.Drawing.Size(15, 15)
        Me.btnDesrollador.TabIndex = 59
        Me.btnDesrollador.Text = "desa"
        Me.btnDesrollador.UseVisualStyleBackColor = True
        '
        'BtnTabConfig
        '
        Me.BtnTabConfig.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnTabConfig.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTabConfig.Location = New System.Drawing.Point(796, 7)
        Me.BtnTabConfig.Name = "BtnTabConfig"
        Me.BtnTabConfig.Size = New System.Drawing.Size(156, 40)
        Me.BtnTabConfig.TabIndex = 63
        Me.BtnTabConfig.Text = "Config"
        Me.BtnTabConfig.UseVisualStyleBackColor = False
        '
        'BtnTabJOG
        '
        Me.BtnTabJOG.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnTabJOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTabJOG.Location = New System.Drawing.Point(412, 7)
        Me.BtnTabJOG.Name = "BtnTabJOG"
        Me.BtnTabJOG.Size = New System.Drawing.Size(156, 40)
        Me.BtnTabJOG.TabIndex = 62
        Me.BtnTabJOG.Text = "JOG"
        Me.BtnTabJOG.UseVisualStyleBackColor = False
        '
        'BtnTabHome
        '
        Me.BtnTabHome.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnTabHome.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTabHome.Location = New System.Drawing.Point(28, 7)
        Me.BtnTabHome.Name = "BtnTabHome"
        Me.BtnTabHome.Size = New System.Drawing.Size(156, 40)
        Me.BtnTabHome.TabIndex = 60
        Me.BtnTabHome.Text = "Home"
        Me.BtnTabHome.UseVisualStyleBackColor = False
        '
        'BtnTabCtrlManual
        '
        Me.BtnTabCtrlManual.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnTabCtrlManual.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTabCtrlManual.Location = New System.Drawing.Point(220, 7)
        Me.BtnTabCtrlManual.Name = "BtnTabCtrlManual"
        Me.BtnTabCtrlManual.Size = New System.Drawing.Size(156, 40)
        Me.BtnTabCtrlManual.TabIndex = 59
        Me.BtnTabCtrlManual.Text = "Manual"
        Me.BtnTabCtrlManual.UseVisualStyleBackColor = False
        '
        'Screens
        '
        Me.Screens.Controls.Add(Me.TabHome)
        Me.Screens.Controls.Add(Me.TabControlManual)
        Me.Screens.Controls.Add(Me.TabJOG)
        Me.Screens.Controls.Add(Me.TabConfiguracion)
        Me.Screens.Controls.Add(Me.TabSecuencia)
        Me.Screens.Controls.Add(Me.TabDesarrollador)
        Me.Screens.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Screens.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Screens.Location = New System.Drawing.Point(-2, 30)
        Me.Screens.Name = "Screens"
        Me.Screens.SelectedIndex = 0
        Me.Screens.Size = New System.Drawing.Size(1024, 457)
        Me.Screens.TabIndex = 44
        '
        'TabJOG
        '
        Me.TabJOG.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabJOG.Controls.Add(Me.ProgressBarGripper)
        Me.TabJOG.Controls.Add(Me.btnGripperOFF)
        Me.TabJOG.Controls.Add(Me.btnGripperON)
        Me.TabJOG.Controls.Add(Me.FlechaVelJOGJoy)
        Me.TabJOG.Controls.Add(Me.btnGuardarSec)
        Me.TabJOG.Controls.Add(Me.btnGuardarMov)
        Me.TabJOG.Controls.Add(Me.btnPosOrigenJOG)
        Me.TabJOG.Controls.Add(Me.Label6)
        Me.TabJOG.Controls.Add(Me.Label7)
        Me.TabJOG.Controls.Add(Me.Label8)
        Me.TabJOG.Controls.Add(Me.Label9)
        Me.TabJOG.Controls.Add(Me.Label10)
        Me.TabJOG.Controls.Add(Me.Label11)
        Me.TabJOG.Controls.Add(Me.tboxJOGEstadoEJE6)
        Me.TabJOG.Controls.Add(Me.tboxJOGEstadoEJE5)
        Me.TabJOG.Controls.Add(Me.tboxJOGEstadoEJE4)
        Me.TabJOG.Controls.Add(Me.tboxJOGEstadoEJE3)
        Me.TabJOG.Controls.Add(Me.tboxJOGEstadoEJE2)
        Me.TabJOG.Controls.Add(Me.tboxJOGEstadoEJE1)
        Me.TabJOG.Controls.Add(Me.btnE6_NEG_JOG)
        Me.TabJOG.Controls.Add(Me.btnE6_POS_JOG)
        Me.TabJOG.Controls.Add(Me.btnE5_NEG_JOG)
        Me.TabJOG.Controls.Add(Me.btnE5_POS_JOG)
        Me.TabJOG.Controls.Add(Me.btnE4_NEG_JOG)
        Me.TabJOG.Controls.Add(Me.btnE4_POS_JOG)
        Me.TabJOG.Controls.Add(Me.btnE3_NEG_JOG)
        Me.TabJOG.Controls.Add(Me.btnE3_POS_JOG)
        Me.TabJOG.Controls.Add(Me.btnE2_NEG_JOG)
        Me.TabJOG.Controls.Add(Me.btnE2_POS_JOG)
        Me.TabJOG.Controls.Add(Me.Label25)
        Me.TabJOG.Controls.Add(Me.Label19)
        Me.TabJOG.Controls.Add(Me.Label20)
        Me.TabJOG.Controls.Add(Me.cmbVelocidadJOG6)
        Me.TabJOG.Controls.Add(Me.cmbVelocidadJOG5)
        Me.TabJOG.Controls.Add(Me.Label23)
        Me.TabJOG.Controls.Add(Me.cmbVelocidadJOG4)
        Me.TabJOG.Controls.Add(Me.Label18)
        Me.TabJOG.Controls.Add(Me.Label17)
        Me.TabJOG.Controls.Add(Me.cmbVelocidadJOG3)
        Me.TabJOG.Controls.Add(Me.cmbVelocidadJOG2)
        Me.TabJOG.Controls.Add(Me.Label14)
        Me.TabJOG.Controls.Add(Me.Label13)
        Me.TabJOG.Controls.Add(Me.cmbVelocidadJOG1)
        Me.TabJOG.Controls.Add(Me.lblHabilitar_Jog)
        Me.TabJOG.Controls.Add(Me.btnHabJOG)
        Me.TabJOG.Controls.Add(Me.btnE1_NEG_JOG)
        Me.TabJOG.Controls.Add(Me.btnE1_POS_JOG)
        Me.TabJOG.Location = New System.Drawing.Point(4, 27)
        Me.TabJOG.Name = "TabJOG"
        Me.TabJOG.Padding = New System.Windows.Forms.Padding(3)
        Me.TabJOG.Size = New System.Drawing.Size(1016, 426)
        Me.TabJOG.TabIndex = 4
        Me.TabJOG.Text = "JOG"
        '
        'btnGripperOFF
        '
        Me.btnGripperOFF.BackColor = System.Drawing.Color.Gray
        Me.btnGripperOFF.Location = New System.Drawing.Point(391, 131)
        Me.btnGripperOFF.Name = "btnGripperOFF"
        Me.btnGripperOFF.Size = New System.Drawing.Size(90, 54)
        Me.btnGripperOFF.TabIndex = 139
        Me.btnGripperOFF.Text = "Abrir Gripper"
        Me.btnGripperOFF.UseVisualStyleBackColor = False
        '
        'btnGripperON
        '
        Me.btnGripperON.BackColor = System.Drawing.Color.Gray
        Me.btnGripperON.Location = New System.Drawing.Point(391, 205)
        Me.btnGripperON.Name = "btnGripperON"
        Me.btnGripperON.Size = New System.Drawing.Size(90, 54)
        Me.btnGripperON.TabIndex = 138
        Me.btnGripperON.Text = "Cerrar Gripper"
        Me.btnGripperON.UseVisualStyleBackColor = False
        '
        'FlechaVelJOGJoy
        '
        Me.FlechaVelJOGJoy.BackColor = System.Drawing.Color.Transparent
        Me.FlechaVelJOGJoy.Image = Global.VisualRobot.My.Resources.Resources.Flecha_Right
        Me.FlechaVelJOGJoy.Location = New System.Drawing.Point(106, 113)
        Me.FlechaVelJOGJoy.Name = "FlechaVelJOGJoy"
        Me.FlechaVelJOGJoy.Size = New System.Drawing.Size(50, 30)
        Me.FlechaVelJOGJoy.TabIndex = 137
        Me.FlechaVelJOGJoy.TabStop = False
        '
        'btnGuardarSec
        '
        Me.btnGuardarSec.Location = New System.Drawing.Point(886, 71)
        Me.btnGuardarSec.Name = "btnGuardarSec"
        Me.btnGuardarSec.Size = New System.Drawing.Size(100, 44)
        Me.btnGuardarSec.TabIndex = 136
        Me.btnGuardarSec.Text = "SaveSec"
        Me.btnGuardarSec.UseVisualStyleBackColor = True
        '
        'btnGuardarMov
        '
        Me.btnGuardarMov.Location = New System.Drawing.Point(886, 19)
        Me.btnGuardarMov.Name = "btnGuardarMov"
        Me.btnGuardarMov.Size = New System.Drawing.Size(100, 44)
        Me.btnGuardarMov.TabIndex = 135
        Me.btnGuardarMov.Text = "SaveMov"
        Me.btnGuardarMov.UseVisualStyleBackColor = True
        '
        'btnPosOrigenJOG
        '
        Me.btnPosOrigenJOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPosOrigenJOG.Image = Global.VisualRobot.My.Resources.Resources.home
        Me.btnPosOrigenJOG.Location = New System.Drawing.Point(10, 6)
        Me.btnPosOrigenJOG.Name = "btnPosOrigenJOG"
        Me.btnPosOrigenJOG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPosOrigenJOG.Size = New System.Drawing.Size(56, 55)
        Me.btnPosOrigenJOG.TabIndex = 134
        Me.btnPosOrigenJOG.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(532, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 25)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Eje 6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(532, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "Eje 5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(532, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 25)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "Eje 4"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(532, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 25)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Eje 3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(532, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 25)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "Eje 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(532, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 25)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Eje 1"
        '
        'tboxJOGEstadoEJE6
        '
        Me.tboxJOGEstadoEJE6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxJOGEstadoEJE6.Location = New System.Drawing.Point(612, 372)
        Me.tboxJOGEstadoEJE6.Name = "tboxJOGEstadoEJE6"
        Me.tboxJOGEstadoEJE6.Size = New System.Drawing.Size(102, 33)
        Me.tboxJOGEstadoEJE6.TabIndex = 122
        Me.tboxJOGEstadoEJE6.Text = "0.00°"
        '
        'tboxJOGEstadoEJE5
        '
        Me.tboxJOGEstadoEJE5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxJOGEstadoEJE5.Location = New System.Drawing.Point(612, 320)
        Me.tboxJOGEstadoEJE5.Name = "tboxJOGEstadoEJE5"
        Me.tboxJOGEstadoEJE5.Size = New System.Drawing.Size(102, 33)
        Me.tboxJOGEstadoEJE5.TabIndex = 121
        Me.tboxJOGEstadoEJE5.Text = "0.00°"
        '
        'tboxJOGEstadoEJE4
        '
        Me.tboxJOGEstadoEJE4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxJOGEstadoEJE4.Location = New System.Drawing.Point(612, 268)
        Me.tboxJOGEstadoEJE4.Name = "tboxJOGEstadoEJE4"
        Me.tboxJOGEstadoEJE4.Size = New System.Drawing.Size(102, 33)
        Me.tboxJOGEstadoEJE4.TabIndex = 120
        Me.tboxJOGEstadoEJE4.Text = "0.00°"
        '
        'tboxJOGEstadoEJE3
        '
        Me.tboxJOGEstadoEJE3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxJOGEstadoEJE3.Location = New System.Drawing.Point(612, 216)
        Me.tboxJOGEstadoEJE3.Name = "tboxJOGEstadoEJE3"
        Me.tboxJOGEstadoEJE3.Size = New System.Drawing.Size(102, 33)
        Me.tboxJOGEstadoEJE3.TabIndex = 119
        Me.tboxJOGEstadoEJE3.Text = "0.00°"
        '
        'tboxJOGEstadoEJE2
        '
        Me.tboxJOGEstadoEJE2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxJOGEstadoEJE2.Location = New System.Drawing.Point(612, 164)
        Me.tboxJOGEstadoEJE2.Name = "tboxJOGEstadoEJE2"
        Me.tboxJOGEstadoEJE2.Size = New System.Drawing.Size(102, 33)
        Me.tboxJOGEstadoEJE2.TabIndex = 118
        Me.tboxJOGEstadoEJE2.Text = "0.00°"
        '
        'tboxJOGEstadoEJE1
        '
        Me.tboxJOGEstadoEJE1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxJOGEstadoEJE1.Location = New System.Drawing.Point(612, 112)
        Me.tboxJOGEstadoEJE1.Name = "tboxJOGEstadoEJE1"
        Me.tboxJOGEstadoEJE1.Size = New System.Drawing.Size(102, 33)
        Me.tboxJOGEstadoEJE1.TabIndex = 117
        Me.tboxJOGEstadoEJE1.Text = "0.00°"
        '
        'btnE6_NEG_JOG
        '
        Me.btnE6_NEG_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE6_NEG_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE6_NEG_JOG.Location = New System.Drawing.Point(726, 367)
        Me.btnE6_NEG_JOG.Name = "btnE6_NEG_JOG"
        Me.btnE6_NEG_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE6_NEG_JOG.TabIndex = 116
        Me.btnE6_NEG_JOG.Text = "-"
        Me.btnE6_NEG_JOG.UseVisualStyleBackColor = False
        '
        'btnE6_POS_JOG
        '
        Me.btnE6_POS_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE6_POS_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE6_POS_JOG.Location = New System.Drawing.Point(814, 367)
        Me.btnE6_POS_JOG.Name = "btnE6_POS_JOG"
        Me.btnE6_POS_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE6_POS_JOG.TabIndex = 115
        Me.btnE6_POS_JOG.Text = "+"
        Me.btnE6_POS_JOG.UseVisualStyleBackColor = False
        '
        'btnE5_NEG_JOG
        '
        Me.btnE5_NEG_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE5_NEG_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE5_NEG_JOG.Location = New System.Drawing.Point(726, 315)
        Me.btnE5_NEG_JOG.Name = "btnE5_NEG_JOG"
        Me.btnE5_NEG_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE5_NEG_JOG.TabIndex = 114
        Me.btnE5_NEG_JOG.Text = "-"
        Me.btnE5_NEG_JOG.UseVisualStyleBackColor = False
        '
        'btnE5_POS_JOG
        '
        Me.btnE5_POS_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE5_POS_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE5_POS_JOG.Location = New System.Drawing.Point(814, 315)
        Me.btnE5_POS_JOG.Name = "btnE5_POS_JOG"
        Me.btnE5_POS_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE5_POS_JOG.TabIndex = 113
        Me.btnE5_POS_JOG.Text = "+"
        Me.btnE5_POS_JOG.UseVisualStyleBackColor = False
        '
        'btnE4_NEG_JOG
        '
        Me.btnE4_NEG_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE4_NEG_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE4_NEG_JOG.Location = New System.Drawing.Point(726, 263)
        Me.btnE4_NEG_JOG.Name = "btnE4_NEG_JOG"
        Me.btnE4_NEG_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE4_NEG_JOG.TabIndex = 112
        Me.btnE4_NEG_JOG.Text = "-"
        Me.btnE4_NEG_JOG.UseVisualStyleBackColor = False
        '
        'btnE4_POS_JOG
        '
        Me.btnE4_POS_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE4_POS_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE4_POS_JOG.Location = New System.Drawing.Point(814, 263)
        Me.btnE4_POS_JOG.Name = "btnE4_POS_JOG"
        Me.btnE4_POS_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE4_POS_JOG.TabIndex = 111
        Me.btnE4_POS_JOG.Text = "+"
        Me.btnE4_POS_JOG.UseVisualStyleBackColor = False
        '
        'btnE3_NEG_JOG
        '
        Me.btnE3_NEG_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE3_NEG_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE3_NEG_JOG.Location = New System.Drawing.Point(726, 211)
        Me.btnE3_NEG_JOG.Name = "btnE3_NEG_JOG"
        Me.btnE3_NEG_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE3_NEG_JOG.TabIndex = 110
        Me.btnE3_NEG_JOG.Text = "-"
        Me.btnE3_NEG_JOG.UseVisualStyleBackColor = False
        '
        'btnE3_POS_JOG
        '
        Me.btnE3_POS_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE3_POS_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE3_POS_JOG.Location = New System.Drawing.Point(814, 211)
        Me.btnE3_POS_JOG.Name = "btnE3_POS_JOG"
        Me.btnE3_POS_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE3_POS_JOG.TabIndex = 109
        Me.btnE3_POS_JOG.Text = "+"
        Me.btnE3_POS_JOG.UseVisualStyleBackColor = False
        '
        'btnE2_NEG_JOG
        '
        Me.btnE2_NEG_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE2_NEG_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE2_NEG_JOG.Location = New System.Drawing.Point(726, 159)
        Me.btnE2_NEG_JOG.Name = "btnE2_NEG_JOG"
        Me.btnE2_NEG_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE2_NEG_JOG.TabIndex = 108
        Me.btnE2_NEG_JOG.Text = "-"
        Me.btnE2_NEG_JOG.UseVisualStyleBackColor = False
        '
        'btnE2_POS_JOG
        '
        Me.btnE2_POS_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE2_POS_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE2_POS_JOG.Location = New System.Drawing.Point(814, 159)
        Me.btnE2_POS_JOG.Name = "btnE2_POS_JOG"
        Me.btnE2_POS_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE2_POS_JOG.TabIndex = 107
        Me.btnE2_POS_JOG.Text = "+"
        Me.btnE2_POS_JOG.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(625, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(149, 25)
        Me.Label25.TabIndex = 106
        Me.Label25.Text = "Movimiento"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(174, 341)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 25)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "Eje 6"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(174, 294)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 25)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "Eje 5"
        '
        'cmbVelocidadJOG6
        '
        Me.cmbVelocidadJOG6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVelocidadJOG6.Location = New System.Drawing.Point(257, 336)
        Me.cmbVelocidadJOG6.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.cmbVelocidadJOG6.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmbVelocidadJOG6.Name = "cmbVelocidadJOG6"
        Me.cmbVelocidadJOG6.Size = New System.Drawing.Size(49, 33)
        Me.cmbVelocidadJOG6.TabIndex = 102
        Me.cmbVelocidadJOG6.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'cmbVelocidadJOG5
        '
        Me.cmbVelocidadJOG5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVelocidadJOG5.Location = New System.Drawing.Point(257, 289)
        Me.cmbVelocidadJOG5.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.cmbVelocidadJOG5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmbVelocidadJOG5.Name = "cmbVelocidadJOG5"
        Me.cmbVelocidadJOG5.Size = New System.Drawing.Size(49, 33)
        Me.cmbVelocidadJOG5.TabIndex = 100
        Me.cmbVelocidadJOG5.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(174, 247)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 25)
        Me.Label23.TabIndex = 99
        Me.Label23.Text = "Eje 4"
        '
        'cmbVelocidadJOG4
        '
        Me.cmbVelocidadJOG4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVelocidadJOG4.Location = New System.Drawing.Point(257, 242)
        Me.cmbVelocidadJOG4.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.cmbVelocidadJOG4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmbVelocidadJOG4.Name = "cmbVelocidadJOG4"
        Me.cmbVelocidadJOG4.Size = New System.Drawing.Size(49, 33)
        Me.cmbVelocidadJOG4.TabIndex = 97
        Me.cmbVelocidadJOG4.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(174, 201)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 25)
        Me.Label18.TabIndex = 96
        Me.Label18.Text = "Eje 3"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(174, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 25)
        Me.Label17.TabIndex = 95
        Me.Label17.Text = "Eje 2"
        '
        'cmbVelocidadJOG3
        '
        Me.cmbVelocidadJOG3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVelocidadJOG3.Location = New System.Drawing.Point(257, 199)
        Me.cmbVelocidadJOG3.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.cmbVelocidadJOG3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmbVelocidadJOG3.Name = "cmbVelocidadJOG3"
        Me.cmbVelocidadJOG3.Size = New System.Drawing.Size(49, 33)
        Me.cmbVelocidadJOG3.TabIndex = 93
        Me.cmbVelocidadJOG3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbVelocidadJOG2
        '
        Me.cmbVelocidadJOG2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVelocidadJOG2.Location = New System.Drawing.Point(257, 157)
        Me.cmbVelocidadJOG2.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.cmbVelocidadJOG2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmbVelocidadJOG2.Name = "cmbVelocidadJOG2"
        Me.cmbVelocidadJOG2.Size = New System.Drawing.Size(49, 33)
        Me.cmbVelocidadJOG2.TabIndex = 91
        Me.cmbVelocidadJOG2.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(174, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 25)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Eje 1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(218, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 25)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Velocidad"
        '
        'cmbVelocidadJOG1
        '
        Me.cmbVelocidadJOG1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVelocidadJOG1.Location = New System.Drawing.Point(257, 114)
        Me.cmbVelocidadJOG1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.cmbVelocidadJOG1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmbVelocidadJOG1.Name = "cmbVelocidadJOG1"
        Me.cmbVelocidadJOG1.Size = New System.Drawing.Size(49, 33)
        Me.cmbVelocidadJOG1.TabIndex = 87
        Me.cmbVelocidadJOG1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblHabilitar_Jog
        '
        Me.lblHabilitar_Jog.AutoSize = True
        Me.lblHabilitar_Jog.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHabilitar_Jog.Location = New System.Drawing.Point(481, 26)
        Me.lblHabilitar_Jog.Name = "lblHabilitar_Jog"
        Me.lblHabilitar_Jog.Size = New System.Drawing.Size(91, 25)
        Me.lblHabilitar_Jog.TabIndex = 86
        Me.lblHabilitar_Jog.Text = "Estado"
        '
        'btnHabJOG
        '
        Me.btnHabJOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHabJOG.Image = Global.VisualRobot.My.Resources.Resources.Jog
        Me.btnHabJOG.Location = New System.Drawing.Point(424, 12)
        Me.btnHabJOG.Name = "btnHabJOG"
        Me.btnHabJOG.Size = New System.Drawing.Size(51, 47)
        Me.btnHabJOG.TabIndex = 85
        Me.btnHabJOG.UseVisualStyleBackColor = True
        '
        'btnE1_NEG_JOG
        '
        Me.btnE1_NEG_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE1_NEG_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE1_NEG_JOG.Location = New System.Drawing.Point(726, 107)
        Me.btnE1_NEG_JOG.Name = "btnE1_NEG_JOG"
        Me.btnE1_NEG_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE1_NEG_JOG.TabIndex = 14
        Me.btnE1_NEG_JOG.Text = "-"
        Me.btnE1_NEG_JOG.UseVisualStyleBackColor = False
        '
        'btnE1_POS_JOG
        '
        Me.btnE1_POS_JOG.BackColor = System.Drawing.Color.Gray
        Me.btnE1_POS_JOG.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE1_POS_JOG.Location = New System.Drawing.Point(814, 107)
        Me.btnE1_POS_JOG.Name = "btnE1_POS_JOG"
        Me.btnE1_POS_JOG.Size = New System.Drawing.Size(46, 43)
        Me.btnE1_POS_JOG.TabIndex = 10
        Me.btnE1_POS_JOG.Text = "+"
        Me.btnE1_POS_JOG.UseVisualStyleBackColor = False
        '
        'TabConfiguracion
        '
        Me.TabConfiguracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabConfiguracion.Controls.Add(Me.Panel4)
        Me.TabConfiguracion.Controls.Add(Me.Panel2)
        Me.TabConfiguracion.Location = New System.Drawing.Point(4, 27)
        Me.TabConfiguracion.Name = "TabConfiguracion"
        Me.TabConfiguracion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConfiguracion.Size = New System.Drawing.Size(1016, 426)
        Me.TabConfiguracion.TabIndex = 3
        Me.TabConfiguracion.Text = "Configuración"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TBox_PortRobot)
        Me.Panel4.Controls.Add(Me.BtnConnectRobot)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.TBox_IpRobot)
        Me.Panel4.Controls.Add(Me.BtnDesconectar)
        Me.Panel4.Location = New System.Drawing.Point(44, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(279, 263)
        Me.Panel4.TabIndex = 96
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(80, 12)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(120, 25)
        Me.Label31.TabIndex = 97
        Me.Label31.Text = "Conexión"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 25)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "IP:"
        '
        'TBox_PortRobot
        '
        Me.TBox_PortRobot.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_PortRobot.Location = New System.Drawing.Point(181, 97)
        Me.TBox_PortRobot.Name = "TBox_PortRobot"
        Me.TBox_PortRobot.Size = New System.Drawing.Size(85, 33)
        Me.TBox_PortRobot.TabIndex = 82
        Me.TBox_PortRobot.Text = "23"
        '
        'BtnConnectRobot
        '
        Me.BtnConnectRobot.BackColor = System.Drawing.Color.Gray
        Me.BtnConnectRobot.Location = New System.Drawing.Point(74, 149)
        Me.BtnConnectRobot.Name = "BtnConnectRobot"
        Me.BtnConnectRobot.Size = New System.Drawing.Size(132, 45)
        Me.BtnConnectRobot.TabIndex = 77
        Me.BtnConnectRobot.Text = "Conectar"
        Me.BtnConnectRobot.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 101)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(69, 25)
        Me.Label27.TabIndex = 81
        Me.Label27.Text = "Port:"
        '
        'TBox_IpRobot
        '
        Me.TBox_IpRobot.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBox_IpRobot.Location = New System.Drawing.Point(55, 54)
        Me.TBox_IpRobot.Name = "TBox_IpRobot"
        Me.TBox_IpRobot.Size = New System.Drawing.Size(211, 33)
        Me.TBox_IpRobot.TabIndex = 75
        Me.TBox_IpRobot.Text = "192.168.0.80"
        '
        'BtnDesconectar
        '
        Me.BtnDesconectar.BackColor = System.Drawing.Color.Gray
        Me.BtnDesconectar.Location = New System.Drawing.Point(74, 200)
        Me.BtnDesconectar.Name = "BtnDesconectar"
        Me.BtnDesconectar.Size = New System.Drawing.Size(132, 45)
        Me.BtnDesconectar.TabIndex = 80
        Me.BtnDesconectar.Text = "Desconectar"
        Me.BtnDesconectar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSalmon
        Me.Panel2.Controls.Add(Me.cmbStepEje6)
        Me.Panel2.Controls.Add(Me.cmbStepEje5)
        Me.Panel2.Controls.Add(Me.cmbStepEje4)
        Me.Panel2.Controls.Add(Me.cmbStepEje3)
        Me.Panel2.Controls.Add(Me.cmbStepEje2)
        Me.Panel2.Controls.Add(Me.cmbStepEje1)
        Me.Panel2.Controls.Add(Me.btnCargarConf)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Location = New System.Drawing.Point(740, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 350)
        Me.Panel2.TabIndex = 95
        '
        'cmbStepEje6
        '
        Me.cmbStepEje6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStepEje6.FormattingEnabled = True
        Me.cmbStepEje6.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32"})
        Me.cmbStepEje6.Location = New System.Drawing.Point(96, 259)
        Me.cmbStepEje6.Name = "cmbStepEje6"
        Me.cmbStepEje6.Size = New System.Drawing.Size(61, 26)
        Me.cmbStepEje6.TabIndex = 102
        '
        'cmbStepEje5
        '
        Me.cmbStepEje5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStepEje5.FormattingEnabled = True
        Me.cmbStepEje5.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32"})
        Me.cmbStepEje5.Location = New System.Drawing.Point(96, 218)
        Me.cmbStepEje5.Name = "cmbStepEje5"
        Me.cmbStepEje5.Size = New System.Drawing.Size(61, 26)
        Me.cmbStepEje5.TabIndex = 101
        '
        'cmbStepEje4
        '
        Me.cmbStepEje4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStepEje4.FormattingEnabled = True
        Me.cmbStepEje4.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32"})
        Me.cmbStepEje4.Location = New System.Drawing.Point(96, 177)
        Me.cmbStepEje4.Name = "cmbStepEje4"
        Me.cmbStepEje4.Size = New System.Drawing.Size(61, 26)
        Me.cmbStepEje4.TabIndex = 100
        '
        'cmbStepEje3
        '
        Me.cmbStepEje3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStepEje3.FormattingEnabled = True
        Me.cmbStepEje3.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32"})
        Me.cmbStepEje3.Location = New System.Drawing.Point(96, 136)
        Me.cmbStepEje3.Name = "cmbStepEje3"
        Me.cmbStepEje3.Size = New System.Drawing.Size(61, 26)
        Me.cmbStepEje3.TabIndex = 99
        '
        'cmbStepEje2
        '
        Me.cmbStepEje2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStepEje2.FormattingEnabled = True
        Me.cmbStepEje2.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32"})
        Me.cmbStepEje2.Location = New System.Drawing.Point(96, 95)
        Me.cmbStepEje2.Name = "cmbStepEje2"
        Me.cmbStepEje2.Size = New System.Drawing.Size(61, 26)
        Me.cmbStepEje2.TabIndex = 98
        '
        'cmbStepEje1
        '
        Me.cmbStepEje1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStepEje1.FormattingEnabled = True
        Me.cmbStepEje1.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32"})
        Me.cmbStepEje1.Location = New System.Drawing.Point(96, 54)
        Me.cmbStepEje1.Name = "cmbStepEje1"
        Me.cmbStepEje1.Size = New System.Drawing.Size(61, 26)
        Me.cmbStepEje1.TabIndex = 97
        '
        'btnCargarConf
        '
        Me.btnCargarConf.BackColor = System.Drawing.Color.Gray
        Me.btnCargarConf.Location = New System.Drawing.Point(25, 299)
        Me.btnCargarConf.Name = "btnCargarConf"
        Me.btnCargarConf.Size = New System.Drawing.Size(124, 39)
        Me.btnCargarConf.TabIndex = 96
        Me.btnCargarConf.Text = "Cargar"
        Me.btnCargarConf.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(16, 12)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(142, 25)
        Me.Label30.TabIndex = 95
        Me.Label30.Text = "Micropasos"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(15, 178)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 25)
        Me.Label22.TabIndex = 89
        Me.Label22.Text = "Eje 4"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 25)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Eje 1"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(15, 260)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 25)
        Me.Label26.TabIndex = 93
        Me.Label26.Text = "Eje 6"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 25)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "Eje 2"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(15, 219)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 25)
        Me.Label24.TabIndex = 91
        Me.Label24.Text = "Eje 5"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 137)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 25)
        Me.Label21.TabIndex = 87
        Me.Label21.Text = "Eje 3"
        '
        'TabSecuencia
        '
        Me.TabSecuencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabSecuencia.Controls.Add(Me.lboxSecAct)
        Me.TabSecuencia.Controls.Add(Me.ListSEC_Select)
        Me.TabSecuencia.Controls.Add(Me.btnCamDirSEC)
        Me.TabSecuencia.Controls.Add(Me.btnEjecSec)
        Me.TabSecuencia.Controls.Add(Me.btnPararSec)
        Me.TabSecuencia.Controls.Add(Me.tboxNomSecAct)
        Me.TabSecuencia.Controls.Add(Me.btnCrearSec)
        Me.TabSecuencia.Controls.Add(Me.btnCargarSec)
        Me.TabSecuencia.Controls.Add(Me.tboxSecAct)
        Me.TabSecuencia.Location = New System.Drawing.Point(4, 27)
        Me.TabSecuencia.Name = "TabSecuencia"
        Me.TabSecuencia.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSecuencia.Size = New System.Drawing.Size(1016, 426)
        Me.TabSecuencia.TabIndex = 6
        Me.TabSecuencia.Text = "Secuencia"
        '
        'lboxSecAct
        '
        Me.lboxSecAct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxSecAct.FormattingEnabled = True
        Me.lboxSecAct.Location = New System.Drawing.Point(380, 68)
        Me.lboxSecAct.Name = "lboxSecAct"
        Me.lboxSecAct.Size = New System.Drawing.Size(441, 329)
        Me.lboxSecAct.TabIndex = 141
        '
        'ListSEC_Select
        '
        Me.ListSEC_Select.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListSEC_Select.FormattingEnabled = True
        Me.ListSEC_Select.Location = New System.Drawing.Point(50, 68)
        Me.ListSEC_Select.Name = "ListSEC_Select"
        Me.ListSEC_Select.Size = New System.Drawing.Size(212, 264)
        Me.ListSEC_Select.TabIndex = 140
        '
        'btnCamDirSEC
        '
        Me.btnCamDirSEC.BackColor = System.Drawing.Color.Gray
        Me.btnCamDirSEC.Location = New System.Drawing.Point(101, 354)
        Me.btnCamDirSEC.Name = "btnCamDirSEC"
        Me.btnCamDirSEC.Size = New System.Drawing.Size(110, 44)
        Me.btnCamDirSEC.TabIndex = 139
        Me.btnCamDirSEC.Text = "Cambiar Directorio"
        Me.btnCamDirSEC.UseVisualStyleBackColor = False
        '
        'btnEjecSec
        '
        Me.btnEjecSec.BackColor = System.Drawing.Color.Gray
        Me.btnEjecSec.Location = New System.Drawing.Point(870, 190)
        Me.btnEjecSec.Name = "btnEjecSec"
        Me.btnEjecSec.Size = New System.Drawing.Size(110, 44)
        Me.btnEjecSec.TabIndex = 137
        Me.btnEjecSec.Text = "Ejecutar Secuencia"
        Me.btnEjecSec.UseVisualStyleBackColor = False
        '
        'btnPararSec
        '
        Me.btnPararSec.BackColor = System.Drawing.Color.Gray
        Me.btnPararSec.Location = New System.Drawing.Point(870, 256)
        Me.btnPararSec.Name = "btnPararSec"
        Me.btnPararSec.Size = New System.Drawing.Size(110, 44)
        Me.btnPararSec.TabIndex = 135
        Me.btnPararSec.Text = "Parar Secuencia"
        Me.btnPararSec.UseVisualStyleBackColor = False
        '
        'tboxNomSecAct
        '
        Me.tboxNomSecAct.Enabled = False
        Me.tboxNomSecAct.Location = New System.Drawing.Point(429, 25)
        Me.tboxNomSecAct.Name = "tboxNomSecAct"
        Me.tboxNomSecAct.Size = New System.Drawing.Size(341, 24)
        Me.tboxNomSecAct.TabIndex = 134
        Me.tboxNomSecAct.Text = ""
        '
        'btnCrearSec
        '
        Me.btnCrearSec.BackColor = System.Drawing.Color.Gray
        Me.btnCrearSec.Location = New System.Drawing.Point(870, 124)
        Me.btnCrearSec.Name = "btnCrearSec"
        Me.btnCrearSec.Size = New System.Drawing.Size(110, 44)
        Me.btnCrearSec.TabIndex = 133
        Me.btnCrearSec.Text = "Crear Secuencia"
        Me.btnCrearSec.UseVisualStyleBackColor = False
        '
        'btnCargarSec
        '
        Me.btnCargarSec.Image = Global.VisualRobot.My.Resources.Resources.uploadSEC
        Me.btnCargarSec.Location = New System.Drawing.Point(300, 184)
        Me.btnCargarSec.Name = "btnCargarSec"
        Me.btnCargarSec.Size = New System.Drawing.Size(43, 42)
        Me.btnCargarSec.TabIndex = 131
        Me.btnCargarSec.UseVisualStyleBackColor = True
        '
        'tboxSecAct
        '
        Me.tboxSecAct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxSecAct.Location = New System.Drawing.Point(380, 68)
        Me.tboxSecAct.Name = "tboxSecAct"
        Me.tboxSecAct.ReadOnly = True
        Me.tboxSecAct.Size = New System.Drawing.Size(0, 0)
        Me.tboxSecAct.TabIndex = 130
        Me.tboxSecAct.Text = "-> *1+0000192+0000093+0000094+0000095+0000096+000009*"
        '
        'TabDesarrollador
        '
        Me.TabDesarrollador.BackColor = System.Drawing.Color.Silver
        Me.TabDesarrollador.Controls.Add(Me.Label5)
        Me.TabDesarrollador.Controls.Add(Me.RichTextBox1)
        Me.TabDesarrollador.Controls.Add(Me.LabelJOY7)
        Me.TabDesarrollador.Controls.Add(Me.LabelJOY6)
        Me.TabDesarrollador.Controls.Add(Me.LabelJOY5)
        Me.TabDesarrollador.Controls.Add(Me.LabelJOY4)
        Me.TabDesarrollador.Controls.Add(Me.LabelJOY3)
        Me.TabDesarrollador.Controls.Add(Me.LabelJOY2)
        Me.TabDesarrollador.Controls.Add(Me.LabelJOY1)
        Me.TabDesarrollador.Location = New System.Drawing.Point(4, 27)
        Me.TabDesarrollador.Name = "TabDesarrollador"
        Me.TabDesarrollador.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDesarrollador.Size = New System.Drawing.Size(1016, 426)
        Me.TabDesarrollador.TabIndex = 5
        Me.TabDesarrollador.Text = "Desarrollador (No TOCAR)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(597, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "TCP:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(582, 41)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(414, 286)
        Me.RichTextBox1.TabIndex = 75
        Me.RichTextBox1.Text = ""
        '
        'LabelJOY7
        '
        Me.LabelJOY7.AutoSize = True
        Me.LabelJOY7.Location = New System.Drawing.Point(92, 338)
        Me.LabelJOY7.Name = "LabelJOY7"
        Me.LabelJOY7.Size = New System.Drawing.Size(101, 18)
        Me.LabelJOY7.TabIndex = 7
        Me.LabelJOY7.Text = "LabelJOY7"
        '
        'LabelJOY6
        '
        Me.LabelJOY6.AutoSize = True
        Me.LabelJOY6.Location = New System.Drawing.Point(92, 287)
        Me.LabelJOY6.Name = "LabelJOY6"
        Me.LabelJOY6.Size = New System.Drawing.Size(101, 18)
        Me.LabelJOY6.TabIndex = 6
        Me.LabelJOY6.Text = "LabelJOY6"
        '
        'LabelJOY5
        '
        Me.LabelJOY5.AutoSize = True
        Me.LabelJOY5.Location = New System.Drawing.Point(92, 236)
        Me.LabelJOY5.Name = "LabelJOY5"
        Me.LabelJOY5.Size = New System.Drawing.Size(101, 18)
        Me.LabelJOY5.TabIndex = 5
        Me.LabelJOY5.Text = "LabelJOY5"
        '
        'LabelJOY4
        '
        Me.LabelJOY4.AutoSize = True
        Me.LabelJOY4.Location = New System.Drawing.Point(92, 185)
        Me.LabelJOY4.Name = "LabelJOY4"
        Me.LabelJOY4.Size = New System.Drawing.Size(101, 18)
        Me.LabelJOY4.TabIndex = 4
        Me.LabelJOY4.Text = "LabelJOY4"
        '
        'LabelJOY3
        '
        Me.LabelJOY3.AutoSize = True
        Me.LabelJOY3.Location = New System.Drawing.Point(92, 134)
        Me.LabelJOY3.Name = "LabelJOY3"
        Me.LabelJOY3.Size = New System.Drawing.Size(101, 18)
        Me.LabelJOY3.TabIndex = 3
        Me.LabelJOY3.Text = "LabelJOY3"
        '
        'LabelJOY2
        '
        Me.LabelJOY2.AutoSize = True
        Me.LabelJOY2.Location = New System.Drawing.Point(92, 83)
        Me.LabelJOY2.Name = "LabelJOY2"
        Me.LabelJOY2.Size = New System.Drawing.Size(101, 18)
        Me.LabelJOY2.TabIndex = 2
        Me.LabelJOY2.Text = "LabelJOY2"
        '
        'LabelJOY1
        '
        Me.LabelJOY1.AutoSize = True
        Me.LabelJOY1.Location = New System.Drawing.Point(92, 32)
        Me.LabelJOY1.Name = "LabelJOY1"
        Me.LabelJOY1.Size = New System.Drawing.Size(101, 18)
        Me.LabelJOY1.TabIndex = 1
        Me.LabelJOY1.Text = "LabelJOY1"
        '
        'tboxModoAct
        '
        Me.tboxModoAct.Enabled = False
        Me.tboxModoAct.Location = New System.Drawing.Point(283, 17)
        Me.tboxModoAct.Name = "tboxModoAct"
        Me.tboxModoAct.Size = New System.Drawing.Size(412, 24)
        Me.tboxModoAct.TabIndex = 125
        Me.tboxModoAct.Text = ""
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.GRE_LED_Mode)
        Me.Panel5.Controls.Add(Me.YEL_LED_Mode)
        Me.Panel5.Controls.Add(Me.RED_LED_Mode)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.EstadoPingRobot)
        Me.Panel5.Controls.Add(Me.EstadoIP_Robot)
        Me.Panel5.Controls.Add(Me.tboxModoAct)
        Me.Panel5.Location = New System.Drawing.Point(-2, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1024, 58)
        Me.Panel5.TabIndex = 64
        '
        'GRE_LED_Mode
        '
        Me.GRE_LED_Mode.BackColor = System.Drawing.Color.White
        Me.GRE_LED_Mode.Image = Global.VisualRobot.My.Resources.Resources.Led_Gre_OFF
        Me.GRE_LED_Mode.InitialImage = Nothing
        Me.GRE_LED_Mode.Location = New System.Drawing.Point(228, 10)
        Me.GRE_LED_Mode.Name = "GRE_LED_Mode"
        Me.GRE_LED_Mode.Size = New System.Drawing.Size(38, 38)
        Me.GRE_LED_Mode.TabIndex = 133
        Me.GRE_LED_Mode.TabStop = False
        '
        'YEL_LED_Mode
        '
        Me.YEL_LED_Mode.BackColor = System.Drawing.Color.White
        Me.YEL_LED_Mode.Image = Global.VisualRobot.My.Resources.Resources.Led_Yel_OFF
        Me.YEL_LED_Mode.InitialImage = Nothing
        Me.YEL_LED_Mode.Location = New System.Drawing.Point(169, 10)
        Me.YEL_LED_Mode.Name = "YEL_LED_Mode"
        Me.YEL_LED_Mode.Size = New System.Drawing.Size(38, 38)
        Me.YEL_LED_Mode.TabIndex = 132
        Me.YEL_LED_Mode.TabStop = False
        '
        'RED_LED_Mode
        '
        Me.RED_LED_Mode.BackColor = System.Drawing.Color.White
        Me.RED_LED_Mode.Image = Global.VisualRobot.My.Resources.Resources.Led_Red_OFF
        Me.RED_LED_Mode.InitialImage = Nothing
        Me.RED_LED_Mode.Location = New System.Drawing.Point(110, 10)
        Me.RED_LED_Mode.Name = "RED_LED_Mode"
        Me.RED_LED_Mode.Size = New System.Drawing.Size(38, 38)
        Me.RED_LED_Mode.TabIndex = 131
        Me.RED_LED_Mode.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(28, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 53)
        Me.PictureBox2.TabIndex = 130
        Me.PictureBox2.TabStop = False
        '
        'txtSecCarg
        '
        Me.txtSecCarg.Filter = "Secuencia|* .sec"
        Me.txtSecCarg.InitialDirectory = """/"""
        '
        'SaveSec
        '
        Me.SaveSec.Filter = "Secuencia|* .sec"
        '
        'ProgressBarGripper
        '
        Me.ProgressBarGripper.Location = New System.Drawing.Point(370, 279)
        Me.ProgressBarGripper.Maximum = 51
        Me.ProgressBarGripper.Name = "ProgressBarGripper"
        Me.ProgressBarGripper.Size = New System.Drawing.Size(133, 23)
        Me.ProgressBarGripper.Step = 1
        Me.ProgressBarGripper.TabIndex = 141
        Me.ProgressBarGripper.UseWaitCursor = True
        '
        'Ventana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1020, 539)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Screens)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventana"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Interfaz MECA-ARM"
        Me.TabControlManual.ResumeLayout(False)
        Me.TabControlManual.PerformLayout()
        CType(Me.nupMotor1Man, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMotor2Man, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMotor3Man, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMotor4Man, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVelocidadMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMotor5Man, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupMotor6Man, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabHome.ResumeLayout(False)
        Me.TabHome.PerformLayout()
        CType(Me.EstadoPingRobot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Screens.ResumeLayout(False)
        Me.TabJOG.ResumeLayout(False)
        Me.TabJOG.PerformLayout()
        CType(Me.FlechaVelJOGJoy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVelocidadJOG6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVelocidadJOG5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVelocidadJOG4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVelocidadJOG3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVelocidadJOG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVelocidadJOG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConfiguracion.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabSecuencia.ResumeLayout(False)
        Me.TabDesarrollador.ResumeLayout(False)
        Me.TabDesarrollador.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.GRE_LED_Mode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YEL_LED_Mode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RED_LED_Mode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TabControlManual As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMotor1 As Button
    Friend WithEvents nupMotor1Man As NumericUpDown
    Friend WithEvents nupMotor2Man As NumericUpDown
    Friend WithEvents BtnSend As Button
    Friend WithEvents DisPosMotor6 As Button
    Friend WithEvents Clear As Button
    Friend WithEvents nupMotor3Man As NumericUpDown
    Friend WithEvents Clock As Button
    Friend WithEvents AumPosMotor6 As Button
    Friend WithEvents PrevManual As TextBox
    Friend WithEvents nupMotor4Man As NumericUpDown
    Friend WithEvents lblVelocidad As Label
    Friend WithEvents DisPosMotor5 As Button
    Friend WithEvents cmbVelocidadMan As NumericUpDown
    Friend WithEvents nupMotor5Man As NumericUpDown
    Friend WithEvents btnPosOrigenMan As Button
    Friend WithEvents AumPosMotor5 As Button
    Friend WithEvents lblMotor1 As Label
    Friend WithEvents DisPosMotor4 As Button
    Friend WithEvents lblMotor2 As Label
    Friend WithEvents AumPosMotor4 As Button
    Friend WithEvents lblMotor3 As Label
    Friend WithEvents DisPosMotor3 As Button
    Friend WithEvents lblMotor4 As Label
    Friend WithEvents AumPosMotor3 As Button
    Friend WithEvents lblMotor5 As Label
    Friend WithEvents DisPosMotor2 As Button
    Friend WithEvents nupMotor6Man As NumericUpDown
    Friend WithEvents AumPosMotor2 As Button
    Friend WithEvents lblMotor6 As Label
    Friend WithEvents DisPosMotor1 As Button
    Friend WithEvents btnMotor2 As Button
    Friend WithEvents AumPosMotor1 As Button
    Friend WithEvents btnMotor3 As Button
    Friend WithEvents btnMotor4 As Button
    Friend WithEvents btnMotor5 As Button
    Friend WithEvents btnMotor6 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TabHome As TabPage
    Friend WithEvents tboxHomeEstadoEJE6 As TextBox
    Friend WithEvents tboxHomeEstadoEJE3 As TextBox
    Friend WithEvents tboxHomeEstadoEJE5 As TextBox
    Friend WithEvents tboxHomeEstadoEJE2 As TextBox
    Friend WithEvents tboxHomeEstadoEJE4 As TextBox
    Friend WithEvents tboxHomeEstadoEJE1 As TextBox
    Friend WithEvents lblPinza As Label
    Friend WithEvents lblMano As Label
    Friend WithEvents lblMuñeca As Label
    Friend WithEvents lblCodo As Label
    Friend WithEvents lblHombro As Label
    Friend WithEvents lblBase As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnTabHome As Button
    Friend WithEvents BtnTabCtrlManual As Button
    Friend WithEvents Screens As TabControl
    Friend WithEvents TabConfiguracion As TabPage
    Friend WithEvents EstadoPingRobot As System.Windows.Forms.PictureBox
    Friend WithEvents BtnDesconectar As System.Windows.Forms.Button
    Friend WithEvents EstadoIP_Robot As System.Windows.Forms.TextBox
    Friend WithEvents TBox_IpRobot As System.Windows.Forms.TextBox
    Friend WithEvents BtnConnectRobot As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabJOG As System.Windows.Forms.TabPage
    Friend WithEvents BtnTabConfig As System.Windows.Forms.Button
    Friend WithEvents BtnTabJOG As System.Windows.Forms.Button
    Friend WithEvents btnE1_NEG_JOG As System.Windows.Forms.Button
    Friend WithEvents btnE1_POS_JOG As System.Windows.Forms.Button
    Friend WithEvents btnHab_JOG As System.Windows.Forms.Button
    Friend WithEvents lblHabilitar_Jog As System.Windows.Forms.Label
    Friend WithEvents btnHabJOG As System.Windows.Forms.Button
    Friend WithEvents tboxJOGEstadoEJE6 As System.Windows.Forms.TextBox
    Friend WithEvents tboxJOGEstadoEJE5 As System.Windows.Forms.TextBox
    Friend WithEvents tboxJOGEstadoEJE4 As System.Windows.Forms.TextBox
    Friend WithEvents tboxJOGEstadoEJE3 As System.Windows.Forms.TextBox
    Friend WithEvents tboxJOGEstadoEJE2 As System.Windows.Forms.TextBox
    Friend WithEvents tboxJOGEstadoEJE1 As System.Windows.Forms.TextBox
    Friend WithEvents btnE6_NEG_JOG As System.Windows.Forms.Button
    Friend WithEvents btnE6_POS_JOG As System.Windows.Forms.Button
    Friend WithEvents btnE5_NEG_JOG As System.Windows.Forms.Button
    Friend WithEvents btnE5_POS_JOG As System.Windows.Forms.Button
    Friend WithEvents btnE4_NEG_JOG As System.Windows.Forms.Button
    Friend WithEvents btnE4_POS_JOG As System.Windows.Forms.Button
    Friend WithEvents btnE3_NEG_JOG As System.Windows.Forms.Button
    Friend WithEvents btnE3_POS_JOG As System.Windows.Forms.Button
    Friend WithEvents btnE2_NEG_JOG As System.Windows.Forms.Button
    Friend WithEvents btnE2_POS_JOG As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbVelocidadJOG6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbVelocidadJOG5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbVelocidadJOG4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbVelocidadJOG3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbVelocidadJOG2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbVelocidadJOG1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabDesarrollador As TabPage
    Friend WithEvents LabelJOY7 As Label
    Friend WithEvents LabelJOY6 As Label
    Friend WithEvents LabelJOY5 As Label
    Friend WithEvents LabelJOY4 As Label
    Friend WithEvents LabelJOY3 As Label
    Friend WithEvents LabelJOY2 As Label
    Friend WithEvents LabelJOY1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents tboxModoAct As RichTextBox
    Friend WithEvents TBox_PortRobot As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btnHab_Man As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDesrollador As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TabSecuencia As System.Windows.Forms.TabPage
    Friend WithEvents btnTabSec As System.Windows.Forms.Button
    Friend WithEvents txtSecCarg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnPosOrigenJOG As Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnCargarConf As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmbStepEje1 As ComboBox
    Friend WithEvents cmbStepEje6 As ComboBox
    Friend WithEvents cmbStepEje5 As ComboBox
    Friend WithEvents cmbStepEje4 As ComboBox
    Friend WithEvents cmbStepEje3 As ComboBox
    Friend WithEvents cmbStepEje2 As ComboBox
    Friend WithEvents btnCargarSec As Button
    Friend WithEvents btnCrearSec As Button
    Friend WithEvents SaveSec As SaveFileDialog
    Friend WithEvents btnGuardarMov As Button
    Friend WithEvents btnGuardarSec As Button
    Friend WithEvents RED_LED_Mode As PictureBox
    Friend WithEvents GRE_LED_Mode As PictureBox
    Friend WithEvents YEL_LED_Mode As PictureBox
    Friend WithEvents btnPararSec As Button
    Friend WithEvents tboxNomSecAct As RichTextBox
    Friend WithEvents btnEjecSec As Button
    Friend WithEvents btnCamDirSEC As Button
    Friend WithEvents ListSEC_Select As ListBox
    Friend WithEvents FolderBrowserSEC As FolderBrowserDialog
    Friend WithEvents lboxSecAct As ListBox
    Friend WithEvents tboxSecAct As RichTextBox
    Friend WithEvents FlechaVelJOGJoy As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGripperOFF As Button
    Friend WithEvents btnGripperON As Button
    Friend WithEvents ProgressBarGripper As ProgressBar
End Class
