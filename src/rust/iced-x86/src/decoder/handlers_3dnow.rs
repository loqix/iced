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

#![cfg_attr(feature = "cargo-clippy", allow(clippy::useless_let_if_seq))]

use super::*;

static CODE_VALUES: [u16; 0x100] = [
	// GENERATOR-BEGIN: D3nowCodeValues
	// ⚠️This was generated by GENERATOR!🦹‍♂️
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pi2fw_mm_mmm64 as u16,
	Code::D3NOW_Pi2fd_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pf2iw_mm_mmm64 as u16,
	Code::D3NOW_Pf2id_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfrcpv_mm_mmm64 as u16,
	Code::D3NOW_Pfrsqrtv_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfnacc_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfpnacc_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfcmpge_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfmin_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfrcp_mm_mmm64 as u16,
	Code::D3NOW_Pfrsqrt_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfsub_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfadd_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfcmpgt_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfmax_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfrcpit1_mm_mmm64 as u16,
	Code::D3NOW_Pfrsqit1_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfsubr_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfacc_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfcmpeq_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfmul_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pfrcpit2_mm_mmm64 as u16,
	Code::D3NOW_Pmulhrw_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pswapd_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::D3NOW_Pavgusb_mm_mmm64 as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	Code::INVALID as u16,
	// GENERATOR-END: D3nowCodeValues
];

#[allow(non_camel_case_types)]
#[repr(C)]
pub(crate) struct OpCodeHandler_D3NOW {
	pub(crate) decode: OpCodeHandlerDecodeFn,
	pub(crate) has_modrm: bool,
}

impl OpCodeHandler_D3NOW {
	pub(crate) fn decode(self_ptr: *const OpCodeHandler, decoder: &mut Decoder, instruction: &mut Instruction) {
		debug_assert!(decoder.state.encoding() == EncodingKind::Legacy);
		const_assert_eq!(0, OpKind::Register as u32);
		//super::instruction_internal::internal_set_op0_kind(instruction, OpKind::Register);
		super::instruction_internal::internal_set_op0_register_u32(instruction, decoder.state.reg + Register::MM0 as u32);
		let ib;
		if decoder.state.mod_ == 3 {
			const_assert_eq!(0, OpKind::Register as u32);
			//super::instruction_internal::internal_set_op1_kind(instruction, OpKind::Register);
			super::instruction_internal::internal_set_op1_register_u32(instruction, decoder.state.rm + Register::MM0 as u32);
			ib = decoder.read_u8();
		} else {
			super::instruction_internal::internal_set_op1_kind(instruction, OpKind::Memory);
			decoder.read_op_mem(instruction);
			ib = decoder.read_u8();
		}
		debug_assert_eq!(0x100, CODE_VALUES.len());
		// Safe, the index is always 00-FFh, and we only store valid Code values in the array
		let code = unsafe { std::mem::transmute(*CODE_VALUES.as_ptr().offset(ib as isize)) };
		super::instruction_internal::internal_set_code(instruction, code);
		if code == Code::INVALID {
			decoder.set_invalid_instruction();
		}
	}
}
