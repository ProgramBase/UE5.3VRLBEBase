using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatConstant")]
	public partial class FRigVMFunction_MathFloatConstant : FRigVMFunction_MathFloatBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatConstant");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatConstant()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatConstant A, FRigVMFunction_MathFloatConstant B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatConstant A, FRigVMFunction_MathFloatConstant B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatConstant;

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

		private static uint __Value = 0;

	}
}