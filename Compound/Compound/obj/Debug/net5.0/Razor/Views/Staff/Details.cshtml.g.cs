#pragma checksum "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49c39b2e2a92ffe548b31e70c14e6adb6ef4ccf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Details), @"mvc.1.0.view", @"/Views/Staff/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\_ViewImports.cshtml"
using Compound;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\_ViewImports.cshtml"
using Compound.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c39b2e2a92ffe548b31e70c14e6adb6ef4ccf1", @"/Views/Staff/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"628968bf8344dc7e33ac9eb5d6b387703f5412c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Staff_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
  

    StaffModel Staff = (StaffModel)ViewData["StaffList"];
    List<UserModel> User = (List<UserModel>)ViewData["Users"];
    var space = "\t";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 11 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
Write(Staff.Staff_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<div style=\" display:flex\">\r\n    <figure class=\"figure\">\r\n        <img style=\" height:7em; width:10em ; border-radius: 30% \"");
            BeginWriteAttribute("src", " src=\"", 378, "\"", 400, 1);
#nullable restore
#line 18 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
WriteAttributeValue("", 384, Staff.Staff_Img, 384, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"figure-img img-fluid rounded\"");
            BeginWriteAttribute("alt", " alt=\"", 438, "\"", 461, 1);
#nullable restore
#line 18 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
WriteAttributeValue("", 444, Staff.Staff_Name, 444, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </figure>\r\n    <div style=\" padding-left:1em\">\r\n        <h3>");
#nullable restore
#line 21 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
       Write(space);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" About me:</h3>
        <p style=""width:25em"">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas vel est nec felis scelerisque lacinia. Etiam sollicitudin efficitur orci sed imperdiet. Nulla a lectus sit amet diam ultricies vulputate. Nam quis quam non nisl porttitor consequat. Nunc eget dui augue. Nam tincidunt ligula ac gravida faucibus. Morbi eu tempor urna. Vestibulum et tellus id arcu fermentum gravida id sed libero.
        </p>
        </div>
        <div style="" padding-left:1em"">
        <h3>");
#nullable restore
#line 27 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
       Write(space);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Status:</h3>\r\n\r\n");
#nullable restore
#line 29 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
         if (@Staff.UserId != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"width:30em\">");
#nullable restore
#line 30 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
                          Write(Staff.Staff_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" serves right now ");
#nullable restore
#line 30 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
                                                             Write(Staff.User.User_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 30 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
                                                                                           }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"width:20em\">");
#nullable restore
#line 33 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
                         Write(Staff.Staff_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is avalible for serving any user for need</p>\r\n");
#nullable restore
#line 34 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Staff\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<br />\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
