namespace Arka_s_PDOCX_Solutions
{
    partial class frmYesNo
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
            this.lblYesNo = new MaterialSkin.Controls.MaterialLabel();
            this.btnYes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYesNo
            // 
            this.lblYesNo.Depth = 0;
            this.lblYesNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblYesNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYesNo.Location = new System.Drawing.Point(39, 84);
            this.lblYesNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblYesNo.Name = "lblYesNo";
            this.lblYesNo.Size = new System.Drawing.Size(337, 66);
            this.lblYesNo.TabIndex = 0;
            this.lblYesNo.Text = "materialLabel1";
            // 
            // btnYes
            // 
            this.btnYes.Depth = 0;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(210, 184);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Primary = true;
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Depth = 0;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Location = new System.Drawing.Point(301, 184);
            this.btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNo.Name = "btnNo";
            this.btnNo.Primary = true;
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Arka_s_PDOCX_Solutions.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmYesNo
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 249);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblYesNo);
            this.MaximizeBox = false;
            this.Name = "frmYesNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arka\'s PDOCX-Solutions";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblYesNo;
        private MaterialSkin.Controls.MaterialRaisedButton btnYes;
        private MaterialSkin.Controls.MaterialRaisedButton btnNo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}