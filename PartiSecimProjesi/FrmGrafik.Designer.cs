namespace PartiSecimProjesi
{
    partial class FrmGrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrafik));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblE = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.prgbarE = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.prgbarD = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prgbarC = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.prgbarB = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.prgbarA = new System.Windows.Forms.ProgressBar();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1073, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 31);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1067, 278);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblE);
            this.groupBox2.Controls.Add(this.lblD);
            this.groupBox2.Controls.Add(this.lblC);
            this.groupBox2.Controls.Add(this.lblB);
            this.groupBox2.Controls.Add(this.lblA);
            this.groupBox2.Controls.Add(this.prgbarE);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.prgbarD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.prgbarC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.prgbarB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.prgbarA);
            this.groupBox2.Controls.Add(this.cmbIlce);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1073, 337);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri ";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(849, 280);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(26, 29);
            this.lblE.TabIndex = 17;
            this.lblE.Text = "0";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(849, 229);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(26, 29);
            this.lblD.TabIndex = 16;
            this.lblD.Text = "0";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(849, 178);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(26, 29);
            this.lblC.TabIndex = 15;
            this.lblC.Text = "0";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(849, 128);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(26, 29);
            this.lblB.TabIndex = 14;
            this.lblB.Text = "0";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(849, 84);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(26, 29);
            this.lblA.TabIndex = 13;
            this.lblA.Text = "0";
            // 
            // prgbarE
            // 
            this.prgbarE.Location = new System.Drawing.Point(327, 276);
            this.prgbarE.Maximum = 200;
            this.prgbarE.Name = "prgbarE";
            this.prgbarE.Size = new System.Drawing.Size(500, 43);
            this.prgbarE.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Parti E:";
            // 
            // prgbarD
            // 
            this.prgbarD.Location = new System.Drawing.Point(327, 226);
            this.prgbarD.Maximum = 200;
            this.prgbarD.Name = "prgbarD";
            this.prgbarD.Size = new System.Drawing.Size(500, 43);
            this.prgbarD.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parti D:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parti C:";
            // 
            // prgbarC
            // 
            this.prgbarC.Location = new System.Drawing.Point(327, 175);
            this.prgbarC.Maximum = 200;
            this.prgbarC.Name = "prgbarC";
            this.prgbarC.Size = new System.Drawing.Size(500, 43);
            this.prgbarC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parti B:";
            // 
            // prgbarB
            // 
            this.prgbarB.Location = new System.Drawing.Point(327, 126);
            this.prgbarB.Maximum = 200;
            this.prgbarB.Name = "prgbarB";
            this.prgbarB.Size = new System.Drawing.Size(500, 43);
            this.prgbarB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parti A:";
            // 
            // prgbarA
            // 
            this.prgbarA.Location = new System.Drawing.Point(327, 77);
            this.prgbarA.Maximum = 200;
            this.prgbarA.Name = "prgbarA";
            this.prgbarA.Size = new System.Drawing.Size(500, 43);
            this.prgbarA.TabIndex = 2;
            // 
            // cmbIlce
            // 
            this.cmbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(327, 36);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(500, 37);
            this.cmbIlce.TabIndex = 1;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // FrmGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1097, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmGrafik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrafik";
            this.Load += new System.EventHandler(this.FrmGrafik_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgbarE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar prgbarD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar prgbarC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prgbarB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar prgbarA;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
    }
}