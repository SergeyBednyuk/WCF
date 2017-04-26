using System.ServiceModel;

namespace ServiceConvertorDll
{
    [ServiceContract]
    interface IConverter
    {
        [OperationContract]
        ConvertedUnits LinearMeasure(double meters);
        [OperationContract]
        ConvertedUnits CelsiumToFohrenheit(double c);
        [OperationContract]
        ConvertedUnits FohrenheitToCelsium(double f);
    }
}
