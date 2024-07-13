namespace TESTneu2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.eingabeZeile = new System.Windows.Forms.TextBox();
            this.eingabeSpalten = new System.Windows.Forms.TextBox();
            this.TxtZeile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GenMatrix = new System.Windows.Forms.Button();
            this.SaveMatrix = new System.Windows.Forms.Button();
            this.textBoxAusgabeMatrix = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // eingabeZeile
            // 
            this.eingabeZeile.Location = new System.Drawing.Point(657, 32);
            this.eingabeZeile.Name = "eingabeZeile";
            this.eingabeZeile.Size = new System.Drawing.Size(100, 22);
            this.eingabeZeile.TabIndex = 0;
            // 
            // eingabeSpalten
            // 
            this.eingabeSpalten.Location = new System.Drawing.Point(657, 82);
            this.eingabeSpalten.Name = "eingabeSpalten";
            this.eingabeSpalten.Size = new System.Drawing.Size(100, 22);
            this.eingabeSpalten.TabIndex = 1;
            // 
            // TxtZeile
            // 
            this.TxtZeile.AutoSize = true;
            this.TxtZeile.Location = new System.Drawing.Point(578, 38);
            this.TxtZeile.Name = "TxtZeile";
            this.TxtZeile.Size = new System.Drawing.Size(50, 16);
            this.TxtZeile.TabIndex = 2;
            this.TxtZeile.Text = "Zeilen: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spalten: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(539, 226);
            this.dataGridView1.TabIndex = 4;
            // 
            // GenMatrix
            // 
            this.GenMatrix.Location = new System.Drawing.Point(688, 299);
            this.GenMatrix.Name = "GenMatrix";
            this.GenMatrix.Size = new System.Drawing.Size(100, 23);
            this.GenMatrix.TabIndex = 5;
            this.GenMatrix.Text = "Generieren";
            this.GenMatrix.UseVisualStyleBackColor = true;
            // 
            // SaveMatrix
            // 
            this.SaveMatrix.Location = new System.Drawing.Point(555, 299);
            this.SaveMatrix.Name = "SaveMatrix";
            this.SaveMatrix.Size = new System.Drawing.Size(101, 23);
            this.SaveMatrix.TabIndex = 6;
            this.SaveMatrix.Text = "Save";
            this.SaveMatrix.UseVisualStyleBackColor = true;
            // 
            // textBoxAusgabeMatrix
            // 
            this.textBoxAusgabeMatrix.Location = new System.Drawing.Point(133, 257);
            this.textBoxAusgabeMatrix.Multiline = true;
            this.textBoxAusgabeMatrix.Name = "textBoxAusgabeMatrix";
            this.textBoxAusgabeMatrix.Size = new System.Drawing.Size(244, 181);
            this.textBoxAusgabeMatrix.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAusgabeMatrix);
            this.Controls.Add(this.SaveMatrix);
            this.Controls.Add(this.GenMatrix);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtZeile);
            this.Controls.Add(this.eingabeSpalten);
            this.Controls.Add(this.eingabeZeile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox eingabeZeile;
        private System.Windows.Forms.TextBox eingabeSpalten;
        private System.Windows.Forms.Label TxtZeile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GenMatrix;
        private System.Windows.Forms.Button SaveMatrix;
        private System.Windows.Forms.TextBox textBoxAusgabeMatrix;
    }
}
