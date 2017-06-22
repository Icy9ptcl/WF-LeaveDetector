using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WF_LeaveDetector1 {
    public partial class Setting : Form {
        LeavingDetector LD;

        public Setting(LeavingDetector LD) {
            Owner = LD;
            this.LD = LD;

            InitializeComponent();

            HourNumUD.Value = this.LD.LeaveDetectTime_H;
            MinuteNumUD.Value = this.LD.LeaveDetectTime_M;
            SecondNumUD.Value = this.LD.LeaveDetectTime_S;
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

            //LeavingDetector LD = (LeavingDetector) this.Owner;

            LD.LeaveDetectTime_H = (int)HourNumUD.Value;
            LD.LeaveDetectTime_M = (int) MinuteNumUD.Value;
            LD.LeaveDetectTime_S = (int) SecondNumUD.Value;
        }

        private void TimeSetting_Preset_30min_Click(object sender , EventArgs e) {
            HourNumUD.Value = 0;
            MinuteNumUD.Value = 30;
            SecondNumUD.Value = 0;
            NumUD_Check();
        }

        private void TimeSetting_Preset_10min_Click(object sender , EventArgs e) {
            HourNumUD.Value = 0;
            MinuteNumUD.Value = 10;
            SecondNumUD.Value = 0;
            NumUD_Check();
        }

        private void TimeSetting_Preset_3min_Click(object sender , EventArgs e) {
            HourNumUD.Value = 0;
            MinuteNumUD.Value = 3;
            SecondNumUD.Value = 0;
            NumUD_Check();
        }
        private void TimeSetting_Preset_1hour_Click(object sender , EventArgs e) {
            HourNumUD.Value = 1;
            MinuteNumUD.Value = 0;
            SecondNumUD.Value = 0;
            NumUD_Check();
        }

        private void TimeSetting_ResetButton_Click(object sender , EventArgs e) {
            HourNumUD.Value = 0;
            MinuteNumUD.Value = 0;
            SecondNumUD.Value = 0;
            NumUD_Check();
        }

        private void TodoSetting_ImplementsBox_SelectedIndexChanged (object sender , EventArgs e) {
            //LeavingDetector LD = (LeavingDetector) Owner;

            //LeavingDetector LD = new LeavingDetector();

            LD.LeavingToDoFlag = (LeavingDetector.LeavingToDo) TodoSetting_ImplementsBox.SelectedIndex;

            
            switch (TodoSetting_ImplementsBox.SelectedIndex) {
                case 0:
                    LD.LeavingToDoFlag = LeavingDetector.LeavingToDo.Nothing;
                    break;
                case 1:
                    LD.LeavingToDoFlag = LeavingDetector.LeavingToDo.Sleep;
                    break;
                case 2:
                    LD.LeavingToDoFlag = LeavingDetector.LeavingToDo.Lock;
                    break;
                case 3:
                    LD.LeavingToDoFlag = LeavingDetector.LeavingToDo.ShutDown;
                    break;
                case 4:
                    LD.LeavingToDoFlag = LeavingDetector.LeavingToDo.Reboot;
                    break;
                case 5:
                    LD.LeavingToDoFlag = LeavingDetector.LeavingToDo.Hybernate;
                    break;
            }
            
            //Debug.Print("enum = " + LD.LeavingToDoFlag.ToString() + " Index = " + TodoSetting_ImplementsBox.SelectedIndex.ToString());
        }
    }
}
