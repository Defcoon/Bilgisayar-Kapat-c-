namespace BilgisayarKapatici_v1
{
    partial class Performans_İzleyici
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
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.pbRAM = new System.Windows.Forms.ProgressBar();
            this.lblRAM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbCPU = new System.Windows.Forms.ProgressBar();
            this.lblCPU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.islemci = new System.Diagnostics.PerformanceCounter();
            this.tmrDeger = new System.Windows.Forms.Timer(this.components);
            this.ram = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.islemci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            this.SuspendLayout();
            // 
            // chkTopMost
            // 
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTopMost.Location = new System.Drawing.Point(13, 14);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(140, 17);
            this.chkTopMost.TabIndex = 14;
            this.chkTopMost.Text = "Her zaman üstte tut";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged_1);
            // 
            // pbRAM
            // 
            this.pbRAM.Location = new System.Drawing.Point(15, 108);
            this.pbRAM.Name = "pbRAM";
            this.pbRAM.Size = new System.Drawing.Size(187, 18);
            this.pbRAM.TabIndex = 13;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRAM.ForeColor = System.Drawing.Color.Red;
            this.lblRAM.Location = new System.Drawing.Point(102, 89);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(27, 13);
            this.lblRAM.TabIndex = 12;
            this.lblRAM.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "RAM Kullanımı :";
            // 
            // pbCPU
            // 
            this.pbCPU.Location = new System.Drawing.Point(14, 59);
            this.pbCPU.Name = "pbCPU";
            this.pbCPU.Size = new System.Drawing.Size(188, 18);
            this.pbCPU.TabIndex = 10;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCPU.ForeColor = System.Drawing.Color.Red;
            this.lblCPU.Location = new System.Drawing.Point(102, 40);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(27, 13);
            this.lblCPU.TabIndex = 9;
            this.lblCPU.Text = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CPU Kullanımı :";
            // 
            // islemci
            // 
            this.islemci.CategoryName = "İşlemci";
            this.islemci.CounterName = "% İşlemci Zamanı";
            this.islemci.InstanceName = "_Total";
            // 
            // tmrDeger
            // 
            this.tmrDeger.Interval = 500;
            this.tmrDeger.Tick += new System.EventHandler(this.tmrDeger_Tick);
            // 
            // ram
            // 
            this.ram.CategoryName = "Memory";
            this.ram.CounterName = "% Committed Bytes In Use";
            // 
            // Performans_İzleyici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 140);
            this.Controls.Add(this.chkTopMost);
            this.Controls.Add(this.pbRAM);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbCPU);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.label1);
            this.Name = "Performans_İzleyici";
            this.Text = "Performans_İzleyici";
            this.Load += new System.EventHandler(this.Performans_İzleyici_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.islemci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.ProgressBar pbRAM;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbCPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.PerformanceCounter islemci;
        private System.Windows.Forms.Timer tmrDeger;
        private System.Diagnostics.PerformanceCounter ram;
    }
}