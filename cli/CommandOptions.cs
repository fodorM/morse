using System.Text.RegularExpressions;

public sealed class CommandOptions
{

    private static readonly String DELIMITER = "=";

    public static readonly String OPTION_SHORT = "^--short=.$";

    public static readonly String OPTION_LONG = "^--long=.$";

    private CommandOptions()
    {
    }

    public static bool isValid(String option)
    {
        return isOptionShort(option) || isOptionLong(option);
    }

    public static bool isOptionShort(String option)
    {
        return Regex.IsMatch(option, OPTION_SHORT);
    }

    public static bool isOptionLong(String option)
    {
        return Regex.IsMatch(option, OPTION_LONG);
    }

    public static String getOptionValue(String command)
    {
        return command.Split(DELIMITER)[1];
    }
}
