#pragma checksum "C:\Users\ssbjvq\source\repos\Br.Sa.Scania.TrackNTrace.Outbound.Maritimo\Br.Sa.Scania.TrackNTrace.Outbound.Maritimo\Views\CadastroDeNavios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3484b744d9e34e67f71cdfdad65ce7be75abeadf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CadastroDeNavios_Index), @"mvc.1.0.view", @"/Views/CadastroDeNavios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CadastroDeNavios/Index.cshtml", typeof(AspNetCore.Views_CadastroDeNavios_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3484b744d9e34e67f71cdfdad65ce7be75abeadf", @"/Views/CadastroDeNavios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6945bfa9f475c2edcf5073fb9e397adf07618fe", @"/Views/_ViewImports.cshtml")]
    public class Views_CadastroDeNavios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CadastroDeNavios/Logica_CadastroDeNavios.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 25155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3484b744d9e34e67f71cdfdad65ce7be75abeadf3859", async() => {
                BeginContext(43, 25058, true);
                WriteLiteral(@"
    <section >
        <div class=""container"">
            <div class=""row"">
                <div class=""col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6"">

                    <div class="""">
                        <label for=""Nome do navio"">Nome do navio</label>
                        <input id=""Name"" type=""text"" class=""form-control"" placeholder=""Nome do navio"">
                    </div>
                    <div class="""">
                        <label for=""Numero de IMO"">Numero de IMO</label>
                        <input id=""Imo"" type=""number"" class=""form-control"" placeholder=""Numero de IMO"">
                    </div>
                    <div class="""">
                        <label for=""Numero de MMSI"">Numero de MMSI</label>
                        <input id=""Mmsi"" type=""number"" class=""form-control"" placeholder=""Numero de MMSI"">
                    </div>
                    <div class="""">
                        <label for=""Indicativo"">Indicativo</label>
                        <input ");
                WriteLiteral(@"id=""Indicative"" type=""text"" class=""form-control"" placeholder=""Indicativo"">
                    </div>
                    <div class="""">
                        <label for=""Bandeira"">Bandeira</label>
                        <form action=""/action_page.php"">
                            <select id=""Flag"" class=""form-control"">

                                <option value=""Afghanistan"">Afghanistan</option>
                                <option value=""Åland Islands"">Åland Islands</option>
                                <option value=""Albania"">Albania</option>
                                <option value=""Algeria"">Algeria</option>
                                <option value=""American Samoa"">American Samoa</option>
                                <option value=""Andorra"">Andorra</option>
                                <option value=""Angola"">Angola</option>
                                <option value=""Anguilla"">Anguilla</option>
                                <option value=""Antarctica"">Antarc");
                WriteLiteral(@"tica</option>
                                <option value=""Antigua and Barbuda"">Antigua and Barbuda</option>
                                <option value=""Argentina"">Argentina</option>
                                <option value=""Armenia"">Armenia</option>
                                <option value=""Aruba"">Aruba</option>
                                <option value=""Australia"">Australia</option>
                                <option value=""Austria"">Austria</option>
                                <option value=""Azerbaijan"">Azerbaijan</option>
                                <option value=""Bahamas"">Bahamas</option>
                                <option value=""Bahrain"">Bahrain</option>
                                <option value=""Bangladesh"">Bangladesh</option>
                                <option value=""Barbados"">Barbados</option>
                                <option value=""Belarus"">Belarus</option>
                                <option value=""Belgium"">Belgium</option>
     ");
                WriteLiteral(@"                           <option value=""Belize"">Belize</option>
                                <option value=""Benin"">Benin</option>
                                <option value=""Bermuda"">Bermuda</option>
                                <option value=""Bhutan"">Bhutan</option>
                                <option value=""Bolivia"">Bolivia</option>
                                <option value=""Bosnia and Herzegovina"">Bosnia and Herzegovina</option>
                                <option value=""Botswana"">Botswana</option>
                                <option value=""Bouvet Island"">Bouvet Island</option>
                                <option value=""Brazil"">Brazil</option>
                                <option value=""British Indian Ocean Territory"">British Indian Ocean Territory</option>
                                <option value=""Brunei Darussalam"">Brunei Darussalam</option>
                                <option value=""Bulgaria"">Bulgaria</option>
                                <option");
                WriteLiteral(@" value=""Burkina Faso"">Burkina Faso</option>
                                <option value=""Burundi"">Burundi</option>
                                <option value=""Cambodia"">Cambodia</option>
                                <option value=""Cameroon"">Cameroon</option>
                                <option value=""Canada"">Canada</option>
                                <option value=""Cape Verde"">Cape Verde</option>
                                <option value=""Cayman Islands"">Cayman Islands</option>
                                <option value=""Central African Republic"">Central African Republic</option>
                                <option value=""Chad"">Chad</option>
                                <option value=""Chile"">Chile</option>
                                <option value=""China"">China</option>
                                <option value=""Christmas Island"">Christmas Island</option>
                                <option value=""Cocos (Keeling) Islands"">Cocos (Keeling) Islands</option>
                WriteLiteral(@"
                                <option value=""Colombia"">Colombia</option>
                                <option value=""Comoros"">Comoros</option>
                                <option value=""Congo"">Congo</option>
                                <option value=""Congo, The Democratic Republic of The"">Congo, The Democratic Republic of The</option>
                                <option value=""Cook Islands"">Cook Islands</option>
                                <option value=""Costa Rica"">Costa Rica</option>
                                <option value=""Cote D'ivoire"">Cote D'ivoire</option>
                                <option value=""Croatia"">Croatia</option>
                                <option value=""Cuba"">Cuba</option>
                                <option value=""Cyprus"">Cyprus</option>
                                <option value=""Czech Republic"">Czech Republic</option>
                                <option value=""Denmark"">Denmark</option>
                                <option val");
                WriteLiteral(@"ue=""Djibouti"">Djibouti</option>
                                <option value=""Dominica"">Dominica</option>
                                <option value=""Dominican Republic"">Dominican Republic</option>
                                <option value=""Ecuador"">Ecuador</option>
                                <option value=""Egypt"">Egypt</option>
                                <option value=""El Salvador"">El Salvador</option>
                                <option value=""Equatorial Guinea"">Equatorial Guinea</option>
                                <option value=""Eritrea"">Eritrea</option>
                                <option value=""Estonia"">Estonia</option>
                                <option value=""Ethiopia"">Ethiopia</option>
                                <option value=""Falkland Islands (Malvinas)"">Falkland Islands (Malvinas)</option>
                                <option value=""Faroe Islands"">Faroe Islands</option>
                                <option value=""Fiji"">Fiji</option>
       ");
                WriteLiteral(@"                         <option value=""Finland"">Finland</option>
                                <option value=""France"">France</option>
                                <option value=""French Guiana"">French Guiana</option>
                                <option value=""French Polynesia"">French Polynesia</option>
                                <option value=""French Southern Territories"">French Southern Territories</option>
                                <option value=""Gabon"">Gabon</option>
                                <option value=""Gambia"">Gambia</option>
                                <option value=""Georgia"">Georgia</option>
                                <option value=""Germany"">Germany</option>
                                <option value=""Ghana"">Ghana</option>
                                <option value=""Gibraltar"">Gibraltar</option>
                                <option value=""Greece"">Greece</option>
                                <option value=""Greenland"">Greenland</option>
     ");
                WriteLiteral(@"                           <option value=""Grenada"">Grenada</option>
                                <option value=""Guadeloupe"">Guadeloupe</option>
                                <option value=""Guam"">Guam</option>
                                <option value=""Guatemala"">Guatemala</option>
                                <option value=""Guernsey"">Guernsey</option>
                                <option value=""Guinea"">Guinea</option>
                                <option value=""Guinea-bissau"">Guinea-bissau</option>
                                <option value=""Guyana"">Guyana</option>
                                <option value=""Haiti"">Haiti</option>
                                <option value=""Heard Island and Mcdonald Islands"">Heard Island and Mcdonald Islands</option>
                                <option value=""Holy See (Vatican City State)"">Holy See (Vatican City State)</option>
                                <option value=""Honduras"">Honduras</option>
                                <");
                WriteLiteral(@"option value=""Hong Kong"">Hong Kong</option>
                                <option value=""Hungary"">Hungary</option>
                                <option value=""Iceland"">Iceland</option>
                                <option value=""India"">India</option>
                                <option value=""Indonesia"">Indonesia</option>
                                <option value=""Iran, Islamic Republic of"">Iran, Islamic Republic of</option>
                                <option value=""Iraq"">Iraq</option>
                                <option value=""Ireland"">Ireland</option>
                                <option value=""Isle of Man"">Isle of Man</option>
                                <option value=""Israel"">Israel</option>
                                <option value=""Italy"">Italy</option>
                                <option value=""Jamaica"">Jamaica</option>
                                <option value=""Japan"">Japan</option>
                                <option value=""Jersey"">Jersey</");
                WriteLiteral(@"option>
                                <option value=""Jordan"">Jordan</option>
                                <option value=""Kazakhstan"">Kazakhstan</option>
                                <option value=""Kenya"">Kenya</option>
                                <option value=""Kiribati"">Kiribati</option>
                                <option value=""Korea, Democratic People's Republic of"">Korea, Democratic People's Republic of</option>
                                <option value=""Korea, Republic of"">Korea, Republic of</option>
                                <option value=""Kuwait"">Kuwait</option>
                                <option value=""Kyrgyzstan"">Kyrgyzstan</option>
                                <option value=""Lao People's Democratic Republic"">Lao People's Democratic Republic</option>
                                <option value=""Latvia"">Latvia</option>
                                <option value=""Lebanon"">Lebanon</option>
                                <option value=""Lesotho"">Lesotho");
                WriteLiteral(@"</option>
                                <option value=""Liberia"">Liberia</option>
                                <option value=""Libyan Arab Jamahiriya"">Libyan Arab Jamahiriya</option>
                                <option value=""Liechtenstein"">Liechtenstein</option>
                                <option value=""Lithuania"">Lithuania</option>
                                <option value=""Luxembourg"">Luxembourg</option>
                                <option value=""Macao"">Macao</option>
                                <option value=""Macedonia, The Former Yugoslav Republic of"">Macedonia, The Former Yugoslav Republic of</option>
                                <option value=""Madagascar"">Madagascar</option>
                                <option value=""Malawi"">Malawi</option>
                                <option value=""Malaysia"">Malaysia</option>
                                <option value=""Maldives"">Maldives</option>
                                <option value=""Mali"">Mali</option>
     ");
                WriteLiteral(@"                           <option value=""Malta"">Malta</option>
                                <option value=""Marshall Islands"">Marshall Islands</option>
                                <option value=""Martinique"">Martinique</option>
                                <option value=""Mauritania"">Mauritania</option>
                                <option value=""Mauritius"">Mauritius</option>
                                <option value=""Mayotte"">Mayotte</option>
                                <option value=""Mexico"">Mexico</option>
                                <option value=""Micronesia, Federated States of"">Micronesia, Federated States of</option>
                                <option value=""Moldova, Republic of"">Moldova, Republic of</option>
                                <option value=""Monaco"">Monaco</option>
                                <option value=""Mongolia"">Mongolia</option>
                                <option value=""Montenegro"">Montenegro</option>
                                <");
                WriteLiteral(@"option value=""Montserrat"">Montserrat</option>
                                <option value=""Morocco"">Morocco</option>
                                <option value=""Mozambique"">Mozambique</option>
                                <option value=""Myanmar"">Myanmar</option>
                                <option value=""Namibia"">Namibia</option>
                                <option value=""Nauru"">Nauru</option>
                                <option value=""Nepal"">Nepal</option>
                                <option value=""Netherlands"">Netherlands</option>
                                <option value=""Netherlands Antilles"">Netherlands Antilles</option>
                                <option value=""New Caledonia"">New Caledonia</option>
                                <option value=""New Zealand"">New Zealand</option>
                                <option value=""Nicaragua"">Nicaragua</option>
                                <option value=""Niger"">Niger</option>
                                <opti");
                WriteLiteral(@"on value=""Nigeria"">Nigeria</option>
                                <option value=""Niue"">Niue</option>
                                <option value=""Norfolk Island"">Norfolk Island</option>
                                <option value=""Northern Mariana Islands"">Northern Mariana Islands</option>
                                <option value=""Norway"">Norway</option>
                                <option value=""Oman"">Oman</option>
                                <option value=""Pakistan"">Pakistan</option>
                                <option value=""Palau"">Palau</option>
                                <option value=""Palestinian Territory, Occupied"">Palestinian Territory, Occupied</option>
                                <option value=""Panama"">Panama</option>
                                <option value=""Papua New Guinea"">Papua New Guinea</option>
                                <option value=""Paraguay"">Paraguay</option>
                                <option value=""Peru"">Peru</option>
       ");
                WriteLiteral(@"                         <option value=""Philippines"">Philippines</option>
                                <option value=""Pitcairn"">Pitcairn</option>
                                <option value=""Poland"">Poland</option>
                                <option value=""Portugal"">Portugal</option>
                                <option value=""Puerto Rico"">Puerto Rico</option>
                                <option value=""Qatar"">Qatar</option>
                                <option value=""Reunion"">Reunion</option>
                                <option value=""Romania"">Romania</option>
                                <option value=""Russian Federation"">Russian Federation</option>
                                <option value=""Rwanda"">Rwanda</option>
                                <option value=""Saint Helena"">Saint Helena</option>
                                <option value=""Saint Kitts and Nevis"">Saint Kitts and Nevis</option>
                                <option value=""Saint Lucia"">Saint Lucia");
                WriteLiteral(@"</option>
                                <option value=""Saint Pierre and Miquelon"">Saint Pierre and Miquelon</option>
                                <option value=""Saint Vincent and The Grenadines"">Saint Vincent and The Grenadines</option>
                                <option value=""Samoa"">Samoa</option>
                                <option value=""San Marino"">San Marino</option>
                                <option value=""Sao Tome and Principe"">Sao Tome and Principe</option>
                                <option value=""Saudi Arabia"">Saudi Arabia</option>
                                <option value=""Senegal"">Senegal</option>
                                <option value=""Serbia"">Serbia</option>
                                <option value=""Seychelles"">Seychelles</option>
                                <option value=""Sierra Leone"">Sierra Leone</option>
                                <option value=""Singapore"">Singapore</option>
                                <option value=""Slovakia");
                WriteLiteral(@""">Slovakia</option>
                                <option value=""Slovenia"">Slovenia</option>
                                <option value=""Solomon Islands"">Solomon Islands</option>
                                <option value=""Somalia"">Somalia</option>
                                <option value=""South Africa"">South Africa</option>
                                <option value=""South Georgia and The South Sandwich Islands"">South Georgia and The South Sandwich Islands</option>
                                <option value=""Spain"">Spain</option>
                                <option value=""Sri Lanka"">Sri Lanka</option>
                                <option value=""Sudan"">Sudan</option>
                                <option value=""Suriname"">Suriname</option>
                                <option value=""Svalbard and Jan Mayen"">Svalbard and Jan Mayen</option>
                                <option value=""Swaziland"">Swaziland</option>
                                <option value=""Sweden"">");
                WriteLiteral(@"Sweden</option>
                                <option value=""Switzerland"">Switzerland</option>
                                <option value=""Syrian Arab Republic"">Syrian Arab Republic</option>
                                <option value=""Taiwan, Province of China"">Taiwan, Province of China</option>
                                <option value=""Tajikistan"">Tajikistan</option>
                                <option value=""Tanzania, United Republic of"">Tanzania, United Republic of</option>
                                <option value=""Thailand"">Thailand</option>
                                <option value=""Timor-leste"">Timor-leste</option>
                                <option value=""Togo"">Togo</option>
                                <option value=""Tokelau"">Tokelau</option>
                                <option value=""Tonga"">Tonga</option>
                                <option value=""Trinidad and Tobago"">Trinidad and Tobago</option>
                                <option value=""Tuni");
                WriteLiteral(@"sia"">Tunisia</option>
                                <option value=""Turkey"">Turkey</option>
                                <option value=""Turkmenistan"">Turkmenistan</option>
                                <option value=""Turks and Caicos Islands"">Turks and Caicos Islands</option>
                                <option value=""Tuvalu"">Tuvalu</option>
                                <option value=""Uganda"">Uganda</option>
                                <option value=""Ukraine"">Ukraine</option>
                                <option value=""United Arab Emirates"">United Arab Emirates</option>
                                <option value=""United Kingdom"">United Kingdom</option>
                                <option value=""United States"">United States</option>
                                <option value=""United States Minor Outlying Islands"">United States Minor Outlying Islands</option>
                                <option value=""Uruguay"">Uruguay</option>
                                <option");
                WriteLiteral(@" value=""Uzbekistan"">Uzbekistan</option>
                                <option value=""Vanuatu"">Vanuatu</option>
                                <option value=""Venezuela"">Venezuela</option>
                                <option value=""Viet Nam"">Viet Nam</option>
                                <option value=""Virgin Islands, British"">Virgin Islands, British</option>
                                <option value=""Virgin Islands, U.S."">Virgin Islands, U.S.</option>
                                <option value=""Wallis and Futuna"">Wallis and Futuna</option>
                                <option value=""Western Sahara"">Western Sahara</option>
                                <option value=""Yemen"">Yemen</option>
                                <option value=""Zambia"">Zambia</option>
                                <option value=""Zimbabwe"">Zimbabwe</option>

                            </select>
                        </form>
                    </div>
                </div>
                <div cl");
                WriteLiteral(@"ass=""col-6 col-sm-6 col-md-6 col-lg-6 col-xl-6"">
                    <div class="""">
                        <label for=""Tipo do Navio"">Tipo do Navio</label>
                        <select id=""AisVesselType"" class=""form-control"">
                            <option value=""Ro-ro"">Ro-ro</option>
                            <option value=""CargoVessel"">Cargo Vessel</option>
                            <option value=""ContainerShip"">Container Ship </option>
                            <option value=""Tankers"">Tankers</option>
                            <option value=""UnspecifiedShips"">Unspecified Ships</option>
                        </select>
                    </div>
                    <div class="""">
                        <label for=""Capacidade"">Capacidade</label>
                        <input id=""Capacity"" type=""text"" class=""form-control"" placeholder=""Capacidade"">
                    </div>
                    <div class="""">
                        <label for=""Tamanho do Navio"">Tamanho do N");
                WriteLiteral(@"avio</label>
                        <input id=""VesselSize"" type=""text"" class=""form-control"" placeholder=""Tamanho do Navio"">
                    </div>
                    <div class="""">
                        <label for=""Ano de Fabricação"">Ano de Fabricação</label>
                        <input id=""Year"" type=""text"" class=""form-control"" placeholder=""Ano de Fabricação"">
                    </div>
                    <div class="""">
                        <label for=""Estado"">Estado</label>
                        <select id=""State"" class=""form-control"">
                            <option value=""On"">On</option>
                            <option value=""Off"">Off</option>
                        </select>
                    </div>
                </div>
            </div>
            <br />
            <input type=""button"" value=""Enviar"" id=""buttonSend"" class=""btn btn-success"" />
            <br />
            <hr />
        </div>
        <div class=""container-fluid"" style=""height:500px");
                WriteLiteral(@"; overflow:auto"">
            <table id=""myTable"" class=""table table-striped table-clickable table-panel copyable style-scope"">
                <thead class=""style-scope "">

                    <tr>
                        <th>Nome do navio</th>
                        <th>Numero de IMO</th>
                        <th>Numero de MMSI</th>
                        <th>Indicativo</th>
                        <th>Bandeira</th>
                        <th>Tipo do Navio</th>
                        <th>Capacidade</th>
                        <th>Tamanho do Navio</th>
                        <th>Ano de Fabricação</th>
                        <th>Estado</th>
                    </tr>
                </thead>
                <tr>
                    <td id=""NavioNome""></td>
                    <td id=""NavioImo""></td>
                    <td id=""NavioMmsi""></td>
                    <td id=""NavioIndicativo""></td>
                    <td id=""NavioBandeira""></td>
                    <td id=""NavioTip");
                WriteLiteral(@"o""></td>
                    <td id=""NavioCapacidade""></td>
                    <td id=""NavioTamanho""></td>
                    <td id=""NavioAno""></td>
                    <td id=""NavioEstado""></td>
                </tr>

            </table>
        </div>
    </section>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/openlayers/4.6.5/ol-debug.js"" type=""text/javascript""></script>
    <script src=""https://code.jquery.com/jquery-2.2.3.min.js""></script>
    ");
                EndContext();
                BeginContext(25101, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3484b744d9e34e67f71cdfdad65ce7be75abeadf30828", async() => {
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
                BeginContext(25173, 12, true);
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
            BeginContext(25192, 9, true);
            WriteLiteral("\r\n</html>");
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