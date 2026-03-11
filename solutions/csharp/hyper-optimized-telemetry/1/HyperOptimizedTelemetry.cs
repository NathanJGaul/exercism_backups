public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte prefix;
        List<byte> bytes = new();
        
        if (reading >= -9223372036854775808 && reading <= -2147483649)
        {
            // negative signed long (256 - 8 bytes)
            prefix = (byte) (256 - 8);
            bytes.AddRange(BitConverter.GetBytes((long) reading));
        }
        else if (reading >= -2147483648 && reading <= -32769)
        {
            // negative signed int 32 bit (256 - 4 bytes)
            prefix = (byte) (256 - 4);
            bytes.AddRange(BitConverter.GetBytes((int) reading));
        }
        else if (reading >= -32768 && reading <= -1)
        {
            // negative signed short 16 bit (256 - 2 bytes)
            prefix = (byte) (256 - 2);
            bytes.AddRange(BitConverter.GetBytes((short) reading));
        }
        else if (reading >= 0 && reading <= 65535)
        {
            // unsigned short 16 bit (2 bytes)
            prefix = (byte) 2;
            bytes.AddRange(BitConverter.GetBytes((ushort) reading));
        }
        else if (reading >= 65536 && reading <= 2147483647)
        {
            // positive signed int 32 bit (256 - 4 bytes)
            prefix = (byte) (256 - 4);
            bytes.AddRange(BitConverter.GetBytes((int) reading));
        }
        else if (reading >= 2147483648 && reading <= 4294967295)
        {
            // unsigned int 32 bit (4 bytes)
            prefix = (byte) 4;
            bytes.AddRange(BitConverter.GetBytes((uint) reading));
        }
        else
        {
            // positive signed long 64 bit (8 bytes)
            prefix = (byte) (256 - 8);
            bytes.AddRange(BitConverter.GetBytes((long) reading));
        }

        // add prefix to list
        bytes.Insert(0, prefix);

        // pad list to 9 bytes
        bytes.AddRange(Enumerable.Repeat((byte) 0, 9 - bytes.Count));
        
        return bytes.ToArray();
    }

    public static long FromBuffer(byte[] buffer)
    {
        return buffer[0] switch
        {
            2       => BitConverter.ToUInt16(buffer, 1),   // ushort
            4       => BitConverter.ToUInt32(buffer, 1),   // uint
            256 - 2 => BitConverter.ToInt16(buffer, 1),    // short
            256 - 4 => BitConverter.ToInt32(buffer, 1),    // int
            256 - 8 => BitConverter.ToInt64(buffer, 1),    // long
            _       => 0                                   // invalid
        };
    }
}
