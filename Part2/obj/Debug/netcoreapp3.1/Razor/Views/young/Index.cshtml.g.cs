#pragma checksum "C:\Users\IbrahimMukaila\Desktop\PythonWork\Part 2\Part2\Part2\Views\young\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e5301de1381b70a9fd3799d98f8756f813abd26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_young_Index), @"mvc.1.0.view", @"/Views/young/Index.cshtml")]
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
#line 1 "C:\Users\IbrahimMukaila\Desktop\PythonWork\Part 2\Part2\Part2\Views\_ViewImports.cshtml"
using Part2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IbrahimMukaila\Desktop\PythonWork\Part 2\Part2\Part2\Views\_ViewImports.cshtml"
using Part2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IbrahimMukaila\Desktop\PythonWork\Part 2\Part2\Part2\Views\young\Index.cshtml"
using Part2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\IbrahimMukaila\Desktop\PythonWork\Part 2\Part2\Part2\Views\young\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5301de1381b70a9fd3799d98f8756f813abd26", @"/Views/young/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f07845377f02580ca412ae3b72d4226f5cb5a799", @"/Views/_ViewImports.cshtml")]
    public class Views_young_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\IbrahimMukaila\Desktop\PythonWork\Part 2\Part2\Part2\Views\young\Index.cshtml"
  
    
        DateTime zeroTime = new DateTime(1, 1, 1);
        

        TimeSpan span = DateTime.Now.Subtract(UserManager.FindByEmailAsync(User.Identity.Name).Result.DateOfBirth);
        
        // Because we start at year 1 for the Gregorian
        // calendar, we must subtract a year here.
        int years = (zeroTime + span).Year - 1;
    
    


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\" style=\"margin-top: 25%\">\r\n     <h1>Welcome to the CO876 Course</h1>\r\n    \r\n\r\n");
#nullable restore
#line 25 "C:\Users\IbrahimMukaila\Desktop\PythonWork\Part 2\Part2\Part2\Views\young\Index.cshtml"
     if( @years > 18)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>You are seeing this because you are older than 18</h2>\r\n");
#nullable restore
#line 28 "C:\Users\IbrahimMukaila\Desktop\PythonWork\Part 2\Part2\Part2\Views\young\Index.cshtml"
        
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>You are seeing this because you are younger than 18</h2>\r\n");
#nullable restore
#line 33 "C:\Users\IbrahimMukaila\Desktop\PythonWork\Part 2\Part2\Part2\Views\young\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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