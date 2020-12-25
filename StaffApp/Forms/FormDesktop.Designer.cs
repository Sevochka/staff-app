namespace StaffApp.Forms
{
    partial class FormDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesktop));
            this.loadingDataProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // loadingDataProgress
            // 
            this.loadingDataProgress.animated = true;
            this.loadingDataProgress.animationIterval = 5;
            this.loadingDataProgress.animationSpeed = 300;
            this.loadingDataProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.loadingDataProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadingDataProgress.BackgroundImage")));
            this.loadingDataProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.loadingDataProgress.ForeColor = System.Drawing.Color.SeaGreen;
            this.loadingDataProgress.LabelVisible = true;
            this.loadingDataProgress.LineProgressThickness = 8;
            this.loadingDataProgress.LineThickness = 5;
            this.loadingDataProgress.Location = new System.Drawing.Point(245, 70);
            this.loadingDataProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.loadingDataProgress.MaxValue = 100;
            this.loadingDataProgress.Name = "loadingDataProgress";
            this.loadingDataProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.loadingDataProgress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.loadingDataProgress.Size = new System.Drawing.Size(311, 311);
            this.loadingDataProgress.TabIndex = 18;
            this.loadingDataProgress.Value = 0;
            // 
            // FormDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.loadingDataProgress);
            this.Name = "FormDesktop";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar loadingDataProgress;
    }
}