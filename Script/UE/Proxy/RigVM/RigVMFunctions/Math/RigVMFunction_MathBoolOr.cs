using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathBoolOr")]
	public partial class FRigVMFunction_MathBoolOr : FRigVMFunction_MathBoolBinaryAggregateOp, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathBoolOr");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathBoolOr()
		{
		}

		public static bool operator ==(FRigVMFunction_MathBoolOr A, FRigVMFunction_MathBoolOr B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathBoolOr A, FRigVMFunction_MathBoolOr B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathBoolOr;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}