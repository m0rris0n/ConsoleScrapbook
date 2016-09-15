/*

public static bool IsPalindrome(string str)
{
    string workString = null;

    str = str.ToLower();

    foreach (char c in str)
    {
        if ((c >= 97) && (c <= 122))
            workString = workString + c;
    }

    for (int i = 0; i < (workString.Length / 2); i++)
    {
        if (workString.ElementAt(i) != workString.ElementAt(workString.Length - (i + 1)))
            return false;
    }

    return true;

    throw new NotImplementedException("Waiting to be implemented.");
}*/