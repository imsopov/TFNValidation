        
public static bool TFNValidation(string TFN)
{
    List<int> digits = new List<int>();

    if (TFN.Length != 9 || TFN == "000000000")
    {
        return false;
    }

    int i = 0;
    foreach(char c in TFN)
    {
        digits.Add(c.ToInt());
        i++;
    }
    //do the calcs
    var sum = (digits[0] * 1)
        + (digits[1] * 4)
        + (digits[2] * 3)
        + (digits[3] * 7)
        + (digits[4] * 5)
        + (digits[5] * 8)
        + (digits[6] * 6)
        + (digits[7] * 9)
        + (digits[8] * 10);

    var remainder = sum % 11;
    if (remainder == 0)
    {
        return true;
    }
    return false;
}
