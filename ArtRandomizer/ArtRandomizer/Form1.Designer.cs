namespace ArtRandomizer
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.titlelbl = new System.Windows.Forms.Label();
            this.moodCombo = new System.Windows.Forms.ComboBox();
            this.colourCombo = new System.Windows.Forms.ComboBox();
            this.moodlbl = new System.Windows.Forms.Label();
            this.colourlbl = new System.Windows.Forms.Label();
            this.randomizeBtn = new System.Windows.Forms.Button();
            this.colourPalette = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(27, 43);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(458, 71);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "Art Randomizer";
            // 
            // moodCombo
            // 
            this.moodCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moodCombo.FormattingEnabled = true;
            this.moodCombo.Location = new System.Drawing.Point(39, 204);
            this.moodCombo.Name = "moodCombo";
            this.moodCombo.Size = new System.Drawing.Size(375, 37);
            this.moodCombo.TabIndex = 1;
            // 
            // colourCombo
            // 
            this.colourCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourCombo.FormattingEnabled = true;
            this.colourCombo.Location = new System.Drawing.Point(460, 204);
            this.colourCombo.Name = "colourCombo";
            this.colourCombo.Size = new System.Drawing.Size(375, 37);
            this.colourCombo.TabIndex = 1;
            this.colourCombo.SelectedValueChanged += new System.EventHandler(this.colourCombo_SelectedValueChanged);
            // 
            // moodlbl
            // 
            this.moodlbl.AutoSize = true;
            this.moodlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moodlbl.Location = new System.Drawing.Point(34, 165);
            this.moodlbl.Name = "moodlbl";
            this.moodlbl.Size = new System.Drawing.Size(75, 29);
            this.moodlbl.TabIndex = 0;
            this.moodlbl.Text = "Mood";
            // 
            // colourlbl
            // 
            this.colourlbl.AutoSize = true;
            this.colourlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourlbl.Location = new System.Drawing.Point(455, 165);
            this.colourlbl.Name = "colourlbl";
            this.colourlbl.Size = new System.Drawing.Size(85, 29);
            this.colourlbl.TabIndex = 0;
            this.colourlbl.Text = "Colour";
            // 
            // randomizeBtn
            // 
            this.randomizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizeBtn.Location = new System.Drawing.Point(716, 279);
            this.randomizeBtn.Name = "randomizeBtn";
            this.randomizeBtn.Size = new System.Drawing.Size(296, 98);
            this.randomizeBtn.TabIndex = 2;
            this.randomizeBtn.Text = "Randomize";
            this.randomizeBtn.UseVisualStyleBackColor = true;
            this.randomizeBtn.Click += new System.EventHandler(this.randomizeBtn_Click);
            // 
            // colourPalette
            // 
            this.colourPalette.Location = new System.Drawing.Point(39, 277);
            this.colourPalette.Name = "colourPalette";
            this.colourPalette.Size = new System.Drawing.Size(375, 100);
            this.colourPalette.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 418);
            this.Controls.Add(this.colourPalette);
            this.Controls.Add(this.randomizeBtn);
            this.Controls.Add(this.colourCombo);
            this.Controls.Add(this.moodCombo);
            this.Controls.Add(this.moodlbl);
            this.Controls.Add(this.colourlbl);
            this.Controls.Add(this.titlelbl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Random";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.ComboBox moodCombo;
        private System.Windows.Forms.ComboBox colourCombo;
        private System.Windows.Forms.Label moodlbl;
        private System.Windows.Forms.Label colourlbl;
        private System.Windows.Forms.Button randomizeBtn;
        private System.Windows.Forms.Panel colourPalette;
    }
}

