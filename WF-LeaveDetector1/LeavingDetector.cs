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
    public partial class LeavingDetector : Form {
        // 変数を宣言する
        int Backx;
        int Backy;
        int x;
        int y;
        bool Real = true;

        public enum LeavingToDo {
            Nothing, Sleep, Lock,ShutDown, Reboot, Hybernate
        };

        public LeavingToDo LeavingToDoFlag = LeavingToDo.Nothing;

        bool EnabledFlag = false;

        DateTimeOffset BackedTime = DateTimeOffset.Now;
        TimeSpan TimeDiff = DateTimeOffset.Now.Offset;

        public int LeaveDetectTime_H = 0;
        public int LeaveDetectTime_M = 3;
        public int LeaveDetectTime_S = 0;
        public long LeaveDetectTime_ms;

        // ここから
        public LeavingDetector() {
            InitializeComponent();
        }

        private void TickingTimer1_Tick(object sender , EventArgs e) {
            if ( EnabledFlag == true ) {
                Backx = x;
                Backy = y;
                x = Cursor.Position.X;
                y = Cursor.Position.Y;
                if ( ( x != Backx ) || ( y != Backy ) ) {
                    //LeavingCount = 0;
                    BackedTime = DateTimeOffset.Now;
                    LeaveCheck();
                } else {
                    //LeavingCount++;
                    LeaveCheck();
                }
                TickingTimer1.Stop();
                TickingTimer1.Start();
            } else {
                LeavingTimeLabel.Text = "--:--:--";
            }
        }

        public void LeaveCheck() {

            int NowTime_H;
            int NowTime_M;
            int NowTime_S;
            long NowTime_ms;

            int BackTime_H;
            int BackTime_M;
            int BackTime_S;
            long BackTime_ms;

            long Interval_ms;

            long Diff_ms;
            int Diff_H;
            int Diff_M;
            int Diff_S;

            bool ErrorFlag = false;

            try {
                // 現在時刻を取得してミリセカンドにする
                DateTimeOffset NowTime = DateTimeOffset.Now;
                NowTime_H = int.Parse(NowTime.ToString("HH"));
                NowTime_M = int.Parse(NowTime.ToString("mm"));
                NowTime_S = int.Parse(NowTime.ToString("ss"));
                NowTime_ms = HMStoMilliSec(NowTime_H , NowTime_M , NowTime_S);
                // 操作を確認した時刻を取得してミリセカンドにする
                BackTime_H = int.Parse(BackedTime.ToString("HH"));
                BackTime_M = int.Parse(BackedTime.ToString("mm"));
                BackTime_S = int.Parse(BackedTime.ToString("ss"));
                BackTime_ms = HMStoMilliSec(BackTime_H , BackTime_M , BackTime_S);
            } catch ( FormatException ) {
                ErrorFlag = true;
                NowTime_ms = 0;
                BackTime_ms = 0;
            }

            if ( ErrorFlag == false ) {
                Interval_ms = TickingTimer1.Interval;
                LeaveDetectTime_ms = HMStoMilliSec(LeaveDetectTime_H , LeaveDetectTime_M , LeaveDetectTime_S);
                Diff_ms = NowTime_ms - BackTime_ms;

                if (Diff_ms >= LeaveDetectTime_ms) {
                    // 離席していた
                    LeaveDeterminatedTodo();
                }

                Diff_H = (int) ( ( Diff_ms / 1000.0 / 60.0 / 60.0 ) % 60 );
                Diff_M = (int) ( ( Diff_ms / 1000.0 / 60.0 ) % 60 );
                Diff_S = (int) ( Diff_ms / 1000.0 % 60 );
                
                //
                LeavingTimeLabel.Text = FormatS( 2 , Diff_H ) + ":" + FormatS( 2 , Diff_M ) + ":" + FormatS( 2 , Diff_S );

            }

        }

        public long HMStoMilliSec(int H,int M,int S) {
            return (long)(( H * 1000 * 60 * 60 ) + ( M * 1000 * 60 ) + ( S * 1000 ) );
        }

        public string FormatS(int length,long Number) {
            string NumS = Number.ToString();
            string FormattedString = new string('0' , (length - NumS.Length)) + NumS;
            return FormattedString;
        }

        public string GetTimeString(int H,int M,int S) {
            string TempS = "";

            if (H != 0) {
                TempS += H.ToString() + "時間 ";
            }

            if (M != 0) {
                TempS += M.ToString() + "分 ";
            }

            if ( S != 0 ) {
                TempS += S.ToString() + "秒 ";
            }

            //最後のスペースは消す
            if (TempS.Substring(TempS.Length - 1 , 1) == " ") {
                TempS = TempS.Substring(0,TempS.Length - 1);
            } 

            return TempS;
        }


        private void Form1_Load(object sender , EventArgs e) {
            TickingTimer1.Start();
        }

        private void ControlButton_Click(object sender , EventArgs e) {
            if ( EnabledFlag == false ) {
                ChangeStatus(true);
            } else {
                ChangeStatus(false);
            }
        }

        private string GetToDo(LeavingToDo flag) {
            switch (flag) {

                case LeavingToDo.Nothing:
                    return "何もしない";

                case LeavingToDo.Sleep:
                    return "スリープ";

                case LeavingToDo.Lock:
                    return "ロック";

                case LeavingToDo.ShutDown:
                    return "シャットダウン";

                case LeavingToDo.Reboot:
                    return "再起動";

                case LeavingToDo.Hybernate:
                    return "休止状態";

                default:
                    return "";
            }
               
        }

        private void ChangeStatus(bool flag) {
            string StS = "";
            if ((GetToDo(LeavingToDoFlag) == "") || ( ( GetToDo(LeavingToDoFlag) == "何もしない" ))) {
                StS = "通知します";
            } else {
                StS = GetToDo(LeavingToDoFlag) + "を実行します";
            }


            EnabledFlag = flag;
            BackedTime = DateTimeOffset.Now;
            if ( EnabledFlag == true ) {
                ControlButton.Text = "無効にする";
                TickingTimer1.Start();
                StatusLabel.Text = "離席時間 " + GetTimeString(LeaveDetectTime_H , LeaveDetectTime_M , LeaveDetectTime_S) + "後に" + StS;
            } else {
                ControlButton.Text = "有効にする";
                TickingTimer1.Stop();
                StatusLabel.Text = "タイマーは無効です";
            }
        }
        /*
        public LeavingToDo LeavingTodoFlag {
            set {
                LeavingToDo LeavingToDoFlag = value;
            }
            get {
                return LeavingToDoFlag;
            }
        }
        */
        private void LeaveDeterminatedTodo() {
            ChangeStatus(false);

            switch ( LeavingToDoFlag ) {
                case LeavingToDo.Nothing:
                    break;
                case LeavingToDo.ShutDown:
                    if ( Real == true ) {
                        AdjustToken();
                        ExitWindowsEx(ExitWindows.EWX_POWEROFF , 0);
                    } else {
                        Debug.Print("シャットダウン");
                    }
                    break;
                case LeavingToDo.Reboot:
                    if ( Real == true ) {
                        AdjustToken();
                        ExitWindowsEx(ExitWindows.EWX_REBOOT , 0);
                    } else {
                        Debug.Print("再起動");
                    }
                    break;
                case LeavingToDo.Hybernate:
                    if ( Real == true ) {
                        Application.SetSuspendState(PowerState.Hibernate , false , false);
                    } else {
                        Debug.Print("休止状態");
                    }
                    break;
                case LeavingToDo.Sleep:
                    if ( Real == true ) {
                        Application.SetSuspendState(PowerState.Suspend , false , false);
                    } else {
                        Debug.Print("スリープ");
                    }
                    break;
                case LeavingToDo.Lock:
                    if ( Real == true ) {
                        Debug.Print("ロック");
                        //Processオブジェクトを作成
                        Process p = new Process();

                        //ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
                        p.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
                        //出力を読み取れるようにする
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.RedirectStandardInput = false;
                        //ウィンドウを表示しないようにする
                        p.StartInfo.CreateNoWindow = true;
                        //コマンドラインを指定（"/c"は実行後閉じるために必要）
                        p.StartInfo.Arguments = @"/c rundll32.exe User32.dll LockWorkStation";

                        //起動
                        p.Start();

                        //プロセス終了まで待機する
                        //WaitForExitはReadToEndの後である必要がある
                        //(親プロセス、子プロセスでブロック防止のため)
                        p.WaitForExit();
                        p.Close();
                    } else {
                    }
                    break;
                default:
                    break;
            }
        }

        public enum ExitWindows : uint {
            EWX_LOGOFF = 0x00,
            EWX_SHUTDOWN = 0x01,
            EWX_REBOOT = 0x02,
            EWX_POWEROFF = 0x08,
            EWX_RESTARTAPPS = 0x40,
            EWX_FORCE = 0x04,
            EWX_FORCEIFHUNG = 0x10,
        }

        [System.Runtime.InteropServices.DllImport("user32.dll" , SetLastError = true)]
        public static extern bool ExitWindowsEx(ExitWindows uFlags ,
            int dwReason);
        [System.Runtime.InteropServices.DllImport("kernel32.dll" , SetLastError = true)]
        private static extern IntPtr GetCurrentProcess();

        [System.Runtime.InteropServices.DllImport("advapi32.dll" , SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr ProcessHandle ,
            uint DesiredAccess ,
            out IntPtr TokenHandle);

        [System.Runtime.InteropServices.DllImport("kernel32.dll" , SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hObject);

        [System.Runtime.InteropServices.DllImport("advapi32.dll" , SetLastError = true ,
            CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern bool LookupPrivilegeValue(string lpSystemName ,
            string lpName ,
            out long lpLuid);

        [System.Runtime.InteropServices.StructLayout(
           System.Runtime.InteropServices.LayoutKind.Sequential , Pack = 1)]
        private struct TOKEN_PRIVILEGES {
            public int PrivilegeCount;
            public long Luid;
            public int Attributes;
        }

        [System.Runtime.InteropServices.DllImport("advapi32.dll" , SetLastError = true)]
        private static extern bool AdjustTokenPrivileges(IntPtr TokenHandle ,
            bool DisableAllPrivileges ,
            ref TOKEN_PRIVILEGES NewState ,
            int BufferLength ,
            IntPtr PreviousState ,
            IntPtr ReturnLength);

        //シャットダウンするためのセキュリティ特権を有効にする
        public static void AdjustToken() {
            const uint TOKEN_ADJUST_PRIVILEGES = 0x20;
            const uint TOKEN_QUERY = 0x8;
            const int SE_PRIVILEGE_ENABLED = 0x2;
            const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

            if ( Environment.OSVersion.Platform != PlatformID.Win32NT )
                return;

            IntPtr procHandle = GetCurrentProcess();

            //トークンを取得する
            IntPtr tokenHandle;
            OpenProcessToken(procHandle ,
                TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY , out tokenHandle);
            //LUIDを取得する
            TOKEN_PRIVILEGES tp = new TOKEN_PRIVILEGES();
            tp.Attributes = SE_PRIVILEGE_ENABLED;
            tp.PrivilegeCount = 1;
            LookupPrivilegeValue(null , SE_SHUTDOWN_NAME , out tp.Luid);
            //特権を有効にする
            AdjustTokenPrivileges(
                tokenHandle , false , ref tp , 0 , IntPtr.Zero , IntPtr.Zero);

            //閉じる
            CloseHandle(tokenHandle);
        }

        private void ConfigButton_Click(object sender , EventArgs e) {
            Setting f = new Setting(this);
            ChangeStatus(false);
            f.ShowDialog(this);
            f.Dispose();
        }
    }
}

