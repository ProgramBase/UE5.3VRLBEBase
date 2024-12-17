using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatUnaryOp")]
	public partial class FRigVMFunction_MathFloatUnaryOp : FRigVMFunction_MathFloatBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatUnaryOp");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatUnaryOp()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatUnaryOp A, FRigVMFunction_MathFloatUnaryOp B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatUnaryOp A, FRigVMFunction_MathFloatUnaryOp B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatUnaryOp;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		public float Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		private static uint __Result = 0;

	}
}