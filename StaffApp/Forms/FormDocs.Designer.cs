namespace StaffApp.Forms
{
    partial class FormDocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocs));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btnReportAllEmployees = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.laEmployee = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // btnReportAllEmployees
            // 
            this.btnReportAllEmployees.AllowToggling = false;
            this.btnReportAllEmployees.AnimationSpeed = 200;
            this.btnReportAllEmployees.AutoGenerateColors = false;
            this.btnReportAllEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnReportAllEmployees.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnReportAllEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportAllEmployees.BackgroundImage")));
            this.btnReportAllEmployees.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReportAllEmployees.ButtonText = "Отчет о всех сотрудниках предприятия";
            this.btnReportAllEmployees.ButtonTextMarginLeft = 0;
            this.btnReportAllEmployees.ColorContrastOnClick = 45;
            this.btnReportAllEmployees.ColorContrastOnHover = 45;
            this.btnReportAllEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnReportAllEmployees.CustomizableEdges = borderEdges1;
            this.btnReportAllEmployees.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReportAllEmployees.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnReportAllEmployees.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReportAllEmployees.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReportAllEmployees.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReportAllEmployees.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnReportAllEmployees.ForeColor = System.Drawing.Color.White;
            this.btnReportAllEmployees.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportAllEmployees.IconMarginLeft = 11;
            this.btnReportAllEmployees.IconPadding = 10;
            this.btnReportAllEmployees.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportAllEmployees.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReportAllEmployees.IdleBorderRadius = 3;
            this.btnReportAllEmployees.IdleBorderThickness = 1;
            this.btnReportAllEmployees.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnReportAllEmployees.IdleIconLeftImage = null;
            this.btnReportAllEmployees.IdleIconRightImage = null;
            this.btnReportAllEmployees.IndicateFocus = false;
            this.btnReportAllEmployees.Location = new System.Drawing.Point(138, 110);
            this.btnReportAllEmployees.Name = "btnReportAllEmployees";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnReportAllEmployees.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnReportAllEmployees.OnPressedState = stateProperties2;
            this.btnReportAllEmployees.Size = new System.Drawing.Size(506, 44);
            this.btnReportAllEmployees.TabIndex = 14;
            this.btnReportAllEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReportAllEmployees.TextMarginLeft = 0;
            this.btnReportAllEmployees.UseDefaultRadiusAndThickness = true;
            this.btnReportAllEmployees.Click += new System.EventHandler(this.btnReportAllEmployees_Click);
            // 
            // laEmployee
            // 
            this.laEmployee.AutoEllipsis = false;
            this.laEmployee.CursorType = null;
            this.laEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.laEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.laEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.laEmployee.Location = new System.Drawing.Point(0, 0);
            this.laEmployee.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.laEmployee.Name = "laEmployee";
            this.laEmployee.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.laEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laEmployee.Size = new System.Drawing.Size(800, 56);
            this.laEmployee.TabIndex = 15;
            this.laEmployee.Text = "Какой документ вы хотите создать?";
            this.laEmployee.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.laEmployee.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FormDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laEmployee);
            this.Controls.Add(this.btnReportAllEmployees);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormDocs";
            this.Text = "Документы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReportAllEmployees;
        private Bunifu.UI.WinForms.BunifuLabel laEmployee;
    }
}