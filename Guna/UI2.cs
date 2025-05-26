using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guna
{
    internal class UI2
    {
        internal class WinForms
        {
            internal class Guna2TextBox
            {
                internal Color BorderColor;
                internal int BorderRadius;
                internal int BorderThickness;
                internal Padding Margin;
                internal string PlaceholderText;
                internal Cursor Cursor;
                internal string SelectedText;
                internal string Name;
                internal Point Location;
                internal string DefaultText;
                internal object DisabledState;

                internal class UI2
                {
                    internal class WinForms
                    {
                        internal class Guna2TextBox : Guna.UI2.WinForms.Guna2TextBox
                        {
                        }
                    }
                }
            }

            internal class Guna2Button
            {
                internal Color ForeColor;
                internal Color BackColor;
                internal Font Font;
                internal object DisabledState;

                public Guna2Button()
                {
                }
            }

            internal class Guna2HtmlLabel
            {
                internal string Text;
                internal int TabIndex;
                internal EventHandler MouseLeave;
                internal EventHandler MouseHover;

                public Guna2HtmlLabel()
                {
                }
            }

            internal class Guna2CustomGradientPanel
            {
                internal AnchorStyles Anchor;
                internal int BorderRadius;
                internal string Name;
                internal object Controls;

                public Guna2CustomGradientPanel()
                {
                }

                internal void SuspendLayout()
                {
                    throw new NotImplementedException();
                }

                internal void ResumeLayout(bool v)
                {
                    throw new NotImplementedException();
                }

                internal void PerformLayout()
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}