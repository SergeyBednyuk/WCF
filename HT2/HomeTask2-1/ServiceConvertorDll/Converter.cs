namespace ServiceConvertorDll
{
    public class Converter : IConverter
    {
        public ConvertedUnits LinearMeasure(double meters)
        {
            double _remainder = 0;
            double _yard = meters / 0.9144;
            _remainder = meters - ((int)_yard * 0.9144);
            double _foot = _remainder / 0.3048;
            _remainder = _remainder - (int)_foot * 0.1048;
            double _inch = _remainder / 0.0254;

            //return new ConvertedUnits() { inch = _inch, foot =(int)_foot, yard =(int)_yard };
            return new ConvertedUnits() { yard = (int)_yard, foot = (int)_foot, inch = _inch };
        }

        public ConvertedUnits CelsiumToFohrenheit(double c)
        {
            var rezult = (c * 1.8) + 32;
            return new ConvertedUnits() { fohrenheit = rezult };
        }

        public ConvertedUnits FohrenheitToCelsium(double f)
        {
            var rezult = (f - 32) / 1.8;
            return new ConvertedUnits() { celsius = rezult };
        }
    }
}
