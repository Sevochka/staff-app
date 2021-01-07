namespace StaffApp.Forms
{
    partial class FormPosition
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosition));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridDepartments = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panelDepartment = new System.Windows.Forms.Panel();
            this.btnAddDepartment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.laDepartment = new Bunifu.UI.WinForms.BunifuLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPositions = new System.Windows.Forms.Panel();
            this.btnAddPosition = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dataGridPositions = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartments)).BeginInit();
            this.panelDepartment.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridDepartments, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panelDepartment, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 219);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // dataGridDepartments
            // 
            this.dataGridDepartments.AllowCustomTheming = false;
            this.dataGridDepartments.AllowUserToAddRows = false;
            this.dataGridDepartments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridDepartments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDepartments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridDepartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDepartments.ColumnHeadersHeight = 40;
            this.dataGridDepartments.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridDepartments.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridDepartments.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridDepartments.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridDepartments.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridDepartments.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridDepartments.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridDepartments.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridDepartments.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridDepartments.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridDepartments.CurrentTheme.Name = null;
            this.dataGridDepartments.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridDepartments.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridDepartments.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridDepartments.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridDepartments.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDepartments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDepartments.EnableHeadersVisualStyles = false;
            this.dataGridDepartments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridDepartments.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridDepartments.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridDepartments.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridDepartments.Location = new System.Drawing.Point(3, 46);
            this.dataGridDepartments.MultiSelect = false;
            this.dataGridDepartments.Name = "dataGridDepartments";
            this.dataGridDepartments.ReadOnly = true;
            this.dataGridDepartments.RowHeadersVisible = false;
            this.dataGridDepartments.RowHeadersWidth = 62;
            this.dataGridDepartments.RowTemplate.Height = 40;
            this.dataGridDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDepartments.Size = new System.Drawing.Size(788, 170);
            this.dataGridDepartments.TabIndex = 2;
            this.dataGridDepartments.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDepartments_CellClick);
            this.dataGridDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDepartments_CellContentClick);
            this.dataGridDepartments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDepartments_CellDoubleClick);
            // 
            // panelDepartment
            // 
            this.panelDepartment.Controls.Add(this.btnAddDepartment);
            this.panelDepartment.Controls.Add(this.laDepartment);
            this.panelDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDepartment.Location = new System.Drawing.Point(3, 3);
            this.panelDepartment.Name = "panelDepartment";
            this.panelDepartment.Size = new System.Drawing.Size(788, 37);
            this.panelDepartment.TabIndex = 0;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.AllowToggling = false;
            this.btnAddDepartment.AnimationSpeed = 200;
            this.btnAddDepartment.AutoGenerateColors = false;
            this.btnAddDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDepartment.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAddDepartment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDepartment.BackgroundImage")));
            this.btnAddDepartment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddDepartment.ButtonText = "Добавить отдел";
            this.btnAddDepartment.ButtonTextMarginLeft = 0;
            this.btnAddDepartment.ColorContrastOnClick = 45;
            this.btnAddDepartment.ColorContrastOnHover = 45;
            this.btnAddDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddDepartment.CustomizableEdges = borderEdges1;
            this.btnAddDepartment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDepartment.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddDepartment.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddDepartment.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddDepartment.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddDepartment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartment.IconMarginLeft = 11;
            this.btnAddDepartment.IconPadding = 10;
            this.btnAddDepartment.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartment.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDepartment.IdleBorderRadius = 3;
            this.btnAddDepartment.IdleBorderThickness = 1;
            this.btnAddDepartment.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDepartment.IdleIconLeftImage = null;
            this.btnAddDepartment.IdleIconRightImage = null;
            this.btnAddDepartment.IndicateFocus = false;
            this.btnAddDepartment.Location = new System.Drawing.Point(539, 0);
            this.btnAddDepartment.Name = "btnAddDepartment";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAddDepartment.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnAddDepartment.OnPressedState = stateProperties2;
            this.btnAddDepartment.Size = new System.Drawing.Size(249, 37);
            this.btnAddDepartment.TabIndex = 4;
            this.btnAddDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddDepartment.TextMarginLeft = 0;
            this.btnAddDepartment.UseDefaultRadiusAndThickness = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // laDepartment
            // 
            this.laDepartment.AutoEllipsis = false;
            this.laDepartment.CursorType = null;
            this.laDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laDepartment.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.laDepartment.ForeColor = System.Drawing.Color.Gainsboro;
            this.laDepartment.Location = new System.Drawing.Point(0, 0);
            this.laDepartment.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.laDepartment.Name = "laDepartment";
            this.laDepartment.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.laDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laDepartment.Size = new System.Drawing.Size(788, 37);
            this.laDepartment.TabIndex = 3;
            this.laDepartment.Text = "Отделы";
            this.laDepartment.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.laDepartment.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panelPositions, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridPositions, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 228);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 219);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // panelPositions
            // 
            this.panelPositions.Controls.Add(this.btnAddPosition);
            this.panelPositions.Controls.Add(this.bunifuLabel1);
            this.panelPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPositions.Location = new System.Drawing.Point(3, 3);
            this.panelPositions.Name = "panelPositions";
            this.panelPositions.Size = new System.Drawing.Size(788, 37);
            this.panelPositions.TabIndex = 0;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.AllowToggling = false;
            this.btnAddPosition.AnimationSpeed = 200;
            this.btnAddPosition.AutoGenerateColors = false;
            this.btnAddPosition.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPosition.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnAddPosition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPosition.BackgroundImage")));
            this.btnAddPosition.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPosition.ButtonText = "Добавить должность";
            this.btnAddPosition.ButtonTextMarginLeft = 0;
            this.btnAddPosition.ColorContrastOnClick = 45;
            this.btnAddPosition.ColorContrastOnHover = 45;
            this.btnAddPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddPosition.CustomizableEdges = borderEdges2;
            this.btnAddPosition.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPosition.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddPosition.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddPosition.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddPosition.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddPosition.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAddPosition.ForeColor = System.Drawing.Color.White;
            this.btnAddPosition.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPosition.IconMarginLeft = 11;
            this.btnAddPosition.IconPadding = 10;
            this.btnAddPosition.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPosition.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPosition.IdleBorderRadius = 3;
            this.btnAddPosition.IdleBorderThickness = 1;
            this.btnAddPosition.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPosition.IdleIconLeftImage = null;
            this.btnAddPosition.IdleIconRightImage = null;
            this.btnAddPosition.IndicateFocus = false;
            this.btnAddPosition.Location = new System.Drawing.Point(539, 0);
            this.btnAddPosition.Name = "btnAddPosition";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnAddPosition.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnAddPosition.OnPressedState = stateProperties4;
            this.btnAddPosition.Size = new System.Drawing.Size(249, 37);
            this.btnAddPosition.TabIndex = 5;
            this.btnAddPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPosition.TextMarginLeft = 0;
            this.btnAddPosition.UseDefaultRadiusAndThickness = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(788, 37);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Должности";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dataGridPositions
            // 
            this.dataGridPositions.AllowCustomTheming = false;
            this.dataGridPositions.AllowUserToAddRows = false;
            this.dataGridPositions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridPositions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPositions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPositions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridPositions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridPositions.ColumnHeadersHeight = 40;
            this.dataGridPositions.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridPositions.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridPositions.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridPositions.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridPositions.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridPositions.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridPositions.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridPositions.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridPositions.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridPositions.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridPositions.CurrentTheme.Name = null;
            this.dataGridPositions.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridPositions.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridPositions.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridPositions.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridPositions.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPositions.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPositions.EnableHeadersVisualStyles = false;
            this.dataGridPositions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridPositions.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridPositions.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridPositions.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridPositions.Location = new System.Drawing.Point(3, 46);
            this.dataGridPositions.Name = "dataGridPositions";
            this.dataGridPositions.ReadOnly = true;
            this.dataGridPositions.RowHeadersVisible = false;
            this.dataGridPositions.RowHeadersWidth = 62;
            this.dataGridPositions.RowTemplate.Height = 40;
            this.dataGridPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPositions.Size = new System.Drawing.Size(788, 170);
            this.dataGridPositions.TabIndex = 1;
            this.dataGridPositions.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridPositions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPositions_CellContentClick);
            // 
            // FormPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPosition";
            this.Text = "Должности";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartments)).EndInit();
            this.panelDepartment.ResumeLayout(false);
            this.panelDepartment.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelPositions.ResumeLayout(false);
            this.panelPositions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPositions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuLabel laDepartment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridDepartments;
        private System.Windows.Forms.Panel panelDepartment;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddDepartment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelPositions;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridPositions;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddPosition;
    }
}