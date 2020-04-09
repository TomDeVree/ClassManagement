using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagementService
{
    public partial class StudentInClass
    {
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
