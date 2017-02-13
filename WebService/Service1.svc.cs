using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService1
    {
        public CompositeType GetStudents()
        {
            List<Student> Students = new List<Student>
            {
                new Student {Sid=1, Name="Lily",Age=12 },
                new Student {Sid=2, Name="Poly",Age=13 },
                new Student {Sid=3, Name="Anny",Age=13 },
            };
            return new CompositeType { Students = Students };
        }

        public Student GetFirstStudent()
        {
            List<Student> Students = new List<Student>
            {
                new Student {Sid=1, Name="Lily",Age=12 },
                new Student {Sid=2, Name="Poly",Age=13 },
                new Student {Sid=3, Name="Anny",Age=13 },
            };
            return Students.OrderBy(s => s.Sid).FirstOrDefault();
        }

    }
}
