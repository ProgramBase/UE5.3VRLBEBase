using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorFloor")]
	public partial class FRigVMFunction_MathVectorFloor : FRigVMFunction_MathVectorUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorFloor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorFloor()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorFloor A, FRigVMFunction_MathVectorFloor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorFloor A, FRigVMFunction_MathVectorFloor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorFloor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}