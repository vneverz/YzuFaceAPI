﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceAPI_yzu.Models
{
    public class CognitiveModels
    {
        public class ListItem
        {
            public string Value { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return this.Text;
            }
        }
    }
}
