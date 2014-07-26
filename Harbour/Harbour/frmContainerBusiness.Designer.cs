namespace Harbour
{
    partial class frmContainerBusiness
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
            this.dgvCntBusi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCntNo = new System.Windows.Forms.TextBox();
            this.txtCntType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCntHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCntLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLineId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnAddBusi = new System.Windows.Forms.Button();
            this.btnDeleteBusi = new System.Windows.Forms.Button();
            this.btnUpdateBusi = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCntBusi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCntBusi
            // 
            this.dgvCntBusi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCntBusi.Location = new System.Drawing.Point(4, 106);
            this.dgvCntBusi.Name = "dgvCntBusi";
            this.dgvCntBusi.RowTemplate.Height = 23;
            this.dgvCntBusi.Size = new System.Drawing.Size(919, 417);
            this.dgvCntBusi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "箱号";
            // 
            // txtCntNo
            // 
            this.txtCntNo.Location = new System.Drawing.Point(83, 19);
            this.txtCntNo.Name = "txtCntNo";
            this.txtCntNo.Size = new System.Drawing.Size(100, 21);
            this.txtCntNo.TabIndex = 2;
            // 
            // txtCntType
            // 
            this.txtCntType.Location = new System.Drawing.Point(260, 19);
            this.txtCntType.Name = "txtCntType";
            this.txtCntType.Size = new System.Drawing.Size(100, 21);
            this.txtCntType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "箱型";
            // 
            // txtCntHeight
            // 
            this.txtCntHeight.Location = new System.Drawing.Point(437, 19);
            this.txtCntHeight.Name = "txtCntHeight";
            this.txtCntHeight.Size = new System.Drawing.Size(100, 21);
            this.txtCntHeight.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "高度";
            // 
            // txtCntLength
            // 
            this.txtCntLength.Location = new System.Drawing.Point(614, 19);
            this.txtCntLength.Name = "txtCntLength";
            this.txtCntLength.Size = new System.Drawing.Size(100, 21);
            this.txtCntLength.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "长度";
            // 
            // txtLineId
            // 
            this.txtLineId.Location = new System.Drawing.Point(791, 19);
            this.txtLineId.Name = "txtLineId";
            this.txtLineId.Size = new System.Drawing.Size(100, 21);
            this.txtLineId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(732, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "箱主";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(201, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(319, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(437, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(83, 59);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // btnAddBusi
            // 
            this.btnAddBusi.Location = new System.Drawing.Point(461, 545);
            this.btnAddBusi.Name = "btnAddBusi";
            this.btnAddBusi.Size = new System.Drawing.Size(75, 23);
            this.btnAddBusi.TabIndex = 17;
            this.btnAddBusi.Text = "增加一行";
            this.btnAddBusi.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBusi
            // 
            this.btnDeleteBusi.Location = new System.Drawing.Point(579, 545);
            this.btnDeleteBusi.Name = "btnDeleteBusi";
            this.btnDeleteBusi.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBusi.TabIndex = 18;
            this.btnDeleteBusi.Text = "删除一行";
            this.btnDeleteBusi.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBusi
            // 
            this.btnUpdateBusi.Location = new System.Drawing.Point(697, 545);
            this.btnUpdateBusi.Name = "btnUpdateBusi";
            this.btnUpdateBusi.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBusi.TabIndex = 19;
            this.btnUpdateBusi.Text = "修改一行";
            this.btnUpdateBusi.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(815, 545);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmContainerBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 599);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateBusi);
            this.Controls.Add(this.btnDeleteBusi);
            this.Controls.Add(this.btnAddBusi);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLineId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCntLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCntHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCntType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCntNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCntBusi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmContainerBusiness";
            this.Text = "集装箱信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCntBusi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCntBusi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCntNo;
        private System.Windows.Forms.TextBox txtCntType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCntHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCntLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLineId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnAddBusi;
        private System.Windows.Forms.Button btnDeleteBusi;
        private System.Windows.Forms.Button btnUpdateBusi;
        private System.Windows.Forms.Button btnSave;
    }
}