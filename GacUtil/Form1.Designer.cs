namespace GacUtil
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
            this.GacDLLList = new System.Windows.Forms.DataGridView();
            this.GAC_32 = new System.Windows.Forms.CheckBox();
            this.GAC = new System.Windows.Forms.CheckBox();
            this.GAC_MSIL = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnEsporta = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.chkGac64 = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GacDLLList)).BeginInit();
            this.SuspendLayout();
            // 
            // GacDLLList
            // 
            this.GacDLLList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GacDLLList.Location = new System.Drawing.Point(12, 114);
            this.GacDLLList.Name = "GacDLLList";
            this.GacDLLList.Size = new System.Drawing.Size(984, 604);
            this.GacDLLList.TabIndex = 0;
            this.GacDLLList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GacDLLList_CellContentClick);
            // 
            // GAC_32
            // 
            this.GAC_32.AutoSize = true;
            this.GAC_32.Location = new System.Drawing.Point(12, 48);
            this.GAC_32.Name = "GAC_32";
            this.GAC_32.Size = new System.Drawing.Size(66, 17);
            this.GAC_32.TabIndex = 1;
            this.GAC_32.Text = "GAC_32";
            this.GAC_32.UseVisualStyleBackColor = true;
            this.GAC_32.CheckedChanged += new System.EventHandler(this.GAC_32_CheckedChanged);
            // 
            // GAC
            // 
            this.GAC.AutoSize = true;
            this.GAC.Location = new System.Drawing.Point(84, 48);
            this.GAC.Name = "GAC";
            this.GAC.Size = new System.Drawing.Size(48, 17);
            this.GAC.TabIndex = 2;
            this.GAC.Text = "GAC";
            this.GAC.UseVisualStyleBackColor = true;
            this.GAC.CheckedChanged += new System.EventHandler(this.GAC_CheckedChanged);
            // 
            // GAC_MSIL
            // 
            this.GAC_MSIL.AutoSize = true;
            this.GAC_MSIL.Location = new System.Drawing.Point(138, 48);
            this.GAC_MSIL.Name = "GAC_MSIL";
            this.GAC_MSIL.Size = new System.Drawing.Size(79, 17);
            this.GAC_MSIL.TabIndex = 3;
            this.GAC_MSIL.Text = "GAC_MSIL";
            this.GAC_MSIL.UseVisualStyleBackColor = true;
            this.GAC_MSIL.CheckedChanged += new System.EventHandler(this.GAC_MSIL_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(12, 88);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cerca:";
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(295, 88);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 6;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnEsporta
            // 
            this.btnEsporta.Location = new System.Drawing.Point(376, 89);
            this.btnEsporta.Name = "btnEsporta";
            this.btnEsporta.Size = new System.Drawing.Size(82, 22);
            this.btnEsporta.TabIndex = 7;
            this.btnEsporta.Text = "Esporta";
            this.btnEsporta.UseVisualStyleBackColor = true;
            this.btnEsporta.Click += new System.EventHandler(this.btnEsporta_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(464, 89);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(106, 23);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "Import in GAC";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // chkGac64
            // 
            this.chkGac64.AutoSize = true;
            this.chkGac64.Location = new System.Drawing.Point(223, 48);
            this.chkGac64.Name = "chkGac64";
            this.chkGac64.Size = new System.Drawing.Size(66, 17);
            this.chkGac64.TabIndex = 9;
            this.chkGac64.Text = "GAC_64";
            this.chkGac64.UseVisualStyleBackColor = true;
            this.chkGac64.CheckedChanged += new System.EventHandler(this.chkGac64_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(243, 88);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(28, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "X";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkGac64);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnEsporta);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.GAC_MSIL);
            this.Controls.Add(this.GAC);
            this.Controls.Add(this.GAC_32);
            this.Controls.Add(this.GacDLLList);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAC Util";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GacDLLList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GacDLLList;
        private System.Windows.Forms.CheckBox GAC_32;
        private System.Windows.Forms.CheckBox GAC;
        private System.Windows.Forms.CheckBox GAC_MSIL;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnEsporta;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.CheckBox chkGac64;
        private System.Windows.Forms.Button btnClear;
    }
}

