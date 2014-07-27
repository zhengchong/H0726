namespace Harbour
{
    partial class frmContractInfo
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
            this.dgvContInfo = new System.Windows.Forms.DataGridView();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.btnDelInfo = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContInfo
            // 
            this.dgvContInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContInfo.Location = new System.Drawing.Point(-1, 12);
            this.dgvContInfo.Name = "dgvContInfo";
            this.dgvContInfo.RowTemplate.Height = 23;
            this.dgvContInfo.Size = new System.Drawing.Size(753, 400);
            this.dgvContInfo.TabIndex = 0;
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Location = new System.Drawing.Point(291, 433);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(75, 23);
            this.btnAddInfo.TabIndex = 1;
            this.btnAddInfo.Text = "增加一行";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            // 
            // btnDelInfo
            // 
            this.btnDelInfo.Location = new System.Drawing.Point(409, 433);
            this.btnDelInfo.Name = "btnDelInfo";
            this.btnDelInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDelInfo.TabIndex = 1;
            this.btnDelInfo.Text = "减少一行";
            this.btnDelInfo.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(527, 433);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateInfo.TabIndex = 1;
            this.btnUpdateInfo.Text = "修改一行";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(645, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmContractInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 471);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.btnDelInfo);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.dgvContInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmContractInfo";
            this.Text = "frmContractInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContInfo;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Button btnDelInfo;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnSave;
    }
}