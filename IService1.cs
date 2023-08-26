using System;               // for array class
using System.Linq;          // for sorting algorithms
using System.ServiceModel;

namespace Assignment1 {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface TempAndSorting {

        [OperationContract]
        int c2f(int c);
        [OperationContract]
        int f2c(int f);
        [OperationContract]
        string sort(string s);
    }
}
