namespace RNA
{
    partial class Setup_Constraints
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
            this.Restriction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reversible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerBound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperBound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 462);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(411, 462);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Restriction,
            this.Reversible,
            this.LowerBound,
            this.UpperBound});
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 444);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Restriction
            // 
            this.Restriction.HeaderText = "Restriction";
            this.Restriction.Name = "Restriction";
            this.Restriction.ReadOnly = true;
            this.Restriction.Width = 220;
            // 
            // Reversible
            // 
            this.Reversible.HeaderText = "Reversible";
            this.Reversible.MaxInputLength = 5;
            this.Reversible.Name = "Reversible";
            this.Reversible.ReadOnly = true;
            this.Reversible.Width = 60;
            // 
            // LowerBound
            // 
            this.LowerBound.HeaderText = "Lower Bound";
            this.LowerBound.MaxInputLength = 6;
            this.LowerBound.Name = "LowerBound";
            this.LowerBound.Width = 70;
            // 
            // UpperBound
            // 
            this.UpperBound.HeaderText = "Upper Bound";
            this.UpperBound.MaxInputLength = 6;
            this.UpperBound.Name = "UpperBound";
            this.UpperBound.Width = 70;
            // 
            // Setup_Constraints
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(507, 488);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Setup_Constraints";
            this.Text = "Setup_Constraints";
            this.Load += new System.EventHandler(this.Setup_Constraints_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restriction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reversible;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowerBound;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpperBound;
    }
}