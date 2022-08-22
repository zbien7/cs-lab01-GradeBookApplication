using GradeBook.Enums;
using System;
using GradeBook.GradeBooks;
using System.Collections.Generic;
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