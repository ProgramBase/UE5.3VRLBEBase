using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleConstTwoPi")]
	public partial class FRigVMFunction_MathDoubleConstTwoPi : FRigVMFunction_MathDoubleConstant, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleConstTwoPi");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleConstTwoPi()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleConstTwoPi A, FRigVMFunction_MathDoubleConstTwoPi B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleConstTwoPi A, FRigVMFunction_MathDoubleConstTwoPi B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleConstTwoPi;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}