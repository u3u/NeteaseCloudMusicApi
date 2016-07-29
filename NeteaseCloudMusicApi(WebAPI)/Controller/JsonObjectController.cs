/**
 * @auther u3u
 * @version 1.0.0
 * @update 2016/07/29
 * @description 推荐使用VS2015 .NET Framework 4.5 以上
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace NeteaseCloudMusicWebApi.Controller
{
    public class JsonObjectController : ApiController
    {
        /// <summary>
        /// 序列化对象或字符串为JSON对象而不是JSON字符串(不使用WebApi的JSON序列化)
        /// </summary>
        /// <param name="o">要序列号的对象</param>
        /// <returns></returns>
        public HttpResponseMessage Json( object o )
        {
            HttpResponseMessage message = new HttpResponseMessage( HttpStatusCode.OK );
            message.Content = new StringContent( o is string ? o.ToString( ) : new JavaScriptSerializer( ).Serialize( o ) , Encoding.UTF8 , "application/json" );
            return message;
        }
    }
}
