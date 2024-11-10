namespace DN.HELPER.LIBRARY.EXTENSION;

public static class ObjectExtension
{
    public static string ToStringOrEmpty(this object objString) => objString == null ? string.Empty : objString.ToString();
}