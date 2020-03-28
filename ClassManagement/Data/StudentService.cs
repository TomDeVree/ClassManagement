using ClassManagementService;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagementClient.Data
{
    public class StudentService
    {
        private ClassManagementService.Student.StudentClient studentClient;
        public StudentService()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            studentClient = new Student.StudentClient(channel);
        }

        public async Task<IEnumerable<ClassManagementService.StudentInClass>> ListStudentsForClass(string className)
        {
            ListStudentsForClassReply reply = await studentClient.ListStudentsForClassAsync(new ListStudentsForClassRequest { ClassName = className });
            return reply.Students;
        }
    }
}
