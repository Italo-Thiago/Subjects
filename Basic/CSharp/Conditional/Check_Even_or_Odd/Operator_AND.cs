using System;

namespace Check_Even_or_Odd;

public class Operator_AND
{
    public static bool isEven_AND(int n) {
        if ((n & 1) == 0)
            return true;
        else
            return false;
    }
}
