
namespace CleanCodeDemo.Gui.UsersControl
{
    partial class HomePageUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageUserControl));
            this.panelContainerLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelFiratName = new System.Windows.Forms.Label();
            this.panelContainerLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainerLogo
            // 
            this.panelContainerLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainerLogo.Controls.Add(this.labelCompanyName);
            this.panelContainerLogo.Controls.Add(this.pictureBoxLogo);
            this.panelContainerLogo.Location = new System.Drawing.Point(331, 149);
            this.panelContainerLogo.Name = "panelContainerLogo";
            this.panelContainerLogo.Size = new System.Drawing.Size(401, 264);
            this.panelContainerLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(103, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(201, 158);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.Location = new System.Drawing.Point(112, 208);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(192, 46);
            this.labelCompanyName.TabIndex = 1;
            this.labelCompanyName.Text = "اسم المؤسسة";
            // 
            // labelDateTime
            // 
            this.labelDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(3, 507);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(185, 46);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "11:30 am";
            // 
            // labelFiratName
            // 
            this.labelFiratName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFiratName.AutoSize = true;
            this.labelFiratName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiratName.Location = new System.Drawing.Point(874, 507);
            this.labelFiratName.Name = "labelFiratName";
            this.labelFiratName.Size = new System.Drawing.Size(178, 46);
            this.labelFiratName.TabIndex = 1;
            this.labelFiratName.Text = "مرحبا صفاء";
            // 
            // HomePageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelFiratName);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.panelContainerLogo);
            this.Name = "HomePageUserControl";
            this.Size = new System.Drawing.Size(1062, 562);
            this.panelContainerLogo.ResumeLayout(false);
            this.panelContainerLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainerLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelFiratName;
    }
}
