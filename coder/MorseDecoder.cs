using System.Text;

public class MorseDecoder
{

    private MorseCodeTable morseCodeTable;

    public MorseDecoder(MorseCodeTable morseCodeTable)
    {
        this.morseCodeTable = morseCodeTable;
    }

    public String decode(String text)
    {
        if (text == null || string.IsNullOrEmpty(text))
        {
            return "";
        }

        String[] morseUnitCharacters = text.Trim().Split(" ");
        StringBuilder stringBuilder = new StringBuilder();

        for (int index = 0; index < morseUnitCharacters.Length; index++)
        {
            String englishCharacter = morseCodeTable.getMorseToAlphabet().GetValueOrDefault(morseUnitCharacters[index]);

            if (englishCharacter == null)
            {
                throw new ArgumentException("Character " + morseUnitCharacters[index] + " is not a valid morse character");
            }

            stringBuilder.Append(englishCharacter);
        }

        return stringBuilder.ToString();
    }
}
