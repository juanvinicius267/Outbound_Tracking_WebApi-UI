#pragma checksum "C:\Users\ssbjvq\source\repos\Br.Sa.Scania.TrackNTrace.Outbound.Maritimo\Br.Sa.Scania.TrackNTrace.Outbound.Maritimo\Views\TrackNTrace\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "931ae64f8029cecd99125dc859f378878aee55e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrackNTrace_Index), @"mvc.1.0.view", @"/Views/TrackNTrace/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TrackNTrace/Index.cshtml", typeof(AspNetCore.Views_TrackNTrace_Index))]
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
#line 2 "C:\Users\ssbjvq\source\repos\Br.Sa.Scania.TrackNTrace.Outbound.Maritimo\Br.Sa.Scania.TrackNTrace.Outbound.Maritimo\Views\_ViewImports.cshtml"
using Br.Sa.Scania.TrackNTrace.Outbound.Maritimo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931ae64f8029cecd99125dc859f378878aee55e9", @"/Views/TrackNTrace/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6945bfa9f475c2edcf5073fb9e397adf07618fe", @"/Views/_ViewImports.cshtml")]
    public class Views_TrackNTrace_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Views/Shared/Header.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/TrackNTrace/Logica_TrackNTrace.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 1251, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "931ae64f8029cecd99125dc859f378878aee55e94306", async() => {
                BeginContext(33, 65, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                EndContext();
                BeginContext(98, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "931ae64f8029cecd99125dc859f378878aee55e94755", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(138, 1133, true);
                WriteLiteral(@"
    <title>TrackNTrace</title>
    <meta content=""X-UA-Compatible"" http-equiv=""IE=edge"">
    <noscript><meta content=""0;url=https://static.scania.com/vendors/components/pure-js/nonJS-browsers/1.0.0/nonJS-browsers.html"" http-equiv=""refresh""></noscript>
    <script src=""https://static.scania.com/vendors/components/pure-js/browser-reject/1.0.0/js/browser-reject.js""></script>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Track&Trace - Outbound</title>
    <script src=""https://static.scania.com/build/global/3.5.3-1/js/corporate-ui.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/openlayers/4.6.5/ol-debug.js"" type=""text/javascript""></script>
    <script src=""https://cdn.polyfill.io/v2/polyfill.min.js?features=requestAnimationFrame,Element.prototype.classList,URL""></script>
    <link rel=""stylesheet"" href=""https://openlayers.org/en/v5.3.0/css/ol.css"" type=""text/css"">
    <script src=""https://cdn.polyf");
                WriteLiteral("ill.io/v2/polyfill.min.js?features=requestAnimationFrame,Element.prototype.classList,URL\"></script>\r\n\r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1278, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1280, 14515, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "931ae64f8029cecd99125dc859f378878aee55e98007", async() => {
                BeginContext(1286, 14432, true);
                WriteLiteral(@"

 
        <div class=""row"">

            <div class=""col-1 col-sm-1 col-md-1 col-lg-1 col-xl-1"" style=""background-color:white; min-height:500px"">
                <div class=""nav flex-column nav-pills"" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
                    <a class=""nav-link active"" id=""v-pills-home-tab"" data-toggle=""pill"" href=""#v-pills-home"" role=""tab"" aria-controls=""v-pills-home"" aria-selected=""true"">
                        <div class=""btn-group dropright"">
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" style=""background-color:white""><img src=""https://pngimage.net/wp-content/uploads/2018/06/lupa-de-pesquisa-png-7.png"" style="" width:20px; height:20px"" /></button>
                            <div class=""dropdown-menu"">
                                <input id=""searchEngineId"" type=""text"" placeholder=""Digite aqui..."" />
                            </div>
    ");
                WriteLiteral(@"                    </div>
                    </a>
                    <a class=""nav-link"" id=""v-pills-profile-tab"" data-toggle=""pill"" href=""#v-pills-profile"" role=""tab"" aria-controls=""v-pills-profile"" aria-selected=""false"">
                        <div class=""btn-group dropright"">
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" style=""background-color:white""><img src=""https://tracking.lomi.devtest.aws.scania.com/Pictures/redTruck.png"" style="" width:20px; height:20px"" /></button>
                            <div class=""dropdown-menu"" style=""height:200px; overflow:auto"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th scope=""col"">POP-ID</th>
                                            <th scope=""col"">MARKET</th>
                                      ");
                WriteLiteral(@"  </tr>
                                    </thead>
                                    <tbody class=""style-scope"" id=""tableTrucksDelayed""></tbody>
                                </table>
                            </div>
                        </div>
                    </a>
                    <a class=""nav-link"" id=""v-pills-messages-tab"" data-toggle=""pill"" href=""#v-pills-messages"" role=""tab"" aria-controls=""v-pills-messages"" aria-selected=""false"">
                        <div class=""btn-group dropright"">
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" style=""background-color:white""><img src=""https://tracking.lomi.devtest.aws.scania.com/Pictures/orangeTruck.png"" style="" width:20px; height:20px"" /></button>
                            <div class=""dropdown-menu"" style=""height:200px; overflow:auto"">
                                <table class=""table"">
                                   ");
                WriteLiteral(@" <thead>
                                        <tr>
                                            <th scope=""col"">POP-ID</th>
                                            <th scope=""col"">MARKET</th>
                                        </tr>
                                    </thead>
                                    <tbody class=""style-scope"" id=""tableTrucksOrange""></tbody>
                                </table>
                            </div>
                        </div>

                    </a>
                    <a class=""nav-link"" id=""v-pills-settings-tab"" data-toggle=""pill"" href=""#v-pills-settings"" role=""tab"" aria-controls=""v-pills-settings"" aria-selected=""false"">
                        <div class=""btn-group dropright"">
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" style=""background-color:white""><img src=""https://tracking.lomi.devtest.aws.scania.com/Pictures/green");
                WriteLiteral(@"Truck.png"" style="" width:20px; height:20px"" /></button>
                            <div class=""dropdown-menu"" style=""height:200px; overflow:auto"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th scope=""col"">POP-ID</th>
                                            <th scope=""col"">MARKET</th>                                         
                                        </tr>
                                    </thead>
                                    <tbody class=""style-scope"" id=""tableTrucksGreen""></tbody>
                                </table>
                            </div>
                        </div>

                    </a>
                    <a class=""nav-link"" id=""v-pills-settings-tab"" data-toggle=""pill"" href=""#v-pills-settings"" role=""tab"" aria-controls=""v-pills-settings"" aria-selected=""false"">
                        <div class=""b");
                WriteLiteral(@"tn-group dropright"">
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" style=""background-color:white""><img src=""https://tracking.lomi.devtest.aws.scania.com/Pictures/truck.png"" style="" width:20px; height:20px"" /></button>
                            <div class=""dropdown-menu"" style=""height:200px; overflow:auto"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th scope=""col"">POP-ID</th>
                                            <th scope=""col"">Track Number</th>
                                        </tr>
                                    </thead>
                                    <tbody class=""style-scope"" id=""tableItemsOnBoard""></tbody>
                                </table>
                            </div>
                        </div>

");
                WriteLiteral(@"                    </a>
                    <a class=""nav-link"" id=""v-pills-settings-tab"" data-toggle=""pill"" href=""#v-pills-settings"" role=""tab"" aria-controls=""v-pills-settings"" aria-selected=""false"">
                        <div class=""btn-group dropright"">
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" style=""background-color:white""><img src=""https://cdn2.iconfinder.com/data/icons/shipping-and-delivery-solid-collection/60/04_-_Shipping_and_Delivery_-_Solid_-_Failed_Delivery-512.png"" style="" width:25px; height:25px"" /></button>
                            <div class=""dropdown-menu"" style=""height:200px; overflow:auto"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th scope=""col"">ERRO LOCATION</th>                                            
          ");
                WriteLiteral(@"                                  <th scope=""col"">VESSEL</th>
                                        </tr>
                                    </thead>
                                    <tbody class=""style-scope"" id=""tableFailedTrucks""></tbody>
                                   
                                </table>
                            </div>
                        </div>

                    </a>
                    <a class=""nav-link"" id=""v-pills-settings-tab"" data-toggle=""pill"" href=""#v-pills-settings"" role=""tab"" aria-controls=""v-pills-settings"" aria-selected=""false"">
                        <div class=""btn-group dropright"">
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" style=""background-color:white""><img src=""https://i.imgur.com/mRCNbTr.png"" style="" width:25px; height:25px"" /></button>
                            <div class=""dropdown-menu"" style=""height:200px; overfl");
                WriteLiteral(@"ow:auto"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th scope=""col"">BATCH ID</th>
                                            <th scope=""col"">CHASSI</th>
                                            <th scope=""col"">VESSEL</th>
                                            
                                        </tr>
                                    </thead>
                                    <tbody class=""style-scope"" id=""tableItemsDelayed"">
                                        
                                    </tbody>
                                </table>
                            </div>
                        </div>

                    </a>
                    <a class=""nav-link"" id=""v-pills-settings-tab"" data-toggle=""pill"" href=""#v-pills-settings"" role=""tab"" aria-controls=""v-pills-settings"" aria-selected=""false"">
               ");
                WriteLiteral(@"         <div class=""btn-group dropright"">
                            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">FLOWS</button>
                            <div class=""dropdown-menu"" style=""height:200px; overflow:auto"">
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" value="""" id=""defaultCheck1"">
                                    <label class=""form-check-label"" for=""defaultCheck1"">
                                        OUTPERU
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" value="""" id=""defaultCheck1"">
                                    <label class=""form-check-label"" for=""defaultCheck1"">
                                        OUTARG
      ");
                WriteLiteral(@"                              </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" value="""" id=""defaultCheck1"">
                                    <label class=""form-check-label"" for=""defaultCheck1"">
                                        OUTCHI
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" value="""" id=""defaultCheck1"">
                                    <label class=""form-check-label"" for=""defaultCheck1"">
                                        OUTBOLI
                                    </label>
                                </div>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
            <");
                WriteLiteral(@"div class=""col-11 col-sm-11 col-md-11 col-lg-11 col-xl-11"">
                <div class=""row"">
                    <div class=""col-4 col-lg-4 col-sm-4 col-md-4 col-lg-4 col-xl-4""></div>
                    <div class=""col-1 col-lg-1 col-sm-1 col-md-1 col-lg-1 col-xl-1"">
                        <div style=""height:32px; color:darkblue; font-weight:bold"" id=""countTotal"" value=""0"">
                            Total: 0
                        </div>
                    </div>
                    <div class=""col-1 col-lg-1 col-sm-1 col-md-1 col-lg-1 col-xl-1"">
                        <div style=""height:32px; color:#60b269; font-weight:bold"" id=""countOk"">
                            Ok: 0
                        </div>
                    </div>
                    <div class=""col-2 col-lg-2 col-sm-2 col-md-2 col-lg-2 col-xl-2"">
                        <div style=""height:32px; color:#E35205; font-weight:bold"" id=""countMissInformation"">
                           Possible Delayed: 0
                   ");
                WriteLiteral(@"     </div>
                    </div>
                    <div class=""col-1 col-lg-1 col-sm-1 col-md-1 col-lg-1 col-xl-1"">
                        <div style=""height:32px; color:#D6001C; font-weight:bold"" id=""countDelay"">
                            Delayed: 0
                        </div>
                    </div>
                </div>
                <div id=""map"" style=""min-width:100%"">

                </div>

            </div>

        </div>
        <div id=""main-content"">
            <div class=""container-fluid"">
                <div class=""row style-scope "">
                    <div class=""col-sm-12 style-scope"">
                        <div class=""btn-toolbar style-scope"" id=""closeTable"">
                            <i class=""scania-icon-search-mobile md style-scopee pull-right""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-md-12 style-scope colapse-when-asked"" style="""">
                    <header c");
                WriteLiteral(@"lass=""c-page-header copyable style-scope "">
                        <div class=""row style-scope "" id=""listaInfoNavio"">
                            <div class=""col-sm-12 col-md-12 style-scope "" id=""listaInfoNavio"">
                            </div>
                        </div>
                    </header>
                </div>
                <div class=""row style-scope colapse-when-asked"">
                    <div class=""col-md-12 style-scope "" style=""width:1800px;height:400px ; overflow:auto"">
                        <div class=""table-responsive style-scope"" id=""tableVessel"">

                        </div>
                    </div>
                </div>
                <div class=""row style-scope colapse-when-asked"" style="""">
                    <div class=""col-md-6 style-scope"">
                        <div id=""mapMoreInfo"" class=""map"" style="""">
                        </div>

                        
                    </div>
                </div>
            </div>
       ");
                WriteLiteral(" </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n  \r\n    <script src=\"//code.jquery.com/jquery-3.4.1.min.js\"></script>\r\n    ");
                EndContext();
                BeginContext(15718, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "931ae64f8029cecd99125dc859f378878aee55e923851", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(15780, 8, true);
                WriteLiteral("\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(15795, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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