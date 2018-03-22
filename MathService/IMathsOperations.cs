using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace MathsLibrary
{
    [ServiceContract]
    public interface IMathsOperations
    {
        [OperationContract]
        int Add(int num1, int num2);

        [OperationContract]
        int Multiply(int num1, int num2);

        [OperationContract]
        [FaultContract(typeof(CustomFaultDetails))]
        int Divide(int num1, int num2);
    }

    [DataContract]
    public class CustomFaultDetails
    {
        [DataMember]
        public string ErrorID { get; set; }

        [DataMember]
        public string ErrorDetails { get; set; }
    }
}