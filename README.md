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

***

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

在控制器中使用：

```
[AllowCrossSite]
```

推荐阅读：
+ [CORS in ASP .NET MVC5](http://stackoverflow.com/questions/27218240/cors-in-asp-net-mvc5)
+ [Setting Access-Control-Allow-Origin in ASP.Net MVC - simplest possible method](http://stackoverflow.com/questions/6290053/setting-access-control-allow-origin-in-asp-net-mvc-simplest-possible-method)

***

### ASP.NET WebAPI CORS

项目：`src\Cors.AspNet.WebAPI`。

引用 `Microsoft.AspNet.WebApi.Cors` 包：

```
Install-Package Microsoft.AspNet.WebApi.Cors
```

`WebApiConfig.cs` 文件：

```
config.EnableCors();
```

在控制器：

```
[EnableCors(origins: "http://localhost:63342", headers: "*", methods: "*")]
```

推荐阅读：
+ [CORS on ASP.NET](https://enable-cors.org/server_aspnet.html)
+ [WebApi 跨域问题解决方案：CORS](http://www.cnblogs.com/landeanfen/p/5177176.html)

***

### ASP.NET Core CORS

项目：`src\Cors.AspNetCore`

修改 `ConfigureServices`：

```
services.AddCors(options => options.AddPolicy("CorsSample",
    p => p.WithOrigins("http://localhost:63342")
        .AllowAnyMethod()
        .AllowAnyHeader()));
```

修改 `Configure`：

```
app.UseCors("CorsSample");
```

控制器：

```
[EnableCors("CorsSample")]
```

推荐阅读：
+ [ASP.NET Core CORS 简单使用](http://www.cnblogs.com/xishuai/p/aspnet-core-cors.html)
