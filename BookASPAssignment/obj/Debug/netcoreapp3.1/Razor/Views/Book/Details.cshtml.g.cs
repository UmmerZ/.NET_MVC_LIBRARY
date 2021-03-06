#pragma checksum "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "072cf8021e20cd0fa95fc76184e5b10a1a9a0f36"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"072cf8021e20cd0fa95fc76184e5b10a1a9a0f36", @"/Views/Book/Details.cshtml")]
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p");
            BeginWriteAttribute("class", " class=\"", 89, "\"", 150, 2);
            WriteAttributeValue("", 97, "alert-", 97, 6, true);
#nullable restore
#line 9 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
WriteAttributeValue("", 103, ViewBag.Error != null ? "danger" : "success", 103, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                                                                 Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
    if (ViewBag.Error != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 13 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
             foreach (Exception e in ViewBag.Exception.ValidationExceptions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"alert-danger\">");
#nullable restore
#line 15 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                                     Write(e.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 18 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 22 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
 if (ViewBag.Book != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Book Details: </h1>\r\n");
            WriteLiteral("    <p>Book ID: ");
#nullable restore
#line 26 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
            Write(ViewBag.Book.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Title: ");
#nullable restore
#line 27 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
          Write(ViewBag.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Author: ");
#nullable restore
#line 28 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
           Write(ViewBag.Book.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Publication Date: ");
#nullable restore
#line 29 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                     Write(((DateTime)ViewBag.Book.PublicationDate).ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
     if (ViewBag.Book.Borrows.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<H1>Library Details</H1>\r\n");
#nullable restore
#line 33 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
        foreach (Borrow borrow in ViewBag.Book.Borrows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Checked Out Date: ");
#nullable restore
#line 35 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                             Write(((DateTime)borrow.CheckedOutDate).ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Due Date: ");
#nullable restore
#line 36 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                     Write(((DateTime)borrow.DueDate).ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("            <p>Returned Date: ");
#nullable restore
#line 38 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                          Write((borrow.ReturnedDate == null ? "Not Returned" : ((DateTime)borrow.ReturnedDate).ToLongDateString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Number of Extensions Given: ");
#nullable restore
#line 39 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                                       Write(borrow.ExtentionCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 40 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"

            if (borrow.ReturnedDate == null || borrow.ReturnedDate < DateTime.Now)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-dark\">This Book Cannot be Borrowed as it has not been returned yet!</div>\r\n");
#nullable restore
#line 44 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
            }
        }



#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1519, "\"", 1564, 2);
            WriteAttributeValue("", 1526, "/Book/Return?bookID=", 1526, 20, true);
#nullable restore
#line 48 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
WriteAttributeValue("", 1546, ViewBag.Book.ID, 1546, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Return Book</a>\r\n");
            WriteLiteral("        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1619, "\"", 1664, 2);
            WriteAttributeValue("", 1626, "/Book/Extend?bookID=", 1626, 20, true);
#nullable restore
#line 50 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
WriteAttributeValue("", 1646, ViewBag.Book.ID, 1646, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Extend Due Date</a>\r\n");
            WriteLiteral("        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1722, "\"", 1763, 2);
            WriteAttributeValue("", 1729, "/Book/Delete?id=", 1729, 16, true);
#nullable restore
#line 52 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
WriteAttributeValue("", 1745, ViewBag.Book.ID, 1745, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Book</a>\r\n");
#nullable restore
#line 53 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"



    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1846, "\"", 1897, 2);
            WriteAttributeValue("", 1853, "/Book/BorrowCreate?bookID=", 1853, 26, true);
#nullable restore
#line 59 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
WriteAttributeValue("", 1879, ViewBag.Book.ID, 1879, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Create Borrow</a>\r\n");
#nullable restore
#line 61 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
                                                                                                                              
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\write\source\repos\BookASPAssignment\BookASPAssignment\Views\Book\Details.cshtml"
     
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
