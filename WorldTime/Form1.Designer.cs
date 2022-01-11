
namespace WorldTime
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
            this.localLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pst = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.est = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ist = new System.Windows.Forms.Label();
            this.ontop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // localLbl
            // 
            this.localLbl.AutoSize = true;
            this.localLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.localLbl.Location = new System.Drawing.Point(12, 41);
            this.localLbl.Name = "localLbl";
            this.localLbl.Size = new System.Drawing.Size(88, 37);
            this.localLbl.TabIndex = 0;
            this.localLbl.Text = "00:00";
            this.localLbl.Click += new System.EventHandler(this.localLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "GMT/UTC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pst
            // 
            this.pst.AutoSize = true;
            this.pst.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pst.Location = new System.Drawing.Point(106, 41);
            this.pst.Name = "pst";
            this.pst.Size = new System.Drawing.Size(88, 37);
            this.pst.TabIndex = 2;
            this.pst.Text = "00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pacific (PST)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Eastern (EST)";
            // 
            // est
            // 
            this.est.AutoSize = true;
            this.est.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.est.Location = new System.Drawing.Point(201, 41);
            this.est.Name = "est";
            this.est.Size = new System.Drawing.Size(88, 37);
            this.est.TabIndex = 4;
            this.est.Text = "00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "India (IST)";
            // 
            // ist
            // 
            this.ist.AutoSize = true;
            this.ist.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ist.Location = new System.Drawing.Point(295, 41);
            this.ist.Name = "ist";
            this.ist.Size = new System.Drawing.Size(88, 37);
            this.ist.TabIndex = 6;
            this.ist.Text = "00:00";
            this.ist.Click += new System.EventHandler(this.label7_Click);
            // 
            // ontop
            // 
            this.ontop.Location = new System.Drawing.Point(284, 99);
            this.ontop.Name = "ontop";
            this.ontop.Size = new System.Drawing.Size(105, 23);
            this.ontop.TabIndex = 8;
            this.ontop.Text = "Toggle OnTop";
            this.ontop.UseVisualStyleBackColor = true;
            this.ontop.Click += new System.EventHandler(this.ontop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 134);
            this.Controls.Add(this.ontop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.est);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WorldTime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label localLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label est;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ist;
        private System.Windows.Forms.Button ontop;
    }
}

