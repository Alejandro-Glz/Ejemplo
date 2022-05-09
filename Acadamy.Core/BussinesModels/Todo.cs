using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadamy.Core.BussinesModels
{
    public class Todo
    {

        public string Title { get; set; } 
        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime DoneDate { get; set; }


        

    }
}
