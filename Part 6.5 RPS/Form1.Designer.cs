namespace Part_6._5_RPS
{
    partial class MainForm
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
            this.imgScissor = new System.Windows.Forms.PictureBox();
            this.imgPaper = new System.Windows.Forms.PictureBox();
            this.imgRock = new System.Windows.Forms.PictureBox();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissor = new System.Windows.Forms.RadioButton();
            this.grpPLayersChoice = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).BeginInit();
            this.grpPLayersChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgScissor
            // 
            this.imgScissor.Image = global::Part_6._5_RPS.Properties.Resources.jake_shears_scissor_sisters_another_album;
            this.imgScissor.Location = new System.Drawing.Point(54, 32);
            this.imgScissor.Name = "imgScissor";
            this.imgScissor.Size = new System.Drawing.Size(194, 185);
            this.imgScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgScissor.TabIndex = 0;
            this.imgScissor.TabStop = false;
            this.imgScissor.Visible = false;
            this.imgScissor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgPaper
            // 
            this.imgPaper.Image = global::Part_6._5_RPS.Properties.Resources.download;
            this.imgPaper.Location = new System.Drawing.Point(54, 32);
            this.imgPaper.Name = "imgPaper";
            this.imgPaper.Size = new System.Drawing.Size(194, 185);
            this.imgPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaper.TabIndex = 1;
            this.imgPaper.TabStop = false;
            this.imgPaper.Visible = false;
            // 
            // imgRock
            // 
            this.imgRock.Image = global::Part_6._5_RPS.Properties.Resources.pasadena_boy_starts_rock_wall_for_painted_rocks_1_large;
            this.imgRock.Location = new System.Drawing.Point(54, 32);
            this.imgRock.Name = "imgRock";
            this.imgRock.Size = new System.Drawing.Size(194, 185);
            this.imgRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRock.TabIndex = 2;
            this.imgRock.TabStop = false;
            this.imgRock.Visible = false;
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(6, 31);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 3;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(6, 63);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 4;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // radScissor
            // 
            this.radScissor.AutoSize = true;
            this.radScissor.Location = new System.Drawing.Point(6, 102);
            this.radScissor.Name = "radScissor";
            this.radScissor.Size = new System.Drawing.Size(64, 17);
            this.radScissor.TabIndex = 5;
            this.radScissor.TabStop = true;
            this.radScissor.Text = "Scissors";
            this.radScissor.UseVisualStyleBackColor = true;
            this.radScissor.CheckedChanged += new System.EventHandler(this.radScissor_CheckedChanged);
            // 
            // grpPLayersChoice
            // 
            this.grpPLayersChoice.Controls.Add(this.radRock);
            this.grpPLayersChoice.Controls.Add(this.radScissor);
            this.grpPLayersChoice.Controls.Add(this.radPaper);
            this.grpPLayersChoice.Location = new System.Drawing.Point(48, 248);
            this.grpPLayersChoice.Name = "grpPLayersChoice";
            this.grpPLayersChoice.Size = new System.Drawing.Size(200, 142);
            this.grpPLayersChoice.TabIndex = 6;
            this.grpPLayersChoice.TabStop = false;
            this.grpPLayersChoice.Text = "Players Choice";
            this.grpPLayersChoice.Enter += new System.EventHandler(this.grpPLayersChoice_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpPLayersChoice);
            this.Controls.Add(this.imgRock);
            this.Controls.Add(this.imgPaper);
            this.Controls.Add(this.imgScissor);
            this.Name = "MainForm";
            this.Text = "RPS";
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).EndInit();
            this.grpPLayersChoice.ResumeLayout(false);
            this.grpPLayersChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgScissor;
        private System.Windows.Forms.PictureBox imgPaper;
        private System.Windows.Forms.PictureBox imgRock;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radScissor;
        private System.Windows.Forms.GroupBox grpPLayersChoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

