namespace CNOVAHLP
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
            this.cbmSite = new System.Windows.Forms.ComboBox();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.txtStatusSite = new System.Windows.Forms.TextBox();
            this.cmbPoolsList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecyclePool = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbmSite
            // 
            this.cbmSite.FormattingEnabled = true;
            this.cbmSite.Items.AddRange(new object[] {
            "Selecion um site"});
            this.cbmSite.Location = new System.Drawing.Point(28, 72);
            this.cbmSite.Name = "cbmSite";
            this.cbmSite.Size = new System.Drawing.Size(141, 21);
            this.cbmSite.TabIndex = 0;
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(175, 70);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(75, 23);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(25, 106);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Habilitar Proxy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selecione um site";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(256, 70);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(75, 23);
            this.btnDesligar.TabIndex = 6;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // txtStatusSite
            // 
            this.txtStatusSite.Location = new System.Drawing.Point(28, 139);
            this.txtStatusSite.Multiline = true;
            this.txtStatusSite.Name = "txtStatusSite";
            this.txtStatusSite.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatusSite.Size = new System.Drawing.Size(573, 110);
            this.txtStatusSite.TabIndex = 7;
            // 
            // cmbPoolsList
            // 
            this.cmbPoolsList.FormattingEnabled = true;
            this.cmbPoolsList.Location = new System.Drawing.Point(31, 291);
            this.cmbPoolsList.Name = "cmbPoolsList";
            this.cmbPoolsList.Size = new System.Drawing.Size(244, 21);
            this.cmbPoolsList.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista de App Pools IIS";
            // 
            // btnRecyclePool
            // 
            this.btnRecyclePool.Location = new System.Drawing.Point(282, 288);
            this.btnRecyclePool.Name = "btnRecyclePool";
            this.btnRecyclePool.Size = new System.Drawing.Size(75, 23);
            this.btnRecyclePool.TabIndex = 10;
            this.btnRecyclePool.Text = "Reciclar Pool";
            this.btnRecyclePool.UseVisualStyleBackColor = true;
            this.btnRecyclePool.Click += new System.EventHandler(this.btnRecyclePool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 401);
            this.Controls.Add(this.btnRecyclePool);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPoolsList);
            this.Controls.Add(this.txtStatusSite);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.cbmSite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmSite;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.TextBox txtStatusSite;
        private System.Windows.Forms.ComboBox cmbPoolsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecyclePool;
    }
}

