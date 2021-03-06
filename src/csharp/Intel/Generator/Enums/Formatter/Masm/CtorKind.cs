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

namespace Generator.Enums.Formatter.Masm {
	[Enum(nameof(CtorKind), "MasmCtorKind")]
	enum CtorKind {
		Previous,
		Normal_1,
		Normal_2,
		AamAad,
		AX,
		AY,
		bnd,
		STIG1,
		DeclareData,
		DX,
		fword,
		Int3,
		imul,
		invlpga,
		CCa_1,
		CCa_2,
		CCa_3,
		CCb_1,
		CCb_2,
		CCb_3,
		jcc_1,
		jcc_2,
		jcc_3,
		Loopcc1,
		Loopcc2,
		maskmovq,
		memsize,
		YD,
		YX,
		monitor,
		mwait,
		mwaitx,
		nop,
		OpSize_1,
		OpSize_2,
		OpSize2,
		YA,
		pblendvb,
		pclmulqdq,
		pops_2,
		pops_3,
		XY,
		reg,
		Reg16,
		Reg32,
		reverse,
		ST_STi,
		STi_ST,
		XLAT,
	}
}
