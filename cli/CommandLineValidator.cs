public sealed class CommandLineValidator {

    private static readonly int BASIC_ARGS_LENGTH = 2;

    private static readonly int EXTENDED_ARGS_LENGTH = 4;

    private CommandLineValidator() {
    }

    public static void validateArgs(String[] args) {
        validateArgsLength(args);
        validateCommand(args[0]);

        if (args.Length == EXTENDED_ARGS_LENGTH) {
            validateCommandOptions(args[2], args[3]);
        }
    }

    public static bool isBasicArgumentList(String[] args) {
        return args.Length == BASIC_ARGS_LENGTH;
    }

    public static bool isExtendedArgumentList(String[] args) {
        return args.Length == EXTENDED_ARGS_LENGTH;
    }

    private static void validateArgsLength(String[] args) {
        if (!isBasicArgumentList(args) && !isExtendedArgumentList(args)) {
            throw new ArgumentException("Invalid usage!");
        }
    }

    private static void validateCommand(String command) {
        if (!Commands.isValid(command)) {
            throw new ArgumentException("Invalid command: " + command);
        }
    }

    private static void validateCommandOptions(params string[] options) {
        foreach (String opt in options) {
            if (!CommandOptions.isValid(opt)) {
                throw new ArgumentException("Invalid command option: " + opt);
            }
        }
    }
}

