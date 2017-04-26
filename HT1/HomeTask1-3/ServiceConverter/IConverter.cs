using  System.ServiceModel;

namespace ServiceConverter
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
