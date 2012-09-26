namespace colony
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colonyControl = new System.Windows.Forms.TabControl();
            this.economyPage = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metalPic = new System.Windows.Forms.PictureBox();
            this.crystalPic = new System.Windows.Forms.PictureBox();
            this.energyPic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.metalStt = new System.Windows.Forms.Label();
            this.crystalStt = new System.Windows.Forms.Label();
            this.energyStt = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colonyControl.SuspendLayout();
            this.economyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metalPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.energyPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colonyControl
            // 
            this.colonyControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colonyControl.Controls.Add(this.economyPage);
            this.colonyControl.Location = new System.Drawing.Point(0, 88);
            this.colonyControl.Name = "colonyControl";
            this.colonyControl.SelectedIndex = 0;
            this.colonyControl.Size = new System.Drawing.Size(699, 352);
            this.colonyControl.TabIndex = 1;
            // 
            // economyPage
            // 
            this.economyPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.economyPage.Controls.Add(this.listBox1);
            this.economyPage.Location = new System.Drawing.Point(4, 25);
            this.economyPage.Name = "economyPage";
            this.economyPage.Padding = new System.Windows.Forms.Padding(3);
            this.economyPage.Size = new System.Drawing.Size(691, 323);
            this.economyPage.TabIndex = 0;
            this.economyPage.Text = "Economy";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(8, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 308);
            this.listBox1.TabIndex = 0;
            // 
            // metalPic
            // 
            this.metalPic.Image = ((System.Drawing.Image)(resources.GetObject("metalPic.Image")));
            this.metalPic.Location = new System.Drawing.Point(12, 13);
            this.metalPic.Name = "metalPic";
            this.metalPic.Size = new System.Drawing.Size(100, 50);
            this.metalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.metalPic.TabIndex = 2;
            this.metalPic.TabStop = false;
            // 
            // crystalPic
            // 
            this.crystalPic.Image = ((System.Drawing.Image)(resources.GetObject("crystalPic.Image")));
            this.crystalPic.Location = new System.Drawing.Point(138, 13);
            this.crystalPic.Name = "crystalPic";
            this.crystalPic.Size = new System.Drawing.Size(100, 50);
            this.crystalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crystalPic.TabIndex = 3;
            this.crystalPic.TabStop = false;
            // 
            // energyPic
            // 
            this.energyPic.Image = ((System.Drawing.Image)(resources.GetObject("energyPic.Image")));
            this.energyPic.Location = new System.Drawing.Point(267, 13);
            this.energyPic.Name = "energyPic";
            this.energyPic.Size = new System.Drawing.Size(100, 50);
            this.energyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.energyPic.TabIndex = 4;
            this.energyPic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(428, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solar day";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 18);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // metalStt
            // 
            this.metalStt.AutoSize = true;
            this.metalStt.Location = new System.Drawing.Point(12, 66);
            this.metalStt.Name = "metalStt";
            this.metalStt.Size = new System.Drawing.Size(45, 16);
            this.metalStt.TabIndex = 6;
            this.metalStt.Text = "label1";
            // 
            // crystalStt
            // 
            this.crystalStt.AutoSize = true;
            this.crystalStt.Location = new System.Drawing.Point(135, 66);
            this.crystalStt.Name = "crystalStt";
            this.crystalStt.Size = new System.Drawing.Size(45, 16);
            this.crystalStt.TabIndex = 7;
            this.crystalStt.Text = "label2";
            // 
            // energyStt
            // 
            this.energyStt.AutoSize = true;
            this.energyStt.Location = new System.Drawing.Point(264, 66);
            this.energyStt.Name = "energyStt";
            this.energyStt.Size = new System.Drawing.Size(45, 16);
            this.energyStt.TabIndex = 8;
            this.energyStt.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 436);
            this.Controls.Add(this.energyStt);
            this.Controls.Add(this.crystalStt);
            this.Controls.Add(this.metalStt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.energyPic);
            this.Controls.Add(this.crystalPic);
            this.Controls.Add(this.metalPic);
            this.Controls.Add(this.colonyControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.colonyControl.ResumeLayout(false);
            this.economyPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metalPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crystalPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.energyPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl colonyControl;
        private System.Windows.Forms.TabPage economyPage;
        private System.Windows.Forms.PictureBox metalPic;
        private System.Windows.Forms.PictureBox crystalPic;
        private System.Windows.Forms.PictureBox energyPic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label metalStt;
        private System.Windows.Forms.Label crystalStt;
        private System.Windows.Forms.Label energyStt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

