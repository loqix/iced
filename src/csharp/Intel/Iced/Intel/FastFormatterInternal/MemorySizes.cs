/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if FAST_FMT
using System;

namespace Iced.Intel.FastFormatterInternal {
	static class MemorySizes {
		public static readonly string[] AllMemorySizes = GetMemorySizes();

		static string[] GetMemorySizes() {
			var memSizes = new string[IcedConstants.MemorySizeEnumCount];
#if HAS_SPAN
			System.ReadOnlySpan<byte> data =
#else
			byte[] data =
#endif
			new byte[IcedConstants.MemorySizeEnumCount] {
				// GENERATOR-BEGIN: MemorySizes
				// ⚠️This was generated by GENERATOR!🦹‍♂️
				0x00,
				0x01,
				0x0D,
				0x03,
				0x0B,
				0x0B,
				0x0E,
				0x0F,
				0x10,
				0x01,
				0x0D,
				0x03,
				0x0B,
				0x0E,
				0x0F,
				0x10,
				0x03,
				0x08,
				0x0C,
				0x0D,
				0x03,
				0x0B,
				0x03,
				0x0B,
				0x0B,
				0x09,
				0x08,
				0x08,
				0x0D,
				0x03,
				0x0B,
				0x0C,
				0x0E,
				0x0D,
				0x04,
				0x05,
				0x07,
				0x06,
				0x00,
				0x00,
				0x00,
				0x00,
				0x0C,
				0x10,
				0x00,
				0x0C,
				0x11,
				0x10,
				0x0D,
				0x0D,
				0x03,
				0x03,
				0x03,
				0x03,
				0x03,
				0x0B,
				0x0B,
				0x0B,
				0x0B,
				0x0B,
				0x0B,
				0x0B,
				0x0B,
				0x0E,
				0x0E,
				0x0E,
				0x0E,
				0x0E,
				0x0E,
				0x0E,
				0x0E,
				0x0E,
				0x0E,
				0x0E,
				0x0E,
				0x0E,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x0F,
				0x10,
				0x10,
				0x10,
				0x10,
				0x10,
				0x10,
				0x10,
				0x10,
				0x10,
				0x10,
				0x10,
				0x10,
				0x10,
				0x02,
				0x02,
				0x02,
				0x02,
				0x02,
				0x0A,
				0x0A,
				0x0A,
				0x02,
				0x0A,
				0x02,
				0x02,
				0x0A,
				0x0A,
				0x0A,
				0x02,
				0x0A,
				0x02,
				0x02,
				0x0A,
				0x0A,
				0x0A,
				0x02,
				0x0A,
				0x02,
				0x02,
				0x02,
				0x0A,
				0x0A,
				0x0A,
				0x0A,
				0x0A,
				0x0A,
				0x02,
				0x02,
				0x02,
				// GENERATOR-END: MemorySizes
			};

			for (int i = 0; i < memSizes.Length; i++) {
				var keywords = data[i] switch {
					// GENERATOR-BEGIN: Switch
					// ⚠️This was generated by GENERATOR!🦹‍♂️
					0 => "",
					1 => "byte ptr ",
					2 => "dword bcst ",
					3 => "dword ptr ",
					4 => "fpuenv14 ptr ",
					5 => "fpuenv28 ptr ",
					6 => "fpustate108 ptr ",
					7 => "fpustate94 ptr ",
					8 => "fword ptr ",
					9 => "oword ptr ",
					10 => "qword bcst ",
					11 => "qword ptr ",
					12 => "tbyte ptr ",
					13 => "word ptr ",
					14 => "xmmword ptr ",
					15 => "ymmword ptr ",
					16 => "zmmword ptr ",
					17 => "mem384 ptr ",
					// GENERATOR-END: Switch
					_ => throw new InvalidOperationException(),
				};
				memSizes[i] = keywords;
			}

			return memSizes;
		}
	}
}
#endif
