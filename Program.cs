using System;
using System.IO;

public class MorseTranlator {

    public static void Main(String[] args) {
        try {
            CommandLineValidator.validateArgs(args);

            CommandArguments cmdArguments = new CommandArguments(args);
            MorseCodeTable morseCodeTable = new MorseCodeTable(cmdArguments.getShortSign(), cmdArguments.getLongSign());

            if (Commands.isCommandEncode(cmdArguments.getCommand())) {
                MorseEncoder encoder = new MorseEncoder(morseCodeTable);
                Console.WriteLine("Morse code: " + encoder.encode(cmdArguments.getText()));
            } else {
                MorseDecoder decoder = new MorseDecoder(morseCodeTable);
                Console.WriteLine("Sentence: " + decoder.decode(cmdArguments.getText()));
            }
        } catch (ArgumentException exception) {
            Console.WriteLine(exception.Message);
            Console.WriteLine("\nUsage: morse [COMMAND] [TEXT] [COMMAND OPTIONS]");
            Console.WriteLine("Please keep the order!");
            Console.WriteLine("\nExamples:");
            Console.WriteLine("  - morse encode \"Hello World!\"");
            Console.WriteLine("  - morse encode \"Hello World!\" --short=. --long=-");
            Console.WriteLine("  - morse decode \".... . .-.. .-.. --- / .-- --- .-. .-.. -.. -.-.--\"");
            Console.WriteLine("  - morse decode \",,,, , ,;,, ,;,, ;;; / ,;; ;;; ,;, ,;,, ;,, ;,;,;;\" --short=, --long=;");
        }
    }
}

