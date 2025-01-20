using System;

namespace Check_Even_or_Odd;

public class Bitwise
{
    public static bool isEven_Bitwise(int n) {
        if (n == (n >> 1) << 1)
            return true;
        else    
            return false;
    }
}
