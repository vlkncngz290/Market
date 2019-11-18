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
            this.xuıObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.xuıSlidingPanel1 = new XanderUI.XUISlidingPanel();
            this.xuıButton1 = new XanderUI.XUIButton();
            this.xuıButton2 = new XanderUI.XUIButton();
            this.xuıButton3 = new XanderUI.XUIButton();
            this.xuıButton4 = new XanderUI.XUIButton();
            this.xuıButton5 = new XanderUI.XUIButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.xuıSlidingPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuıObjectEllipse1
            // 
            this.xuıObjectEllipse1.CornerRadius = 10;
            this.xuıObjectEllipse1.EffectedControl = this;
            this.xuıObjectEllipse1.EffectedForm = this;
            // 
            // xuıSlidingPanel1
            // 
            this.xuıSlidingPanel1.BottomLeft = System.Drawing.Color.DodgerBlue;
            this.xuıSlidingPanel1.BottomRight = System.Drawing.Color.DodgerBlue;
            this.xuıSlidingPanel1.CollapseControl = null;
            this.xuıSlidingPanel1.Collapsed = true;
            this.xuıSlidingPanel1.Controls.Add(this.xuıButton5);
            this.xuıSlidingPanel1.Controls.Add(this.xuıButton4);
            this.xuıSlidingPanel1.Controls.Add(this.xuıButton3);
            this.xuıSlidingPanel1.Controls.Add(this.xuıButton2);
            this.xuıSlidingPanel1.Controls.Add(this.xuıButton1);
            this.xuıSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xuıSlidingPanel1.HideControls = false;
            this.xuıSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuıSlidingPanel1.Name = "xuıSlidingPanel1";
            this.xuıSlidingPanel1.PanelWidthCollapsed = 50;
            this.xuıSlidingPanel1.PanelWidthExpanded = 200;
            this.xuıSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuıSlidingPanel1.Size = new System.Drawing.Size(234, 743);
            this.xuıSlidingPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuıSlidingPanel1.TabIndex = 21;
            this.xuıSlidingPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuıSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // xuıButton1
            // 
            this.xuıButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuıButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıButton1.ButtonImage")));
            this.xuıButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuıButton1.ButtonText = "Satış";
            this.xuıButton1.ClickBackColor = System.Drawing.Color.Silver;
            this.xuıButton1.ClickTextColor = System.Drawing.Color.DimGray;
            this.xuıButton1.CornerRadius = 100;
            this.xuıButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuıButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton1.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.xuıButton1.HoverTextColor = System.Drawing.Color.Black;
            this.xuıButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuıButton1.Location = new System.Drawing.Point(3, 54);
            this.xuıButton1.Name = "xuıButton1";
            this.xuıButton1.Size = new System.Drawing.Size(226, 50);
            this.xuıButton1.TabIndex = 0;
            this.xuıButton1.TextColor = System.Drawing.Color.DimGray;
            this.xuıButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuıButton2
            // 
            this.xuıButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuıButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıButton2.ButtonImage")));
            this.xuıButton2.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuıButton2.ButtonText = "Satınalma";
            this.xuıButton2.ClickBackColor = System.Drawing.Color.Silver;
            this.xuıButton2.ClickTextColor = System.Drawing.Color.DimGray;
            this.xuıButton2.CornerRadius = 100;
            this.xuıButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuıButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton2.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.xuıButton2.HoverTextColor = System.Drawing.Color.Black;
            this.xuıButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuıButton2.Location = new System.Drawing.Point(3, 110);
            this.xuıButton2.Name = "xuıButton2";
            this.xuıButton2.Size = new System.Drawing.Size(226, 50);
            this.xuıButton2.TabIndex = 1;
            this.xuıButton2.TextColor = System.Drawing.Color.DimGray;
            this.xuıButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuıButton3
            // 
            this.xuıButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuıButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıButton3.ButtonImage")));
            this.xuıButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuıButton3.ButtonText = "Ürün Analizi";
            this.xuıButton3.ClickBackColor = System.Drawing.Color.Silver;
            this.xuıButton3.ClickTextColor = System.Drawing.Color.DimGray;
            this.xuıButton3.CornerRadius = 100;
            this.xuıButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuıButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton3.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.xuıButton3.HoverTextColor = System.Drawing.Color.Black;
            this.xuıButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuıButton3.Location = new System.Drawing.Point(3, 166);
            this.xuıButton3.Name = "xuıButton3";
            this.xuıButton3.Size = new System.Drawing.Size(226, 50);
            this.xuıButton3.TabIndex = 2;
            this.xuıButton3.TextColor = System.Drawing.Color.DimGray;
            this.xuıButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuıButton4
            // 
            this.xuıButton4.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuıButton4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıButton4.ButtonImage")));
            this.xuıButton4.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuıButton4.ButtonText = "Barkod Oluştur";
            this.xuıButton4.ClickBackColor = System.Drawing.Color.Silver;
            this.xuıButton4.ClickTextColor = System.Drawing.Color.DimGray;
            this.xuıButton4.CornerRadius = 100;
            this.xuıButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuıButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton4.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.xuıButton4.HoverTextColor = System.Drawing.Color.Black;
            this.xuıButton4.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuıButton4.Location = new System.Drawing.Point(3, 222);
            this.xuıButton4.Name = "xuıButton4";
            this.xuıButton4.Size = new System.Drawing.Size(226, 50);
            this.xuıButton4.TabIndex = 3;
            this.xuıButton4.TextColor = System.Drawing.Color.DimGray;
            this.xuıButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuıButton5
            // 
            this.xuıButton5.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuıButton5.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuıButton5.ButtonImage")));
            this.xuıButton5.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuıButton5.ButtonText = "Çıkış";
            this.xuıButton5.ClickBackColor = System.Drawing.Color.Silver;
            this.xuıButton5.ClickTextColor = System.Drawing.Color.DimGray;
            this.xuıButton5.CornerRadius = 100;
            this.xuıButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuıButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuıButton5.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.xuıButton5.HoverTextColor = System.Drawing.Color.Black;
            this.xuıButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuıButton5.Location = new System.Drawing.Point(3, 681);
            this.xuıButton5.Name = "xuıButton5";
            this.xuıButton5.Size = new System.Drawing.Size(226, 50);
            this.xuıButton5.TabIndex = 4;
            this.xuıButton5.TextColor = System.Drawing.Color.DimGray;
            this.xuıButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(235, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(961, 743);
            this.metroPanel1.TabIndex = 22;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 743);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.xuıSlidingPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.xuıSlidingPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUIObjectEllipse xuıObjectEllipse1;
        private XanderUI.XUISlidingPanel xuıSlidingPanel1;
        private XanderUI.XUIButton xuıButton5;
        private XanderUI.XUIButton xuıButton4;
        private XanderUI.XUIButton xuıButton3;
        private XanderUI.XUIButton xuıButton2;
        private XanderUI.XUIButton xuıButton1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}

