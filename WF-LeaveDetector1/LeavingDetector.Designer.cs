namespace WF_LeaveDetector1 {
    partial class LeavingDetector {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.TickingTimer1 = new System.Windows.Forms.Timer(this.components);
            this.LeavingTimeLabel = new System.Windows.Forms.Label();
            this.DisplayLabelPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UIpanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonTLP = new System.Windows.Forms.TableLayoutPanel();
            this.ControlButton = new System.Windows.Forms.Button();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DisplayLabelPanel1.SuspendLayout();
            this.UIpanel.SuspendLayout();
            this.ButtonTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // TickingTimer1
            // 
            this.TickingTimer1.Interval = 500;
            this.TickingTimer1.Tick += new System.EventHandler(this.TickingTimer1_Tick);
            // 
            // LeavingTimeLabel
            // 
            this.LeavingTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeavingTimeLabel.Font = new System.Drawing.Font("メイリオ", 14F);
            this.LeavingTimeLabel.Location = new System.Drawing.Point(0, 80);
            this.LeavingTimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LeavingTimeLabel.Name = "LeavingTimeLabel";
            this.LeavingTimeLabel.Size = new System.Drawing.Size(278, 80);
            this.LeavingTimeLabel.TabIndex = 0;
            this.LeavingTimeLabel.Text = "00:00:00";
            this.LeavingTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayLabelPanel1
            // 
            this.DisplayLabelPanel1.ColumnCount = 1;
            this.DisplayLabelPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayLabelPanel1.Controls.Add(this.LeavingTimeLabel, 0, 1);
            this.DisplayLabelPanel1.Controls.Add(this.TitleLabel, 0, 0);
            this.DisplayLabelPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayLabelPanel1.Location = new System.Drawing.Point(3, 4);
            this.DisplayLabelPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisplayLabelPanel1.Name = "DisplayLabelPanel1";
            this.DisplayLabelPanel1.RowCount = 2;
            this.DisplayLabelPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayLabelPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DisplayLabelPanel1.Size = new System.Drawing.Size(278, 160);
            this.DisplayLabelPanel1.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(278, 80);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "離席時間タイマー";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UIpanel
            // 
            this.UIpanel.ColumnCount = 1;
            this.UIpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UIpanel.Controls.Add(this.DisplayLabelPanel1, 0, 0);
            this.UIpanel.Controls.Add(this.ButtonTLP, 0, 1);
            this.UIpanel.Controls.Add(this.StatusLabel, 0, 2);
            this.UIpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIpanel.Location = new System.Drawing.Point(0, 0);
            this.UIpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UIpanel.Name = "UIpanel";
            this.UIpanel.RowCount = 3;
            this.UIpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.UIpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.UIpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UIpanel.Size = new System.Drawing.Size(284, 261);
            this.UIpanel.TabIndex = 2;
            // 
            // ButtonTLP
            // 
            this.ButtonTLP.ColumnCount = 2;
            this.ButtonTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTLP.Controls.Add(this.ControlButton, 0, 0);
            this.ButtonTLP.Controls.Add(this.ConfigButton, 1, 0);
            this.ButtonTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTLP.Location = new System.Drawing.Point(3, 172);
            this.ButtonTLP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonTLP.Name = "ButtonTLP";
            this.ButtonTLP.RowCount = 1;
            this.ButtonTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTLP.Size = new System.Drawing.Size(278, 64);
            this.ButtonTLP.TabIndex = 2;
            // 
            // ControlButton
            // 
            this.ControlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlButton.Location = new System.Drawing.Point(3, 3);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(133, 58);
            this.ControlButton.TabIndex = 0;
            this.ControlButton.Text = "無効にする";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigButton.Location = new System.Drawing.Point(142, 3);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(133, 58);
            this.ConfigButton.TabIndex = 1;
            this.ConfigButton.Text = "設定";
            this.ConfigButton.UseVisualStyleBackColor = true;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Silver;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.Location = new System.Drawing.Point(0, 240);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(284, 21);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "ようこそ";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LeavingDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UIpanel);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LeavingDetector";
            this.Text = "LeavingDetector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DisplayLabelPanel1.ResumeLayout(false);
            this.UIpanel.ResumeLayout(false);
            this.ButtonTLP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer TickingTimer1;
        private System.Windows.Forms.Label LeavingTimeLabel;
        private System.Windows.Forms.TableLayoutPanel DisplayLabelPanel1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel UIpanel;
        private System.Windows.Forms.TableLayoutPanel ButtonTLP;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button ConfigButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}

