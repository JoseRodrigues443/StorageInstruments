#pragma checksum "C:\Users\Helder\source\repos\StorageInstruments\StorageInstruments\Pages\Instruments\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1607ae6117054361de8e8b32e994774b6e16c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StorageInstruments.Pages.Instruments.Pages_Instruments_List), @"mvc.1.0.razor-page", @"/Pages/Instruments/List.cshtml")]
namespace StorageInstruments.Pages.Instruments
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
#line 1 "C:\Users\Helder\source\repos\StorageInstruments\StorageInstruments\Pages\_ViewImports.cshtml"
using StorageInstruments;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1607ae6117054361de8e8b32e994774b6e16c3f", @"/Pages/Instruments/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"535047857f6056fffd90559582d5c2aaf931e39c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Instruments_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Helder\source\repos\StorageInstruments\StorageInstruments\Pages\Instruments\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Helder\source\repos\StorageInstruments\StorageInstruments\Pages\Instruments\List.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StorageInstruments.Pages.Instruments.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StorageInstruments.Pages.Instruments.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StorageInstruments.Pages.Instruments.ListModel>)PageContext?.ViewData;
        public StorageInstruments.Pages.Instruments.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
