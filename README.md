# ASP.NET CORS 样例

### IIS7 CORS

项目：`src\Cors.IIS7`。

在 `web.config` 配置文件的 `system.webServer:httpProtocol:customHeaders` 节点下添加配置：

```
<add name="Access-Control-Allow-Origin" value="*" />
<add name="Access-Control-Allow-Methods" value="POST" />
<add name="Access-Control-Allow-Headers" value="content-type" />
```

推荐阅读：
+ [CORS on IIS7](https://enable-cors.org/server_iis7.html)
+ [ASP.NET Configuration File Hierarchy and Inheritance](https://msdn.microsoft.com/en-us/library/ms178685.aspx)

### ASP.NET MVC5 CORS

项目：`src\Cors.AspNet.Mvc5`。

添加过滤器以实现 CORS：

```
public class AllowCrossSiteAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
        base.OnActionExecuting(filterContext);
    }
}
```

推荐阅读：
+ [CORS in ASP .NET MVC5](http://stackoverflow.com/questions/27218240/cors-in-asp-net-mvc5)
+ [Setting Access-Control-Allow-Origin in ASP.Net MVC - simplest possible method](http://stackoverflow.com/questions/6290053/setting-access-control-allow-origin-in-asp-net-mvc-simplest-possible-method)
