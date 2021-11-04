
namespace Week_7_Activity_15
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
            this.firstInitial = new System.Windows.Forms.ComboBox();
            this.lastInititial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mediaBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.LuckyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstInitial
            // 
            this.firstInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstInitial.FormattingEnabled = true;
            this.firstInitial.Location = new System.Drawing.Point(209, 29);
            this.firstInitial.Name = "firstInitial";
            this.firstInitial.Size = new System.Drawing.Size(86, 24);
            this.firstInitial.TabIndex = 0;
            // 
            // lastInititial
            // 
            this.lastInititial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastInititial.FormattingEnabled = true;
            this.lastInititial.Location = new System.Drawing.Point(209, 65);
            this.lastInititial.Name = "lastInititial";
            this.lastInititial.Size = new System.Drawing.Size(86, 24);
            this.lastInititial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select first initial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select last initial:";
            // 
            // mediaBox
            // 
            this.mediaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaBox.FormattingEnabled = true;
            this.mediaBox.Items.AddRange(new object[] {
            "Movies",
            "Books",
            "Games",
            "Music"});
            this.mediaBox.Location = new System.Drawing.Point(209, 105);
            this.mediaBox.Name = "mediaBox";
            this.mediaBox.Size = new System.Drawing.Size(86, 24);
            this.mediaBox.TabIndex = 4;
            this.mediaBox.SelectedIndexChanged += new System.EventHandler(this.mediaBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Which do you prefer?:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Favorite genre:";
            // 
            // genreBox
            // 
            this.genreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(209, 143);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(86, 24);
            this.genreBox.TabIndex = 4;
            // 
            // LuckyButton
            // 
            this.LuckyButton.BackColor = System.Drawing.Color.Silver;
            this.LuckyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuckyButton.Location = new System.Drawing.Point(109, 202);
            this.LuckyButton.Name = "LuckyButton";
            this.LuckyButton.Size = new System.Drawing.Size(130, 57);
            this.LuckyButton.TabIndex = 6;
            this.LuckyButton.Text = "Get Lucky!";
            this.LuckyButton.UseVisualStyleBackColor = false;
            this.LuckyButton.Click += new System.EventHandler(this.LuckyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(337, 304);
            this.Controls.Add(this.LuckyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.mediaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastInititial);
            this.Controls.Add(this.firstInitial);
            this.Name = "Form1";
            this.Text = "What\'s My Lucky Number?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox firstInitial;
        private System.Windows.Forms.ComboBox lastInititial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mediaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.Button LuckyButton;
    }
}

