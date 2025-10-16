public class MorseEncoder {

    private MorseCodeTable morseCodeTable;

    public MorseEncoder(MorseCodeTable morseCodeTable) {
        this.morseCodeTable = morseCodeTable;
    }

    public String encode(String text) {
        if (text == null || string.IsNullOrEmpty(text)) {
            return "";
        }

        String lowerCaseText = text.Trim().ToLower();
        String[] morse = new String[lowerCaseText.Length];

        for (int index = 0; index < lowerCaseText.Length; index++) {
            String morseCharacter = morseCodeTable.getAlphabetToMorse().GetValueOrDefault((lowerCaseText[index]).ToString());

            if (morseCharacter == null) {
                throw new ArgumentException("Character " + text[index] + " can't be translated to morse");
            }

            morse[index] = morseCharacter;
        }

        return String.Join(" ", morse);        
    }
}

