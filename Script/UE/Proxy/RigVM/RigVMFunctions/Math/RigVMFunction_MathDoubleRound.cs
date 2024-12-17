﻿using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleRound")]
	public partial class FRigVMFunction_MathDoubleRound : FRigVMFunction_MathDoubleBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleRound");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleRound()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleRound A, FRigVMFunction_MathDoubleRound B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleRound A, FRigVMFunction_MathDoubleRound B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleRound;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public double Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		public double Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		public int Int
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Int, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Int, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		private static uint __Result = 0;

		private static uint __Int = 0;

	}
}