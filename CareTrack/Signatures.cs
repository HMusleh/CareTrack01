﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareTrack
{
    public partial class Signatures : Form
    {
        public Signatures(int caregiverId, int careplanId, List<int> taskIds, List<string> taskDescriptions)
        {
            InitializeComponent();


        }
    }
}
