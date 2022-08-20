using GradeBook.Enums;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;
using System.Text;

namespace GradeBook.GradeBooks  
{	
    public class StandardGradeBook : BaseGradeBook      
    {	    
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}