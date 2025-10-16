public class CommandArguments {

    private String command;

    private String text;

    private String shortSign;

    private String longSign;

    public CommandArguments(String[] args) {
        setMandatoryArguments(args);

        if (CommandLineValidator.isExtendedArgumentList(args)) {
            setOptionalArguments(args);
        }
    }

    public String getCommand() {
        return command;
    }

    public String getText() {
        return text;
    }

    public String getShortSign() {
        return shortSign;
    }

    public String getLongSign() {
        return longSign;
    }

    private void setMandatoryArguments(String[] args) {
        command = args[0];
        text = args[1];
    }

    private void setOptionalArguments(String[] args) {
        if (CommandOptions.isOptionShort(args[2])) {
            shortSign = CommandOptions.getOptionValue(args[2]);
            longSign = CommandOptions.getOptionValue(args[3]);
        } else {
            shortSign = CommandOptions.getOptionValue(args[3]);
            longSign = CommandOptions.getOptionValue(args[2]);
        }
    }
}
