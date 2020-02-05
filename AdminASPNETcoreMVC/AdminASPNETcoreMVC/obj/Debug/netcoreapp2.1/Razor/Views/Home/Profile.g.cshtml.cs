#pragma checksum "c:\users\roua abid\source\repos\AdminASPNETcoreMVC\AdminASPNETcoreMVC\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fb65d8aad001b9b538a4e665e3b2b71bef47b9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
#line 1 "c:\users\roua abid\source\repos\AdminASPNETcoreMVC\AdminASPNETcoreMVC\Views\_ViewImports.cshtml"
using AdminASPNETcoreMVC;

#line default
#line hidden
#line 2 "c:\users\roua abid\source\repos\AdminASPNETcoreMVC\AdminASPNETcoreMVC\Views\_ViewImports.cshtml"
using AdminASPNETcoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb65d8aad001b9b538a4e665e3b2b71bef47b9d", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bd3f8480954f5979ce62b3cce6f2e9965756c44", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "c:\users\roua abid\source\repos\AdminASPNETcoreMVC\AdminASPNETcoreMVC\Views\Home\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(45, 9107, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Profile</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">User Profile</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <!-- Profile Image -->
                    <div class=""card card-primary card-outline"">
                    ");
            WriteLiteral(@"    <div class=""card-body box-profile"">
                            <div class=""text-center"">
                                <img class=""profile-user-img img-fluid img-circle""
                                     src=""../theme/dist/img/user4-128x128.jpg""
                                     alt=""User profile picture"">
                            </div>
                            <h3 class=""profile-username text-center"">Nina Mcintire</h3>
                            <p class=""text-muted text-center"">Software Engineer</p>
                            <ul class=""list-group list-group-unbordered mb-3"">
                                <li class=""list-group-item"">
                                    <b>Followers</b> <a class=""float-right"">1,322</a>
                                </li>
                                <li class=""list-group-item"">
                                    <b>Following</b> <a class=""float-right"">543</a>
                                </li>
                                <l");
            WriteLiteral(@"i class=""list-group-item"">
                                    <b>Friends</b> <a class=""float-right"">13,287</a>
                                </li>
                            </ul>
                            <a href=""#"" class=""btn btn-primary btn-block""><b>Follow</b></a>
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                    <!-- About Me Box -->
                    <div class=""card card-primary"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">About Me</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class=""card-body"">
                            <strong><i class=""fas fa-book mr-1""></i> Education</strong>
                            <p class=""text-muted"">
                                B.S. in Computer Science from the University of Tennessee at Knoxville
             ");
            WriteLiteral(@"               </p>
                            <hr>
                            <strong><i class=""fas fa-map-marker-alt mr-1""></i> Location</strong>
                            <p class=""text-muted"">Malibu, California</p>
                            <hr>
                            <strong><i class=""fas fa-pencil-alt mr-1""></i> Skills</strong>
                            <p class=""text-muted"">
                                <span class=""tag tag-danger"">UI Design</span>
                                <span class=""tag tag-success"">Coding</span>
                                <span class=""tag tag-info"">Javascript</span>
                                <span class=""tag tag-warning"">PHP</span>
                                <span class=""tag tag-primary"">Node.js</span>
                            </p>
                            <hr>
                            <strong><i class=""far fa-file-alt mr-1""></i> Notes</strong>
                            <p class=""text-muted"">Lorem ipsum dolor sit amet");
            WriteLiteral(@", consectetur adipiscing elit. Etiam fermentum enim neque.</p>
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!-- /.col -->
                <div class=""col-md-9"">
                    <div class=""card"">
                        <div class=""card-header p-2"">
                            <ul class=""nav nav-pills"">
                                <li class=""nav-item""><a class=""nav-link active"" href=""#activity"" data-toggle=""tab"">Activity</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""#timeline"" data-toggle=""tab"">Timeline</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""#settings"" data-toggle=""tab"">Settings</a></li>
                            </ul>
                        </div><!-- /.card-header -->
                        <div class=""card-body"">
                            <div class=""tab-");
            WriteLiteral(@"content"">
                                <div class=""active tab-pane"" id=""activity"">
                                    <!-- Post -->
                                    <div class=""post"">
                                        <div class=""user-block"">
                                            <img class=""img-circle img-bordered-sm"" src=""../theme/dist/img/user1-128x128.jpg"" alt=""user image"">
                                            <span class=""username"">
                                                <a href=""#"">Jonathan Burke Jr.</a>
                                                <a href=""#"" class=""float-right btn-tool""><i class=""fas fa-times""></i></a>
                                            </span>
                                            <span class=""description"">Shared publicly - 7:30 PM today</span>
                                        </div>
                                        <!-- /.user-block -->
                                        <p>
                       ");
            WriteLiteral(@"                     Lorem ipsum represents a long-held tradition for designers,
                                            typographers and the like. Some people hate it and argue for
                                            its demise, but others ignore the hate as they create awesome
                                            tools to help create filler text for everyone from bacon lovers
                                            to Charlie Sheen fans.
                                        </p>
                                        <p>
                                            <a href=""#"" class=""link-black text-sm mr-2""><i class=""fas fa-share mr-1""></i> Share</a>
                                            <a href=""#"" class=""link-black text-sm""><i class=""far fa-thumbs-up mr-1""></i> Like</a>
                                            <span class=""float-right"">
                                                <a href=""#"" class=""link-black text-sm"">
                                    ");
            WriteLiteral(@"                <i class=""far fa-comments mr-1""></i> Comments (5)
                                                </a>
                                            </span>
                                        </p>
                                        <input class=""form-control form-control-sm"" type=""text"" placeholder=""Type a comment"">
                                    </div>
                                    <!-- /.post -->
                                    <!-- Post -->
                                    <div class=""post clearfix"">
                                        <div class=""user-block"">
                                            <img class=""img-circle img-bordered-sm"" src=""../theme/dist/img/user7-128x128.jpg"" alt=""User Image"">
                                            <span class=""username"">
                                                <a href=""#"">Sarah Ross</a>
                                                <a href=""#"" class=""float-right btn-tool""><i class=""fas fa-ti");
            WriteLiteral(@"mes""></i></a>
                                            </span>
                                            <span class=""description"">Sent you a message - 3 days ago</span>
                                        </div>
                                        <!-- /.user-block -->
                                        <p>
                                            Lorem ipsum represents a long-held tradition for designers,
                                            typographers and the like. Some people hate it and argue for
                                            its demise, but others ignore the hate as they create awesome
                                            tools to help create filler text for everyone from bacon lovers
                                            to Charlie Sheen fans.
                                        </p>
                                        ");
            EndContext();
            BeginContext(9152, 589, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b7e706dbc094ebfb970fb12340160f4", async() => {
                BeginContext(9182, 552, true);
                WriteLiteral(@"
                                            <div class=""input-group input-group-sm mb-0"">
                                                <input class=""form-control form-control-sm"" placeholder=""Response"">
                                                <div class=""input-group-append"">
                                                    <button type=""submit"" class=""btn btn-danger"">Send</button>
                                                </div>
                                            </div>
                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9741, 10241, true);
            WriteLiteral(@"
                                    </div>
                                    <!-- /.post -->
                                    <!-- Post -->
                                    <div class=""post"">
                                        <div class=""user-block"">
                                            <img class=""img-circle img-bordered-sm"" src=""../theme/dist/img/user6-128x128.jpg"" alt=""User Image"">
                                            <span class=""username"">
                                                <a href=""#"">Adam Jones</a>
                                                <a href=""#"" class=""float-right btn-tool""><i class=""fas fa-times""></i></a>
                                            </span>
                                            <span class=""description"">Posted 5 photos - 5 days ago</span>
                                        </div>
                                        <!-- /.user-block -->
                                        <div class=""row mb-3"">
    ");
            WriteLiteral(@"                                        <div class=""col-sm-6"">
                                                <img class=""img-fluid"" src=""../theme/dist/img/photo1.png"" alt=""Photo"">
                                            </div>
                                            <!-- /.col -->
                                            <div class=""col-sm-6"">
                                                <div class=""row"">
                                                    <div class=""col-sm-6"">
                                                        <img class=""img-fluid mb-3"" src=""../theme/dist/img/photo2.png"" alt=""Photo"">
                                                        <img class=""img-fluid"" src=""../../dist/img/photo3.jpg"" alt=""Photo"">
                                                    </div>
                                                    <!-- /.col -->
                                                    <div class=""col-sm-6"">
                                                       ");
            WriteLiteral(@" <img class=""img-fluid mb-3"" src=""../theme/dist/img/photo4.jpg"" alt=""Photo"">
                                                        <img class=""img-fluid"" src=""../theme/dist/img/photo1.png"" alt=""Photo"">
                                                    </div>
                                                    <!-- /.col -->
                                                </div>
                                                <!-- /.row -->
                                            </div>
                                            <!-- /.col -->
                                        </div>
                                        <!-- /.row -->
                                        <p>
                                            <a href=""#"" class=""link-black text-sm mr-2""><i class=""fas fa-share mr-1""></i> Share</a>
                                            <a href=""#"" class=""link-black text-sm""><i class=""far fa-thumbs-up mr-1""></i> Like</a>
                                            <");
            WriteLiteral(@"span class=""float-right"">
                                                <a href=""#"" class=""link-black text-sm"">
                                                    <i class=""far fa-comments mr-1""></i> Comments (5)
                                                </a>
                                            </span>
                                        </p>
                                        <input class=""form-control form-control-sm"" type=""text"" placeholder=""Type a comment"">
                                    </div>
                                    <!-- /.post -->
                                </div>
                                <!-- /.tab-pane -->
                                <div class=""tab-pane"" id=""timeline"">
                                    <!-- The timeline -->
                                    <div class=""timeline timeline-inverse"">
                                        <!-- timeline time label -->
                                        <div class=""time-la");
            WriteLiteral(@"bel"">
                                            <span class=""bg-danger"">
                                                10 Feb. 2014
                                            </span>
                                        </div>
                                        <!-- /.timeline-label -->
                                        <!-- timeline item -->
                                        <div>
                                            <i class=""fas fa-envelope bg-primary""></i>
                                            <div class=""timeline-item"">
                                                <span class=""time""><i class=""far fa-clock""></i> 12:05</span>
                                                <h3 class=""timeline-header""><a href=""#"">Support Team</a> sent you an email</h3>
                                                <div class=""timeline-body"">
                                                    Etsy doostang zoodles disqus groupon greplin oooj voxy zoodles,
            ");
            WriteLiteral(@"                                        weebly ning heekya handango imeem plugg dopplr jibjab, movity
                                                    jajah plickers sifteo edmodo ifttt zimbra. Babblely odeo kaboodle
                                                    quora plaxo ideeli hulu weebly balihoo...
                                                </div>
                                                <div class=""timeline-footer"">
                                                    <a href=""#"" class=""btn btn-primary btn-sm"">Read more</a>
                                                    <a href=""#"" class=""btn btn-danger btn-sm"">Delete</a>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- END timeline item -->
                                        <!-- timeline item -->
                                        <div>
                     ");
            WriteLiteral(@"                       <i class=""fas fa-user bg-info""></i>
                                            <div class=""timeline-item"">
                                                <span class=""time""><i class=""far fa-clock""></i> 5 mins ago</span>
                                                <h3 class=""timeline-header border-0"">
                                                    <a href=""#"">Sarah Young</a> accepted your friend request
                                                </h3>
                                            </div>
                                        </div>
                                        <!-- END timeline item -->
                                        <!-- timeline item -->
                                        <div>
                                            <i class=""fas fa-comments bg-warning""></i>
                                            <div class=""timeline-item"">
                                                <span class=""time""><i class=""far fa-");
            WriteLiteral(@"clock""></i> 27 mins ago</span>
                                                <h3 class=""timeline-header""><a href=""#"">Jay White</a> commented on your post</h3>
                                                <div class=""timeline-body"">
                                                    Take me to your leader!
                                                    Switzerland is small and neutral!
                                                    We are more like Germany, ambitious and misunderstood!
                                                </div>
                                                <div class=""timeline-footer"">
                                                    <a href=""#"" class=""btn btn-warning btn-flat btn-sm"">View comment</a>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- END timeline item -->
                               ");
            WriteLiteral(@"         <!-- timeline time label -->
                                        <div class=""time-label"">
                                            <span class=""bg-success"">
                                                3 Jan. 2014
                                            </span>
                                        </div>
                                        <!-- /.timeline-label -->
                                        <!-- timeline item -->
                                        <div>
                                            <i class=""fas fa-camera bg-purple""></i>
                                            <div class=""timeline-item"">
                                                <span class=""time""><i class=""far fa-clock""></i> 2 days ago</span>
                                                <h3 class=""timeline-header""><a href=""#"">Mina Lee</a> uploaded new photos</h3>
                                                <div class=""timeline-body"">
                               ");
            WriteLiteral(@"                     <img src=""http://placehold.it/150x100"" alt=""..."">
                                                    <img src=""http://placehold.it/150x100"" alt=""..."">
                                                    <img src=""http://placehold.it/150x100"" alt=""..."">
                                                    <img src=""http://placehold.it/150x100"" alt=""..."">
                                                </div>
                                            </div>
                                        </div>
                                        <!-- END timeline item -->
                                        <div>
                                            <i class=""far fa-clock bg-gray""></i>
                                        </div>
                                    </div>
                                </div>
                                <!-- /.tab-pane -->
                                <div class=""tab-pane"" id=""settings"">
                                   ");
            WriteLiteral(" ");
            EndContext();
            BeginContext(19982, 3493, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d495b38bd0c146688516769ed4f2d6aa", async() => {
                BeginContext(20012, 3456, true);
                WriteLiteral(@"
                                        <div class=""form-group row"">
                                            <label for=""inputName"" class=""col-sm-2 col-form-label"">Name</label>
                                            <div class=""col-sm-10"">
                                                <input type=""email"" class=""form-control"" id=""inputName"" placeholder=""Name"">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputEmail"" class=""col-sm-2 col-form-label"">Email</label>
                                            <div class=""col-sm-10"">
                                                <input type=""email"" class=""form-control"" id=""inputEmail"" placeholder=""Email"">
                                            </div>
                                        </div>
                                        <div class=""form-group r");
                WriteLiteral(@"ow"">
                                            <label for=""inputName2"" class=""col-sm-2 col-form-label"">Name</label>
                                            <div class=""col-sm-10"">
                                                <input type=""text"" class=""form-control"" id=""inputName2"" placeholder=""Name"">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <label for=""inputExperience"" class=""col-sm-2 col-form-label"">Experience</label>
                                            <div class=""col-sm-10"">
                                                <textarea class=""form-control"" id=""inputExperience"" placeholder=""Experience""></textarea>
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                      ");
                WriteLiteral(@"      <label for=""inputSkills"" class=""col-sm-2 col-form-label"">Skills</label>
                                            <div class=""col-sm-10"">
                                                <input type=""text"" class=""form-control"" id=""inputSkills"" placeholder=""Skills"">
                                            </div>
                                        </div>
                                        <div class=""form-group row"">
                                            <div class=""offset-sm-2 col-sm-10"">
                                                <div class=""checkbox"">
                                                    <label>
                                                        <input type=""checkbox""> I agree to the <a href=""#"">terms and conditions</a>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
             ");
                WriteLiteral(@"                           <div class=""form-group row"">
                                            <div class=""offset-sm-2 col-sm-10"">
                                                <button type=""submit"" class=""btn btn-danger"">Submit</button>
                                            </div>
                                        </div>
                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(23475, 533, true);
            WriteLiteral(@"
                                </div>
                                <!-- /.tab-pane -->
                            </div>
                            <!-- /.tab-content -->
                        </div><!-- /.card-body -->
                    </div>
                    <!-- /.nav-tabs-custom -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->
");
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
