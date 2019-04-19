using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class Lecture : Materials
    { 
        private string text;
        private int maxTextSize = 10000;

        public string Text
        {
            get { return text; }
            set
            {
                if (value.Length > maxTextSize)
                {
                    throw new ArgumentException($"{nameof(Text)} size must be less" +
                                                $" or equal to {maxTextSize}");
                }

                text = value;

            }
        }

        public Dictionary<Uri, PresType> PresentationMaterial { get; set; }

        public Lecture(int index, string description)
        {
            index = this.index;
            description = this.description;

        }
    }
}
