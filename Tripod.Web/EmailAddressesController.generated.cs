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
    public partial class EmailAddressesController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected EmailAddressesController(Dummy d) { }

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
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Password()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Password);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult PasswordValidate()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PasswordValidate);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public EmailAddressesController Actions { get { return MVC.EmailAddresses; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "EmailAddresses";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "EmailAddresses";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Password = "Password";
            public readonly string PasswordValidate = "PasswordValidate";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Password = "Password";
            public const string PasswordValidate = "PasswordValidate";
        }


        static readonly ActionParamsClass_Password s_params_Password = new ActionParamsClass_Password();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Password PasswordParams { get { return s_params_Password; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Password
        {
            public readonly string token = "token";
            public readonly string command = "command";
            public readonly string emailAddress = "emailAddress";
        }
        static readonly ActionParamsClass_PasswordValidate s_params_PasswordValidate = new ActionParamsClass_PasswordValidate();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_PasswordValidate PasswordValidateParams { get { return s_params_PasswordValidate; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_PasswordValidate
        {
            public readonly string command = "command";
            public readonly string fieldName = "fieldName";
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
    public partial class T4MVC_EmailAddressesController : Tripod.Web.Controllers.EmailAddressesController
    {
        public T4MVC_EmailAddressesController() : base(Dummy.Instance) { }

        partial void PasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string token);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Password(string token)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Password);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "token", token);
            PasswordOverride(callInfo, token);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void PasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.CreateLocalMembership command, string emailAddress);

        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Password(Tripod.Domain.Security.CreateLocalMembership command, string emailAddress)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Password);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "emailAddress", emailAddress);
            PasswordOverride(callInfo, command, emailAddress);
            return System.Threading.Tasks.Task.FromResult(callInfo as ActionResult);
        }

        partial void PasswordValidateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Tripod.Domain.Security.CreateLocalMembership command, string fieldName);

        public override System.Web.Mvc.ActionResult PasswordValidate(Tripod.Domain.Security.CreateLocalMembership command, string fieldName)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PasswordValidate);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "fieldName", fieldName);
            PasswordValidateOverride(callInfo, command, fieldName);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
