using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderEntry.Models.Utility
{
    /// <summary>
    /// This class represents a JSON result returned from a controller action.
    /// </summary>
    public class JsonNetResult : JsonResult
    {
        /// <summary>
        /// Constructs a new JSON Net result.
        /// </summary>
        public JsonNetResult()
        {
            this.ContentType = "application/json";
        }

        /// <summary>
        /// Constructs a new JSON Net result.
        /// </summary>
        /// <param name="data">The data object.</param>
        /// <param name="jsonRequestBehavior">The JSON request behavior object.</param>
        public JsonNetResult(object data, JsonRequestBehavior jsonRequestBehavior)
        {
            this.Data = data;
            this.JsonRequestBehavior = jsonRequestBehavior;
        }

        /// <summary>
        /// Serializes the result as a JSON object.
        /// </summary>
        /// <param name="context">The controller context.</param>
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            var response = context.HttpContext.Response;

            response.ContentType = String.IsNullOrEmpty(ContentType) == false ? ContentType : "application/json";

            if (ContentEncoding != null)
            {
                response.ContentEncoding = ContentEncoding;
            }

            if (Data == null)
            {
                return;
            }

            var serializedObject = JsonConvert.SerializeObject(Data, Formatting.None);
            response.Write(serializedObject);
        }
    }


}