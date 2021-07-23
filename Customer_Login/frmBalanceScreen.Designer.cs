
namespace Customer_Login
{
    partial class frmBalanceScreen
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("MS PGothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBalance.Location = new System.Drawing.Point(340, 202);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(167, 42);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(323, 142);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 50);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(138, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(149, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 97);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bank Ltd";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(407, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 114);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Close the Application (This will also Log-Out of your account)");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(244, 299);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 114);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "&Log-Out";
            this.toolTip1.SetToolTip(this.btnBack, "Go back to the Log-In screen");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBalanceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBalance);
            this.Name = "frmBalanceScreen";
            this.Text = "frmBalanceScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBalanceScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}