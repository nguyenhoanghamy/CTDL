using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dijkstra;
using Demo_dijckstra;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Net;

namespace DoAnCTDL
{
    
    public partial class Form1 : Form
    {
        bool readyPoints = false;

        Graph g = new Graph();
        Point[] aPoint = new Point[201];
        bool checkPanel = true;
        List<int> way = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] inFile = File.ReadAllLines(@"locations.txt");
            g.AddLocation();

            g.AddCost();
            List<string> location = new List<string>();
            List<string> location1 = new List<string>();
            int k = 0;
            foreach (string name in inFile)
            {
                if (k < inFile.Length - 1)
                { 
                string add = name + "(" + k + ")";
                location.Add(add);
                location1.Add(add);
                k++;
                }
            }
            cbbDiemDau.DataSource = location;
            cbbDiemCuoi.DataSource = location1;
        }

        private void btTinhDuongDi_Click(object sender, EventArgs e)
        {
            readyPoints = true;
            bool[] checkPoint = new bool[g.nLocations];
            int startPoint=-1;
            int endPoint = -1;
            string check = "";
            for (int i = 0; i < (int)g.nLocations; i++)
            {
                checkPoint[i] = false;
                check = g.inFile_location[i]+"("+i+")";
                if (cbbDiemDau.SelectedItem.ToString() == check)
                {
                    startPoint = i;
                }
                if (cbbDiemCuoi.SelectedItem.ToString() == check)
                {
                    endPoint = i;
                }
            }
            
             
            if (checkPanel)
            {     
                //Random rd = new Random();
                int t = 0;
                while (true)
                {
                    if (t >= g.nLocations) break;
                    bool OK = true;
                    int temp;
                    
                    while (true && t>0)
                    {
                        //aPoint[t].X = ;
                        //aPoint[t].Y = ;
                        for (int i = 0; i < t; i++)
                        {
                            temp = KhoangCach(i, t);
                            if (temp == 0)
                            {

                                OK = false;
                                break;
                            }
                        }
                        if (OK == true) break;
                    }

                    t++;
                    checkPanel = false;
                }
            }

            way = new List<int>();
            g.Way(ref way, startPoint,endPoint);
            if (startPoint == endPoint)
                rtbLog.Text = "Điểm đi trùng với điểm đến";
            else if (way.Count > 1)
            {

                string wayname = g.LocationList[way[way.Count - 1]].name;
                for (int i = way.Count - 2; i >= 0; i--)
                    wayname += "->" + g.LocationList[way[i]].name;
                rtbLog.Text = "Quảng đường vận chuyển tối ưu: \n" + wayname + "\nTổng chi phí vận chuyển là: " + g.sWay[endPoint].cost + " triệu đồng";

            }
            else rtbLog.Text = "Không tồn tại điểm đi giữa 2 địa điểm";
            
            panel1.Invalidate();
            panel1.Refresh();



        }
        public Point CTD(Point pt)
        {
            int k = panel1.Height / 205;
            pt.X = pt.X * k + 5;
            pt.Y = pt.Y * k + 5;
            return pt;
        }

        public Point TrungDiem(int a, int b)
        {
            Point td = new Point();
            td.X = (aPoint[a].X + aPoint[b].X) / 2;
            td.Y = (aPoint[a].Y + aPoint[b].Y) / 2;
            return td;
        }

        public int KhoangCach(int a, int b)
        {

            int d = 0;
            d = Convert.ToInt32(Math.Sqrt((aPoint[a].X - aPoint[b].X) * (aPoint[a].X - aPoint[b].X) + (aPoint[a].Y - aPoint[b].Y) * (aPoint[a].Y - aPoint[b].Y)));
            return d;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            //  bút có mũi tên
            Pen p = new Pen(Color.Red, 2);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            p.CustomEndCap = bigArrow;

            // but khong mui ten
            Pen pen = new Pen(Color.White, 1);
            Pen penStart = new Pen(Color.Blue, 4);
            Pen penEnd = new Pen(Color.Yellow, 4);

            // but : khi chua nhap 2 diem dau va cuoi (Điểm thường)
            SolidBrush br = new SolidBrush(Color.White);
            
            
            // but : chỉ nhap diem dau
            SolidBrush brStart = new SolidBrush(Color.BurlyWood);
            // but : chỉ nhap diem cuoi
            SolidBrush brEnd = new SolidBrush(Color.GreenYellow);
            

            Graphics gr = panel1.CreateGraphics();
            
            //tao diem
            aPoint[0].X = 0;
            aPoint[0].Y = 0;

            aPoint[1].X = 200;
            aPoint[1].Y = 2;

            aPoint[2].X = 180;
            aPoint[2].Y = 60;

            aPoint[3].X = 40;
            aPoint[3].Y = 10;

            aPoint[4].X = 120;
            aPoint[4].Y = 20;

            aPoint[5].X = 10;
            aPoint[5].Y = 40;

            aPoint[6].X = 15;
            aPoint[6].Y = 100;

            aPoint[7].X = 125;
            aPoint[7].Y = 155;

            aPoint[8].X = 200;
            aPoint[8].Y = 90;

            aPoint[9].X = 178;
            aPoint[9].Y = 130;

            aPoint[10].X = 80;
            aPoint[10].Y = 105;

            aPoint[11].X = 26;
            aPoint[11].Y = 183;

            aPoint[12].X = 500;
            aPoint[12].Y = 500;
            
            // Ve duong di truoc
            for (int h = 0; h < g.nLocations ; h++)
            {
                for (int k = 0; k < g.nLocations ; k++)
                {
                    if (g.adjMaW[h, k] != g.infinity)
                        gr.DrawLine(pen, CTD(aPoint[h]), CTD(aPoint[k]));
                }
            }
            
            for (int i = 0; i < g.nLocations; i++)
            {
                gr.FillEllipse(br, CTD(aPoint[i]).X - 5, CTD(aPoint[i]).Y - 5, 25, 25);
                gr.DrawString(i + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[i]).X, CTD(aPoint[i]).Y);
            }
            for (int i = way.Count - 1; i > 0 ; i--)
                gr.DrawLine(p, CTD(aPoint[way[i]]), CTD(aPoint[way[i - 1]]));

            Point tempPoint = new Point();
            for (int i = 0; i < g.nLocations; i++)
            {
                for (int j = 0; j < g.nLocations; j++)
                {
                    if (g.adjMaW[i, j] != 0 && g.adjMaW[i, j] != g.infinity)
                    {
                        tempPoint = TrungDiem(i, j);
                        //Hien thi do dai tai trung diem
                        gr.DrawString(g.adjMaW[i, j].ToString(), new Font("Consolas", 8), new SolidBrush(Color.DodgerBlue), CTD(tempPoint));
                    }
                }

            }



            if (readyPoints == true)
            {
                gr.FillEllipse(brStart, CTD(aPoint[cbbDiemDau.SelectedIndex]).X - 5, CTD(aPoint[cbbDiemDau.SelectedIndex]).Y - 5, 25, 25);
                gr.DrawString(cbbDiemDau.SelectedIndex + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[cbbDiemDau.SelectedIndex]).X, CTD(aPoint[cbbDiemDau.SelectedIndex]).Y);

                gr.FillEllipse(brEnd, CTD(aPoint[cbbDiemCuoi.SelectedIndex]).X - 5, CTD(aPoint[cbbDiemCuoi.SelectedIndex]).Y - 5, 25, 25);
                gr.DrawString(cbbDiemCuoi.SelectedIndex + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[cbbDiemCuoi.SelectedIndex]).X, CTD(aPoint[cbbDiemCuoi.SelectedIndex]).Y);
            }
            

        }

    }

}
 
            
