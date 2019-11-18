namespace Market
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xuıBanner1 = new XanderUI.XUIBanner();
            this.xuıBarGraph1 = new XanderUI.XUIBarGraph();
            this.xuıButton1 = new XanderUI.XUIButton();
            this.xuıCard1 = new XanderUI.XUICard();
            this.xuıCheckBox1 = new XanderUI.XUICheckBox();
            this.xuıCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.xuıColorPane1 = new XanderUI.XUIColorPane();
            this.xuıColorPicker1 = new XanderUI.XUIColorPicker();
            this.xuıCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.xuıFlatMenuStrip1 = new XanderUI.XUIFlatMenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuıFlatProgressBar1 = new XanderUI.XUIFlatProgressBar();
            this.xuıFlatTab1 = new XanderUI.XUIFlatTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xuıGauge1 = new XanderUI.XUIGauge();
            this.xuıGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuıJoyStick1 = new XanderUI.XUIJoyStick();
            this.xuıLineGraph1 = new XanderUI.XUILineGraph();
            this.xuıNavigationBar1 = new XanderUI.XUINavigationBar();
            this.xuıObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.xuıPieGraph1 = new XanderUI.XUIPieGraph();
            this.xuıRadio1 = new XanderUI.XUIRadio();
            this.xuıSegment1 = new XanderUI.XUISegment();
            this.xuıSlider1 = new XanderUI.XUISlider();
            this.xuıSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.xuıSuperButton1 = new XanderUI.XUISuperButton();
            this.xuıSwitch1 = new XanderUI.XUISwitch();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuıFlatMenuStrip1.SuspendLayout();
            this.xuıFlatTab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuıBanner1
            // 
            this.xuıBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuıBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuıBanner1.BorderColor = System.Drawing.Color.White;
            this.xuıBanner1.ForeColor = System.Drawing.Color.White;
            this.xuıBanner1.Location = new System.Drawing.Point(315, 27);
            this.xuıBanner1.Name = "xuıBanner1";
            this.xuıBanner1.Size = new System.Drawing.Size(100, 20);
            this.xuıBanner1.TabIndex = 0;
            this.xuıBanner1.Text = "xuıBanner1";
            this.xuıBanner1.Click += new System.EventHandler(this.xuıBanner1_Click);
            // 
            // xuıBarGraph1
            // 
            this.xuıBarGraph1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.xuıBarGraph1.GraphOrientation = XanderUI.XUIBarGraph.Orientation.Vertical;
            this.xuıBarGraph1.GraphStyle = XanderUI.XUIBarGraph.Style.Material;
            this.xuıBarGraph1.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("xuıBarGraph1.Items")));
            this.xuıBarGraph1.Location = new System.Drawing.Point(315, 131);
            this.xuıBarGraph1.Name = "xuıBarGraph1";
            this.xuıBarGraph1.ShowGrid = false;
            this.xuıBarGraph1.Size = new System.Drawing.Size(294, 200);
            this.xuıBarGraph1.Sorting = XanderUI.XUIBarGraph.SortStyle.Normal;
            this.xuıBarGraph1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            this.xuıBarGraph1.TabIndex = 1;
            this.xuıBarGraph1.Text = "xuıBarGraph1";
            this.xuıBarGraph1.TextAlignment = XanderUI.XUIBarGraph.Aligning.Far;
            this.xuıBarGraph1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.xuıBarGraph1.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            // 
            // xuıButton1
            // 
            this.xuıButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuıButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıButton1.ButtonImage")));
            this.xuıButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuıButton1.ButtonText = "Button";
            this.xuıButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuıButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuıButton1.CornerRadius = 5;
            this.xuıButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuıButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuıButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuıButton1.Location = new System.Drawing.Point(968, 64);
            this.xuıButton1.Name = "xuıButton1";
            this.xuıButton1.Size = new System.Drawing.Size(200, 50);
            this.xuıButton1.TabIndex = 2;
            this.xuıButton1.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuıButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuıCard1
            // 
            this.xuıCard1.BackColor = System.Drawing.Color.Transparent;
            this.xuıCard1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuıCard1.Color2 = System.Drawing.Color.LimeGreen;
            this.xuıCard1.ForeColor = System.Drawing.Color.White;
            this.xuıCard1.Location = new System.Drawing.Point(942, 140);
            this.xuıCard1.Name = "xuıCard1";
            this.xuıCard1.Size = new System.Drawing.Size(320, 170);
            this.xuıCard1.TabIndex = 3;
            this.xuıCard1.Text = "xuıCard1";
            this.xuıCard1.Text1 = "Savings Card";
            this.xuıCard1.Text2 = "1234 5678 9101 1121";
            this.xuıCard1.Text3 = "Exp: 01/02 - 03/04";
            // 
            // xuıCheckBox1
            // 
            this.xuıCheckBox1.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuıCheckBox1.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuıCheckBox1.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuıCheckBox1.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.xuıCheckBox1.Checked = false;
            this.xuıCheckBox1.ForeColor = System.Drawing.Color.White;
            this.xuıCheckBox1.Location = new System.Drawing.Point(315, 357);
            this.xuıCheckBox1.Name = "xuıCheckBox1";
            this.xuıCheckBox1.Size = new System.Drawing.Size(100, 20);
            this.xuıCheckBox1.TabIndex = 4;
            this.xuıCheckBox1.Text = "xuıCheckBox1";
            this.xuıCheckBox1.TickThickness = 2;
            // 
            // xuıCircleProgressBar1
            // 
            this.xuıCircleProgressBar1.AnimationSpeed = 5;
            this.xuıCircleProgressBar1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.xuıCircleProgressBar1.FilledColorAlpha = 130;
            this.xuıCircleProgressBar1.FilledThickness = 40;
            this.xuıCircleProgressBar1.IsAnimated = false;
            this.xuıCircleProgressBar1.Location = new System.Drawing.Point(315, 383);
            this.xuıCircleProgressBar1.Name = "xuıCircleProgressBar1";
            this.xuıCircleProgressBar1.Percentage = 63;
            this.xuıCircleProgressBar1.ShowText = true;
            this.xuıCircleProgressBar1.Size = new System.Drawing.Size(100, 102);
            this.xuıCircleProgressBar1.TabIndex = 5;
            this.xuıCircleProgressBar1.TextColor = System.Drawing.Color.Gray;
            this.xuıCircleProgressBar1.TextSize = 25;
            this.xuıCircleProgressBar1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.xuıCircleProgressBar1.UnfilledThickness = 24;
            // 
            // xuıColorPane1
            // 
            this.xuıColorPane1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.xuıColorPane1.Color10 = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.xuıColorPane1.Color11 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.xuıColorPane1.Color12 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
            this.xuıColorPane1.Color13 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(216)))), ((int)(((byte)(54)))));
            this.xuıColorPane1.Color14 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(120)))));
            this.xuıColorPane1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.xuıColorPane1.Color3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(11)))), ((int)(((byte)(56)))));
            this.xuıColorPane1.Color4 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(36)))), ((int)(((byte)(76)))));
            this.xuıColorPane1.Color5 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuıColorPane1.Color6 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.xuıColorPane1.Color7 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuıColorPane1.Color8 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuıColorPane1.Color9 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuıColorPane1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuıColorPane1.GridColor = System.Drawing.Color.White;
            this.xuıColorPane1.Location = new System.Drawing.Point(1087, 316);
            this.xuıColorPane1.Name = "xuıColorPane1";
            this.xuıColorPane1.SelectedColor = System.Drawing.Color.Empty;
            this.xuıColorPane1.ShowGrid = true;
            this.xuıColorPane1.Size = new System.Drawing.Size(175, 50);
            this.xuıColorPane1.TabIndex = 6;
            this.xuıColorPane1.Text = "xuıColorPane1";
            // 
            // xuıColorPicker1
            // 
            this.xuıColorPicker1.Location = new System.Drawing.Point(1129, 372);
            this.xuıColorPicker1.Name = "xuıColorPicker1";
            this.xuıColorPicker1.PickerImage = ((System.Drawing.Image)(resources.GetObject("xuıColorPicker1.PickerImage")));
            this.xuıColorPicker1.SelectedColor = System.Drawing.Color.Empty;
            this.xuıColorPicker1.ShowColorPreview = true;
            this.xuıColorPicker1.Size = new System.Drawing.Size(133, 133);
            this.xuıColorPicker1.TabIndex = 7;
            this.xuıColorPicker1.Text = "xuıColorPicker1";
            // 
            // xuıCustomGroupbox1
            // 
            this.xuıCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuıCustomGroupbox1.BorderWidth = 1;
            this.xuıCustomGroupbox1.Location = new System.Drawing.Point(619, 27);
            this.xuıCustomGroupbox1.Name = "xuıCustomGroupbox1";
            this.xuıCustomGroupbox1.ShowText = true;
            this.xuıCustomGroupbox1.Size = new System.Drawing.Size(200, 100);
            this.xuıCustomGroupbox1.TabIndex = 8;
            this.xuıCustomGroupbox1.TabStop = false;
            this.xuıCustomGroupbox1.Text = "xuıCustomGroupbox1";
            this.xuıCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // xuıFlatMenuStrip1
            // 
            this.xuıFlatMenuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.xuıFlatMenuStrip1.HoverBackColor = System.Drawing.Color.RoyalBlue;
            this.xuıFlatMenuStrip1.HoverTextColor = System.Drawing.Color.White;
            this.xuıFlatMenuStrip1.ItemBackColor = System.Drawing.Color.DodgerBlue;
            this.xuıFlatMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.xuıFlatMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.xuıFlatMenuStrip1.Name = "xuıFlatMenuStrip1";
            this.xuıFlatMenuStrip1.SelectedBackColor = System.Drawing.Color.DarkOrchid;
            this.xuıFlatMenuStrip1.SelectedTextColor = System.Drawing.Color.White;
            this.xuıFlatMenuStrip1.SeperatorColor = System.Drawing.Color.White;
            this.xuıFlatMenuStrip1.Size = new System.Drawing.Size(1326, 24);
            this.xuıFlatMenuStrip1.TabIndex = 9;
            this.xuıFlatMenuStrip1.Text = "xuıFlatMenuStrip1";
            this.xuıFlatMenuStrip1.TextColor = System.Drawing.Color.White;
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.menüToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ayarlarToolStripMenuItem.Text = "ayarlar";
            // 
            // xuıFlatProgressBar1
            // 
            this.xuıFlatProgressBar1.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.xuıFlatProgressBar1.BarThickness = 5;
            this.xuıFlatProgressBar1.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuıFlatProgressBar1.InocmpletedColor = System.Drawing.Color.White;
            this.xuıFlatProgressBar1.Location = new System.Drawing.Point(619, 152);
            this.xuıFlatProgressBar1.MaxValue = 100;
            this.xuıFlatProgressBar1.Name = "xuıFlatProgressBar1";
            this.xuıFlatProgressBar1.Size = new System.Drawing.Size(300, 30);
            this.xuıFlatProgressBar1.TabIndex = 10;
            this.xuıFlatProgressBar1.Text = "xuıFlatProgressBar1";
            this.xuıFlatProgressBar1.Value = 50;
            // 
            // xuıFlatTab1
            // 
            this.xuıFlatTab1.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuıFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuıFlatTab1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuıFlatTab1.Controls.Add(this.tabPage1);
            this.xuıFlatTab1.Controls.Add(this.tabPage2);
            this.xuıFlatTab1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.xuıFlatTab1.InActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.xuıFlatTab1.InActiveTextColor = System.Drawing.Color.White;
            this.xuıFlatTab1.ItemSize = new System.Drawing.Size(240, 16);
            this.xuıFlatTab1.Location = new System.Drawing.Point(315, 510);
            this.xuıFlatTab1.Name = "xuıFlatTab1";
            this.xuıFlatTab1.OnlyTopLine = true;
            this.xuıFlatTab1.PageColor = System.Drawing.Color.White;
            this.xuıFlatTab1.SelectedIndex = 0;
            this.xuıFlatTab1.Size = new System.Drawing.Size(200, 100);
            this.xuıFlatTab1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 76);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 76);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // xuıGauge1
            // 
            this.xuıGauge1.DialColor = System.Drawing.Color.Gray;
            this.xuıGauge1.DialThickness = 5;
            this.xuıGauge1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuıGauge1.GaugeStyle = XanderUI.XUIGauge.Style.Material;
            this.xuıGauge1.Location = new System.Drawing.Point(619, 188);
            this.xuıGauge1.Name = "xuıGauge1";
            this.xuıGauge1.Percentage = 75;
            this.xuıGauge1.Size = new System.Drawing.Size(140, 70);
            this.xuıGauge1.TabIndex = 12;
            this.xuıGauge1.Text = "xuıGauge1";
            this.xuıGauge1.Thickness = 8;
            this.xuıGauge1.UnfilledColor = System.Drawing.Color.Gray;
            // 
            // xuıGradientPanel1
            // 
            this.xuıGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuıGradientPanel1.BottomRight = System.Drawing.Color.Fuchsia;
            this.xuıGradientPanel1.Location = new System.Drawing.Point(619, 305);
            this.xuıGradientPanel1.Name = "xuıGradientPanel1";
            this.xuıGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuıGradientPanel1.Size = new System.Drawing.Size(200, 200);
            this.xuıGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuıGradientPanel1.TabIndex = 13;
            this.xuıGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuıGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // xuıJoyStick1
            // 
            this.xuıJoyStick1.BackColor = System.Drawing.Color.White;
            this.xuıJoyStick1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xuıJoyStick1.BackgroundImage")));
            this.xuıJoyStick1.JoyStickColor = System.Drawing.Color.DodgerBlue;
            this.xuıJoyStick1.KeepOnScreen = true;
            this.xuıJoyStick1.Location = new System.Drawing.Point(959, 316);
            this.xuıJoyStick1.MovableObject = null;
            this.xuıJoyStick1.Name = "xuıJoyStick1";
            this.xuıJoyStick1.Sensitivity = 3;
            this.xuıJoyStick1.Size = new System.Drawing.Size(122, 122);
            this.xuıJoyStick1.TabIndex = 14;
            this.xuıJoyStick1.Text = "xuıJoyStick1";
            // 
            // xuıLineGraph1
            // 
            this.xuıLineGraph1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuıLineGraph1.BelowLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuıLineGraph1.BorderColor = System.Drawing.Color.White;
            this.xuıLineGraph1.GraphStyle = XanderUI.XUILineGraph.Style.Material;
            this.xuıLineGraph1.GraphTitle = "XUI LineGraph";
            this.xuıLineGraph1.GraphTitleColor = System.Drawing.Color.Gray;
            this.xuıLineGraph1.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("xuıLineGraph1.Items")));
            this.xuıLineGraph1.LineColor = System.Drawing.Color.White;
            this.xuıLineGraph1.Location = new System.Drawing.Point(1171, 511);
            this.xuıLineGraph1.Name = "xuıLineGraph1";
            this.xuıLineGraph1.PointSize = 7;
            this.xuıLineGraph1.ShowBorder = false;
            this.xuıLineGraph1.ShowPoints = true;
            this.xuıLineGraph1.ShowTitle = false;
            this.xuıLineGraph1.ShowVerticalLines = false;
            this.xuıLineGraph1.Size = new System.Drawing.Size(200, 100);
            this.xuıLineGraph1.TabIndex = 15;
            this.xuıLineGraph1.Text = "xuıLineGraph1";
            this.xuıLineGraph1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.xuıLineGraph1.VerticalLineColor = System.Drawing.Color.DimGray;
            // 
            // xuıNavigationBar1
            // 
            this.xuıNavigationBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuıNavigationBar1.ItemColor = System.Drawing.Color.White;
            this.xuıNavigationBar1.LeftCustomImage = null;
            this.xuıNavigationBar1.LeftCustomText = "CustomBack";
            this.xuıNavigationBar1.LeftItem = XanderUI.XUINavigationBar.NavigationItem.Back;
            this.xuıNavigationBar1.Location = new System.Drawing.Point(319, 625);
            this.xuıNavigationBar1.Name = "xuıNavigationBar1";
            this.xuıNavigationBar1.NavBarStyle = XanderUI.XUINavigationBar.Style.Android;
            this.xuıNavigationBar1.RightCustomImage = null;
            this.xuıNavigationBar1.RightCustomText = "CustomNext";
            this.xuıNavigationBar1.RightItem = XanderUI.XUINavigationBar.NavigationItem.Next;
            this.xuıNavigationBar1.Size = new System.Drawing.Size(300, 40);
            this.xuıNavigationBar1.TabIndex = 16;
            this.xuıNavigationBar1.Text = "xuıNavigationBar1";
            this.xuıNavigationBar1.Title = "Navigation Bar";
            this.xuıNavigationBar1.TitleColor = System.Drawing.Color.White;
            // 
            // xuıObjectEllipse1
            // 
            this.xuıObjectEllipse1.CornerRadius = 10;
            this.xuıObjectEllipse1.EffectedControl = this;
            this.xuıObjectEllipse1.EffectedForm = this;
            // 
            // xuıPieGraph1
            // 
            this.xuıPieGraph1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.xuıPieGraph1.Location = new System.Drawing.Point(1051, 511);
            this.xuıPieGraph1.Name = "xuıPieGraph1";
            this.xuıPieGraph1.Numbers = ((System.Collections.Generic.List<int>)(resources.GetObject("xuıPieGraph1.Numbers")));
            this.xuıPieGraph1.Size = new System.Drawing.Size(100, 100);
            this.xuıPieGraph1.TabIndex = 17;
            this.xuıPieGraph1.Text = "xuıPieGraph1";
            // 
            // xuıRadio1
            // 
            this.xuıRadio1.Checked = false;
            this.xuıRadio1.ForeColor = System.Drawing.Color.White;
            this.xuıRadio1.Location = new System.Drawing.Point(436, 357);
            this.xuıRadio1.Name = "xuıRadio1";
            this.xuıRadio1.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuıRadio1.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuıRadio1.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.xuıRadio1.Size = new System.Drawing.Size(100, 16);
            this.xuıRadio1.TabIndex = 18;
            this.xuıRadio1.Text = "xuıRadio1";
            // 
            // xuıSegment1
            // 
            this.xuıSegment1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuıSegment1.Items = "Contacts, Recents, Messages, Dialer";
            this.xuıSegment1.Location = new System.Drawing.Point(521, 510);
            this.xuıSegment1.Name = "xuıSegment1";
            this.xuıSegment1.SegmentActiveTextColor = System.Drawing.Color.White;
            this.xuıSegment1.SegmentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(135)))));
            this.xuıSegment1.SegmentColor = System.Drawing.Color.White;
            this.xuıSegment1.SegmentInactiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.xuıSegment1.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.xuıSegment1.SelectedIndex = 0;
            this.xuıSegment1.Size = new System.Drawing.Size(240, 30);
            this.xuıSegment1.TabIndex = 19;
            this.xuıSegment1.Text = "xuıSegment1";
            // 
            // xuıSlider1
            // 
            this.xuıSlider1.BarThickness = 4;
            this.xuıSlider1.BigStepIncrement = 10;
            this.xuıSlider1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuıSlider1.KnobColor = System.Drawing.Color.Gray;
            this.xuıSlider1.KnobImage = null;
            this.xuıSlider1.Location = new System.Drawing.Point(619, 264);
            this.xuıSlider1.Name = "xuıSlider1";
            this.xuıSlider1.Percentage = 50;
            this.xuıSlider1.QuickHopping = false;
            this.xuıSlider1.Size = new System.Drawing.Size(250, 20);
            this.xuıSlider1.SliderStyle = XanderUI.XUISlider.Style.Windows10;
            this.xuıSlider1.TabIndex = 20;
            this.xuıSlider1.Text = "xuıSlider1";
            this.xuıSlider1.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            // 
            // xuıSlidingPanel1
            // 
            this.xuıSlidingPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuıSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuıSlidingPanel1.CollapseControl = null;
            this.xuıSlidingPanel1.Collapsed = true;
            this.xuıSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuıSlidingPanel1.HideControls = false;
            this.xuıSlidingPanel1.Location = new System.Drawing.Point(0, 24);
            this.xuıSlidingPanel1.Name = "xuıSlidingPanel1";
            this.xuıSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuıSlidingPanel1.PanelWidthExpanded = 200;
            this.xuıSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuıSlidingPanel1.Size = new System.Drawing.Size(181, 719);
            this.xuıSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuıSlidingPanel1.TabIndex = 21;
            this.xuıSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuıSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // xuıSuperButton1
            // 
            this.xuıSuperButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuıSuperButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıSuperButton1.ButtonImage")));
            this.xuıSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuıSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuıSuperButton1.ButtonText = "SuperButton";
            this.xuıSuperButton1.CornerRadius = 5;
            this.xuıSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıSuperButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuıSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuıSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuıSuperButton1.Location = new System.Drawing.Point(319, 53);
            this.xuıSuperButton1.Name = "xuıSuperButton1";
            this.xuıSuperButton1.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuıSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuıSuperButton1.Size = new System.Drawing.Size(100, 40);
            this.xuıSuperButton1.SuperSelected = false;
            this.xuıSuperButton1.TabIndex = 22;
            this.xuıSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuıSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuıSwitch1
            // 
            this.xuıSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.xuıSwitch1.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuıSwitch1.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.xuıSwitch1.Location = new System.Drawing.Point(476, 383);
            this.xuıSwitch1.Name = "xuıSwitch1";
            this.xuıSwitch1.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.xuıSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuıSwitch1.Size = new System.Drawing.Size(60, 30);
            this.xuıSwitch1.SwitchState = XanderUI.XUISwitch.State.On;
            this.xuıSwitch1.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.xuıSwitch1.TabIndex = 23;
            this.xuıSwitch1.Text = "xuıSwitch1";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 743);
            this.Controls.Add(this.xuıSwitch1);
            this.Controls.Add(this.xuıSuperButton1);
            this.Controls.Add(this.xuıSlidingPanel1);
            this.Controls.Add(this.xuıSlider1);
            this.Controls.Add(this.xuıSegment1);
            this.Controls.Add(this.xuıRadio1);
            this.Controls.Add(this.xuıPieGraph1);
            this.Controls.Add(this.xuıNavigationBar1);
            this.Controls.Add(this.xuıLineGraph1);
            this.Controls.Add(this.xuıJoyStick1);
            this.Controls.Add(this.xuıGradientPanel1);
            this.Controls.Add(this.xuıGauge1);
            this.Controls.Add(this.xuıFlatTab1);
            this.Controls.Add(this.xuıFlatProgressBar1);
            this.Controls.Add(this.xuıCustomGroupbox1);
            this.Controls.Add(this.xuıColorPicker1);
            this.Controls.Add(this.xuıColorPane1);
            this.Controls.Add(this.xuıCircleProgressBar1);
            this.Controls.Add(this.xuıCheckBox1);
            this.Controls.Add(this.xuıCard1);
            this.Controls.Add(this.xuıButton1);
            this.Controls.Add(this.xuıBarGraph1);
            this.Controls.Add(this.xuıBanner1);
            this.Controls.Add(this.xuıFlatMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.xuıFlatMenuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.xuıFlatMenuStrip1.ResumeLayout(false);
            this.xuıFlatMenuStrip1.PerformLayout();
            this.xuıFlatTab1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIBanner xuıBanner1;
        private XanderUI.XUIBarGraph xuıBarGraph1;
        private XanderUI.XUIButton xuıButton1;
        private XanderUI.XUICard xuıCard1;
        private XanderUI.XUICheckBox xuıCheckBox1;
        private XanderUI.XUICircleProgressBar xuıCircleProgressBar1;
        private XanderUI.XUIColorPane xuıColorPane1;
        private XanderUI.XUIColorPicker xuıColorPicker1;
        private XanderUI.XUICustomGroupbox xuıCustomGroupbox1;
        private XanderUI.XUIFlatMenuStrip xuıFlatMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private XanderUI.XUIFlatProgressBar xuıFlatProgressBar1;
        private XanderUI.XUIFlatTab xuıFlatTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private XanderUI.XUIGauge xuıGauge1;
        private XanderUI.XUIGradientPanel xuıGradientPanel1;
        private XanderUI.XUIJoyStick xuıJoyStick1;
        private XanderUI.XUILineGraph xuıLineGraph1;
        private XanderUI.XUINavigationBar xuıNavigationBar1;
        private XanderUI.XUIObjectEllipse xuıObjectEllipse1;
        private XanderUI.XUISlider xuıSlider1;
        private XanderUI.XUISegment xuıSegment1;
        private XanderUI.XUIRadio xuıRadio1;
        private XanderUI.XUIPieGraph xuıPieGraph1;
        private XanderUI.XUISuperButton xuıSuperButton1;
        private XanderUI.XUISlidingPanel xuıSlidingPanel1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private XanderUI.XUISwitch xuıSwitch1;
    }
}

