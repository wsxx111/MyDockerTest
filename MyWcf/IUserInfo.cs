using SwaggerWcf.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWcf
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IUserInfo
    {
       
        [OperationContract]
        [SwaggerWcfPath("获取一个数据")]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetData?value={value}",
            BodyStyle = WebMessageBodyStyle.Bare
            )]
        string GetData(int value);

        [OperationContract]
        [SwaggerWcfPath("获取另一个数据")]
        [WebInvoke(
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetDataUsingDataContract",
            BodyStyle = WebMessageBodyStyle.Bare
            )]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        [SwaggerWcfPath("获取哈哈哈哈")]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "GetBody",
            BodyStyle = WebMessageBodyStyle.Bare
            )]
        string GetBody();

        // TODO: 在此添加您的服务操作
    }


    // 使用下面示例中说明的数据约定将复合类型添加到服务操作。
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember(Name = "BoolValue")]
        [Description("一个参数")]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember(Name = "StringValue")]
        [Description("另一个参数")]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
