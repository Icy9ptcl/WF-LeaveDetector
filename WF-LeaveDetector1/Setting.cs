using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_LeaveDetector1 {
    public partial class Setting : Form {
        public Setting() {
            InitializeComponent();
        }

        private void TodoSetting_SoundCheckBox_CheckedChanged(object sender , EventArgs e) {

        }

        private void HourNumUD_ValueChanged(object sender , EventArgs e) {
            NumUD_Check();
        }

        private void MinuteNumUD_ValueChanged(object sender , EventArgs e) {
            NumUD_Check();
        }

        private void SecondNumUD_ValueChanged(object sender , EventArgs e) {
            NumUD_Check();
        }

        private void NumUD_Check() {

            //「秒」の繰り上げ/繰り下げ処理
            if (SecondNumUD.Value > 59) {
                SecondNumUD.Value = 0;
                MinuteNumUD.Value++;
            } else if (SecondNumUD.Value < 0 ) {
                MinuteNumUD.Value--;
                SecondNumUD.Value = 59;
            }
            
            //「分」の繰り上げ/繰り下げ処理
            if ( MinuteNumUD.Value > 59) {
                MinuteNumUD.Value = 0;
                HourNumUD.Value++;
            } else if (MinuteNumUD.Value < 0) {
                HourNumUD.Value--;
                MinuteNumUD.Value = 59;
            }

            //「時間」の繰り上げ/繰り下げ処理
            if (HourNumUD.Value > 99) {
                HourNumUD.Value = 0;
            } else if (HourNumUD.Value < 0) {
                HourNumUD.Value = 99;
            }

        }

        private void TimeSetting_Preset_30min_Click(object sender , EventArgs e) {
            HourNumUD.Value = 0;
            MinuteNumUD.Value = 30;
            SecondNumUD.Value = 0;
        }

        private void TimeSetting_Preset_10min_Click(object sender , EventArgs e) {
            HourNumUD.Value = 0;
            MinuteNumUD.Value = 10;
            SecondNumUD.Value = 0;
        }

        private void TimeSetting_Preset_3min_Click(object sender , EventArgs e) {
            HourNumUD.Value = 0;
            MinuteNumUD.Value = 3;
            SecondNumUD.Value = 0;
        }
        private void TimeSetting_Preset_1hour_Click(object sender , EventArgs e) {
            HourNumUD.Value = 1;
            MinuteNumUD.Value = 0;
            SecondNumUD.Value = 0;
        }

        private void TimeSetting_ResetButton_Click(object sender , EventArgs e) {
            HourNumUD.Value = 0;
            MinuteNumUD.Value = 0;
            SecondNumUD.Value = 0;
        }


    }
}
