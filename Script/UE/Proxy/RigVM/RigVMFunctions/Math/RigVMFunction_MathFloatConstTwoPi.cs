using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathFloatConstTwoPi")]
	public partial class FRigVMFunction_MathFloatConstTwoPi : FRigVMFunction_MathFloatConstant, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathFloatConstTwoPi");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathFloatConstTwoPi()
		{
		}

		public static bool operator ==(FRigVMFunction_MathFloatConstTwoPi A, FRigVMFunction_MathFloatConstTwoPi B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathFloatConstTwoPi A, FRigVMFunction_MathFloatConstTwoPi B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathFloatConstTwoPi;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}