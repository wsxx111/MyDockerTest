using SwaggerWcf.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace MyWcf
{
    [ServiceContract]
    interface ISchoolInfo
    {
        [OperationContract]
        [SwaggerWcfPath("获取一个属性上数据")]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetDataSchool?value={value}",
            BodyStyle = WebMessageBodyStyle.Bare
            )]
        string GetDataSchool(int value);


        [OperationContract]
        [SwaggerWcfPath("获取无呀呀呀呀呀")]
        [WebInvoke(
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetDataOtjerSchool",
            BodyStyle = WebMessageBodyStyle.Bare
            )]
        string GetDataOtjerSchool();
    }
}
