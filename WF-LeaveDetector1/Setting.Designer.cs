namespace WF_LeaveDetector1 {
    partial class Setting {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.UIPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SettingPage1 = new System.Windows.Forms.TableLayoutPanel();
            this.TodoSettingGBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TodoSetting_ImplementsBox = new System.Windows.Forms.ListBox();
            this.TodoSetting_SoundCheckBox = new System.Windows.Forms.CheckBox();
            this.TimeSettingGBox = new System.Windows.Forms.GroupBox();
            this.TimeSettingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TimeSetting_TMSPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HourNumUD = new System.Windows.Forms.NumericUpDown();
            this.MinuteNumUD = new System.Windows.Forms.NumericUpDown();
            this.TimeSetting_SecondLabel = new System.Windows.Forms.Label();
            this.SecondNumUD = new System.Windows.Forms.NumericUpDown();
            this.TimeSetting_MinuteLabel = new System.Windows.Forms.Label();
            this.TimeSetting_HourLabel = new System.Windows.Forms.Label();
            this.TimeSetting_ControlButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Setting_PresetsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TimeSetting_Preset_30min = new System.Windows.Forms.Button();
            this.TimeSetting_Preset_1hour = new System.Windows.Forms.Button();
            this.TimeSetting_Preset_3min = new System.Windows.Forms.Button();
            this.TimeSetting_Preset_10min = new System.Windows.Forms.Button();
            this.TimeSetting_ResetButton = new System.Windows.Forms.Button();
            this.PageControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_NextPage = new System.Windows.Forms.Label();
            this.Settings_PrevPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UIPanel.SuspendLayout();
            this.SettingPage1.SuspendLayout();
            this.TodoSettingGBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.TimeSettingGBox.SuspendLayout();
            this.TimeSettingPanel.SuspendLayout();
            this.TimeSetting_TMSPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNumUD)).BeginInit();
            this.TimeSetting_ControlButtonsPanel.SuspendLayout();
            this.Setting_PresetsPanel.SuspendLayout();
            this.PageControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UIPanel
            // 
            this.UIPanel.AutoScroll = true;
            this.UIPanel.ColumnCount = 1;
            this.UIPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UIPanel.Controls.Add(this.SettingPage1, 0, 0);
            this.UIPanel.Controls.Add(this.PageControlPanel, 0, 1);
            this.UIPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIPanel.Location = new System.Drawing.Point(0, 0);
            this.UIPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UIPanel.Name = "UIPanel";
            this.UIPanel.RowCount = 2;
            this.UIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UIPanel.Size = new System.Drawing.Size(284, 261);
            this.UIPanel.TabIndex = 1;
            // 
            // SettingPage1
            // 
            this.SettingPage1.ColumnCount = 1;
            this.SettingPage1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingPage1.Controls.Add(this.TodoSettingGBox, 0, 1);
            this.SettingPage1.Controls.Add(this.TimeSettingGBox, 0, 0);
            this.SettingPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingPage1.Location = new System.Drawing.Point(3, 3);
            this.SettingPage1.Name = "SettingPage1";
            this.SettingPage1.RowCount = 2;
            this.SettingPage1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingPage1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SettingPage1.Size = new System.Drawing.Size(278, 235);
            this.SettingPage1.TabIndex = 2;
            // 
            // TodoSettingGBox
            // 
            this.TodoSettingGBox.Controls.Add(this.flowLayoutPanel1);
            this.TodoSettingGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodoSettingGBox.Location = new System.Drawing.Point(3, 121);
            this.TodoSettingGBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TodoSettingGBox.Name = "TodoSettingGBox";
            this.TodoSettingGBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TodoSettingGBox.Size = new System.Drawing.Size(272, 110);
            this.TodoSettingGBox.TabIndex = 3;
            this.TodoSettingGBox.TabStop = false;
            this.TodoSettingGBox.Text = "離席検知時の動作";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.TodoSetting_ImplementsBox);
            this.flowLayoutPanel1.Controls.Add(this.TodoSetting_SoundCheckBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 84);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // TodoSetting_ImplementsBox
            // 
            this.TodoSetting_ImplementsBox.FormattingEnabled = true;
            this.TodoSetting_ImplementsBox.ItemHeight = 18;
            this.TodoSetting_ImplementsBox.Items.AddRange(new object[] {
            "何もしない",
            "スリープ",
            "ロック",
            "シャットダウン",
            "再起動",
            "休止状態"});
            this.TodoSetting_ImplementsBox.Location = new System.Drawing.Point(3, 3);
            this.TodoSetting_ImplementsBox.Name = "TodoSetting_ImplementsBox";
            this.TodoSetting_ImplementsBox.Size = new System.Drawing.Size(120, 76);
            this.TodoSetting_ImplementsBox.TabIndex = 0;
            this.TodoSetting_ImplementsBox.SelectedIndexChanged += new System.EventHandler(this.TodoSetting_ImplementsBox_SelectedIndexChanged);
            // 
            // TodoSetting_SoundCheckBox
            // 
            this.TodoSetting_SoundCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TodoSetting_SoundCheckBox.AutoSize = true;
            this.TodoSetting_SoundCheckBox.Location = new System.Drawing.Point(129, 3);
            this.TodoSetting_SoundCheckBox.Name = "TodoSetting_SoundCheckBox";
            this.TodoSetting_SoundCheckBox.Size = new System.Drawing.Size(87, 22);
            this.TodoSetting_SoundCheckBox.TabIndex = 1;
            this.TodoSetting_SoundCheckBox.Text = "音を鳴らす";
            this.TodoSetting_SoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // TimeSettingGBox
            // 
            this.TimeSettingGBox.Controls.Add(this.TimeSettingPanel);
            this.TimeSettingGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSettingGBox.Location = new System.Drawing.Point(3, 3);
            this.TimeSettingGBox.Name = "TimeSettingGBox";
            this.TimeSettingGBox.Size = new System.Drawing.Size(272, 111);
            this.TimeSettingGBox.TabIndex = 2;
            this.TimeSettingGBox.TabStop = false;
            this.TimeSettingGBox.Text = "離席と判定する時間の設定";
            // 
            // TimeSettingPanel
            // 
            this.TimeSettingPanel.ColumnCount = 2;
            this.TimeSettingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.TimeSettingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TimeSettingPanel.Controls.Add(this.TimeSetting_TMSPanel, 0, 0);
            this.TimeSettingPanel.Controls.Add(this.TimeSetting_ControlButtonsPanel, 1, 0);
            this.TimeSettingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSettingPanel.Location = new System.Drawing.Point(3, 21);
            this.TimeSettingPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.TimeSettingPanel.Name = "TimeSettingPanel";
            this.TimeSettingPanel.RowCount = 1;
            this.TimeSettingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TimeSettingPanel.Size = new System.Drawing.Size(266, 87);
            this.TimeSettingPanel.TabIndex = 16;
            // 
            // TimeSetting_TMSPanel
            // 
            this.TimeSetting_TMSPanel.AutoSize = true;
            this.TimeSetting_TMSPanel.ColumnCount = 2;
            this.TimeSetting_TMSPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TimeSetting_TMSPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.TimeSetting_TMSPanel.Controls.Add(this.HourNumUD, 0, 0);
            this.TimeSetting_TMSPanel.Controls.Add(this.MinuteNumUD, 0, 1);
            this.TimeSetting_TMSPanel.Controls.Add(this.TimeSetting_SecondLabel, 1, 2);
            this.TimeSetting_TMSPanel.Controls.Add(this.SecondNumUD, 0, 2);
            this.TimeSetting_TMSPanel.Controls.Add(this.TimeSetting_MinuteLabel, 1, 1);
            this.TimeSetting_TMSPanel.Controls.Add(this.TimeSetting_HourLabel, 1, 0);
            this.TimeSetting_TMSPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimeSetting_TMSPanel.Location = new System.Drawing.Point(3, 3);
            this.TimeSetting_TMSPanel.Name = "TimeSetting_TMSPanel";
            this.TimeSetting_TMSPanel.RowCount = 3;
            this.TimeSetting_TMSPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TimeSetting_TMSPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TimeSetting_TMSPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TimeSetting_TMSPanel.Size = new System.Drawing.Size(121, 81);
            this.TimeSetting_TMSPanel.TabIndex = 13;
            // 
            // HourNumUD
            // 
            this.HourNumUD.Cursor = System.Windows.Forms.Cursors.Default;
            this.HourNumUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourNumUD.Location = new System.Drawing.Point(3, 3);
            this.HourNumUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.HourNumUD.Name = "HourNumUD";
            this.HourNumUD.Size = new System.Drawing.Size(63, 25);
            this.HourNumUD.TabIndex = 0;
            this.HourNumUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HourNumUD.ValueChanged += new System.EventHandler(this.HourNumUD_ValueChanged);
            // 
            // MinuteNumUD
            // 
            this.MinuteNumUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinuteNumUD.Location = new System.Drawing.Point(3, 30);
            this.MinuteNumUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinuteNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.MinuteNumUD.Name = "MinuteNumUD";
            this.MinuteNumUD.Size = new System.Drawing.Size(63, 25);
            this.MinuteNumUD.TabIndex = 1;
            this.MinuteNumUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MinuteNumUD.ValueChanged += new System.EventHandler(this.MinuteNumUD_ValueChanged);
            // 
            // TimeSetting_SecondLabel
            // 
            this.TimeSetting_SecondLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSetting_SecondLabel.Location = new System.Drawing.Point(72, 54);
            this.TimeSetting_SecondLabel.Name = "TimeSetting_SecondLabel";
            this.TimeSetting_SecondLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimeSetting_SecondLabel.Size = new System.Drawing.Size(46, 27);
            this.TimeSetting_SecondLabel.TabIndex = 5;
            this.TimeSetting_SecondLabel.Text = "秒";
            this.TimeSetting_SecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SecondNumUD
            // 
            this.SecondNumUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondNumUD.Location = new System.Drawing.Point(3, 57);
            this.SecondNumUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.SecondNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.SecondNumUD.Name = "SecondNumUD";
            this.SecondNumUD.Size = new System.Drawing.Size(63, 25);
            this.SecondNumUD.TabIndex = 2;
            this.SecondNumUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SecondNumUD.ValueChanged += new System.EventHandler(this.SecondNumUD_ValueChanged);
            // 
            // TimeSetting_MinuteLabel
            // 
            this.TimeSetting_MinuteLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimeSetting_MinuteLabel.Location = new System.Drawing.Point(86, 27);
            this.TimeSetting_MinuteLabel.Name = "TimeSetting_MinuteLabel";
            this.TimeSetting_MinuteLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimeSetting_MinuteLabel.Size = new System.Drawing.Size(32, 27);
            this.TimeSetting_MinuteLabel.TabIndex = 4;
            this.TimeSetting_MinuteLabel.Text = "分";
            this.TimeSetting_MinuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeSetting_HourLabel
            // 
            this.TimeSetting_HourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSetting_HourLabel.Location = new System.Drawing.Point(72, 0);
            this.TimeSetting_HourLabel.Name = "TimeSetting_HourLabel";
            this.TimeSetting_HourLabel.Size = new System.Drawing.Size(46, 27);
            this.TimeSetting_HourLabel.TabIndex = 3;
            this.TimeSetting_HourLabel.Text = "時間";
            this.TimeSetting_HourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeSetting_ControlButtonsPanel
            // 
            this.TimeSetting_ControlButtonsPanel.ColumnCount = 1;
            this.TimeSetting_ControlButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TimeSetting_ControlButtonsPanel.Controls.Add(this.Setting_PresetsPanel, 0, 0);
            this.TimeSetting_ControlButtonsPanel.Controls.Add(this.TimeSetting_ResetButton, 0, 1);
            this.TimeSetting_ControlButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSetting_ControlButtonsPanel.Location = new System.Drawing.Point(130, 3);
            this.TimeSetting_ControlButtonsPanel.Name = "TimeSetting_ControlButtonsPanel";
            this.TimeSetting_ControlButtonsPanel.RowCount = 2;
            this.TimeSetting_ControlButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TimeSetting_ControlButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TimeSetting_ControlButtonsPanel.Size = new System.Drawing.Size(133, 81);
            this.TimeSetting_ControlButtonsPanel.TabIndex = 15;
            // 
            // Setting_PresetsPanel
            // 
            this.Setting_PresetsPanel.ColumnCount = 2;
            this.Setting_PresetsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Setting_PresetsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Setting_PresetsPanel.Controls.Add(this.TimeSetting_Preset_30min, 0, 0);
            this.Setting_PresetsPanel.Controls.Add(this.TimeSetting_Preset_1hour, 1, 1);
            this.Setting_PresetsPanel.Controls.Add(this.TimeSetting_Preset_3min, 0, 1);
            this.Setting_PresetsPanel.Controls.Add(this.TimeSetting_Preset_10min, 1, 0);
            this.Setting_PresetsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Setting_PresetsPanel.Location = new System.Drawing.Point(3, 3);
            this.Setting_PresetsPanel.Name = "Setting_PresetsPanel";
            this.Setting_PresetsPanel.RowCount = 2;
            this.Setting_PresetsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Setting_PresetsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Setting_PresetsPanel.Size = new System.Drawing.Size(127, 50);
            this.Setting_PresetsPanel.TabIndex = 7;
            // 
            // TimeSetting_Preset_30min
            // 
            this.TimeSetting_Preset_30min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSetting_Preset_30min.Location = new System.Drawing.Point(3, 0);
            this.TimeSetting_Preset_30min.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.TimeSetting_Preset_30min.Name = "TimeSetting_Preset_30min";
            this.TimeSetting_Preset_30min.Size = new System.Drawing.Size(57, 25);
            this.TimeSetting_Preset_30min.TabIndex = 10;
            this.TimeSetting_Preset_30min.Text = "30分";
            this.TimeSetting_Preset_30min.UseVisualStyleBackColor = true;
            this.TimeSetting_Preset_30min.Click += new System.EventHandler(this.TimeSetting_Preset_30min_Click);
            // 
            // TimeSetting_Preset_1hour
            // 
            this.TimeSetting_Preset_1hour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSetting_Preset_1hour.Location = new System.Drawing.Point(66, 25);
            this.TimeSetting_Preset_1hour.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.TimeSetting_Preset_1hour.Name = "TimeSetting_Preset_1hour";
            this.TimeSetting_Preset_1hour.Size = new System.Drawing.Size(58, 25);
            this.TimeSetting_Preset_1hour.TabIndex = 9;
            this.TimeSetting_Preset_1hour.Text = "1時間";
            this.TimeSetting_Preset_1hour.UseVisualStyleBackColor = true;
            this.TimeSetting_Preset_1hour.Click += new System.EventHandler(this.TimeSetting_Preset_1hour_Click);
            // 
            // TimeSetting_Preset_3min
            // 
            this.TimeSetting_Preset_3min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSetting_Preset_3min.Location = new System.Drawing.Point(3, 25);
            this.TimeSetting_Preset_3min.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.TimeSetting_Preset_3min.Name = "TimeSetting_Preset_3min";
            this.TimeSetting_Preset_3min.Size = new System.Drawing.Size(57, 25);
            this.TimeSetting_Preset_3min.TabIndex = 8;
            this.TimeSetting_Preset_3min.Text = "3分";
            this.TimeSetting_Preset_3min.UseVisualStyleBackColor = true;
            this.TimeSetting_Preset_3min.Click += new System.EventHandler(this.TimeSetting_Preset_3min_Click);
            // 
            // TimeSetting_Preset_10min
            // 
            this.TimeSetting_Preset_10min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSetting_Preset_10min.Location = new System.Drawing.Point(66, 0);
            this.TimeSetting_Preset_10min.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.TimeSetting_Preset_10min.Name = "TimeSetting_Preset_10min";
            this.TimeSetting_Preset_10min.Size = new System.Drawing.Size(58, 25);
            this.TimeSetting_Preset_10min.TabIndex = 7;
            this.TimeSetting_Preset_10min.Text = "10分";
            this.TimeSetting_Preset_10min.UseVisualStyleBackColor = true;
            this.TimeSetting_Preset_10min.Click += new System.EventHandler(this.TimeSetting_Preset_10min_Click);
            // 
            // TimeSetting_ResetButton
            // 
            this.TimeSetting_ResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeSetting_ResetButton.Location = new System.Drawing.Point(3, 56);
            this.TimeSetting_ResetButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.TimeSetting_ResetButton.Name = "TimeSetting_ResetButton";
            this.TimeSetting_ResetButton.Size = new System.Drawing.Size(127, 25);
            this.TimeSetting_ResetButton.TabIndex = 10;
            this.TimeSetting_ResetButton.Text = "リセット";
            this.TimeSetting_ResetButton.UseVisualStyleBackColor = true;
            this.TimeSetting_ResetButton.Click += new System.EventHandler(this.TimeSetting_ResetButton_Click);
            // 
            // PageControlPanel
            // 
            this.PageControlPanel.ColumnCount = 3;
            this.PageControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PageControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.PageControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PageControlPanel.Controls.Add(this.Settings_NextPage, 2, 0);
            this.PageControlPanel.Controls.Add(this.Settings_PrevPage, 0, 0);
            this.PageControlPanel.Controls.Add(this.label1, 1, 0);
            this.PageControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageControlPanel.Location = new System.Drawing.Point(0, 241);
            this.PageControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PageControlPanel.Name = "PageControlPanel";
            this.PageControlPanel.RowCount = 1;
            this.PageControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PageControlPanel.Size = new System.Drawing.Size(284, 20);
            this.PageControlPanel.TabIndex = 2;
            // 
            // Settings_NextPage
            // 
            this.Settings_NextPage.BackColor = System.Drawing.Color.Silver;
            this.Settings_NextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_NextPage.Location = new System.Drawing.Point(143, 0);
            this.Settings_NextPage.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_NextPage.Name = "Settings_NextPage";
            this.Settings_NextPage.Size = new System.Drawing.Size(141, 20);
            this.Settings_NextPage.TabIndex = 1;
            this.Settings_NextPage.Text = "次のページへ→";
            this.Settings_NextPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Settings_PrevPage
            // 
            this.Settings_PrevPage.BackColor = System.Drawing.Color.Silver;
            this.Settings_PrevPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_PrevPage.Location = new System.Drawing.Point(0, 0);
            this.Settings_PrevPage.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_PrevPage.Name = "Settings_PrevPage";
            this.Settings_PrevPage.Size = new System.Drawing.Size(141, 20);
            this.Settings_PrevPage.TabIndex = 0;
            this.Settings_PrevPage.Text = "←前のページへ";
            this.Settings_PrevPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(141, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 20);
            this.label1.TabIndex = 2;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UIPanel);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Setting";
            this.Text = "Setting";
            this.UIPanel.ResumeLayout(false);
            this.SettingPage1.ResumeLayout(false);
            this.TodoSettingGBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.TimeSettingGBox.ResumeLayout(false);
            this.TimeSettingPanel.ResumeLayout(false);
            this.TimeSettingPanel.PerformLayout();
            this.TimeSetting_TMSPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HourNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNumUD)).EndInit();
            this.TimeSetting_ControlButtonsPanel.ResumeLayout(false);
            this.Setting_PresetsPanel.ResumeLayout(false);
            this.PageControlPanel.ResumeLayout(false);
            this.PageControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel UIPanel;
        private System.Windows.Forms.TableLayoutPanel SettingPage1;
        private System.Windows.Forms.GroupBox TodoSettingGBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox TodoSetting_ImplementsBox;
        private System.Windows.Forms.CheckBox TodoSetting_SoundCheckBox;
        private System.Windows.Forms.GroupBox TimeSettingGBox;
        private System.Windows.Forms.TableLayoutPanel TimeSetting_TMSPanel;
        private System.Windows.Forms.NumericUpDown HourNumUD;
        private System.Windows.Forms.NumericUpDown MinuteNumUD;
        private System.Windows.Forms.Label TimeSetting_SecondLabel;
        private System.Windows.Forms.NumericUpDown SecondNumUD;
        private System.Windows.Forms.Label TimeSetting_MinuteLabel;
        private System.Windows.Forms.Label TimeSetting_HourLabel;
        private System.Windows.Forms.TableLayoutPanel TimeSetting_ControlButtonsPanel;
        private System.Windows.Forms.TableLayoutPanel Setting_PresetsPanel;
        private System.Windows.Forms.Button TimeSetting_Preset_30min;
        private System.Windows.Forms.Button TimeSetting_Preset_1hour;
        private System.Windows.Forms.Button TimeSetting_Preset_3min;
        private System.Windows.Forms.Button TimeSetting_Preset_10min;
        private System.Windows.Forms.Button TimeSetting_ResetButton;
        private System.Windows.Forms.TableLayoutPanel PageControlPanel;
        private System.Windows.Forms.TableLayoutPanel TimeSettingPanel;
        private System.Windows.Forms.Label Settings_NextPage;
        private System.Windows.Forms.Label Settings_PrevPage;
        private System.Windows.Forms.Label label1;
    }
}