namespace DataImageReport
{
	partial class DataImage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataImage));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.title = new System.Windows.Forms.Label();
			this.label_id = new System.Windows.Forms.Label();
			this.label_name = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.picture_Signature = new System.Windows.Forms.PictureBox();
			this.picture_Photo = new System.Windows.Forms.PictureBox();
			this.button_Save = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture_Signature)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Photo)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 239);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(585, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(130, 17);
			this.toolStripStatusLabel.Text = "Data and images report";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(77, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(213, 20);
			this.textBox1.TabIndex = 1;
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(12, 9);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(296, 31);
			this.title.TabIndex = 2;
			this.title.Text = "Data and images report";
			// 
			// label_id
			// 
			this.label_id.AutoSize = true;
			this.label_id.Location = new System.Drawing.Point(15, 67);
			this.label_id.Name = "label_id";
			this.label_id.Size = new System.Drawing.Size(16, 13);
			this.label_id.TabIndex = 3;
			this.label_id.Text = "Id";
			// 
			// label_name
			// 
			this.label_name.AutoSize = true;
			this.label_name.Location = new System.Drawing.Point(15, 97);
			this.label_name.Name = "label_name";
			this.label_name.Size = new System.Drawing.Size(35, 13);
			this.label_name.TabIndex = 4;
			this.label_name.Text = "Name";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(77, 94);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(213, 20);
			this.textBox2.TabIndex = 5;
			// 
			// picture_Signature
			// 
			this.picture_Signature.AccessibleName = "Signature";
			this.picture_Signature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picture_Signature.Image = ((System.Drawing.Image)(resources.GetObject("picture_Signature.Image")));
			this.picture_Signature.Location = new System.Drawing.Point(77, 138);
			this.picture_Signature.Name = "picture_Signature";
			this.picture_Signature.Size = new System.Drawing.Size(213, 76);
			this.picture_Signature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picture_Signature.TabIndex = 6;
			this.picture_Signature.TabStop = false;
			// 
			// picture_Photo
			// 
			this.picture_Photo.AccessibleName = "Photo";
			this.picture_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picture_Photo.Image = ((System.Drawing.Image)(resources.GetObject("picture_Photo.Image")));
			this.picture_Photo.Location = new System.Drawing.Point(337, 64);
			this.picture_Photo.Name = "picture_Photo";
			this.picture_Photo.Size = new System.Drawing.Size(220, 150);
			this.picture_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picture_Photo.TabIndex = 7;
			this.picture_Photo.TabStop = false;
			// 
			// button_Save
			// 
			this.button_Save.Location = new System.Drawing.Point(416, 19);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(141, 23);
			this.button_Save.TabIndex = 8;
			this.button_Save.Text = "Save";
			this.button_Save.UseVisualStyleBackColor = true;
			// 
			// DataImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 261);
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.picture_Photo);
			this.Controls.Add(this.picture_Signature);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label_name);
			this.Controls.Add(this.label_id);
			this.Controls.Add(this.title);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "DataImage";
			this.Text = "DataImage";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture_Signature)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Photo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label label_id;
		private System.Windows.Forms.Label label_name;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.PictureBox picture_Signature;
		private System.Windows.Forms.PictureBox picture_Photo;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.Button button_Save;
	}
}