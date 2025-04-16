using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareTrack
{
    public static class AppState
    {
        public static int caregiverId { get; set; }
        public static int careplanId { get; set; }
        public static List<int> completedTaskId { get; set; } = new List<int>();
        public static List<string> completedDescriptions { get; set; } = new List<string>();
        public static bool TasksCompleted { get; set; } = false;

        public static int clientId { get; set; }
    }
    
}
