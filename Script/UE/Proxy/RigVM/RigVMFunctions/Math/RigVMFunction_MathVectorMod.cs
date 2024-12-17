using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorMod")]
	public partial class FRigVMFunction_MathVectorMod : FRigVMFunction_MathVectorBinaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorMod");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorMod()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorMod A, FRigVMFunction_MathVectorMod B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorMod A, FRigVMFunction_MathVectorMod B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorMod;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}