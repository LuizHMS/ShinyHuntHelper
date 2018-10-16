namespace ShinyHuntHelper
{
    partial class frmPopup
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
            this.clrBackground = new System.Windows.Forms.ColorDialog();
            this.pcbPopUp = new System.Windows.Forms.PictureBox();
            this.btnColorDialog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPopUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPopUp
            // 
            this.pcbPopUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbPopUp.Location = new System.Drawing.Point(12, 12);
            this.pcbPopUp.Name = "pcbPopUp";
            this.pcbPopUp.Size = new System.Drawing.Size(240, 240);
            this.pcbPopUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPopUp.TabIndex = 0;
            this.pcbPopUp.TabStop = false;
            //this.pcbPopUp.Click += new System.EventHandler(this.pcbPopUp_Click);
            this.pcbPopUp.DoubleClick += new System.EventHandler(this.pcbPopUp_DoubleClick);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnColorDialog.Location = new System.Drawing.Point(92, 265);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(75, 23);
            this.btnColorDialog.TabIndex = 1;
            this.btnColorDialog.Text = "Background";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // frmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 300);
            this.Controls.Add(this.btnColorDialog);
            this.Controls.Add(this.pcbPopUp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(284, 338);
            this.Name = "frmPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pokémon";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPopUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog clrBackground;
        private System.Windows.Forms.PictureBox pcbPopUp;
        private System.Windows.Forms.Button btnColorDialog;
    }
}