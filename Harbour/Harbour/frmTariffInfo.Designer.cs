namespace Harbour
{
    partial class frmTariffInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.btnDelInfo = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(743, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Location = new System.Drawing.Point(279, 399);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(75, 23);
            this.btnAddInfo.TabIndex = 1;
            this.btnAddInfo.Text = "增加一行";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            // 
            // btnDelInfo
            // 
            this.btnDelInfo.Location = new System.Drawing.Point(393, 399);
            this.btnDelInfo.Name = "btnDelInfo";
            this.btnDelInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDelInfo.TabIndex = 1;
            this.btnDelInfo.Text = "删除一行";
            this.btnDelInfo.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(507, 399);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateInfo.TabIndex = 1;
            this.btnUpdateInfo.Text = "查询一行";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(621, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmTariffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 449);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.btnDelInfo);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTariffInfo";
            this.Text = "frmTariffInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Button btnDelInfo;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnSave;
    }
}