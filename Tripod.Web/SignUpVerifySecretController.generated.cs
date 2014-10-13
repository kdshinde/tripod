// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Tripod.Web.Controllers
{
    public partial class SignUpVerifySecretController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected SignUpVerifySecretController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Validate()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Validate);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Post()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Post);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public SignUpVerifySecretController Actions { get { return MVC.SignUpVerifySecret; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "SignUpVerifySecret";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "SignUpVerifySecret";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Validate = "Validate";
            public readonly string Post = "Post";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Validate = "Validate";
            public const string Post = "Post";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string ticket = "ticket";
            public readonly string returnUrl = "returnUrl";
        }
        static readonly ActionParamsClass_Validate s_params_Validate = new ActionParamsClass_Validate();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Validate ValidateParams { get { return s_params_Validate; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Validate
        {
            public readonly string command = "command";
            public readonly string fieldName = "fieldName";
        }
        static readonly ActionParamsClass_Post s_params_Post = new ActionParamsClass_Post();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Post PostParams { get { return s_params_Post; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Post
        {
            public readonly string ticket = "ticket";
            public readonly string command = "command";
            public readonly string returnUrl = "returnUrl";
            public readonly string emailAddress = "emailAddress";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_SignUpVerifySecretController : Tripod.Web.Controllers.SignUpVerifySecretController
    {
        public T4MVC_SignUpVerifySecretController() : base(Dummy.Instance) { }

        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string ticket, string returnUrl);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Index(string ticket, string returnUrl)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ticket", ticket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            IndexOverride(callInfo, ticket, returnUrl);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void ValidateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.VerifyEmailSecret command, string fieldName);

        public override System.Web.Mvc.ActionResult Validate(Tripod.Domain.Security.VerifyEmailSecret command, string fieldName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Validate);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "fieldName", fieldName);
            ValidateOverride(callInfo, command, fieldName);
            return callInfo;
        }

        partial void PostOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string ticket, Tripod.Domain.Security.VerifyEmailSecret command, string returnUrl, string emailAddress);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Post(string ticket, Tripod.Domain.Security.VerifyEmailSecret command, string returnUrl, string emailAddress)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Post);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "ticket", ticket);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "returnUrl", returnUrl);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emailAddress", emailAddress);
            PostOverride(callInfo, ticket, command, returnUrl, emailAddress);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
