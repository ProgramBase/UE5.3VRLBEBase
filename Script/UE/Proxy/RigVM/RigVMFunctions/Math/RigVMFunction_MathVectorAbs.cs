using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorAbs")]
	public partial class FRigVMFunction_MathVectorAbs : FRigVMFunction_MathVectorUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorAbs");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorAbs()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorAbs A, FRigVMFunction_MathVectorAbs B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorAbs A, FRigVMFunction_MathVectorAbs B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorAbs;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}