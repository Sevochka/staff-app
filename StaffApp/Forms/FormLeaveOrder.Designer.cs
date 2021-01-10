namespace StaffApp.Forms
{
    partial class FormLeaveOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLeaveOrder));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpCreate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.laEmployee = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dpFinish = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dpKick = new Bunifu.Framework.UI.BunifuDatepicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.inputReason = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.inputOsn = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tbBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laEmployee);
            this.panel1.Controls.Add(this.dpCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 123);
            this.panel1.TabIndex = 0;
            // 
            // dpCreate
            // 
            this.dpCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dpCreate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpCreate.BorderRadius = 0;
            this.dpCreate.ForeColor = System.Drawing.Color.White;
            this.dpCreate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpCreate.FormatCustom = null;
            this.dpCreate.Location = new System.Drawing.Point(30, 46);
            this.dpCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpCreate.Name = "dpCreate";
            this.dpCreate.Size = new System.Drawing.Size(234, 55);
            this.dpCreate.TabIndex = 0;
            this.dpCreate.Value = new System.DateTime(2021, 1, 10, 16, 0, 24, 309);
            // 
            // laEmployee
            // 
            this.laEmployee.AutoEllipsis = false;
            this.laEmployee.AutoSize = false;
            this.laEmployee.CursorType = null;
            this.laEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.laEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.laEmployee.Location = new System.Drawing.Point(0, 0);
            this.laEmployee.Name = "laEmployee";
            this.laEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laEmployee.Size = new System.Drawing.Size(295, 38);
            this.laEmployee.TabIndex = 3;
            this.laEmployee.Text = "Дата составления";
            this.laEmployee.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.laEmployee.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuLabel1);
            this.panel2.Controls.Add(this.dpFinish);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(304, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 123);
            this.panel2.TabIndex = 1;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(295, 38);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Дата прекращения";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dpFinish
            // 
            this.dpFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dpFinish.BackColor = System.Drawing.Color.SeaGreen;
            this.dpFinish.BorderRadius = 0;
            this.dpFinish.ForeColor = System.Drawing.Color.White;
            this.dpFinish.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpFinish.FormatCustom = null;
            this.dpFinish.Location = new System.Drawing.Point(31, 46);
            this.dpFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpFinish.Name = "dpFinish";
            this.dpFinish.Size = new System.Drawing.Size(234, 55);
            this.dpFinish.TabIndex = 0;
            this.dpFinish.Value = new System.DateTime(2021, 1, 10, 16, 0, 24, 309);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuLabel2);
            this.panel3.Controls.Add(this.dpKick);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(605, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 123);
            this.panel3.TabIndex = 2;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuLabel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(296, 38);
            this.bunifuLabel2.TabIndex = 3;
            this.bunifuLabel2.Text = "Дата увольнения";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dpKick
            // 
            this.dpKick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dpKick.BackColor = System.Drawing.Color.SeaGreen;
            this.dpKick.BorderRadius = 0;
            this.dpKick.ForeColor = System.Drawing.Color.White;
            this.dpKick.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpKick.FormatCustom = null;
            this.dpKick.Location = new System.Drawing.Point(31, 46);
            this.dpKick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpKick.Name = "dpKick";
            this.dpKick.Size = new System.Drawing.Size(235, 55);
            this.dpKick.TabIndex = 0;
            this.dpKick.Value = new System.DateTime(2021, 1, 10, 16, 0, 24, 309);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 129);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(904, 129);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.inputReason);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(904, 166);
            this.panel5.TabIndex = 5;
            // 
            // inputReason
            // 
            this.inputReason.AcceptsReturn = false;
            this.inputReason.AcceptsTab = false;
            this.inputReason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputReason.AnimationSpeed = 200;
            this.inputReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.inputReason.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputReason.BackgroundImage")));
            this.inputReason.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.inputReason.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.inputReason.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputReason.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.inputReason.BorderRadius = 4;
            this.inputReason.BorderThickness = 1;
            this.inputReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputReason.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.inputReason.DefaultText = "";
            this.inputReason.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.inputReason.ForeColor = System.Drawing.Color.Silver;
            this.inputReason.HideSelection = true;
            this.inputReason.IconLeft = null;
            this.inputReason.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputReason.IconPadding = 10;
            this.inputReason.IconRight = null;
            this.inputReason.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputReason.Lines = new string[0];
            this.inputReason.Location = new System.Drawing.Point(83, 24);
            this.inputReason.MaxLength = 32767;
            this.inputReason.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputReason.Modified = false;
            this.inputReason.Multiline = true;
            this.inputReason.Name = "inputReason";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.inputReason.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputReason.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.inputReason.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            stateProperties4.ForeColor = System.Drawing.Color.Silver;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.inputReason.OnIdleState = stateProperties4;
            this.inputReason.PasswordChar = '\0';
            this.inputReason.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputReason.PlaceholderText = "Причина увольнения";
            this.inputReason.ReadOnly = false;
            this.inputReason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputReason.SelectedText = "";
            this.inputReason.SelectionLength = 0;
            this.inputReason.SelectionStart = 0;
            this.inputReason.ShortcutsEnabled = true;
            this.inputReason.Size = new System.Drawing.Size(737, 116);
            this.inputReason.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputReason.TabIndex = 16;
            this.inputReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputReason.TextMarginBottom = 0;
            this.inputReason.TextMarginLeft = 5;
            this.inputReason.TextMarginTop = 0;
            this.inputReason.TextPlaceholder = "Причина увольнения";
            this.inputReason.UseSystemPasswordChar = false;
            this.inputReason.WordWrap = true;
            this.inputReason.TextChange += new System.EventHandler(this.inputReason_TextChange);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.inputOsn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 295);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(904, 164);
            this.panel6.TabIndex = 6;
            // 
            // inputOsn
            // 
            this.inputOsn.AcceptsReturn = false;
            this.inputOsn.AcceptsTab = false;
            this.inputOsn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputOsn.AnimationSpeed = 200;
            this.inputOsn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputOsn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputOsn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.inputOsn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputOsn.BackgroundImage")));
            this.inputOsn.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.inputOsn.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.inputOsn.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputOsn.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.inputOsn.BorderRadius = 4;
            this.inputOsn.BorderThickness = 1;
            this.inputOsn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputOsn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputOsn.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.inputOsn.DefaultText = "";
            this.inputOsn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.inputOsn.ForeColor = System.Drawing.Color.Silver;
            this.inputOsn.HideSelection = true;
            this.inputOsn.IconLeft = null;
            this.inputOsn.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputOsn.IconPadding = 10;
            this.inputOsn.IconRight = null;
            this.inputOsn.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.inputOsn.Lines = new string[0];
            this.inputOsn.Location = new System.Drawing.Point(83, 16);
            this.inputOsn.MaxLength = 32767;
            this.inputOsn.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputOsn.Modified = false;
            this.inputOsn.Multiline = true;
            this.inputOsn.Name = "inputOsn";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.inputOsn.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputOsn.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.inputOsn.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            stateProperties8.ForeColor = System.Drawing.Color.Silver;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.inputOsn.OnIdleState = stateProperties8;
            this.inputOsn.PasswordChar = '\0';
            this.inputOsn.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputOsn.PlaceholderText = "Основания";
            this.inputOsn.ReadOnly = false;
            this.inputOsn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputOsn.SelectedText = "";
            this.inputOsn.SelectionLength = 0;
            this.inputOsn.SelectionStart = 0;
            this.inputOsn.ShortcutsEnabled = true;
            this.inputOsn.Size = new System.Drawing.Size(737, 114);
            this.inputOsn.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputOsn.TabIndex = 16;
            this.inputOsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputOsn.TextMarginBottom = 0;
            this.inputOsn.TextMarginLeft = 5;
            this.inputOsn.TextMarginTop = 0;
            this.inputOsn.TextPlaceholder = "Основания";
            this.inputOsn.UseSystemPasswordChar = false;
            this.inputOsn.WordWrap = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbBottom);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 455);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(904, 58);
            this.panel7.TabIndex = 7;
            // 
            // tbBottom
            // 
            this.tbBottom.ColumnCount = 2;
            this.tbBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBottom.Controls.Add(this.btnCancel, 1, 0);
            this.tbBottom.Controls.Add(this.btnSave, 0, 0);
            this.tbBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBottom.Location = new System.Drawing.Point(0, 0);
            this.tbBottom.Name = "tbBottom";
            this.tbBottom.RowCount = 1;
            this.tbBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBottom.Size = new System.Drawing.Size(904, 58);
            this.tbBottom.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(9)))), ((int)(((byte)(76)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.ButtonText = "Отменить";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(9)))), ((int)(((byte)(76)))));
            this.btnCancel.IdleBorderRadius = 3;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(9)))), ((int)(((byte)(76)))));
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(455, 3);
            this.btnCancel.Name = "btnCancel";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(145)))));
            stateProperties9.BorderRadius = 3;
            stateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties9.BorderThickness = 1;
            stateProperties9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(145)))));
            stateProperties9.ForeColor = System.Drawing.Color.White;
            stateProperties9.IconLeftImage = null;
            stateProperties9.IconRightImage = null;
            this.btnCancel.onHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            stateProperties10.BorderRadius = 3;
            stateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties10.BorderThickness = 1;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            stateProperties10.ForeColor = System.Drawing.Color.White;
            stateProperties10.IconLeftImage = null;
            stateProperties10.IconRightImage = null;
            this.btnCancel.OnPressedState = stateProperties10;
            this.btnCancel.Size = new System.Drawing.Size(446, 52);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // btnSave
            // 
            this.btnSave.AllowToggling = false;
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.ButtonText = "Провести и уволить";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges2;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Enabled = false;
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.IdleBorderRadius = 3;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.BorderRadius = 3;
            stateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties11.BorderThickness = 1;
            stateProperties11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.ForeColor = System.Drawing.Color.White;
            stateProperties11.IconLeftImage = null;
            stateProperties11.IconRightImage = null;
            this.btnSave.onHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties12.BorderRadius = 3;
            stateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties12.BorderThickness = 1;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.IconLeftImage = null;
            stateProperties12.IconRightImage = null;
            this.btnSave.OnPressedState = stateProperties12;
            this.btnSave.Size = new System.Drawing.Size(446, 52);
            this.btnSave.TabIndex = 1;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormLeaveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(904, 513);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "FormLeaveOrder";
            this.Text = "Увольнение";
            this.Load += new System.EventHandler(this.FormLeaveOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tbBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker dpCreate;
        private Bunifu.UI.WinForms.BunifuLabel laEmployee;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker dpFinish;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker dpKick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox inputReason;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox inputOsn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tbBottom;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
    }
}