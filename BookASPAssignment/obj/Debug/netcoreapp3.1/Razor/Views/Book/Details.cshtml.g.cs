#pragma checksum "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfc2071c8c23b7d3a8c471c07b002c81b5d85722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
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
#line 1 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\_ViewImports.cshtml"
using BookASPAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\_ViewImports.cshtml"
using BookASPAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfc2071c8c23b7d3a8c471c07b002c81b5d85722", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63e8d3f87da9bc3d3441024de92f3a815ba5e4dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
 if (ViewBag.Book != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Book Details: </h1>\r\n");
            WriteLiteral("    <p>Book ID: ");
#nullable restore
#line 13 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
            Write(ViewBag.Book.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Title: ");
#nullable restore
#line 14 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
          Write(ViewBag.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Author: ");
#nullable restore
#line 15 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
           Write(ViewBag.Book.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Publication Date: ");
#nullable restore
#line 16 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                     Write(((DateTime)ViewBag.Book.PublicationDate).ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
     if (ViewBag.Book.Borrows.Count > 0)
    {
        foreach (Borrow borrow in ViewBag.Book.Borrows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Checked Out Date: ");
#nullable restore
#line 22 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                             Write(((DateTime)borrow.CheckedOutDate).ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Due Date: ");
#nullable restore
#line 23 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                     Write(((DateTime)borrow.DueDate).ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("            <p>Returned Date: ");
#nullable restore
#line 25 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                          Write((borrow.ReturnedDate == null ? "Not Returned" : ((DateTime)borrow.ReturnedDate).ToLongDateString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Number of Extensions Given: ");
#nullable restore
#line 26 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                                       Write(borrow.ExtentionCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 27 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
        }



#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 891, "\"", 936, 2);
            WriteAttributeValue("", 898, "/Book/Return?bookID=", 898, 20, true);
#nullable restore
#line 30 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
WriteAttributeValue("", 918, ViewBag.Book.ID, 918, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Return Book</a>\r\n");
            WriteLiteral("        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 991, "\"", 1036, 2);
            WriteAttributeValue("", 998, "/Book/Extend?bookID=", 998, 20, true);
#nullable restore
#line 32 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
WriteAttributeValue("", 1018, ViewBag.Book.ID, 1018, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Extend Due Date</a>\r\n");
            WriteLiteral("        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1094, "\"", 1135, 2);
            WriteAttributeValue("", 1101, "/Book/Delete?id=", 1101, 16, true);
#nullable restore
#line 34 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
WriteAttributeValue("", 1117, ViewBag.Book.ID, 1117, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Book</a>\r\n");
#nullable restore
#line 35 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"



    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1218, "\"", 1263, 2);
            WriteAttributeValue("", 1225, "/Book/Borrow?bookID=", 1225, 20, true);
#nullable restore
#line 41 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
WriteAttributeValue("", 1245, ViewBag.Book.ID, 1245, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Create Borrow</a>\r\n");
#nullable restore
#line 43 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                                                                                                                              
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
