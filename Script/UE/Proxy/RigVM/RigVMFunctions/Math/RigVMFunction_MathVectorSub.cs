using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorSub")]
	public partial class FRigVMFunction_MathVectorSub : FRigVMFunction_MathVectorBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorSub");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorSub()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorSub A, FRigVMFunction_MathVectorSub B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorSub A, FRigVMFunction_MathVectorSub B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorSub;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}