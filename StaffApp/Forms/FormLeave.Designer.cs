namespace StaffApp.Forms
{
    partial class FormLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLeave));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.dpLeave = new Bunifu.Framework.UI.BunifuDatepicker();
            this.laEmployee = new Bunifu.UI.WinForms.BunifuLabel();
            this.tbBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.inputReason = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tbBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpLeave
            // 
            this.dpLeave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dpLeave.BackColor = System.Drawing.Color.SeaGreen;
            this.dpLeave.BorderRadius = 0;
            this.dpLeave.ForeColor = System.Drawing.Color.White;
            this.dpLeave.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpLeave.FormatCustom = null;
            this.dpLeave.Location = new System.Drawing.Point(173, 95);
            this.dpLeave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpLeave.Name = "dpLeave";
            this.dpLeave.Size = new System.Drawing.Size(454, 55);
            this.dpLeave.TabIndex = 0;
            this.dpLeave.Value = new System.DateTime(2021, 1, 10, 13, 58, 47, 789);
            // 
            // laEmployee
            // 
            this.laEmployee.AutoEllipsis = false;
            this.laEmployee.AutoSize = false;
            this.laEmployee.CursorType = null;
            this.laEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.laEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.laEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.laEmployee.Location = new System.Drawing.Point(0, 0);
            this.laEmployee.Name = "laEmployee";
            this.laEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laEmployee.Size = new System.Drawing.Size(800, 58);
            this.laEmployee.TabIndex = 3;
            this.laEmployee.Text = "Введите желаемую дату увольнения";
            this.laEmployee.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.laEmployee.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tbBottom
            // 
            this.tbBottom.ColumnCount = 2;
            this.tbBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBottom.Controls.Add(this.btnCancel, 1, 0);
            this.tbBottom.Controls.Add(this.btnSave, 0, 0);
            this.tbBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbBottom.Location = new System.Drawing.Point(0, 387);
            this.tbBottom.Name = "tbBottom";
            this.tbBottom.RowCount = 1;
            this.tbBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBottom.Size = new System.Drawing.Size(800, 63);
            this.tbBottom.TabIndex = 14;
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
            this.btnCancel.Location = new System.Drawing.Point(403, 3);
            this.btnCancel.Name = "btnCancel";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(145)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(100)))), ((int)(((byte)(145)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnCancel.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(77)))), ((int)(((byte)(130)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnCancel.OnPressedState = stateProperties2;
            this.btnCancel.Size = new System.Drawing.Size(394, 57);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.ButtonText = "Создать";
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
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnSave.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnSave.OnPressedState = stateProperties4;
            this.btnSave.Size = new System.Drawing.Size(394, 57);
            this.btnSave.TabIndex = 1;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.inputReason.Location = new System.Drawing.Point(30, 172);
            this.inputReason.MaxLength = 32767;
            this.inputReason.MinimumSize = new System.Drawing.Size(100, 35);
            this.inputReason.Modified = false;
            this.inputReason.Multiline = true;
            this.inputReason.Name = "inputReason";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.inputReason.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputReason.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.inputReason.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            stateProperties8.ForeColor = System.Drawing.Color.Silver;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.inputReason.OnIdleState = stateProperties8;
            this.inputReason.PasswordChar = '\0';
            this.inputReason.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.inputReason.PlaceholderText = "Причина увольнения";
            this.inputReason.ReadOnly = false;
            this.inputReason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputReason.SelectedText = "";
            this.inputReason.SelectionLength = 0;
            this.inputReason.SelectionStart = 0;
            this.inputReason.ShortcutsEnabled = true;
            this.inputReason.Size = new System.Drawing.Size(737, 209);
            this.inputReason.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.inputReason.TabIndex = 15;
            this.inputReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputReason.TextMarginBottom = 0;
            this.inputReason.TextMarginLeft = 5;
            this.inputReason.TextMarginTop = 0;
            this.inputReason.TextPlaceholder = "Причина увольнения";
            this.inputReason.UseSystemPasswordChar = false;
            this.inputReason.WordWrap = true;
            this.inputReason.TextChange += new System.EventHandler(this.inputReason_TextChange);
            // 
            // FormLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputReason);
            this.Controls.Add(this.tbBottom);
            this.Controls.Add(this.laEmployee);
            this.Controls.Add(this.dpLeave);
            this.Name = "FormLeave";
            this.Text = "Увольнение";
            this.tbBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker dpLeave;
        private Bunifu.UI.WinForms.BunifuLabel laEmployee;
        private System.Windows.Forms.TableLayoutPanel tbBottom;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox inputReason;
    }
}