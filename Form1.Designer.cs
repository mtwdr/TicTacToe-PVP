namespace Lab5
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
            this.label1 = new System.Windows.Forms.Label();
            this.space0_0 = new System.Windows.Forms.Button();
            this.space0_1 = new System.Windows.Forms.Button();
            this.space0_2 = new System.Windows.Forms.Button();
            this.space1_0 = new System.Windows.Forms.Button();
            this.space1_1 = new System.Windows.Forms.Button();
            this.space1_2 = new System.Windows.Forms.Button();
            this.space2_0 = new System.Windows.Forms.Button();
            this.space2_1 = new System.Windows.Forms.Button();
            this.space2_2 = new System.Windows.Forms.Button();
            this.new_game = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIC TAC TOE";
            // 
            // space0_0
            // 
            this.space0_0.Location = new System.Drawing.Point(20, 56);
            this.space0_0.Name = "space0_0";
            this.space0_0.Size = new System.Drawing.Size(51, 50);
            this.space0_0.TabIndex = 1;
            this.space0_0.UseVisualStyleBackColor = true;
            this.space0_0.Click += new System.EventHandler(this.space0_0_Click);
            // 
            // space0_1
            // 
            this.space0_1.Location = new System.Drawing.Point(101, 56);
            this.space0_1.Name = "space0_1";
            this.space0_1.Size = new System.Drawing.Size(51, 50);
            this.space0_1.TabIndex = 2;
            this.space0_1.UseVisualStyleBackColor = true;
            this.space0_1.Click += new System.EventHandler(this.space0_1_Click);
            // 
            // space0_2
            // 
            this.space0_2.Location = new System.Drawing.Point(185, 56);
            this.space0_2.Name = "space0_2";
            this.space0_2.Size = new System.Drawing.Size(51, 50);
            this.space0_2.TabIndex = 3;
            this.space0_2.UseVisualStyleBackColor = true;
            this.space0_2.Click += new System.EventHandler(this.space0_2_Click);
            // 
            // space1_0
            // 
            this.space1_0.Location = new System.Drawing.Point(20, 129);
            this.space1_0.Name = "space1_0";
            this.space1_0.Size = new System.Drawing.Size(51, 50);
            this.space1_0.TabIndex = 4;
            this.space1_0.UseVisualStyleBackColor = true;
            this.space1_0.Click += new System.EventHandler(this.space1_0_Click);
            // 
            // space1_1
            // 
            this.space1_1.Location = new System.Drawing.Point(101, 129);
            this.space1_1.Name = "space1_1";
            this.space1_1.Size = new System.Drawing.Size(51, 50);
            this.space1_1.TabIndex = 5;
            this.space1_1.UseVisualStyleBackColor = true;
            this.space1_1.Click += new System.EventHandler(this.space1_1_Click);
            // 
            // space1_2
            // 
            this.space1_2.Location = new System.Drawing.Point(185, 129);
            this.space1_2.Name = "space1_2";
            this.space1_2.Size = new System.Drawing.Size(51, 50);
            this.space1_2.TabIndex = 6;
            this.space1_2.UseVisualStyleBackColor = true;
            this.space1_2.Click += new System.EventHandler(this.space1_2_Click);
            // 
            // space2_0
            // 
            this.space2_0.Location = new System.Drawing.Point(20, 204);
            this.space2_0.Name = "space2_0";
            this.space2_0.Size = new System.Drawing.Size(51, 50);
            this.space2_0.TabIndex = 7;
            this.space2_0.UseVisualStyleBackColor = true;
            this.space2_0.Click += new System.EventHandler(this.space2_0_Click);
            // 
            // space2_1
            // 
            this.space2_1.Location = new System.Drawing.Point(101, 204);
            this.space2_1.Name = "space2_1";
            this.space2_1.Size = new System.Drawing.Size(51, 50);
            this.space2_1.TabIndex = 8;
            this.space2_1.UseVisualStyleBackColor = true;
            this.space2_1.Click += new System.EventHandler(this.space2_1_Click);
            // 
            // space2_2
            // 
            this.space2_2.Location = new System.Drawing.Point(185, 204);
            this.space2_2.Name = "space2_2";
            this.space2_2.Size = new System.Drawing.Size(51, 50);
            this.space2_2.TabIndex = 9;
            this.space2_2.UseVisualStyleBackColor = true;
            this.space2_2.Click += new System.EventHandler(this.space2_2_Click);
            // 
            // new_game
            // 
            this.new_game.Location = new System.Drawing.Point(20, 316);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(75, 23);
            this.new_game.TabIndex = 10;
            this.new_game.Text = "New Game";
            this.new_game.UseVisualStyleBackColor = true;
            this.new_game.Click += new System.EventHandler(this.new_game_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(174, 316);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.AutoSize = true;
            this.outcomeLabel.Location = new System.Drawing.Point(108, 278);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(0, 13);
            this.outcomeLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 351);
            this.Controls.Add(this.outcomeLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.new_game);
            this.Controls.Add(this.space2_2);
            this.Controls.Add(this.space2_1);
            this.Controls.Add(this.space2_0);
            this.Controls.Add(this.space1_2);
            this.Controls.Add(this.space1_1);
            this.Controls.Add(this.space1_0);
            this.Controls.Add(this.space0_2);
            this.Controls.Add(this.space0_1);
            this.Controls.Add(this.space0_0);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button space0_0;
        private System.Windows.Forms.Button space0_1;
        private System.Windows.Forms.Button space0_2;
        private System.Windows.Forms.Button space1_0;
        private System.Windows.Forms.Button space1_1;
        private System.Windows.Forms.Button space1_2;
        private System.Windows.Forms.Button space2_0;
        private System.Windows.Forms.Button space2_1;
        private System.Windows.Forms.Button space2_2;
        private System.Windows.Forms.Button new_game;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label outcomeLabel;
    }
}

