
namespace _23_variant_CSarp_1_4_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelInputEl = new System.Windows.Forms.Label();
            this.textBoxInputEl = new System.Windows.Forms.TextBox();
            this.labelPosElem = new System.Windows.Forms.Label();
            this.buttonInputEl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(901, 364);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelInputEl
            // 
            this.labelInputEl.AutoSize = true;
            this.labelInputEl.Font = new System.Drawing.Font("Segoe UI", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelInputEl.Location = new System.Drawing.Point(14, 11);
            this.labelInputEl.Name = "labelInputEl";
            this.labelInputEl.Size = new System.Drawing.Size(270, 19);
            this.labelInputEl.TabIndex = 8;
            this.labelInputEl.Text = "Введите(через пробел) аргументы X:";
            this.labelInputEl.Click += new System.EventHandler(this.labelInputEl_Click);
            // 
            // textBoxInputEl
            // 
            this.textBoxInputEl.Location = new System.Drawing.Point(324, 7);
            this.textBoxInputEl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInputEl.Name = "textBoxInputEl";
            this.textBoxInputEl.Size = new System.Drawing.Size(275, 30);
            this.textBoxInputEl.TabIndex = 7;
            // 
            // labelPosElem
            // 
            this.labelPosElem.AutoSize = true;
            this.labelPosElem.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPosElem.Location = new System.Drawing.Point(62, 462);
            this.labelPosElem.Name = "labelPosElem";
            this.labelPosElem.Size = new System.Drawing.Size(300, 19);
            this.labelPosElem.TabIndex = 10;
            this.labelPosElem.Text = "Количество положительных элементов= ";
            // 
            // buttonInputEl
            // 
            this.buttonInputEl.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInputEl.Location = new System.Drawing.Point(638, 7);
            this.buttonInputEl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInputEl.Name = "buttonInputEl";
            this.buttonInputEl.Size = new System.Drawing.Size(127, 31);
            this.buttonInputEl.TabIndex = 12;
            this.buttonInputEl.Text = "Рассчитать";
            this.buttonInputEl.UseVisualStyleBackColor = true;
            this.buttonInputEl.Click += new System.EventHandler(this.buttonInputEl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.buttonInputEl);
            this.Controls.Add(this.labelPosElem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelInputEl);
            this.Controls.Add(this.textBoxInputEl);
            this.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelInputEl;
        private System.Windows.Forms.TextBox textBoxInputEl;
        private System.Windows.Forms.Label labelPosElem;
        private System.Windows.Forms.Button buttonInputEl;
    }
}

