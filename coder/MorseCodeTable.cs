public class MorseCodeTable {

    private Dictionary<String, String> alphabetToMorse = new Dictionary<string, string>();

    private Dictionary<String, String> morseToAlphabet = new Dictionary<String, String>();

    public MorseCodeTable(String shortSignal, String longSignal) {
        alphabetToMorse.Add("a", ".-");
        alphabetToMorse.Add("b", "-...");
        alphabetToMorse.Add("c", "-.-.");
        alphabetToMorse.Add("d", "-..");
        alphabetToMorse.Add("e", ".");
        alphabetToMorse.Add("f", "..-.");
        alphabetToMorse.Add("g", "--.");
        alphabetToMorse.Add("h", "....");
        alphabetToMorse.Add("i", "..");
        alphabetToMorse.Add("j", ".---");
        alphabetToMorse.Add("k", "-.-");
        alphabetToMorse.Add("l", ".-..");
        alphabetToMorse.Add("m", "--");
        alphabetToMorse.Add("n", "-.");
        alphabetToMorse.Add("o", "---");
        alphabetToMorse.Add("p", ".--.");
        alphabetToMorse.Add("q", "--.-");
        alphabetToMorse.Add("r", ".-.");
        alphabetToMorse.Add("s", "...");
        alphabetToMorse.Add("t", "-");
        alphabetToMorse.Add("u", "..-");
        alphabetToMorse.Add("v", "...-");
        alphabetToMorse.Add("w", ".--");
        alphabetToMorse.Add("x", "-..-");
        alphabetToMorse.Add("y", "-.--");
        alphabetToMorse.Add("z", "--..");
        alphabetToMorse.Add("1", ".----");
        alphabetToMorse.Add("2", "..---");
        alphabetToMorse.Add("3", "...--");
        alphabetToMorse.Add("4", "....-");
        alphabetToMorse.Add("5", ".....");
        alphabetToMorse.Add("6", "-....");
        alphabetToMorse.Add("7", "--...");
        alphabetToMorse.Add("8", "---..");
        alphabetToMorse.Add("9", "----.");
        alphabetToMorse.Add("0", "-----");
        alphabetToMorse.Add(".", ".-.-.-");
        alphabetToMorse.Add(",", "--..--");
        alphabetToMorse.Add(":", "---...");
        alphabetToMorse.Add("?", "..--..");
        alphabetToMorse.Add("!", "-.-.--");
        alphabetToMorse.Add("-", "-....-");
        alphabetToMorse.Add("\"", ".-..-.");
        alphabetToMorse.Add("(", "-.--.");
        alphabetToMorse.Add(")", "-.--.-");
        alphabetToMorse.Add("/", "-..-.");
        alphabetToMorse.Add(" ", "/");

        foreach (var kvp in alphabetToMorse.ToList()) {
            string key = kvp.Key;
            string morseCode = kvp.Value;

            if (shortSignal != null) {
                morseCode = morseCode.Replace(".", shortSignal);
            }

            if (longSignal != null) {
                morseCode = morseCode.Replace("-", longSignal);
            }

            alphabetToMorse[key] = morseCode;

            morseToAlphabet[morseCode] = kvp.Key;
        }
    }

    public Dictionary<String, String> getAlphabetToMorse() {
        return alphabetToMorse;
    }

    public Dictionary<String, String> getMorseToAlphabet() {
        return morseToAlphabet;
    }
}

