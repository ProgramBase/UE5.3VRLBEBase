using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorDeg")]
	public partial class FRigVMFunction_MathVectorDeg : FRigVMFunction_MathVectorUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorDeg");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorDeg()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorDeg A, FRigVMFunction_MathVectorDeg B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorDeg A, FRigVMFunction_MathVectorDeg B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorDeg;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}