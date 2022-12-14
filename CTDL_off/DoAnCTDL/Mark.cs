using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_dijckstra
{
    public class Mark
    {
        private int doDai;
        private int diemDiToi;
        private bool daDuyet;

        public int DoDai
        {
            get { return doDai; }
            set { doDai = value; }
        }
        public int DiemDiToi
        {
            set { diemDiToi = value; }
            get { return diemDiToi; }
        }

        public bool DaDuyet
        {
            set { daDuyet = value; }
            get { return daDuyet; }
        }

        // ham khoi tao
        public Mark()
        {
            doDai = -1;
            daDuyet = false;
        }
    }
}
