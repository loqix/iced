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

#if MASM
using System;
using Iced.Intel.FormatterInternal;

namespace Iced.Intel.MasmFormatterInternal {
	static class MemorySizes {
#pragma warning disable CS8618 // Non-nullable field 'dword_ptr' is uninitialized. Consider declaring the field as nullable.
		internal static FormatterString[] dword_ptr;
		internal static FormatterString[] qword_ptr;
		internal static FormatterString[] mmword_ptr;
		internal static FormatterString[] xmmword_ptr;
		internal static FormatterString[] oword_ptr;
#pragma warning restore CS8618

		public readonly struct Info {
			public readonly bool isBroadcast;
			public readonly int size;
			public readonly FormatterString[] keywords;
			public Info(bool isBroadcast, int size, FormatterString[] keywords) {
				this.isBroadcast = isBroadcast;
				this.size = size;
				this.keywords = keywords;
			}
		}

		public static readonly Info[] AllMemorySizes = GetMemorySizes();

		static Info[] GetMemorySizes() {
			// GENERATOR-BEGIN: ConstData
			// ⚠️This was generated by GENERATOR!🦹‍♂️
			const int SizeKindShift = 5;
			const int MemoryKeywordsMask = 31;
			var @byte = new FormatterString("byte");
			var ptr = new FormatterString("ptr");
			var byte_ptr = new[] { @byte, ptr };
			var dword = new FormatterString("dword");
			var bcst = new FormatterString("bcst");
			var dword_bcst = new[] { dword, bcst };
			var dword_ptr = new[] { dword, ptr };
			var fpuenv14 = new FormatterString("fpuenv14");
			var fpuenv14_ptr = new[] { fpuenv14, ptr };
			var fpuenv28 = new FormatterString("fpuenv28");
			var fpuenv28_ptr = new[] { fpuenv28, ptr };
			var fpustate108 = new FormatterString("fpustate108");
			var fpustate108_ptr = new[] { fpustate108, ptr };
			var fpustate94 = new FormatterString("fpustate94");
			var fpustate94_ptr = new[] { fpustate94, ptr };
			var fword = new FormatterString("fword");
			var fword_ptr = new[] { fword, ptr };
			var oword = new FormatterString("oword");
			var oword_ptr = new[] { oword, ptr };
			var qword = new FormatterString("qword");
			var qword_bcst = new[] { qword, bcst };
			var qword_ptr = new[] { qword, ptr };
			var tbyte = new FormatterString("tbyte");
			var tbyte_ptr = new[] { tbyte, ptr };
			var word = new FormatterString("word");
			var word_ptr = new[] { word, ptr };
			var xmmword = new FormatterString("xmmword");
			var xmmword_ptr = new[] { xmmword, ptr };
			var ymmword = new FormatterString("ymmword");
			var ymmword_ptr = new[] { ymmword, ptr };
			var zmmword = new FormatterString("zmmword");
			var zmmword_ptr = new[] { zmmword, ptr };
			var mem384 = new FormatterString("mem384");
			var mem384_ptr = new[] { mem384, ptr };
			var mmword = new FormatterString("mmword");
			var mmword_ptr = new[] { mmword, ptr };
			var sizes = new ushort[] {
				0,
				1,
				2,
				4,
				6,
				8,
				10,
				14,
				16,
				28,
				32,
				48,
				64,
				94,
				108,
				512,
			};
			// GENERATOR-END: ConstData
			MemorySizes.mmword_ptr = mmword_ptr;
			MemorySizes.dword_ptr = dword_ptr;
			MemorySizes.oword_ptr = oword_ptr;
			MemorySizes.qword_ptr = qword_ptr;
			MemorySizes.xmmword_ptr = xmmword_ptr;

			var infos = new Info[IcedConstants.MemorySizeEnumCount];
			var data = new ushort[IcedConstants.MemorySizeEnumCount] {
				// GENERATOR-BEGIN: MemorySizes
				// ⚠️This was generated by GENERATOR!🦹‍♂️
				0x0000,
				0x0021,
				0x004D,
				0x0063,
				0x00AB,
				0x00AB,
				0x010E,
				0x014F,
				0x0190,
				0x0021,
				0x004D,
				0x0063,
				0x00AB,
				0x010E,
				0x014F,
				0x0190,
				0x0063,
				0x0088,
				0x00CC,
				0x004D,
				0x0063,
				0x00AB,
				0x0063,
				0x00AB,
				0x00AB,
				0x0109,
				0x0088,
				0x00C8,
				0x004D,
				0x0063,
				0x00AB,
				0x00CC,
				0x010E,
				0x004D,
				0x00E4,
				0x0125,
				0x01A7,
				0x01C6,
				0x01E0,
				0x01E0,
				0x0000,
				0x0000,
				0x00CC,
				0x0190,
				0x0000,
				0x00CC,
				0x0171,
				0x0190,
				0x004D,
				0x004D,
				0x0063,
				0x0063,
				0x0063,
				0x0063,
				0x0063,
				0x00AB,
				0x00AB,
				0x00AB,
				0x00AB,
				0x00AB,
				0x00AB,
				0x00AB,
				0x00AB,
				0x010E,
				0x010E,
				0x010E,
				0x010E,
				0x010E,
				0x010E,
				0x010E,
				0x010E,
				0x010E,
				0x010E,
				0x010E,
				0x010E,
				0x010E,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x014F,
				0x0190,
				0x0190,
				0x0190,
				0x0190,
				0x0190,
				0x0190,
				0x0190,
				0x0190,
				0x0190,
				0x0190,
				0x0190,
				0x0190,
				0x0190,
				0x0062,
				0x0062,
				0x0062,
				0x0062,
				0x0062,
				0x00AA,
				0x00AA,
				0x00AA,
				0x0062,
				0x00AA,
				0x0062,
				0x0062,
				0x00AA,
				0x00AA,
				0x00AA,
				0x0062,
				0x00AA,
				0x0062,
				0x0062,
				0x00AA,
				0x00AA,
				0x00AA,
				0x0062,
				0x00AA,
				0x0062,
				0x0062,
				0x0062,
				0x00AA,
				0x00AA,
				0x00AA,
				0x00AA,
				0x00AA,
				0x00AA,
				0x0062,
				0x0062,
				0x0062,
				// GENERATOR-END: MemorySizes
			};

			for (int i = 0; i < infos.Length; i++) {
				var d = data[i];
				var keywords = (d & MemoryKeywordsMask) switch {
					// GENERATOR-BEGIN: MemoryKeywordsSwitch
					// ⚠️This was generated by GENERATOR!🦹‍♂️
					0x00 => Array2.Empty<FormatterString>(),
					0x01 => byte_ptr,
					0x02 => dword_bcst,
					0x03 => dword_ptr,
					0x04 => fpuenv14_ptr,
					0x05 => fpuenv28_ptr,
					0x06 => fpustate108_ptr,
					0x07 => fpustate94_ptr,
					0x08 => fword_ptr,
					0x09 => oword_ptr,
					0x0A => qword_bcst,
					0x0B => qword_ptr,
					0x0C => tbyte_ptr,
					0x0D => word_ptr,
					0x0E => xmmword_ptr,
					0x0F => ymmword_ptr,
					0x10 => zmmword_ptr,
					0x11 => mem384_ptr,
					// GENERATOR-END: MemoryKeywordsSwitch
					_ => throw new InvalidOperationException(),
				};
				infos[i] = new Info(i >= (int)IcedConstants.FirstBroadcastMemorySize, sizes[d >> SizeKindShift], keywords);
			}

			return infos;
		}
	}
}
#endif
