namespace NullChecking;

public static class NullCheck
{
    public static bool IsNull(object obj) => ReferenceEquals(obj, null);

    public static bool IsNotNull(object obj) => !obj.IsNull();
}
