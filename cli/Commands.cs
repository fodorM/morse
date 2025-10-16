public sealed class Commands
{

    public static readonly String ENCODE = "encode";

    public static readonly String DECODE = "decode";

    private Commands()
    {
    }

    public static bool isValid(String command)
    {
        return isCommandEncode(command) || isCommandDecode(command);
    }

    public static bool isCommandEncode(String command)
    {
        return string.Equals(ENCODE, command, StringComparison.OrdinalIgnoreCase);
    }

    public static bool isCommandDecode(String command)
    {
        return string.Equals(DECODE, command, StringComparison.OrdinalIgnoreCase);
    }
}
