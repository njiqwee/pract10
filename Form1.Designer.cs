namespace pract10
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBoxFN = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxLN = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxS = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxIDDelete = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(352, 30);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(503, 488);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// textBoxFN
			// 
			this.textBoxFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxFN.Location = new System.Drawing.Point(137, 30);
			this.textBoxFN.Name = "textBoxFN";
			this.textBoxFN.Size = new System.Drawing.Size(195, 31);
			this.textBoxFN.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(15, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Firstname";
			// 
			// textBoxLN
			// 
			this.textBoxLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLN.Location = new System.Drawing.Point(137, 67);
			this.textBoxLN.Name = "textBoxLN";
			this.textBoxLN.Size = new System.Drawing.Size(195, 31);
			this.textBoxLN.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(15, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Lastname";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAdd.Location = new System.Drawing.Point(20, 189);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(122, 46);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDelete.Location = new System.Drawing.Point(20, 283);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(122, 46);
			this.buttonDelete.TabIndex = 3;
			this.buttonDelete.Text = "delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// textBoxS
			// 
			this.textBoxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxS.Location = new System.Drawing.Point(137, 104);
			this.textBoxS.Name = "textBoxS";
			this.textBoxS.Size = new System.Drawing.Size(195, 31);
			this.textBoxS.TabIndex = 1;
			this.textBoxS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxS_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(15, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "search";
			// 
			// textBoxIDDelete
			// 
			this.textBoxIDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxIDDelete.Location = new System.Drawing.Point(151, 307);
			this.textBoxIDDelete.Name = "textBoxIDDelete";
			this.textBoxIDDelete.Size = new System.Drawing.Size(195, 31);
			this.textBoxIDDelete.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(181, 279);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "ID";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(867, 539);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxIDDelete);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxS);
			this.Controls.Add(this.textBoxLN);
			this.Controls.Add(this.textBoxFN);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "app";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxFN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxLN;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBoxS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxIDDelete;
		private System.Windows.Forms.Label label4;
	}
}

