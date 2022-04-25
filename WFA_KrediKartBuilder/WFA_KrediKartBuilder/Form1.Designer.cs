
namespace WFA_KrediKartBuilder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBanka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rbEvet = new System.Windows.Forms.RadioButton();
            this.rbHayir = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKartTip = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.rbHayir);
            this.groupBox1.Controls.Add(this.rbEvet);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.cmbKartTip);
            this.groupBox1.Controls.Add(this.cmbBanka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kredi Kartı Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Seç:";
            // 
            // cmbBanka
            // 
            this.cmbBanka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanka.FormattingEnabled = true;
            this.cmbBanka.Location = new System.Drawing.Point(104, 33);
            this.cmbBanka.Name = "cmbBanka";
            this.cmbBanka.Size = new System.Drawing.Size(184, 28);
            this.cmbBanka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kart Limit:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(104, 88);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(184, 26);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Taksit:";
            // 
            // rbEvet
            // 
            this.rbEvet.AutoSize = true;
            this.rbEvet.Location = new System.Drawing.Point(100, 153);
            this.rbEvet.Name = "rbEvet";
            this.rbEvet.Size = new System.Drawing.Size(59, 24);
            this.rbEvet.TabIndex = 3;
            this.rbEvet.TabStop = true;
            this.rbEvet.Text = "Evet";
            this.rbEvet.UseVisualStyleBackColor = true;
            // 
            // rbHayir
            // 
            this.rbHayir.AutoSize = true;
            this.rbHayir.Location = new System.Drawing.Point(193, 153);
            this.rbHayir.Name = "rbHayir";
            this.rbHayir.Size = new System.Drawing.Size(63, 24);
            this.rbHayir.TabIndex = 3;
            this.rbHayir.TabStop = true;
            this.rbHayir.Text = "Hayır";
            this.rbHayir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kart Tip:";
            // 
            // cmbKartTip
            // 
            this.cmbKartTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKartTip.FormattingEnabled = true;
            this.cmbKartTip.Location = new System.Drawing.Point(104, 198);
            this.cmbKartTip.Name = "cmbKartTip";
            this.cmbKartTip.Size = new System.Drawing.Size(184, 28);
            this.cmbKartTip.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(104, 250);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(184, 34);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(314, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(815, 298);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Banka Adı";
            this.columnHeader1.Width = 261;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kart Limit";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Taksit";
            this.columnHeader3.Width = 144;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kart Tip";
            this.columnHeader4.Width = 231;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 345);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton rbHayir;
        private System.Windows.Forms.RadioButton rbEvet;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cmbKartTip;
        private System.Windows.Forms.ComboBox cmbBanka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

