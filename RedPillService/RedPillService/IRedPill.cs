using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WalidAly
{
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        [OperationContract]
        Guid WhatIsYourToken();

        [OperationContract]
        [FaultContract(typeof(ArgumentOutOfRangeException))]
        long FibonacciNumber(long n);

        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [OperationContract]
        [FaultContract(typeof(ArgumentNullException))]
        string ReverseWords(string s);
    }

    [DataContractAttribute(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {
        [EnumMemberAttribute()]
        Error = 0,

        [EnumMemberAttribute()]
        Equilateral = 1,

        [EnumMemberAttribute()]
        Isosceles = 2,

        [EnumMemberAttribute()]
        Scalene = 3,
    }
}
