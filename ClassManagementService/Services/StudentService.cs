using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagementService.Services
{
    public class StudentService : Student.StudentBase
    {
        public override Task<ListStudentsForClassReply> ListStudentsForClass(ListStudentsForClassRequest request, ServerCallContext context)
        {
            var reply = new ListStudentsForClassReply();
            reply.Students.Add(new StudentInClass { StudentNumber = 1, FirstName = "Kobe", LastName = "De Vree", IsPresentToday = true });
            reply.Students.Add(new StudentInClass { StudentNumber = 1, FirstName = "Yuna", LastName = "De Herdt", IsPresentToday = true });
            return Task.FromResult(reply);
        }
    }
}
