#pragma checksum "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08b537ed92acab1f15dd45125ba8cc86243e6f34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Officer_Create), @"mvc.1.0.view", @"/Views/Officer/Create.cshtml")]
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
#line 1 "D:\FitnessManagementSystem\Fitness\Fitness\Views\_ViewImports.cshtml"
using Fitness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FitnessManagementSystem\Fitness\Fitness\Views\_ViewImports.cshtml"
using Fitness.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b537ed92acab1f15dd45125ba8cc86243e6f34", @"/Views/Officer/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65067f5168b29dd9d623309be4e654a1b4da021", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Officer_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fitness.Models.Officer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
  

    IEnumerable<Sex> SexList = ViewData["SexList"] as IEnumerable<Sex>;
    IEnumerable<Role> RoleList = ViewData["RoleList"] as IEnumerable<Role>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n");
#nullable restore
#line 16 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"form-group col-md-6\">\r\n            <label class=\"font-weight-bold\">เลือกเพศ</label>\r\n            <select style=\"width:80%\" id=\"SexId\" name=\"SexId\" class=\"form-control\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08b537ed92acab1f15dd45125ba8cc86243e6f344490", async() => {
                WriteLiteral("------เลือก------");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 26 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
                 foreach(var s in SexList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08b537ed92acab1f15dd45125ba8cc86243e6f345961", async() => {
#nullable restore
#line 28 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
                                        Write(s.SexName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
                       WriteLiteral(s.SexId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>

        <div class=""form-group col-md-6"">
            <label class=""font-weight-bold"">เลือกบทบาทหน้าที่</label>
            <select style=""width:80%"" id=""RoleId"" name=""RoleId"" class=""form-control"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08b537ed92acab1f15dd45125ba8cc86243e6f348203", async() => {
                WriteLiteral("------เลือกบทบาทหน้าที่------");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
                 foreach (var r in RoleList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08b537ed92acab1f15dd45125ba8cc86243e6f349653", async() => {
#nullable restore
#line 39 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
                                         Write(r.RoleName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
                       WriteLiteral(r.RoleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 46 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.LabelFor(model => model.Officer_Id, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 47 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.TextBoxFor(model => model.Officer_Id, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 48 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Officer_Id, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 52 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.LabelFor(model => model.Firstname, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 53 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.TextBoxFor(model => model.Firstname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 54 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Firstname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 58 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.LabelFor(model => model.Lastname, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 59 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.TextBoxFor(model => model.Lastname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 60 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Lastname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 64 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.LabelFor(model => model.Username, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 65 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.TextBoxFor(model => model.Username, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 66 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 70 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.LabelFor(model => model.Password, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 71 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.TextBoxFor(model => model.Password, new { @class = "form-control", @ValueType = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 72 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 76 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.LabelFor(model => model.Phone_number, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 77 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.TextBoxFor(model => model.Phone_number, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 78 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
   Write(Html.ValidationMessageFor(model => model.Phone_number, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <!-- Add more form fields as needed -->\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n    </div>\r\n");
#nullable restore
#line 88 "D:\FitnessManagementSystem\Fitness\Fitness\Views\Officer\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script>
        $(""#select-emp,#select-emp2,#select-sex"").select({
            theme: 'classic',
            dropdownParent: $('#insertAddlineModal'),
        });

        function ClearOff() {
            $('#select-sex').val('');
        }

        function SaveOfficer(){
            Sex = $('#select-sex').val();

            if (Sex == """") {
                swal({
                    title: ""กรุณาเลือกเพศ"",
                    icon: ""error"",
                    button: ""ตกลง""
                })
                return false
            }

            $.ajax({
                url: '/Officer/SaveOfficer',
                //data: {
                //    id: id,
                //    UserID: emp2,
                //    Fname: empname,
                //    Agency: agency,
                //    Position: position,
                //    ID_AD: AD,
                //    DocNo: DocNo,

                //},
                type: 'POST',
                dataType: 'JSON',
     ");
                WriteLiteral(@"           success: function (res) {
                    console.log(res.data)
                    if (res.success) {
                        swal({
                            title: ""สำเร็จ!"",
                            text: res.message,
                            icon: ""success"",
                            button: ""ตกลง"",
                        });

                        itemTable.ajax.reload();
                        Clearemp();

                    } else {
                        swal({
                            title: ""บันทึกไม่สำเร็จ!"",
                            text: res.message,
                            icon: ""error"",
                            button: ""ตกลง"",
                        });
                    }
                },
                failure: function (response) {
                    swal({
                        title: ""ไม่สำเร็จ!"",
                        text: ""กรุณากรอกใหม่อีกครั้ง"",
                        icon: ""error"",
                    ");
                WriteLiteral("    button: \"ตกลง\",\r\n                    });\r\n                }\r\n            })\r\n        }\r\n\r\n\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fitness.Models.Officer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591