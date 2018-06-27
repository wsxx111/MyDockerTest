using SwaggerWcf.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;

namespace MyWcf
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [SwaggerWcf("SchoolInfoService")]
   
    public class SchoolInfo : ISchoolInfo
    {
        [SwaggerWcfTag("学习")]
        public string GetDataSchool(int value)
        {
            return "飒飒的是的请求";
        }
        [SwaggerWcfTag("学习")]
        public string GetDataOtjerSchool()
        {
            return "潇洒地";
        }
    }
}