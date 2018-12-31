using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourTeamProject
{
    public partial class FrmMySchdual : MetroFramework.Forms.MetroForm
    {
        int dayAddParameter;
        int pickNode = 0;           //  유저의 선택이 몇개 되었다 카운트
    
        DateTime[] times = new DateTime[2];

        public FrmMySchdual()
        {
            InitializeComponent();

            tabControl.SelectTab(0);
        }

        private void FrmMySchdual_Load(object sender, EventArgs e)
        {
            tabControl.TabPages["metroTabPage1"].Text = "STEP01\n티켓/출발일\n";
            tabControl.TabPages["metroTabPage2"].Text = "STEP02\n여행일정 만들기\n";
            tabControl.TabPages["metroTabPage3"].Text = "STEP03\n완료/출력\n";


            rbo_Rail_3.Text = "내일로패스\n        3일";
            rbo_Rail_5.Text = "내일로패스\n        5일";
            rbo_Rail_7.Text = "내일로패스\n        7일";
            rbo_Hana_3.Text = "하나로패스\n        3일";

            //DBtoMysql();
        }

        private void DBtoMysql()
        {
            
        }

        #region 여행일자 변수 셋팅부
        /// <summary>
        /// 시작시점의 날자가 바뀌면 자동 종료되는날 자동연산
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTime_Start_ValueChanged(object sender, EventArgs e)
        {
            int result = DateTime.Compare(dateTime_Start.Value, DateTime.UtcNow);

            if (result==-1)
            {
                MessageBox.Show("현재일 기준으로 선택해 주세요");
                return;
            }
            
            dateTime_End.Value = dateTime_Start.Value.AddDays(dayAddParameter);
        }

        bool btnChk = false;            //  티켓 설정했는지 플레그
        /// <summary>
        /// 티켓을 골랐는지 체크하고, 여행기간을 설정함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rail_3_CheckedChanged(object sender, EventArgs e)
        {
            btnChk = true;
            dateTime_Start.Enabled = true;
            if (rbo_Rail_3.Checked == true || rbo_Hana_3.Checked == true)
            {
                dayAddParameter = 3;
            }
            else if (rbo_Rail_5.Checked == true)
            {
                dayAddParameter = 5;
            }
            else if (rbo_Rail_7.Checked == true)
            {
                dayAddParameter = 7;
            }
            dateTime_Start_ValueChanged(null, null);
        }
        
        /// <summary>
        /// 클리어 이벤트 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ControlClear();
        }

        /// <summary>
        /// 각 컨트롤의 유저 입력 부분을 초기화 시킴
        /// </summary>
        private void ControlClear()
        {
            tabControl.SelectTab(0);

            rbo_Rail_3.Checked = false;
            rbo_Rail_5.Checked = false;
            rbo_Rail_7.Checked = false;
            rbo_Hana_3.Checked = false;

            btn_Pick1.Text = string.Empty;
            btn_Pick2.Text = string.Empty;
            btn_Pick3.Text = string.Empty;
            btn_Pick4.Text = string.Empty;
            btn_Pick5.Text = string.Empty;
            btn_Pick6.Text = string.Empty;
            btn_Pick7.Text = string.Empty;
            btn_Pick8.Text = string.Empty;

            metroTabPage3.Controls.Clear();
            btn_ShowSchdual.Enabled = false;
            btn_Img.Enabled = false;
            pickNode = 0;
            dateTime_Start.Enabled = false;
            
        }
        #endregion


        /// <summary>
        /// 여행일정 짜기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (!btnChk)
            {
                MessageBox.Show("티켓은 꼭 골라주셔야 합니다");
                return;
            }

            if (string.IsNullOrEmpty(btn_Pick1.Text) || string.IsNullOrEmpty(btn_Pick2.Text)|| string.IsNullOrEmpty(btn_Pick3.Text))
            {
                MessageBox.Show("여행지를 3가지 이상 꼭 골라주세요");
                return;
            }

            times[0] = dateTime_Start.Value; times[1] = dateTime_End.Value;
            lbl_Tab2Title.Text =
                String.Format("여행일정 : ({0}) ~ ({1}) ", times[0].ToShortDateString(), times[1].ToShortDateString());

            MakeSchdual();
            tabControl.SelectTab(2);
        }

        /// <summary>
        /// 스케쥴 생성함
        /// </summary>
        //void MakeSchdual()
        //{
        //    //string[] controlName=
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(lbl_Tab2Title.Text);

        //    for (int i = 1; i < pickNode+1; i++)
        //    {
        //        switch (i)
        //        {
        //            case 1:
        //                sb.AppendLine(string.Format("{0} 번째 여행지 : {1}", i, btn_Pick1.Text));
        //                break;
        //            case 2:
        //                sb.AppendLine(string.Format("{0} 번째 여행지 : {1}", i, btn_Pick2.Text));
        //                break;
        //            case 3:
        //                sb.AppendLine(string.Format("{0} 번째 여행지 : {1}", i, btn_Pick3.Text));
        //                break;
        //            case 4:
        //                sb.AppendLine(string.Format("{0} 번째 여행지 : {1}", i, btn_Pick4.Text));
        //                break;
        //            case 5:
        //                sb.AppendLine(string.Format("{0} 번째 여행지 : {1}", i, btn_Pick5.Text));
        //                break;
        //            case 6:
        //                sb.AppendLine(string.Format("{0} 번째 여행지 : {1}", i, btn_Pick6.Text));
        //                break;
        //            case 7:
        //                sb.AppendLine(string.Format("{0} 번째 여행지 : {1}", i, btn_Pick7.Text));
        //                break;
        //            case 8:
        //                sb.AppendLine(string.Format("{0} 번째 여행지 : {1}", i, btn_Pick8.Text));
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    metroTextBox1.Text = sb.ToString();
        //}
        
        void MakeSchdual()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(lbl_Title.Text);

            newControl form;                                    //  동적 컨트롤 생성을 위한 객체 선언
            List<Control> controls = new List<Control>();       //  생성한 컨트롤을 담을 리스트
            for (int i = 1; i < pickNode + 1; i++)              //  사용자가 고른 여행지의 수 만큼
            {
                switch (i)
                {
                    case 1:
                        //string[] setValue=new string[] {i.ToString(), btn_Pick1.Text}
                        //  방문혜택, 축제정보 보내줘야함
                        form = new newControl(btn_Pick1.Text);
                        form.Location = new Point(0, 50);
                        controls.Add(form);
                        break;
                    case 2:
                        form = new newControl(btn_Pick2.Text);
                        form.Location = new Point(355, 50);
                        controls.Add(form);
                        break;
                    case 3:
                        form = new newControl(btn_Pick3.Text);
                        form.Location = new Point(710, 50);
                        controls.Add(form);
                        break;
                    case 4:
                        form = new newControl(btn_Pick4.Text);
                        form.Location = new Point(0, 180);
                        controls.Add(form);
                        break;
                    case 5:
                        form = new newControl(btn_Pick5.Text);
                        form.Location = new Point(355, 180);
                        controls.Add(form);
                        break;
                    case 6:
                        form = new newControl(btn_Pick6.Text);
                        form.Location = new Point(710, 180);
                        controls.Add(form);
                        break;
                    case 7:
                        form = new newControl(btn_Pick7.Text);
                        form.Location = new Point(0, 310);
                        controls.Add(form);
                        break;
                    case 8:
                        form = new newControl(btn_Pick8.Text);
                        form.Location = new Point(355, 310);
                        controls.Add(form);
                        break;
                    default:
                        break;
                }
            }

            metroTabPage3.Controls.AddRange(controls.ToArray());
            btn_Img.Enabled = true;
        }

        #region 여행지 선택Pick버튼 동작부
        Control senderBtn;
        private void btn_Pick_Click(object sender, EventArgs e)
        {
            FrmPickArea form = new FrmPickArea();
            form.send += new FrmPickArea.SendDelegate(SetButton);

            senderBtn = (Control)sender;

            form.ShowDialog();
        }

        void SetButton(string[] str)
        {
            string name = str[0];
            foreach (Control item in this.metroTabPage2.Controls)
            {
                if (item.Name == senderBtn.Name)
                {
                    item.Text = name;
                }
            }
        } 
        #endregion

        /// <summary>
        /// 여행지를 pick하면 카운트 갯수 오르는 텍스트체인지 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Pick_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Text+"텍스트체인지!!");
            if (!String.IsNullOrEmpty(((Button)sender).Text))
            {
                pickNode += 1;
                if (pickNode == 3) 
                {
                    btn_ShowSchdual.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 탭페이지 3의 여행지 짠것을 이미지로 내보냄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Img_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("이미지를 출력하시겠습니까?", "출력", MessageBoxButtons.OKCancel);

            if (result==DialogResult.Cancel)
            {
                return;
            }

            Bitmap bmp = new Bitmap(this.metroTabPage3.Width, this.metroTabPage3.Height);
            
            this.metroTabPage3.DrawToBitmap(bmp, new Rectangle(0, 0, this.metroTabPage3.Width, this.metroTabPage3.Height));
            SaveFileDialog open1 = new SaveFileDialog();
            open1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            if(DialogResult.OK==open1.ShowDialog())
            { 
            bmp.Save(open1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            //pictureBox1.Image = bmp;

            //SaveFileDialog save = new SaveFileDialog();
            //save.ShowDialog();

            //FileStream fs = (FileStream)save.OpenFile();
        }
    }
}
