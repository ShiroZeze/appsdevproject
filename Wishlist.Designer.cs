namespace WindowsFormsApplication2
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
            this.wishList2 = new System.Windows.Forms.ListBox();
            this.wishlistTitle1 = new System.Windows.Forms.Label();
            this.countButton1 = new System.Windows.Forms.Button();
            this.fillButtonBox = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectionOutputBox = new System.Windows.Forms.TextBox();
            this.countOutputBox = new System.Windows.Forms.TextBox();
            this.sortButtonBox = new System.Windows.Forms.Button();
            this.closeButtonBox = new System.Windows.Forms.Button();
            this.countText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wishList2
            // 
            this.wishList2.FormattingEnabled = true;
            this.wishList2.Location = new System.Drawing.Point(11, 32);
            this.wishList2.Name = "wishList2";
            this.wishList2.Size = new System.Drawing.Size(202, 160);
            this.wishList2.TabIndex = 0;
            this.wishList2.SelectedIndexChanged += new System.EventHandler(this.wishList2_SelectedIndexChanged);
            // 
            // wishlistTitle1
            // 
            this.wishlistTitle1.AutoSize = true;
            this.wishlistTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wishlistTitle1.Location = new System.Drawing.Point(12, 9);
            this.wishlistTitle1.Name = "wishlistTitle1";
            this.wishlistTitle1.Size = new System.Drawing.Size(99, 20);
            this.wishlistTitle1.TabIndex = 1;
            this.wishlistTitle1.Text = "WISH LIST";
            this.wishlistTitle1.Click += new System.EventHandler(this.label1_Click);
            // 
            // countButton1
            // 
            this.countButton1.Location = new System.Drawing.Point(235, 119);
            this.countButton1.Name = "countButton1";
            this.countButton1.Size = new System.Drawing.Size(75, 23);
            this.countButton1.TabIndex = 2;
            this.countButton1.Text = "Count";
            this.countButton1.UseVisualStyleBackColor = true;
            this.countButton1.Click += new System.EventHandler(this.countButton1_Click);
            // 
            // fillButtonBox
            // 
            this.fillButtonBox.Location = new System.Drawing.Point(235, 32);
            this.fillButtonBox.Name = "fillButtonBox";
            this.fillButtonBox.Size = new System.Drawing.Size(75, 23);
            this.fillButtonBox.TabIndex = 3;
            this.fillButtonBox.Text = "Fill";
            this.fillButtonBox.UseVisualStyleBackColor = true;
            this.fillButtonBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(235, 90);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selection";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // selectionOutputBox
            // 
            this.selectionOutputBox.Location = new System.Drawing.Point(102, 205);
            this.selectionOutputBox.Name = "selectionOutputBox";
            this.selectionOutputBox.Size = new System.Drawing.Size(100, 20);
            this.selectionOutputBox.TabIndex = 7;
            this.selectionOutputBox.TextChanged += new System.EventHandler(this.selectionOutputBox_TextChanged);
            // 
            // countOutputBox
            // 
            this.countOutputBox.Location = new System.Drawing.Point(102, 247);
            this.countOutputBox.Name = "countOutputBox";
            this.countOutputBox.Size = new System.Drawing.Size(100, 20);
            this.countOutputBox.TabIndex = 8;
            // 
            // sortButtonBox
            // 
            this.sortButtonBox.Location = new System.Drawing.Point(235, 61);
            this.sortButtonBox.Name = "sortButtonBox";
            this.sortButtonBox.Size = new System.Drawing.Size(75, 23);
            this.sortButtonBox.TabIndex = 9;
            this.sortButtonBox.Text = "Sort";
            this.sortButtonBox.UseVisualStyleBackColor = true;
            this.sortButtonBox.Click += new System.EventHandler(this.sortButtonBox_Click);
            // 
            // closeButtonBox
            // 
            this.closeButtonBox.Location = new System.Drawing.Point(235, 148);
            this.closeButtonBox.Name = "closeButtonBox";
            this.closeButtonBox.Size = new System.Drawing.Size(75, 23);
            this.closeButtonBox.TabIndex = 10;
            this.closeButtonBox.Text = "Close";
            this.closeButtonBox.UseVisualStyleBackColor = true;
            this.closeButtonBox.Click += new System.EventHandler(this.closeButtonBox_Click);
            // 
            // countText
            // 
            this.countText.AutoSize = true;
            this.countText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countText.Location = new System.Drawing.Point(13, 249);
            this.countText.Name = "countText";
            this.countText.Size = new System.Drawing.Size(48, 18);
            this.countText.TabIndex = 11;
            this.countText.Text = "Count";
            this.countText.Click += new System.EventHandler(this.countText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 310);
            this.Controls.Add(this.countText);
            this.Controls.Add(this.closeButtonBox);
            this.Controls.Add(this.sortButtonBox);
            this.Controls.Add(this.countOutputBox);
            this.Controls.Add(this.selectionOutputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fillButtonBox);
            this.Controls.Add(this.countButton1);
            this.Controls.Add(this.wishlistTitle1);
            this.Controls.Add(this.wishList2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wishList2;
        private System.Windows.Forms.Label wishlistTitle1;
        private System.Windows.Forms.Button countButton1;
        private System.Windows.Forms.Button fillButtonBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectionOutputBox;
        private System.Windows.Forms.TextBox countOutputBox;
        private System.Windows.Forms.Button sortButtonBox;
        private System.Windows.Forms.Button closeButtonBox;
        private System.Windows.Forms.Label countText;
    }
}

