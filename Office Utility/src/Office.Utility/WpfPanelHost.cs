﻿using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace Office.Utility
{
    /// <summary>
    /// Windows Forms user control that hosts a WPF user Control.
    /// Includes fix for a redraw issue that is present in Office 2007
    /// </summary>
    [ComVisible(true)]
    [ProgId("Office.Utility.WpfPanelHost")]
    [Guid("59A7E2E3-B0AD-449A-81B9-58398873AC8B")]
    public partial class WpfPanelHost : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfPanelHost"/> class.
        /// </summary>
        public WpfPanelHost()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the child WPF user control.
        /// </summary>
        /// <value>The child.</value>
        public UIElement Child
        {
            get
            {
                return elementHost1.Child;
            }
            set
            {
                elementHost1.Child = value;
                elementHost1.Width++;
                elementHost1.Dock = DockStyle.Fill;
            }
        }
    }
}
