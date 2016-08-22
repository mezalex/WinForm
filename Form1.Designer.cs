namespace IKCWH5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.stockdataGridView = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adjcloseTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.closeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hozzaadasButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.szukitesButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.keresettMinta = new System.Windows.Forms.TextBox();
            this.ChoosedComboBox = new System.Windows.Forms.ComboBox();
            this.lekerdezesButton = new System.Windows.Forms.Button();
            this.torlesButton = new System.Windows.Forms.Button();
            this.szerkesztesButton = new System.Windows.Forms.Button();
            this.mentesButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rekordokSzamaLabel = new System.Windows.Forms.Label();
            this.megjelenitButton = new System.Windows.Forms.Button();
            this.diatorlesButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mentésKépkéntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.stockdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockdataGridView
            // 
            this.stockdataGridView.AllowUserToAddRows = false;
            this.stockdataGridView.AllowUserToDeleteRows = false;
            this.stockdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockdataGridView.Location = new System.Drawing.Point(12, 12);
            this.stockdataGridView.Name = "stockdataGridView";
            this.stockdataGridView.ReadOnly = true;
            this.stockdataGridView.Size = new System.Drawing.Size(563, 655);
            this.stockdataGridView.TabIndex = 0;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(584, 13);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(897, 400);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTextBox);
            this.groupBox1.Controls.Add(this.adjcloseTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.volumeTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.closeTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lowTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.highTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.openTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hozzaadasButton);
            this.groupBox1.Location = new System.Drawing.Point(732, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adat felvétel";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(67, 20);
            this.dateTextBox.Mask = "0000-00-00";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 15;
            // 
            // adjcloseTextBox
            // 
            this.adjcloseTextBox.Location = new System.Drawing.Point(67, 176);
            this.adjcloseTextBox.Name = "adjcloseTextBox";
            this.adjcloseTextBox.Size = new System.Drawing.Size(100, 20);
            this.adjcloseTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adj. close:";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(67, 150);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.volumeTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Volume:";
            // 
            // closeTextBox
            // 
            this.closeTextBox.Location = new System.Drawing.Point(67, 124);
            this.closeTextBox.Name = "closeTextBox";
            this.closeTextBox.Size = new System.Drawing.Size(100, 20);
            this.closeTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Close:";
            // 
            // lowTextBox
            // 
            this.lowTextBox.Location = new System.Drawing.Point(67, 98);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Low:";
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(67, 72);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(100, 20);
            this.highTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "High:";
            // 
            // openTextBox
            // 
            this.openTextBox.Location = new System.Drawing.Point(67, 46);
            this.openTextBox.Name = "openTextBox";
            this.openTextBox.Size = new System.Drawing.Size(100, 20);
            this.openTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Open:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // hozzaadasButton
            // 
            this.hozzaadasButton.Location = new System.Drawing.Point(92, 198);
            this.hozzaadasButton.Name = "hozzaadasButton";
            this.hozzaadasButton.Size = new System.Drawing.Size(75, 23);
            this.hozzaadasButton.TabIndex = 0;
            this.hozzaadasButton.Text = "Hozzáadás";
            this.hozzaadasButton.UseVisualStyleBackColor = true;
            this.hozzaadasButton.Click += new System.EventHandler(this.hozzaadasButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.szukitesButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.keresettMinta);
            this.groupBox2.Controls.Add(this.ChoosedComboBox);
            this.groupBox2.Location = new System.Drawing.Point(1205, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 221);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keresés";
            // 
            // szukitesButton
            // 
            this.szukitesButton.Location = new System.Drawing.Point(53, 179);
            this.szukitesButton.Name = "szukitesButton";
            this.szukitesButton.Size = new System.Drawing.Size(75, 23);
            this.szukitesButton.TabIndex = 4;
            this.szukitesButton.Text = "Szűkítés";
            this.szukitesButton.UseVisualStyleBackColor = true;
            this.szukitesButton.Click += new System.EventHandler(this.szukitesButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Keresett részlet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Oszlop";
            // 
            // keresettMinta
            // 
            this.keresettMinta.Location = new System.Drawing.Point(7, 123);
            this.keresettMinta.Name = "keresettMinta";
            this.keresettMinta.Size = new System.Drawing.Size(121, 20);
            this.keresettMinta.TabIndex = 1;
            // 
            // ChoosedComboBox
            // 
            this.ChoosedComboBox.FormattingEnabled = true;
            this.ChoosedComboBox.Items.AddRange(new object[] {
            "ID",
            "Opening",
            "High",
            "Low",
            "Closing",
            "Volume",
            "AdjClose"});
            this.ChoosedComboBox.Location = new System.Drawing.Point(7, 44);
            this.ChoosedComboBox.Name = "ChoosedComboBox";
            this.ChoosedComboBox.Size = new System.Drawing.Size(121, 21);
            this.ChoosedComboBox.TabIndex = 0;
            // 
            // lekerdezesButton
            // 
            this.lekerdezesButton.Location = new System.Drawing.Point(915, 460);
            this.lekerdezesButton.Name = "lekerdezesButton";
            this.lekerdezesButton.Size = new System.Drawing.Size(130, 26);
            this.lekerdezesButton.TabIndex = 4;
            this.lekerdezesButton.Text = "Lekérdezés";
            this.lekerdezesButton.UseVisualStyleBackColor = true;
            this.lekerdezesButton.Click += new System.EventHandler(this.lekerdezesButton_Click);
            // 
            // torlesButton
            // 
            this.torlesButton.Location = new System.Drawing.Point(1070, 459);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(129, 27);
            this.torlesButton.TabIndex = 5;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = true;
            this.torlesButton.Click += new System.EventHandler(this.torlesButton_Click);
            // 
            // szerkesztesButton
            // 
            this.szerkesztesButton.Location = new System.Drawing.Point(916, 495);
            this.szerkesztesButton.Name = "szerkesztesButton";
            this.szerkesztesButton.Size = new System.Drawing.Size(130, 27);
            this.szerkesztesButton.TabIndex = 6;
            this.szerkesztesButton.Text = "Szerkesztés";
            this.szerkesztesButton.UseVisualStyleBackColor = true;
            this.szerkesztesButton.Click += new System.EventHandler(this.szerkesztesButton_Click);
            // 
            // mentesButton
            // 
            this.mentesButton.Location = new System.Drawing.Point(1070, 495);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(129, 27);
            this.mentesButton.TabIndex = 7;
            this.mentesButton.Text = "Mentés";
            this.mentesButton.UseVisualStyleBackColor = true;
            this.mentesButton.Click += new System.EventHandler(this.mentesButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 684);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Rekordok száma:";
            // 
            // rekordokSzamaLabel
            // 
            this.rekordokSzamaLabel.AutoSize = true;
            this.rekordokSzamaLabel.Location = new System.Drawing.Point(108, 684);
            this.rekordokSzamaLabel.Name = "rekordokSzamaLabel";
            this.rekordokSzamaLabel.Size = new System.Drawing.Size(12, 13);
            this.rekordokSzamaLabel.TabIndex = 9;
            this.rekordokSzamaLabel.Text = "\\";
            // 
            // megjelenitButton
            // 
            this.megjelenitButton.Location = new System.Drawing.Point(916, 586);
            this.megjelenitButton.Name = "megjelenitButton";
            this.megjelenitButton.Size = new System.Drawing.Size(129, 30);
            this.megjelenitButton.TabIndex = 10;
            this.megjelenitButton.Text = "Megjelenít diagramon";
            this.megjelenitButton.UseVisualStyleBackColor = true;
            this.megjelenitButton.Click += new System.EventHandler(this.megjelenitButton_Click);
            // 
            // diatorlesButton
            // 
            this.diatorlesButton.Location = new System.Drawing.Point(917, 622);
            this.diatorlesButton.Name = "diatorlesButton";
            this.diatorlesButton.Size = new System.Drawing.Size(129, 30);
            this.diatorlesButton.TabIndex = 11;
            this.diatorlesButton.Text = "Diagram törlés";
            this.diatorlesButton.UseVisualStyleBackColor = true;
            this.diatorlesButton.Click += new System.EventHandler(this.diatorlesButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Opening",
            "High",
            "Low",
            "Closing",
            "Volume",
            "AdjClose"});
            this.checkedListBox1.Location = new System.Drawing.Point(1062, 569);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(137, 94);
            this.checkedListBox1.TabIndex = 12;
            this.checkedListBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentésKépkéntToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 26);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // mentésKépkéntToolStripMenuItem
            // 
            this.mentésKépkéntToolStripMenuItem.Name = "mentésKépkéntToolStripMenuItem";
            this.mentésKépkéntToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.mentésKépkéntToolStripMenuItem.Text = "Mentés képként";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 706);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.diatorlesButton);
            this.Controls.Add(this.megjelenitButton);
            this.Controls.Add(this.rekordokSzamaLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mentesButton);
            this.Controls.Add(this.szerkesztesButton);
            this.Controls.Add(this.torlesButton);
            this.Controls.Add(this.lekerdezesButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.stockdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tőzsdei adatok";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockdataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox adjcloseTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox closeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox openTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hozzaadasButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox keresettMinta;
        private System.Windows.Forms.ComboBox ChoosedComboBox;
        private System.Windows.Forms.Button szukitesButton;
        private System.Windows.Forms.Button lekerdezesButton;
        private System.Windows.Forms.Button torlesButton;
        private System.Windows.Forms.Button szerkesztesButton;
        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label rekordokSzamaLabel;
        private System.Windows.Forms.Button megjelenitButton;
        private System.Windows.Forms.Button diatorlesButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mentésKépkéntToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

