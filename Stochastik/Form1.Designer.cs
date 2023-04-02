
namespace Stochastik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tür3 = new System.Windows.Forms.Button();
            this.tür2 = new System.Windows.Forms.Button();
            this.tür1 = new System.Windows.Forms.Button();
            this.Tür2Auto = new System.Windows.Forms.PictureBox();
            this.Tür1AutoBild = new System.Windows.Forms.PictureBox();
            this.Tür3Auto = new System.Windows.Forms.PictureBox();
            this.Tür1Ziege = new System.Windows.Forms.PictureBox();
            this.Tür2Ziege = new System.Windows.Forms.PictureBox();
            this.Tür3Ziege = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.Button();
            this.WinStay = new System.Windows.Forms.Label();
            this.WinChange = new System.Windows.Forms.Label();
            this.LostLabel = new System.Windows.Forms.Label();
            this.LabelLostCousSwitch = new System.Windows.Forms.Label();
            this.labelLostCousStay = new System.Windows.Forms.Label();
            this.labelwinsTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tür2Auto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür1AutoBild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür3Auto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür1Ziege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür2Ziege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür3Ziege)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(-3, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(225, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Klicken sie auf eine Tür";
            // 
            // tür3
            // 
            this.tür3.Location = new System.Drawing.Point(532, 115);
            this.tür3.Name = "tür3";
            this.tür3.Size = new System.Drawing.Size(133, 301);
            this.tür3.TabIndex = 13;
            this.tür3.Text = "Tür3";
            this.tür3.UseVisualStyleBackColor = true;
            this.tür3.Click += new System.EventHandler(this.tür3_Click);
            // 
            // tür2
            // 
            this.tür2.Location = new System.Drawing.Point(315, 115);
            this.tür2.Name = "tür2";
            this.tür2.Size = new System.Drawing.Size(133, 301);
            this.tür2.TabIndex = 12;
            this.tür2.Text = "Tür2";
            this.tür2.UseVisualStyleBackColor = true;
            this.tür2.Click += new System.EventHandler(this.tür2_Click);
            // 
            // tür1
            // 
            this.tür1.Location = new System.Drawing.Point(91, 115);
            this.tür1.Name = "tür1";
            this.tür1.Size = new System.Drawing.Size(133, 301);
            this.tür1.TabIndex = 11;
            this.tür1.Text = "Tür1";
            this.tür1.UseVisualStyleBackColor = true;
            this.tür1.Click += new System.EventHandler(this.tür1_Click_1);
            // 
            // Tür2Auto
            // 
            this.Tür2Auto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tür2Auto.BackgroundImage")));
            this.Tür2Auto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tür2Auto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Tür2Auto.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tür2Auto.InitialImage")));
            this.Tür2Auto.Location = new System.Drawing.Point(315, 115);
            this.Tür2Auto.Name = "Tür2Auto";
            this.Tür2Auto.Size = new System.Drawing.Size(133, 301);
            this.Tür2Auto.TabIndex = 17;
            this.Tür2Auto.TabStop = false;
            this.Tür2Auto.UseWaitCursor = true;
            this.Tür2Auto.Visible = false;
            // 
            // Tür1AutoBild
            // 
            this.Tür1AutoBild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tür1AutoBild.BackgroundImage")));
            this.Tür1AutoBild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tür1AutoBild.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Tür1AutoBild.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tür1AutoBild.InitialImage")));
            this.Tür1AutoBild.Location = new System.Drawing.Point(91, 115);
            this.Tür1AutoBild.Name = "Tür1AutoBild";
            this.Tür1AutoBild.Size = new System.Drawing.Size(133, 301);
            this.Tür1AutoBild.TabIndex = 16;
            this.Tür1AutoBild.TabStop = false;
            this.Tür1AutoBild.UseWaitCursor = true;
            this.Tür1AutoBild.Visible = false;
            // 
            // Tür3Auto
            // 
            this.Tür3Auto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tür3Auto.BackgroundImage")));
            this.Tür3Auto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tür3Auto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Tür3Auto.InitialImage = ((System.Drawing.Image)(resources.GetObject("Tür3Auto.InitialImage")));
            this.Tür3Auto.Location = new System.Drawing.Point(532, 115);
            this.Tür3Auto.Name = "Tür3Auto";
            this.Tür3Auto.Size = new System.Drawing.Size(133, 301);
            this.Tür3Auto.TabIndex = 18;
            this.Tür3Auto.TabStop = false;
            this.Tür3Auto.UseWaitCursor = true;
            this.Tür3Auto.Visible = false;
            // 
            // Tür1Ziege
            // 
            this.Tür1Ziege.BackgroundImage = global::Stochastik.Properties.Resources.tierportraet_von_einer_sehr_gluecklichen_braunen_ziege_mit_ansteckendem_grinsen;
            this.Tür1Ziege.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tür1Ziege.Location = new System.Drawing.Point(91, 115);
            this.Tür1Ziege.Name = "Tür1Ziege";
            this.Tür1Ziege.Size = new System.Drawing.Size(133, 301);
            this.Tür1Ziege.TabIndex = 19;
            this.Tür1Ziege.TabStop = false;
            // 
            // Tür2Ziege
            // 
            this.Tür2Ziege.BackgroundImage = global::Stochastik.Properties.Resources.tierportraet_von_einer_sehr_gluecklichen_braunen_ziege_mit_ansteckendem_grinsen;
            this.Tür2Ziege.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tür2Ziege.Location = new System.Drawing.Point(315, 115);
            this.Tür2Ziege.Name = "Tür2Ziege";
            this.Tür2Ziege.Size = new System.Drawing.Size(133, 301);
            this.Tür2Ziege.TabIndex = 20;
            this.Tür2Ziege.TabStop = false;
            // 
            // Tür3Ziege
            // 
            this.Tür3Ziege.BackgroundImage = global::Stochastik.Properties.Resources.tierportraet_von_einer_sehr_gluecklichen_braunen_ziege_mit_ansteckendem_grinsen;
            this.Tür3Ziege.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tür3Ziege.Location = new System.Drawing.Point(532, 115);
            this.Tür3Ziege.Name = "Tür3Ziege";
            this.Tür3Ziege.Size = new System.Drawing.Size(133, 301);
            this.Tür3Ziege.TabIndex = 21;
            this.Tür3Ziege.TabStop = false;
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Restart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Restart.Location = new System.Drawing.Point(671, 393);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 32);
            this.Restart.TabIndex = 22;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // WinStay
            // 
            this.WinStay.AutoSize = true;
            this.WinStay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WinStay.Location = new System.Drawing.Point(25, 91);
            this.WinStay.Name = "WinStay";
            this.WinStay.Size = new System.Drawing.Size(67, 21);
            this.WinStay.TabIndex = 23;
            this.WinStay.Text = "WinStay";
            this.WinStay.Click += new System.EventHandler(this.WinStay_Click);
            // 
            // WinChange
            // 
            this.WinChange.AutoSize = true;
            this.WinChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WinChange.Location = new System.Drawing.Point(12, 50);
            this.WinChange.Name = "WinChange";
            this.WinChange.Size = new System.Drawing.Size(84, 21);
            this.WinChange.TabIndex = 24;
            this.WinChange.Text = "WinSwitch";
            this.WinChange.Click += new System.EventHandler(this.WinChange_Click);
            // 
            // LostLabel
            // 
            this.LostLabel.AutoSize = true;
            this.LostLabel.Location = new System.Drawing.Point(336, 15);
            this.LostLabel.Name = "LostLabel";
            this.LostLabel.Size = new System.Drawing.Size(37, 15);
            this.LostLabel.TabIndex = 25;
            this.LostLabel.Text = "Losts:";
            this.LostLabel.Click += new System.EventHandler(this.LostLabel_Click);
            // 
            // LabelLostCousSwitch
            // 
            this.LabelLostCousSwitch.AutoSize = true;
            this.LabelLostCousSwitch.Location = new System.Drawing.Point(615, 15);
            this.LabelLostCousSwitch.Name = "LabelLostCousSwitch";
            this.LabelLostCousSwitch.Size = new System.Drawing.Size(67, 15);
            this.LabelLostCousSwitch.TabIndex = 26;
            this.LabelLostCousSwitch.Text = "cousSwitch";
            this.LabelLostCousSwitch.Click += new System.EventHandler(this.LabelLostCousSwitch_Click);
            // 
            // labelLostCousStay
            // 
            this.labelLostCousStay.AutoSize = true;
            this.labelLostCousStay.Location = new System.Drawing.Point(615, 40);
            this.labelLostCousStay.Name = "labelLostCousStay";
            this.labelLostCousStay.Size = new System.Drawing.Size(54, 15);
            this.labelLostCousStay.TabIndex = 27;
            this.labelLostCousStay.Text = "cousStay";
            // 
            // labelwinsTotal
            // 
            this.labelwinsTotal.AutoSize = true;
            this.labelwinsTotal.Location = new System.Drawing.Point(336, 35);
            this.labelwinsTotal.Name = "labelwinsTotal";
            this.labelwinsTotal.Size = new System.Drawing.Size(33, 15);
            this.labelwinsTotal.TabIndex = 28;
            this.labelwinsTotal.Text = "Wins";
            this.labelwinsTotal.Click += new System.EventHandler(this.labelwinsTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelwinsTotal);
            this.Controls.Add(this.labelLostCousStay);
            this.Controls.Add(this.LabelLostCousSwitch);
            this.Controls.Add(this.LostLabel);
            this.Controls.Add(this.WinChange);
            this.Controls.Add(this.WinStay);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tür3);
            this.Controls.Add(this.tür2);
            this.Controls.Add(this.tür1);
            this.Controls.Add(this.Tür2Auto);
            this.Controls.Add(this.Tür1AutoBild);
            this.Controls.Add(this.Tür3Auto);
            this.Controls.Add(this.Tür1Ziege);
            this.Controls.Add(this.Tür2Ziege);
            this.Controls.Add(this.Tür3Ziege);
            this.Name = "Form1";
            this.Text = "Ziegen Spiel";
            ((System.ComponentModel.ISupportInitialize)(this.Tür2Auto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür1AutoBild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür3Auto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür1Ziege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür2Ziege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tür3Ziege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tür3;
        private System.Windows.Forms.Button tür2;
        private System.Windows.Forms.Button tür1;
        private System.Windows.Forms.PictureBox Tür2Auto;
        private System.Windows.Forms.PictureBox Tür1AutoBild;
        private System.Windows.Forms.PictureBox Tür3Auto;
        private System.Windows.Forms.PictureBox Tür1Ziege;
        private System.Windows.Forms.PictureBox Tür2Ziege;
        private System.Windows.Forms.PictureBox Tür3Ziege;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label WinStay;
        private System.Windows.Forms.Label WinChange;
        private System.Windows.Forms.Label LostLabel;
        private System.Windows.Forms.Label LabelLostCousSwitch;
        private System.Windows.Forms.Label labelLostCousStay;
        private System.Windows.Forms.Label labelwinsTotal;
    }
}

