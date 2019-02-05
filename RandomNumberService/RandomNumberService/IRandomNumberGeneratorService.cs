using RandomNumberService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RandomNumberService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRandomNumberGeneratorService" in both code and config file together.
    [ServiceContract]
    public interface IRandomNumberGeneratorService
    {
        [OperationContract]
        List<NumberDateModel> GetRandomNumbersDate();
    }
}
