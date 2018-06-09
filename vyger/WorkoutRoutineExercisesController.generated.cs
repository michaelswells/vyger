// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace vyger.Controllers
{
    public partial class WorkoutRoutineExercisesController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected WorkoutRoutineExercisesController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Edit()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Create()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Delete()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Copy()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Copy);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public WorkoutRoutineExercisesController Actions { get { return MVC.WorkoutRoutineExercises; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "WorkoutRoutineExercises";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "WorkoutRoutineExercises";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string Edit = "Edit";
            public readonly string Create = "Create";
            public readonly string Delete = "Delete";
            public readonly string Copy = "Copy";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string Edit = "Edit";
            public const string Create = "Create";
            public const string Delete = "Delete";
            public const string Copy = "Copy";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string id = "id";
            public readonly string week = "week";
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string id = "id";
            public readonly string week = "week";
            public readonly string day = "day";
            public readonly string exercise = "exercise";
            public readonly string post = "post";
        }
        static readonly ActionParamsClass_Create s_params_Create = new ActionParamsClass_Create();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Create CreateParams { get { return s_params_Create; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Create
        {
            public readonly string id = "id";
            public readonly string day = "day";
            public readonly string post = "post";
        }
        static readonly ActionParamsClass_Delete s_params_Delete = new ActionParamsClass_Delete();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Delete DeleteParams { get { return s_params_Delete; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Delete
        {
            public readonly string id = "id";
            public readonly string day = "day";
            public readonly string exercise = "exercise";
            public readonly string post = "post";
        }
        static readonly ActionParamsClass_Copy s_params_Copy = new ActionParamsClass_Copy();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Copy CopyParams { get { return s_params_Copy; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Copy
        {
            public readonly string id = "id";
            public readonly string week = "week";
            public readonly string day = "day";
            public readonly string exercise = "exercise";
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
    public partial class T4MVC_WorkoutRoutineExercisesController : vyger.Controllers.WorkoutRoutineExercisesController
    {
        public T4MVC_WorkoutRoutineExercisesController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, int week);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index(int id, int week)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "week", week);
            IndexOverride(callInfo, id, week);
            return callInfo;
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, int week, int day, int exercise, vyger.Models.WorkoutRoutineExercise post);

        [NonAction]
        public override System.Web.Mvc.ActionResult Edit(int id, int week, int day, int exercise, vyger.Models.WorkoutRoutineExercise post)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "week", week);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "day", day);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "exercise", exercise);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "post", post);
            EditOverride(callInfo, id, week, day, exercise, post);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, int day);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create(int id, int day)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "day", day);
            CreateOverride(callInfo, id, day);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, int day, vyger.Models.WorkoutRoutineExercise post);

        [NonAction]
        public override System.Web.Mvc.ActionResult Create(int id, int day, vyger.Models.WorkoutRoutineExercise post)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "day", day);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "post", post);
            CreateOverride(callInfo, id, day, post);
            return callInfo;
        }

        [NonAction]
        partial void DeleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, int day, int exercise);

        [NonAction]
        public override System.Web.Mvc.ActionResult Delete(int id, int day, int exercise)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "day", day);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "exercise", exercise);
            DeleteOverride(callInfo, id, day, exercise);
            return callInfo;
        }

        [NonAction]
        partial void DeleteOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, int day, int exercise, vyger.Models.WorkoutRoutineExercise post);

        [NonAction]
        public override System.Web.Mvc.ActionResult Delete(int id, int day, int exercise, vyger.Models.WorkoutRoutineExercise post)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Delete);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "day", day);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "exercise", exercise);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "post", post);
            DeleteOverride(callInfo, id, day, exercise, post);
            return callInfo;
        }

        [NonAction]
        partial void CopyOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id, int week, int day, int exercise);

        [NonAction]
        public override System.Web.Mvc.ActionResult Copy(int id, int week, int day, int exercise)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Copy);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "week", week);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "day", day);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "exercise", exercise);
            CopyOverride(callInfo, id, week, day, exercise);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
