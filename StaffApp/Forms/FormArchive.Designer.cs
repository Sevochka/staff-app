namespace StaffApp.Forms
{
    partial class FormArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArchive));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dataGridEmployees = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnArchivePositionsDepartments = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel4.AutoEllipsis = true;
            this.bunifuLabel4.AutoSize = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel4.Location = new System.Drawing.Point(2, 12);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(971, 74);
            this.bunifuLabel4.TabIndex = 21;
            this.bunifuLabel4.Text = "Архивные сотрудники";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.AllowCustomTheming = false;
            this.dataGridEmployees.AllowUserToAddRows = false;
            this.dataGridEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEmployees.ColumnHeadersHeight = 40;
            this.dataGridEmployees.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridEmployees.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridEmployees.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridEmployees.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridEmployees.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridEmployees.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridEmployees.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridEmployees.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridEmployees.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridEmployees.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridEmployees.CurrentTheme.Name = null;
            this.dataGridEmployees.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridEmployees.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridEmployees.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridEmployees.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridEmployees.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEmployees.EnableHeadersVisualStyles = false;
            this.dataGridEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridEmployees.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridEmployees.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridEmployees.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridEmployees.Location = new System.Drawing.Point(12, 92);
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.ReadOnly = true;
            this.dataGridEmployees.RowHeadersVisible = false;
            this.dataGridEmployees.RowHeadersWidth = 62;
            this.dataGridEmployees.RowTemplate.Height = 40;
            this.dataGridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmployees.Size = new System.Drawing.Size(952, 337);
            this.dataGridEmployees.TabIndex = 22;
            this.dataGridEmployees.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployees_CellDoubleClick);
            // 
            // btnArchivePositionsDepartments
            // 
            this.btnArchivePositionsDepartments.AllowToggling = false;
            this.btnArchivePositionsDepartments.AnimationSpeed = 200;
            this.btnArchivePositionsDepartments.AutoGenerateColors = false;
            this.btnArchivePositionsDepartments.BackColor = System.Drawing.Color.Transparent;
            this.btnArchivePositionsDepartments.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnArchivePositionsDepartments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArchivePositionsDepartments.BackgroundImage")));
            this.btnArchivePositionsDepartments.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnArchivePositionsDepartments.ButtonText = "Архивные отделы и должности";
            this.btnArchivePositionsDepartments.ButtonTextMarginLeft = 0;
            this.btnArchivePositionsDepartments.ColorContrastOnClick = 45;
            this.btnArchivePositionsDepartments.ColorContrastOnHover = 45;
            this.btnArchivePositionsDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnArchivePositionsDepartments.CustomizableEdges = borderEdges1;
            this.btnArchivePositionsDepartments.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnArchivePositionsDepartments.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnArchivePositionsDepartments.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnArchivePositionsDepartments.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnArchivePositionsDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArchivePositionsDepartments.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnArchivePositionsDepartments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnArchivePositionsDepartments.ForeColor = System.Drawing.Color.White;
            this.btnArchivePositionsDepartments.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchivePositionsDepartments.IconMarginLeft = 11;
            this.btnArchivePositionsDepartments.IconPadding = 10;
            this.btnArchivePositionsDepartments.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchivePositionsDepartments.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnArchivePositionsDepartments.IdleBorderRadius = 3;
            this.btnArchivePositionsDepartments.IdleBorderThickness = 1;
            this.btnArchivePositionsDepartments.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnArchivePositionsDepartments.IdleIconLeftImage = null;
            this.btnArchivePositionsDepartments.IdleIconRightImage = null;
            this.btnArchivePositionsDepartments.IndicateFocus = false;
            this.btnArchivePositionsDepartments.Location = new System.Drawing.Point(40, 3);
            this.btnArchivePositionsDepartments.Margin = new System.Windows.Forms.Padding(20);
            this.btnArchivePositionsDepartments.Name = "btnArchivePositionsDepartments";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnArchivePositionsDepartments.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnArchivePositionsDepartments.OnPressedState = stateProperties2;
            this.btnArchivePositionsDepartments.Size = new System.Drawing.Size(896, 52);
            this.btnArchivePositionsDepartments.TabIndex = 23;
            this.btnArchivePositionsDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnArchivePositionsDepartments.TextMarginLeft = 0;
            this.btnArchivePositionsDepartments.UseDefaultRadiusAndThickness = true;
            this.btnArchivePositionsDepartments.Click += new System.EventHandler(this.btnArchivePositionsDepartments_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnArchivePositionsDepartments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.panel1.Size = new System.Drawing.Size(976, 58);
            this.panel1.TabIndex = 24;
            // 
            // FormArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(976, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridEmployees);
            this.Controls.Add(this.bunifuLabel4);
            this.Name = "FormArchive";
            this.Text = "Архив данных";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridEmployees;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnArchivePositionsDepartments;
        private System.Windows.Forms.Panel panel1;
    }
}