﻿using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroodyHen.Main
{
    public class Settings : ISettings
    {
        public Settings ()
        {
            Enable = new ToggleNode(false);
            MultiThreading = new ToggleNode(true);
            Debug = new ToggleNode(false);
        }

        [Menu("Enable")] public ToggleNode Enable { get; set; }
        [Menu("Enable multithreading")] public ToggleNode MultiThreading { get; set; }
        [Menu("Debug mode")] public ToggleNode Debug { get; set; }
    }
}
