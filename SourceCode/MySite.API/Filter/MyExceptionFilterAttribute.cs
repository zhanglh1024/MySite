﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using MySite.Core;

namespace MySite.API
{
    public class MyExceptionFilterAttribute : ExceptionFilterAttribute
    {
        /// <summary>
        /// 异常捕捉
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnException(HttpActionExecutedContext filterContext)
        {
            base.OnException(filterContext);

            var excetype = filterContext.Exception.GetType().Name;
            var res = new ResponseMessage();
            //自定义异常类型
            if (excetype == "CustomerException")
            {
                var ex = (CustomerException)filterContext.Exception;
                res.Code = ex.Code;
                res.Content = "";
                res.ErrorMsg = ex.Msg ?? ex.Code.ToString();
            }
            //系统异常
            else
            {
                var ex = (Exception)filterContext.Exception;
                res.Code = ResponseCode.ServerInternalError;
                res.Content = "";
                res.ErrorMsg = ex.Message;
            }

            //讲异常返回数据格式重新封装
            filterContext.Response = filterContext.Request.CreateResponse(HttpStatusCode.OK, res);
        }
    }
}