using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathDoubleSub")]
	public partial class FRigVMFunction_MathDoubleSub : FRigVMFunction_MathDoubleBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathDoubleSub");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathDoubleSub()
		{
		}

		public static bool operator ==(FRigVMFunction_MathDoubleSub A, FRigVMFunction_MathDoubleSub B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathDoubleSub A, FRigVMFunction_MathDoubleSub B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathDoubleSub;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}