**三层架构**和MVC的区别？MVMM？WebAPIResutfulWebService[Spring.Net](http://spring.net/)AutoMapperNHibernate FlunetHibernateMVC是一种分层思想，将一个项目代码分为几类，分别放到不同的层里，Model层存储一些数据和业务逻辑，View层处理页面问题，Controller层用来接收人机交互指令。

Model-View-Controller的使用、Area和Global的理解、路由配置、数据传递的方式、AOP思想的体现(4大过滤器)，各种Result、Razor语法、HttpContext相关的五大对象、分布视图、特性的补充、Html扩展控件、Bundles压缩js和css的原理、Owin约束、管道模型及MVC的工作原理URL和URI？

```csharp
//添加多个路由时，第一个匹配的路由起效：
public static void RegisterRoutes(RouteCollection routes)
{
    routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

    routes.MapRoute(
        name: "Default2",
        url: "{controller}/{action}/{id}",
        //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        defaults: new { controller = "Login", action = "Login2", id = UrlParameter.Optional }
    );

    routes.MapRoute(
        name: "Default",
        url: "{controller}/{action}/{id}",
        //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
    );
}
```

