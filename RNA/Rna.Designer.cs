namespace RNA
{
    partial class Rna
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
            this.label7 = new System.Windows.Forms.Label();
            this.comboconstrain = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiomin = new System.Windows.Forms.RadioButton();
            this.radiomax = new System.Windows.Forms.RadioButton();
            this.resultlist = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updateButton = new System.Windows.Forms.Button();
            this.uppertextBox2 = new System.Windows.Forms.TextBox();
            this.lowertextBox1 = new System.Windows.Forms.TextBox();
            this.reactionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.isReversibleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reactionObjetiveComboBox = new System.Windows.Forms.ComboBox();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboreactionexchange = new System.Windows.Forms.ComboBox();
            this.bNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.aNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.combometabolites = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 454);
            this.button1.Text = "Solve";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(413, 454);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Setup Constraints:";
            // 
            // comboconstrain
            // 
            this.comboconstrain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboconstrain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboconstrain.FormattingEnabled = true;
            this.comboconstrain.Location = new System.Drawing.Point(129, 74);
            this.comboconstrain.Name = "comboconstrain";
            this.comboconstrain.Size = new System.Drawing.Size(278, 21);
            this.comboconstrain.TabIndex = 55;
            this.comboconstrain.SelectedIndexChanged += new System.EventHandler(this.comboconstrain_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiomin);
            this.groupBox1.Controls.Add(this.radiomax);
            this.groupBox1.Location = new System.Drawing.Point(413, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 70);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optimize";
            // 
            // radiomin
            // 
            this.radiomin.AutoSize = true;
            this.radiomin.Location = new System.Drawing.Point(6, 42);
            this.radiomin.Name = "radiomin";
            this.radiomin.Size = new System.Drawing.Size(42, 17);
            this.radiomin.TabIndex = 0;
            this.radiomin.Text = "Min";
            this.radiomin.UseVisualStyleBackColor = true;
            // 
            // radiomax
            // 
            this.radiomax.AutoSize = true;
            this.radiomax.Checked = true;
            this.radiomax.Location = new System.Drawing.Point(6, 19);
            this.radiomax.Name = "radiomax";
            this.radiomax.Size = new System.Drawing.Size(45, 17);
            this.radiomax.TabIndex = 0;
            this.radiomax.TabStop = true;
            this.radiomax.Text = "Max";
            this.radiomax.UseVisualStyleBackColor = true;
            // 
            // resultlist
            // 
            this.resultlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.resultlist.GridLines = true;
            this.resultlist.Location = new System.Drawing.Point(14, 272);
            this.resultlist.Name = "resultlist";
            this.resultlist.Size = new System.Drawing.Size(474, 176);
            this.resultlist.TabIndex = 52;
            this.resultlist.UseCompatibleStateImageBehavior = false;
            this.resultlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Increment Value";
            this.columnHeader4.Width = 183;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Flux Value";
            this.columnHeader5.Width = 195;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(413, 105);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 51;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // uppertextBox2
            // 
            this.uppertextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.uppertextBox2.Location = new System.Drawing.Point(129, 141);
            this.uppertextBox2.Name = "uppertextBox2";
            this.uppertextBox2.Size = new System.Drawing.Size(278, 20);
            this.uppertextBox2.TabIndex = 50;
            this.uppertextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uppertextBox2_KeyPress);
            // 
            // lowertextBox1
            // 
            this.lowertextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lowertextBox1.Location = new System.Drawing.Point(129, 119);
            this.lowertextBox1.Name = "lowertextBox1";
            this.lowertextBox1.Size = new System.Drawing.Size(278, 20);
            this.lowertextBox1.TabIndex = 49;
            this.lowertextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowertextBox1_KeyPress);
            // 
            // reactionTextBox
            // 
            this.reactionTextBox.Location = new System.Drawing.Point(129, 52);
            this.reactionTextBox.Name = "reactionTextBox";
            this.reactionTextBox.ReadOnly = true;
            this.reactionTextBox.Size = new System.Drawing.Size(278, 20);
            this.reactionTextBox.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Reaction Id:";
            // 
            // isReversibleTextBox
            // 
            this.isReversibleTextBox.Location = new System.Drawing.Point(129, 97);
            this.isReversibleTextBox.Name = "isReversibleTextBox";
            this.isReversibleTextBox.ReadOnly = true;
            this.isReversibleTextBox.Size = new System.Drawing.Size(278, 20);
            this.isReversibleTextBox.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Upper Bound:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Lower Bound:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Is Reversible: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Objective Function:";
            // 
            // reactionObjetiveComboBox
            // 
            this.reactionObjetiveComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.reactionObjetiveComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.reactionObjetiveComboBox.FormattingEnabled = true;
            this.reactionObjetiveComboBox.Location = new System.Drawing.Point(129, 29);
            this.reactionObjetiveComboBox.Name = "reactionObjetiveComboBox";
            this.reactionObjetiveComboBox.Size = new System.Drawing.Size(278, 21);
            this.reactionObjetiveComboBox.TabIndex = 41;
            this.reactionObjetiveComboBox.SelectedIndexChanged += new System.EventHandler(this.reactionObjetiveComboBox_SelectedIndexChanged);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTextBox.Location = new System.Drawing.Point(44, 6);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(363, 20);
            this.fileTextBox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "File:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Reaction to be varied:";
            // 
            // comboreactionexchange
            // 
            this.comboreactionexchange.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboreactionexchange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboreactionexchange.FormattingEnabled = true;
            this.comboreactionexchange.Location = new System.Drawing.Point(129, 163);
            this.comboreactionexchange.Name = "comboreactionexchange";
            this.comboreactionexchange.Size = new System.Drawing.Size(278, 21);
            this.comboreactionexchange.TabIndex = 57;
            this.comboreactionexchange.SelectedIndexChanged += new System.EventHandler(this.comboreactionexchange_SelectedIndexChanged);
            // 
            // bNumericUpDown
            // 
            this.bNumericUpDown.Location = new System.Drawing.Point(129, 208);
            this.bNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.bNumericUpDown.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.bNumericUpDown.Name = "bNumericUpDown";
            this.bNumericUpDown.Size = new System.Drawing.Size(278, 20);
            this.bNumericUpDown.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "To B:";
            // 
            // aNumericUpDown
            // 
            this.aNumericUpDown.Location = new System.Drawing.Point(129, 186);
            this.aNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.aNumericUpDown.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.aNumericUpDown.Name = "aNumericUpDown";
            this.aNumericUpDown.Size = new System.Drawing.Size(278, 20);
            this.aNumericUpDown.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "From A:";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(117, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 63;
            this.button3.Text = "View Graphics";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Increment";
            // 
            // button4
            // 
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(413, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 24);
            this.button4.TabIndex = 66;
            this.button4.Text = "Convert";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(9, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "Internal Metabolites:";
            // 
            // combometabolites
            // 
            this.combometabolites.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combometabolites.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combometabolites.FormattingEnabled = true;
            this.combometabolites.Location = new System.Drawing.Point(129, 230);
            this.combometabolites.Name = "combometabolites";
            this.combometabolites.Size = new System.Drawing.Size(278, 21);
            this.combometabolites.TabIndex = 64;
            // 
            // button6
            // 
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(413, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 25);
            this.button6.TabIndex = 67;
            this.button6.Text = "Cosntraints";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(267, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 68;
            this.button5.Text = "Export Result RNA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"Text files (*.txt)|*.txt";
            // 
            // Rna
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(494, 479);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.combometabolites);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bNumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aNumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboreactionexchange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboconstrain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultlist);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.uppertextBox2);
            this.Controls.Add(this.lowertextBox1);
            this.Controls.Add(this.reactionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isReversibleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reactionObjetiveComboBox);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Rna";
            this.Text = "Robutness Network Analysis";
            this.Load += new System.EventHandler(this.Rna_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.fileTextBox, 0);
            this.Controls.SetChildIndex(this.reactionObjetiveComboBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.isReversibleTextBox, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.reactionTextBox, 0);
            this.Controls.SetChildIndex(this.lowertextBox1, 0);
            this.Controls.SetChildIndex(this.uppertextBox2, 0);
            this.Controls.SetChildIndex(this.updateButton, 0);
            this.Controls.SetChildIndex(this.resultlist, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.comboconstrain, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.comboreactionexchange, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.aNumericUpDown, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.bNumericUpDown, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.combometabolites, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboconstrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiomin;
        private System.Windows.Forms.RadioButton radiomax;
        private System.Windows.Forms.ListView resultlist;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox uppertextBox2;
        private System.Windows.Forms.TextBox lowertextBox1;
        private System.Windows.Forms.TextBox reactionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox isReversibleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox reactionObjetiveComboBox;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboreactionexchange;
        private System.Windows.Forms.NumericUpDown bNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown aNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combometabolites;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}