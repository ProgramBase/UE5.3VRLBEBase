using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatConstE")]
	public partial class FRigVMFunction_MathFloatConstE : FRigVMFunction_MathFloatConstant, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatConstE");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatConstE()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatConstE A, FRigVMFunction_MathFloatConstE B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatConstE A, FRigVMFunction_MathFloatConstE B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatConstE;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}