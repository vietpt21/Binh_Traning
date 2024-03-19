using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDelegate_listbox
{
    public static class MyExtention
    {
        public delegate bool Mana(int mn);
        public static void ToSotrongListbox(this ListBox lst,Mana mn)
        {
            lst.SelectedIndex = -1;
            for(int i = 0; i < lst.Items.Count; i++)
            {
               int x = Convert.ToInt32(lst.Items[i]);
                if (mn(x))
                {
                    lst.SelectedIndex = i;
                }
            }
           
        }
        public static bool IsSonguyento(this int x)
        {
            int dem = 0;
            for (int i = 0; i <= x; i++)
            {
                if (x%i == 0)
                {
                    dem++;
                }

            }
            return dem == 2;
        }

    }
}
