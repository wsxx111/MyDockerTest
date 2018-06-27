using SwaggerWcf.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace MyWcf
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [SwaggerWcf("UserInfoService")]
    public class UserInfo : IUserInfo
    {
        [SwaggerWcfResponse(HttpStatusCode.Created, "请求成功")]
        [SwaggerWcfResponse(HttpStatusCode.BadRequest, "请求失败400", true)]
        [SwaggerWcfResponse(HttpStatusCode.InternalServerError, "请求失败500", true)]
        [SwaggerWcfTag("组织")]
        public string GetBody()
        {
            return "大所得税的";
        }

        [SwaggerWcfResponse(HttpStatusCode.Created, "请求成功")]
        [SwaggerWcfResponse(HttpStatusCode.BadRequest, "请求失败400", true)]
        [SwaggerWcfResponse(HttpStatusCode.InternalServerError, "请求失败500", true)]
        [SwaggerWcfTag("人事")]
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        [SwaggerWcfResponse(HttpStatusCode.Created, "请求成功")]
        [SwaggerWcfResponse(HttpStatusCode.BadRequest, "请求失败400", true)]
        [SwaggerWcfResponse(HttpStatusCode.InternalServerError, "请求失败500", true)]
        [SwaggerWcfTag("哈斯")]
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
