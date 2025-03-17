namespace Supervisory
{
    partial class formSTCSupervisory
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSTCSupervisory));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbStoBits = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.lblStopbits = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lbComPort = new System.Windows.Forms.Label();
            this.btnConect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblReading = new System.Windows.Forms.Label();
            this.cSerial = new System.IO.Ports.SerialPort(this.components);
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.tank1 = new AdvancedHMIControls.Tank();
            this.tank2 = new AdvancedHMIControls.Tank();
            this.pipe1 = new AdvancedHMIControls.Pipe();
            this.valve = new AdvancedHMIControls.PneumaticBallValve();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pipe3 = new AdvancedHMIControls.Pipe();
            this.pipe4 = new AdvancedHMIControls.Pipe();
            this.Pump1 = new AdvancedHMIControls.WaterPump();
            this.pipe6 = new AdvancedHMIControls.Pipe();
            this.pipe5 = new AdvancedHMIControls.Pipe();
            this.pipe8 = new AdvancedHMIControls.Pipe();
            this.pipe7 = new AdvancedHMIControls.Pipe();
            this.pipe9 = new AdvancedHMIControls.Pipe();
            this.pipe2 = new AdvancedHMIControls.Pipe();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbStoBits);
            this.groupBox2.Controls.Add(this.cbDataBits);
            this.groupBox2.Controls.Add(this.cbParity);
            this.groupBox2.Controls.Add(this.cbBaudRate);
            this.groupBox2.Controls.Add(this.cbComPort);
            this.groupBox2.Controls.Add(this.lblStopbits);
            this.groupBox2.Controls.Add(this.lblDataBits);
            this.groupBox2.Controls.Add(this.lblParity);
            this.groupBox2.Controls.Add(this.lblBaudRate);
            this.groupBox2.Controls.Add(this.lbComPort);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(601, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 367);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Communication";
            // 
            // cbStoBits
            // 
            this.cbStoBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStoBits.FormattingEnabled = true;
            this.cbStoBits.IntegralHeight = false;
            this.cbStoBits.Location = new System.Drawing.Point(26, 329);
            this.cbStoBits.Name = "cbStoBits";
            this.cbStoBits.Size = new System.Drawing.Size(121, 28);
            this.cbStoBits.TabIndex = 1;
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.IntegralHeight = false;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(26, 265);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 28);
            this.cbDataBits.TabIndex = 8;
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.IntegralHeight = false;
            this.cbParity.Location = new System.Drawing.Point(26, 197);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 28);
            this.cbParity.TabIndex = 7;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownHeight = 100;
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.IntegralHeight = false;
            this.cbBaudRate.ItemHeight = 20;
            this.cbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "750",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(26, 134);
            this.cbBaudRate.MaxDropDownItems = 7;
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 28);
            this.cbBaudRate.TabIndex = 6;
            // 
            // cbComPort
            // 
            this.cbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.IntegralHeight = false;
            this.cbComPort.Location = new System.Drawing.Point(26, 69);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 28);
            this.cbComPort.TabIndex = 5;
            // 
            // lblStopbits
            // 
            this.lblStopbits.AutoSize = true;
            this.lblStopbits.Location = new System.Drawing.Point(22, 306);
            this.lblStopbits.Name = "lblStopbits";
            this.lblStopbits.Size = new System.Drawing.Size(74, 20);
            this.lblStopbits.TabIndex = 4;
            this.lblStopbits.Text = "Stop Bits";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(22, 242);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(75, 20);
            this.lblDataBits.TabIndex = 3;
            this.lblDataBits.Text = "Data Bits";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(22, 174);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(48, 20);
            this.lblParity.TabIndex = 2;
            this.lblParity.Text = "Parity";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(22, 111);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(86, 20);
            this.lblBaudRate.TabIndex = 1;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lbComPort
            // 
            this.lbComPort.AutoSize = true;
            this.lbComPort.Location = new System.Drawing.Point(22, 46);
            this.lbComPort.Name = "lbComPort";
            this.lbComPort.Size = new System.Drawing.Size(75, 20);
            this.lbComPort.TabIndex = 0;
            this.lbComPort.Text = "Com Port";
            // 
            // btnConect
            // 
            this.btnConect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConect.Location = new System.Drawing.Point(626, 435);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(121, 45);
            this.btnConect.TabIndex = 3;
            this.btnConect.Text = "Connect";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click_1);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(626, 489);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(121, 45);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarms";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 379);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // lblReading
            // 
            this.lblReading.AutoSize = true;
            this.lblReading.BackColor = System.Drawing.Color.White;
            this.lblReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReading.Location = new System.Drawing.Point(259, 38);
            this.lblReading.Name = "lblReading";
            this.lblReading.Size = new System.Drawing.Size(49, 20);
            this.lblReading.TabIndex = 2;
            this.lblReading.Text = "0000";
            // 
            // cSerial
            // 
            this.cSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.cSerial_DataReceived);
            // 
            // ethernetIPforCLXCom1
            // 
            this.ethernetIPforCLXCom1.CIPConnectionSize = 508;
            this.ethernetIPforCLXCom1.DisableMultiServiceRequest = false;
            this.ethernetIPforCLXCom1.DisableSubscriptions = false;
            this.ethernetIPforCLXCom1.IPAddress = "192.168.0.10";
            this.ethernetIPforCLXCom1.PollRateOverride = 500;
            this.ethernetIPforCLXCom1.Port = 44818;
            this.ethernetIPforCLXCom1.ProcessorSlot = 0;
            this.ethernetIPforCLXCom1.RoutePath = null;
            this.ethernetIPforCLXCom1.Timeout = 4000;
            // 
            // tank1
            // 
            this.tank1.BackColor = System.Drawing.Color.Transparent;
            this.tank1.ComComponent = this.ethernetIPforCLXCom1;
            this.tank1.HighlightColor = System.Drawing.Color.Red;
            this.tank1.HighlightKeyCharacter = "!";
            this.tank1.KeypadText = null;
            this.tank1.Location = new System.Drawing.Point(242, 24);
            this.tank1.MaxValue = 1000;
            this.tank1.MinValue = 0;
            this.tank1.Name = "tank1";
            this.tank1.NumericFormat = null;
            this.tank1.PLCAddressKeypad = "";
            this.tank1.PLCAddressText = "";
            this.tank1.PLCAddressValue = "";
            this.tank1.PLCAddressVisible = "";
            this.tank1.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tank1.Size = new System.Drawing.Size(148, 173);
            this.tank1.TabIndex = 12;
            this.tank1.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.tank1.TextPrefix = null;
            this.tank1.TextSuffix = null;
            this.tank1.Value = 0F;
            this.tank1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tank2
            // 
            this.tank2.BackColor = System.Drawing.Color.Transparent;
            this.tank2.ComComponent = this.ethernetIPforCLXCom1;
            this.tank2.HighlightColor = System.Drawing.Color.Red;
            this.tank2.HighlightKeyCharacter = "!";
            this.tank2.KeypadText = null;
            this.tank2.Location = new System.Drawing.Point(441, 234);
            this.tank2.MaxValue = 1000;
            this.tank2.MinValue = 0;
            this.tank2.Name = "tank2";
            this.tank2.NumericFormat = null;
            this.tank2.PLCAddressKeypad = "";
            this.tank2.PLCAddressText = "";
            this.tank2.PLCAddressValue = "";
            this.tank2.PLCAddressVisible = "";
            this.tank2.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tank2.Size = new System.Drawing.Size(148, 173);
            this.tank2.TabIndex = 13;
            this.tank2.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.tank2.TextPrefix = null;
            this.tank2.TextSuffix = null;
            this.tank2.Value = 0F;
            this.tank2.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pipe1
            // 
            this.pipe1.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe1.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Straight;
            this.pipe1.HighlightColor = System.Drawing.Color.Red;
            this.pipe1.HighlightKeyCharacter = "!";
            this.pipe1.KeypadText = null;
            this.pipe1.Location = new System.Drawing.Point(377, 123);
            this.pipe1.Name = "pipe1";
            this.pipe1.NumericFormat = null;
            this.pipe1.PLCAddressKeypad = "";
            this.pipe1.PLCAddressRotate = "";
            this.pipe1.PLCAddressText = "";
            this.pipe1.PLCAddressVisible = "";
            this.pipe1.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.pipe1.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe1.Size = new System.Drawing.Size(48, 23);
            this.pipe1.TabIndex = 14;
            this.pipe1.TextPrefix = null;
            this.pipe1.TextSuffix = null;
            // 
            // valve
            // 
            this.valve.ComComponent = this.ethernetIPforCLXCom1;
            this.valve.ForeColor = System.Drawing.Color.LightGray;
            this.valve.Location = new System.Drawing.Point(424, 88);
            this.valve.Name = "valve";
            this.valve.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.valve.PLCAddressClick = "";
            this.valve.PLCAddressText = "";
            this.valve.PLCAddressValue = "";
            this.valve.PLCAddressVisible = "";
            this.valve.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.valve.Size = new System.Drawing.Size(60, 60);
            this.valve.TabIndex = 15;
            this.valve.Value = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 23);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pipe3
            // 
            this.pipe3.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe3.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Straight;
            this.pipe3.HighlightColor = System.Drawing.Color.Red;
            this.pipe3.HighlightKeyCharacter = "!";
            this.pipe3.KeypadText = null;
            this.pipe3.Location = new System.Drawing.Point(513, 167);
            this.pipe3.Name = "pipe3";
            this.pipe3.NumericFormat = null;
            this.pipe3.PLCAddressKeypad = "";
            this.pipe3.PLCAddressRotate = "";
            this.pipe3.PLCAddressText = "";
            this.pipe3.PLCAddressVisible = "";
            this.pipe3.Rotation = System.Drawing.RotateFlipType.Rotate90FlipXY;
            this.pipe3.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe3.Size = new System.Drawing.Size(22, 70);
            this.pipe3.TabIndex = 17;
            this.pipe3.TextPrefix = null;
            this.pipe3.TextSuffix = null;
            // 
            // pipe4
            // 
            this.pipe4.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe4.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Straight;
            this.pipe4.HighlightColor = System.Drawing.Color.Red;
            this.pipe4.HighlightKeyCharacter = "!";
            this.pipe4.KeypadText = null;
            this.pipe4.Location = new System.Drawing.Point(404, 327);
            this.pipe4.Name = "pipe4";
            this.pipe4.NumericFormat = null;
            this.pipe4.PLCAddressKeypad = "";
            this.pipe4.PLCAddressRotate = "";
            this.pipe4.PLCAddressText = "";
            this.pipe4.PLCAddressVisible = "";
            this.pipe4.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.pipe4.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe4.Size = new System.Drawing.Size(48, 23);
            this.pipe4.TabIndex = 18;
            this.pipe4.TextPrefix = null;
            this.pipe4.TextSuffix = null;
            // 
            // Pump1
            // 
            this.Pump1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Pump1.ComComponent = this.ethernetIPforCLXCom1;
            this.Pump1.Location = new System.Drawing.Point(235, 294);
            this.Pump1.Name = "Pump1";
            this.Pump1.PLCAddressText = "";
            this.Pump1.PLCAddressValue = "";
            this.Pump1.PLCAddressVisible = "";
            this.Pump1.Size = new System.Drawing.Size(170, 207);
            this.Pump1.TabIndex = 19;
            this.Pump1.Tag = "";
            this.Pump1.Value = false;
            // 
            // pipe6
            // 
            this.pipe6.BackColor = System.Drawing.Color.Transparent;
            this.pipe6.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe6.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Elbow;
            this.pipe6.HighlightColor = System.Drawing.Color.Red;
            this.pipe6.HighlightKeyCharacter = "!";
            this.pipe6.KeypadText = null;
            this.pipe6.Location = new System.Drawing.Point(356, 243);
            this.pipe6.Name = "pipe6";
            this.pipe6.NumericFormat = null;
            this.pipe6.PLCAddressKeypad = "";
            this.pipe6.PLCAddressRotate = "";
            this.pipe6.PLCAddressText = "";
            this.pipe6.PLCAddressVisible = "";
            this.pipe6.Rotation = System.Drawing.RotateFlipType.Rotate270FlipY;
            this.pipe6.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe6.Size = new System.Drawing.Size(49, 51);
            this.pipe6.TabIndex = 21;
            this.pipe6.TextPrefix = null;
            this.pipe6.TextSuffix = null;
            // 
            // pipe5
            // 
            this.pipe5.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe5.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Straight;
            this.pipe5.HighlightColor = System.Drawing.Color.Red;
            this.pipe5.HighlightKeyCharacter = "!";
            this.pipe5.KeypadText = null;
            this.pipe5.Location = new System.Drawing.Point(254, 249);
            this.pipe5.Name = "pipe5";
            this.pipe5.NumericFormat = null;
            this.pipe5.PLCAddressKeypad = "";
            this.pipe5.PLCAddressRotate = "";
            this.pipe5.PLCAddressText = "";
            this.pipe5.PLCAddressVisible = "";
            this.pipe5.Rotation = System.Drawing.RotateFlipType.Rotate180FlipY;
            this.pipe5.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe5.Size = new System.Drawing.Size(103, 19);
            this.pipe5.TabIndex = 22;
            this.pipe5.TextPrefix = null;
            this.pipe5.TextSuffix = null;
            // 
            // pipe8
            // 
            this.pipe8.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe8.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Straight;
            this.pipe8.HighlightColor = System.Drawing.Color.Red;
            this.pipe8.HighlightKeyCharacter = "!";
            this.pipe8.KeypadText = null;
            this.pipe8.Location = new System.Drawing.Point(203, 64);
            this.pipe8.Name = "pipe8";
            this.pipe8.NumericFormat = null;
            this.pipe8.PLCAddressKeypad = "";
            this.pipe8.PLCAddressRotate = "";
            this.pipe8.PLCAddressText = "";
            this.pipe8.PLCAddressVisible = "";
            this.pipe8.Rotation = System.Drawing.RotateFlipType.Rotate270FlipX;
            this.pipe8.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe8.Size = new System.Drawing.Size(22, 163);
            this.pipe8.TabIndex = 24;
            this.pipe8.TextPrefix = null;
            this.pipe8.TextSuffix = null;
            // 
            // pipe7
            // 
            this.pipe7.BackColor = System.Drawing.Color.Transparent;
            this.pipe7.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe7.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Elbow;
            this.pipe7.HighlightColor = System.Drawing.Color.Red;
            this.pipe7.HighlightKeyCharacter = "!";
            this.pipe7.KeypadText = null;
            this.pipe7.Location = new System.Drawing.Point(196, 226);
            this.pipe7.Name = "pipe7";
            this.pipe7.NumericFormat = null;
            this.pipe7.PLCAddressKeypad = "";
            this.pipe7.PLCAddressRotate = "";
            this.pipe7.PLCAddressText = "";
            this.pipe7.PLCAddressVisible = "";
            this.pipe7.Rotation = System.Drawing.RotateFlipType.Rotate270FlipX;
            this.pipe7.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe7.Size = new System.Drawing.Size(59, 47);
            this.pipe7.TabIndex = 23;
            this.pipe7.TextPrefix = null;
            this.pipe7.TextSuffix = null;
            // 
            // pipe9
            // 
            this.pipe9.BackColor = System.Drawing.Color.Transparent;
            this.pipe9.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe9.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Elbow;
            this.pipe9.HighlightColor = System.Drawing.Color.Red;
            this.pipe9.HighlightKeyCharacter = "!";
            this.pipe9.KeypadText = null;
            this.pipe9.Location = new System.Drawing.Point(196, 35);
            this.pipe9.Name = "pipe9";
            this.pipe9.NumericFormat = null;
            this.pipe9.PLCAddressKeypad = "";
            this.pipe9.PLCAddressRotate = "";
            this.pipe9.PLCAddressText = "";
            this.pipe9.PLCAddressVisible = "";
            this.pipe9.Rotation = System.Drawing.RotateFlipType.Rotate270FlipXY;
            this.pipe9.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe9.Size = new System.Drawing.Size(59, 47);
            this.pipe9.TabIndex = 25;
            this.pipe9.TextPrefix = null;
            this.pipe9.TextSuffix = null;
            // 
            // pipe2
            // 
            this.pipe2.BackColor = System.Drawing.Color.Transparent;
            this.pipe2.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe2.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Elbow;
            this.pipe2.HighlightColor = System.Drawing.Color.Red;
            this.pipe2.HighlightKeyCharacter = "!";
            this.pipe2.KeypadText = null;
            this.pipe2.Location = new System.Drawing.Point(483, 120);
            this.pipe2.Name = "pipe2";
            this.pipe2.NumericFormat = null;
            this.pipe2.PLCAddressKeypad = "";
            this.pipe2.PLCAddressRotate = "";
            this.pipe2.PLCAddressText = "";
            this.pipe2.PLCAddressVisible = "";
            this.pipe2.Rotation = System.Drawing.RotateFlipType.Rotate270FlipY;
            this.pipe2.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe2.Size = new System.Drawing.Size(59, 47);
            this.pipe2.TabIndex = 16;
            this.pipe2.TextPrefix = null;
            this.pipe2.TextSuffix = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "mL";
            // 
            // formSTCSupervisory
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pipe9);
            this.Controls.Add(this.pipe8);
            this.Controls.Add(this.pipe7);
            this.Controls.Add(this.pipe5);
            this.Controls.Add(this.pipe6);
            this.Controls.Add(this.Pump1);
            this.Controls.Add(this.pipe4);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.valve);
            this.Controls.Add(this.pipe1);
            this.Controls.Add(this.tank2);
            this.Controls.Add(this.lblReading);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConect);
            this.Controls.Add(this.tank1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pipe3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSTCSupervisory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STC Supervisory 1.0.1";
            this.Load += new System.EventHandler(this.formSTCSupervisory_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbStoBits;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label lblStopbits;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lbComPort;
        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.IO.Ports.SerialPort cSerial;
        private System.Windows.Forms.Label lblReading;
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private AdvancedHMIControls.Tank tank1;
        private AdvancedHMIControls.Tank tank2;
        private AdvancedHMIControls.Pipe pipe1;
        private AdvancedHMIControls.PneumaticBallValve valve;
        private System.Windows.Forms.ImageList imageList1;
        private AdvancedHMIControls.Pipe pipe3;
        private AdvancedHMIControls.Pipe pipe4;
        private AdvancedHMIControls.WaterPump Pump1;
        private AdvancedHMIControls.Pipe pipe6;
        private AdvancedHMIControls.Pipe pipe5;
        private AdvancedHMIControls.Pipe pipe8;
        private AdvancedHMIControls.Pipe pipe7;
        private AdvancedHMIControls.Pipe pipe9;
        private AdvancedHMIControls.Pipe pipe2;
        private System.Windows.Forms.Label label1;
    }
}

