using System;
using System.Windows.Forms;

namespace SportShopping
{
    public class GuiUtils
    {

        public static void FillColumnSizeGrid(DataGridViewColumnCollection columns)
        {
            foreach (DataGridViewColumn column in columns) column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public static int GetInt(string text)
        {
            try
            {
                return int.Parse(text.Trim());
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static float GetFLoat(string text)
        {
            try
            {
                return float.Parse(text.Trim());
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public static decimal GetDecimal(string text)
        {
            try
            {
                return decimal.Parse(text.Trim());
            }
            catch (Exception e)
            {
                return -1;
            }
        }
    }
}
