using System;
using System.Windows.Forms;

namespace CafeInn
{
    partial class AdminDashboardForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboard_tbIn = new System.Windows.Forms.Panel();
            this.dashboard_TIn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dashboard_tbI = new System.Windows.Forms.Panel();
            this.dashboard_TI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dashboard_tbcust = new System.Windows.Forms.Panel();
            this.dashboard_TCust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboard_tb = new System.Windows.Forms.Panel();
            this.dashboard_TC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.dashboard_tbIn.SuspendLayout();
            this.dashboard_tbI.SuspendLayout();
            this.dashboard_tbcust.SuspendLayout();
            this.dashboard_tb.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.dashboard_tbIn);
            this.panel1.Controls.Add(this.dashboard_tbI);
            this.panel1.Controls.Add(this.dashboard_tbcust);
            this.panel1.Controls.Add(this.dashboard_tb);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 271);
            this.panel1.TabIndex = 0;
            // 
            // dashboard_tbIn
            // 
            this.dashboard_tbIn.BackColor = System.Drawing.Color.SeaShell;
            this.dashboard_tbIn.Controls.Add(this.pictureBox4);
            this.dashboard_tbIn.Controls.Add(this.dashboard_TIn);
            this.dashboard_tbIn.Controls.Add(this.label4);
            this.dashboard_tbIn.Location = new System.Drawing.Point(769, 13);
            this.dashboard_tbIn.Name = "dashboard_tbIn";
            this.dashboard_tbIn.Size = new System.Drawing.Size(230, 244);
            this.dashboard_tbIn.TabIndex = 1;
            this.dashboard_tbIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // dashboard_TIn
            // 
            this.dashboard_TIn.AutoSize = true;
            this.dashboard_TIn.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_TIn.ForeColor = System.Drawing.Color.DarkRed;
            this.dashboard_TIn.Location = new System.Drawing.Point(156, 205);
            this.dashboard_TIn.Name = "dashboard_TIn";
            this.dashboard_TIn.Size = new System.Drawing.Size(48, 25);
            this.dashboard_TIn.TabIndex = 14;
            this.dashboard_TIn.Text = "$0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(41, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total of Income";
            // 
            // dashboard_tbI
            // 
            this.dashboard_tbI.BackColor = System.Drawing.Color.SeaShell;
            this.dashboard_tbI.Controls.Add(this.pictureBox3);
            this.dashboard_tbI.Controls.Add(this.dashboard_TI);
            this.dashboard_tbI.Controls.Add(this.label3);
            this.dashboard_tbI.Location = new System.Drawing.Point(521, 13);
            this.dashboard_tbI.Name = "dashboard_tbI";
            this.dashboard_tbI.Size = new System.Drawing.Size(226, 244);
            this.dashboard_tbI.TabIndex = 1;
            // 
            // dashboard_TI
            // 
            this.dashboard_TI.AutoSize = true;
            this.dashboard_TI.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_TI.ForeColor = System.Drawing.Color.DarkRed;
            this.dashboard_TI.Location = new System.Drawing.Point(141, 205);
            this.dashboard_TI.Name = "dashboard_TI";
            this.dashboard_TI.Size = new System.Drawing.Size(48, 25);
            this.dashboard_TI.TabIndex = 13;
            this.dashboard_TI.Text = "$0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(26, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Today\'s Income";
            // 
            // dashboard_tbcust
            // 
            this.dashboard_tbcust.BackColor = System.Drawing.Color.SeaShell;
            this.dashboard_tbcust.Controls.Add(this.pictureBox2);
            this.dashboard_tbcust.Controls.Add(this.dashboard_TCust);
            this.dashboard_tbcust.Controls.Add(this.label1);
            this.dashboard_tbcust.Location = new System.Drawing.Point(274, 13);
            this.dashboard_tbcust.Name = "dashboard_tbcust";
            this.dashboard_tbcust.Size = new System.Drawing.Size(228, 244);
            this.dashboard_tbcust.TabIndex = 1;
            // 
            // dashboard_TCust
            // 
            this.dashboard_TCust.AutoSize = true;
            this.dashboard_TCust.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_TCust.ForeColor = System.Drawing.Color.DarkRed;
            this.dashboard_TCust.Location = new System.Drawing.Point(178, 205);
            this.dashboard_TCust.Name = "dashboard_TCust";
            this.dashboard_TCust.Size = new System.Drawing.Size(22, 25);
            this.dashboard_TCust.TabIndex = 14;
            this.dashboard_TCust.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total of Customer";
            // 
            // dashboard_tb
            // 
            this.dashboard_tb.BackColor = System.Drawing.Color.SeaShell;
            this.dashboard_tb.Controls.Add(this.dashboard_TC);
            this.dashboard_tb.Controls.Add(this.label2);
            this.dashboard_tb.Controls.Add(this.pictureBox1);
            this.dashboard_tb.Location = new System.Drawing.Point(23, 13);
            this.dashboard_tb.Name = "dashboard_tb";
            this.dashboard_tb.Size = new System.Drawing.Size(227, 244);
            this.dashboard_tb.TabIndex = 0;
            // 
            // dashboard_TC
            // 
            this.dashboard_TC.AutoSize = true;
            this.dashboard_TC.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_TC.ForeColor = System.Drawing.Color.DarkRed;
            this.dashboard_TC.Location = new System.Drawing.Point(173, 205);
            this.dashboard_TC.Name = "dashboard_TC";
            this.dashboard_TC.Size = new System.Drawing.Size(22, 25);
            this.dashboard_TC.TabIndex = 11;
            this.dashboard_TC.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(36, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total of Barista";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SeaShell;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 310);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1024, 376);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CafeInn.Properties.Resources.cafe;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1021, 384);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CafeInn.Properties.Resources.Income3;
            this.pictureBox4.Location = new System.Drawing.Point(18, 96);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 87);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CafeInn.Properties.Resources.Money3;
            this.pictureBox3.Location = new System.Drawing.Point(22, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CafeInn.Properties.Resources.Total_Customer2;
            this.pictureBox2.Location = new System.Drawing.Point(21, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeInn.Properties.Resources.Total_Cashier2;
            this.pictureBox1.Location = new System.Drawing.Point(14, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboardForm";
            this.Size = new System.Drawing.Size(1050, 702);
            this.panel1.ResumeLayout(false);
            this.dashboard_tbIn.ResumeLayout(false);
            this.dashboard_tbIn.PerformLayout();
            this.dashboard_tbI.ResumeLayout(false);
            this.dashboard_tbI.PerformLayout();
            this.dashboard_tbcust.ResumeLayout(false);
            this.dashboard_tbcust.PerformLayout();
            this.dashboard_tb.ResumeLayout(false);
            this.dashboard_tb.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        /*private void panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }
        */
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel dashboard_tb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel dashboard_tbIn;
        private System.Windows.Forms.Panel dashboard_tbI;
        private System.Windows.Forms.Panel dashboard_tbcust;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dashboard_TIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dashboard_TI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dashboard_TCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dashboard_TC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PictureBox pictureBox5;
    }
}
