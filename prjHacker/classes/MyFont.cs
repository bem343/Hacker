using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace prjHacker.classes
{
	public static class MyFont
	{
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont
            , IntPtr pdv, [In] ref uint pcFonts);

        private static PrivateFontCollection collection = new PrivateFontCollection();
        private static FontFamily ff { get; set; }

		#region Controle das fontes
		    public static void load(byte[] fontArray)
		    {
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontArray.Length);
                Marshal.Copy(fontArray, 0, fontPtr, fontArray.Length);

                uint dummy = 0;

                AddFontMemResourceEx(fontPtr, (uint)fontArray.Length, IntPtr.Zero, ref dummy);
                collection.AddMemoryFont(fontPtr, fontArray.Length);
                Marshal.FreeCoTaskMem(fontPtr);

                ff = collection.Families[collection.Families.Length-1];
            }
            public static void select(int i)
            {
                ff = collection.Families[i];
            }
            public static void select(FontFamily ff)
            {
                MyFont.ff = ff;
            }
		#endregion

		#region applyff + Sobrecargas
		    public static void applyff(Control Control)
            {
                Font fBase = (Font)Control.Font.Clone();
                Control.Font = new Font(ff, fBase.Size, fBase.Style);
                //Control.ForeColor = Color.Red;
            }
            public static void applyff(ToolStripDropDownItem ToolStripDropDownItem)
            {
                Font fBase = (Font)ToolStripDropDownItem.Font.Clone();
                ToolStripDropDownItem.Font = new Font(ff, fBase.Size, fBase.Style);
                //ToolStripDropDownItem.ForeColor = Color.Red;
            }
            public static void applyff(DataGridViewCellStyle DataGridViewCellStyle)
            {
                Font fBase = (Font)DataGridViewCellStyle.Font.Clone();
                DataGridViewCellStyle.Font = new Font(ff, fBase.Size, fBase.Style);
                //DataGridViewCellStyle.ForeColor = Color.Red;
            }
            public static void applyff(ContextMenuStrip ContextMenuStrip)
            {
                foreach (ToolStripDropDownItem item in ContextMenuStrip.Items)
                {
                    entryDropDowmItem(item);
                }
            }
            public static void applyff(Control.ControlCollection Controls)
            {
                foreach (Control control in Controls)
                {
                    //Se for DataGridView, adentre...
                    if (control.GetType() == typeof(DataGridView))
                    {
                        DataGridView grid = (DataGridView)control;
                        applyff(grid.ColumnHeadersDefaultCellStyle);
                        applyff(grid.DefaultCellStyle);
                    }
                    //Se for MenuStrip, adentre...
                    else if (control.GetType() == typeof(MenuStrip))
                    {
                        MenuStrip menu = (MenuStrip)control;
                        foreach (ToolStripDropDownItem item in menu.Items)
                        {
                            entryDropDowmItem(item);
                        }

                        //Aplica a fonte nele!
                        applyff(control);
                    }
                    else
                    {
                        //Se tem controles filhos, adentre...
                        if (control.HasChildren)
                        applyff(control.Controls);

                        //Aplica a fonte nele!
                        applyff(control);
                    }
                }
            }
		#endregion

		#region Verifica os subItems em caso de MenuStrip
		    private static void entryDropDowmItem(ToolStripDropDownItem item)
            {
                if (item.HasDropDownItems)
                {
                    foreach (ToolStripDropDownItem subItem in item.DropDownItems)
                    {
                        entryDropDowmItem(subItem);
                    }
                }

                applyff(item);
            }
		#endregion
	}
}
