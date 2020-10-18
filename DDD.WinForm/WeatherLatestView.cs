using DDD.WinForm.Common;
using DDD.WinForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD.WinForm
{
    public partial class WeatherLatestView : Form
    {
        public WeatherLatestView()
        {
            InitializeComponent();
        }

        private void BtnLatest_Click(object sender, EventArgs e)
        {
            var dt = WeatherSQLite.GetLatest(Convert.ToInt32(TxtAreaId.Text));

            if (dt.Rows.Count > 0)
            {
                LblDataDate.Text = dt.Rows[0]["DataDate"].ToString();
                LblCondition.Text = dt.Rows[0]["Condition"].ToString();
                LblTemperature.Text =
                    CommonFunc.RoundString(Convert.ToSingle(dt.Rows[0]["Temperature"]),
                                           CommonConst.TemperatureDecimalPoint)
                                            + CommonConst.TemperatureUnitName;
            }
        }

        
    }
}
