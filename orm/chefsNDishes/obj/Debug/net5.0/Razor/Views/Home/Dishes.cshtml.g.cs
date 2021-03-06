#pragma checksum "/Users/yukon/Documents/codingDojo/CSharp/orm/chefsNDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a71ab79353112baf58fa47f9286a9521f4f5e20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
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
#line 1 "/Users/yukon/Documents/codingDojo/CSharp/orm/chefsNDishes/Views/_ViewImports.cshtml"
using chefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yukon/Documents/codingDojo/CSharp/orm/chefsNDishes/Views/_ViewImports.cshtml"
using chefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a71ab79353112baf58fa47f9286a9521f4f5e20", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca1185433e571a8b4705464b2f4a9859bdc71df0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 class=""text-center"">Dishes | <a href=""/"">Chefs</a></h1>
<a class=""btn btn-lg btn-dark shadow mb-5"" href=""/dishesNew"">Add a Dish</a>

<h2 class=""text-center"">Yum, take a look at our tasty dishes!</h2>
<br>
<table class=""table"">
  <thead>
    <tr>
      
      <th scope=""col"">Name</th>
      <th scope=""col"">Chef</th>
      <th scope=""col"">Tastiness</th>
      <th scope=""col"">Calories</th>
    </tr>
  </thead>
  <tbody>
    
");
#nullable restore
#line 20 "/Users/yukon/Documents/codingDojo/CSharp/orm/chefsNDishes/Views/Home/Dishes.cshtml"
              
                foreach(Dish d in ViewBag.AllDishes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                    <td>");
#nullable restore
#line 24 "/Users/yukon/Documents/codingDojo/CSharp/orm/chefsNDishes/Views/Home/Dishes.cshtml"
                   Write(d.nameOfDish);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 25 "/Users/yukon/Documents/codingDojo/CSharp/orm/chefsNDishes/Views/Home/Dishes.cshtml"
                   Write(d.MyChef.chefFName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 25 "/Users/yukon/Documents/codingDojo/CSharp/orm/chefsNDishes/Views/Home/Dishes.cshtml"
                                        Write(d.MyChef.chefLName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 26 "/Users/yukon/Documents/codingDojo/CSharp/orm/chefsNDishes/Views/Home/Dishes.cshtml"
                   Write(d.tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 27 "/Users/yukon/Documents/codingDojo/CSharp/orm/chefsNDishes/Views/Home/Dishes.cshtml"
                   Write(d.numCals);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 29 "/Users/yukon/Documents/codingDojo/CSharp/orm/chefsNDishes/Views/Home/Dishes.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("          \n  </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
