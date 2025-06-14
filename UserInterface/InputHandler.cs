namespace BoolPgia;
public static class InputHandler
{
    public static bool CheckValidLine(GuessLine i_Line)
    {
        bool[] inputArray = new bool[GameUtils.k_NumberOfValidCharacters];
        foreach(Button btn in i_Line.GuessButtons)
        {
            char inputChar = ColorMapping.sr_KColorMapping[btn.BackColor];
            inputArray[inputChar - GameUtils.k_FirstValidChar] = true;
        }

        int numberOfColors = 0;

        foreach(bool b in inputArray)
        {
            if(b)
            {
                numberOfColors++;
            }
        }

        return (numberOfColors == 4);
    }
}
