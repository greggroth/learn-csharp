public class UnitConverter
{
    int ratio;

    public UnitConverter(int unitRatio)
    {
        ratio = unitRatio;
    }

    public int Convert(int unit)
    {
        return unit * ratio;
    }

}
