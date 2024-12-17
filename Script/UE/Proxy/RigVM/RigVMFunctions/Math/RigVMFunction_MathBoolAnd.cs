using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathBoolAnd")]
	public partial class FRigVMFunction_MathBoolAnd : FRigVMFunction_MathBoolBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathBoolAnd");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathBoolAnd()
		{
		}

		public static bool operator ==(FRigVMFunction_MathBoolAnd A, FRigVMFunction_MathBoolAnd B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathBoolAnd A, FRigVMFunction_MathBoolAnd B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathBoolAnd;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}