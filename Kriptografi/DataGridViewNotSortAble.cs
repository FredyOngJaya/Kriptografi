using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kriptografi
{
    public class DataGridViewNotSortAble : System.Windows.Forms.DataGridView
    {
        protected override void OnColumnAdded(System.Windows.Forms.DataGridViewColumnEventArgs e)
        {
            base.OnColumnAdded(e);
            e.Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        }
    }
}
