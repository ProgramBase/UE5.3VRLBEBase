﻿using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleLess")]
	public partial class FRigVMFunction_MathDoubleLess : FRigVMFunction_MathDoubleBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleLess");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleLess()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleLess A, FRigVMFunction_MathDoubleLess B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleLess A, FRigVMFunction_MathDoubleLess B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleLess;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public double A
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __A, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __A, __InBuffer);
				}
			}
		}

		public double B
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __B, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __B, __InBuffer);
				}
			}
		}

		public bool Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		private static uint __A = 0;

		private static uint __B = 0;

		private static uint __Result = 0;

	}
}