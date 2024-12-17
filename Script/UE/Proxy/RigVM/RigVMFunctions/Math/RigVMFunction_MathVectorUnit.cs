using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathVectorUnit")]
	public partial class FRigVMFunction_MathVectorUnit : FRigVMFunction_MathVectorUnaryOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathVectorUnit");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathVectorUnit()
		{
		}

		public static bool operator ==(FRigVMFunction_MathVectorUnit A, FRigVMFunction_MathVectorUnit B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathVectorUnit A, FRigVMFunction_MathVectorUnit B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathVectorUnit;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}