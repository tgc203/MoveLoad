﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class Departmanagement : Form
    {
        private static Departmanagement instance_ = new Departmanagement();

        public static Departmanagement getinstance()
        {
            return instance_;
        }

        public Departmanagement()
        {
            instance_ = this;
            InitializeComponent();
        }

        public void departGDV()
        {
            //user 테이블 이용해서 그리드뷰 만들기
            //cell 클릭 이벤트 이용해서 부서에 대한 정보 표기하기
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //새 폼 띄우고 ShowDialog로 다른행동 못하게 금지
            //
            depart_add_event add = new depart_add_event();
            add.ShowDialog();
        }
    }
}
