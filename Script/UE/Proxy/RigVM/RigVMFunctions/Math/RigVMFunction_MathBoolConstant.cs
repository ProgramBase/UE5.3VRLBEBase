using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathBoolConstant")]
	public partial class FRigVMFunction_MathBoolConstant : FRigVMFunction_MathBoolBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathBoolConstant");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathBoolConstant()
		{
		}

		public static bool operator ==(FRigVMFunction_MathBoolConstant A, FRigVMFunction_MathBoolConstant B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathBoolConstant A, FRigVMFunction_MathBoolConstant B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathBoolConstant;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

	}
}