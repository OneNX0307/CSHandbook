using System;
using Topshelf;

namespace TopshelfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {  
                // 配置和运行宿主服务
                HostFactory.Run(x =>                                 //1
                {
                    x.Service<Service>(s =>                        //2
                    {
                        // 指定服务类型。这里设置为 Service
                        s.ConstructUsing(name => new Service());     //3

                        // 当服务启动后执行什么
                        s.WhenStarted(tc => tc.Start());              //4

                        // 当服务停止后执行什么
                        s.WhenStopped(tc => tc.Stop());               //5
                    });

                    // 服务用本地系统账号来运行
                    x.RunAsLocalSystem();                            //6

                    // 服务描述信息
                    x.SetDescription("我的项目服务");        //7
                    // 服务显示名称
                    x.SetDisplayName("MyProjectServiceShowName");                       //8
                    // 服务名称
                    x.SetServiceName("MyProjectService");                       //9 
                }); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

    public class Service
    { 
        public void Start() {
            //To do something
        }
        public void Stop() {
            //To do something
        }
    }
}
