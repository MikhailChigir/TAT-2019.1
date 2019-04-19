using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    public class Discipline : ICloneable
    {
        protected string guid;
        public string Guid { get; set; }
        protected string description;

        public override string ToString()
        {
            return this.description;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Discipline d = obj as Discipline;
            if (d as Discipline == null)
                return false;
            return d.guid == this.guid;

        }

        public object Clone()
        {
            return new Discipline{guid = this.guid, description = this.description, index = this.index};

        }
    }
}
