using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Models
{
    public class Lifters
    {
        public int ID { get; set; }
        public string liftername { get; set; }
        public int squat { get; set; }
        public int bench { get; set; }
        public int deadlift { get; set; }
    }
}
