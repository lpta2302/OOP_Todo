public class TypeConverter
{
    public static ResType? Convert<ParamType, ResType>(ParamType x)
    {
        if (x == null) return default;
        
        if (typeof(ResType).IsAssignableFrom(typeof(ParamType)) || x is ResType)
        {
            return (ResType)(object)x;
        }
        else
        {
            throw new InvalidCastException($"Cannot convert {typeof(ParamType).FullName} to {typeof(ResType).FullName}");
        }
    }
}
