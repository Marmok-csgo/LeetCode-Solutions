﻿public class Solution
{
    public uint reverseBits(uint n)
    {
        n = (n >> 16 | n << 16);
        n = ((n & 0b1111_1111_0000_0000_1111_1111_0000_0000) >> 8 | (n & 0b0000_0000_1111_1111_0000_0000_1111_1111) << 8);
        n = ((n & 0b1111_0000_1111_0000_1111_0000_1111_0000) >> 4 | (n & 0b0000_1111_0000_1111_0000_1111_0000_1111) << 4);
        n = ((n & 0b1100_1100_1100_1100_1100_1100_1100_1100) >> 2 | (n & 0b0011_0011_0011_0011_0011_0011_0011_0011) << 2);
        n = ((n & 0b1010_1010_1010_1010_1010_1010_1010_1010) >> 1 | (n & 0b0101_0101_0101_0101_0101_0101_0101_0101) << 1);
        return n;

    }
}