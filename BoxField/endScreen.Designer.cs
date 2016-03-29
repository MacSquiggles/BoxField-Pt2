namespace BoxField
{
    partial class endScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.endLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Magneto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(380, 194);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(629, 117);
            this.endLabel.TabIndex = 0;
            this.endLabel.Text = "Game Over";
            // 
            // endScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Controls.Add(this.endLabel);
            this.Name = "endScreen";
            this.Size = new System.Drawing.Size(1350, 769);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endLabel;
    }
}
