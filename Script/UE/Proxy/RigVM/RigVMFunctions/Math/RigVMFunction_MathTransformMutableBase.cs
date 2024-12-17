using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathTransformMutableBase")]
	public partial class FRigVMFunction_MathTransformMutableBase : FRigVMFunction_MathMutableBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathTransformMutableBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathTransformMutableBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathTransformMutableBase A, FRigVMFunction_MathTransformMutableBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathTransformMutableBase A, FRigVMFunction_MathTransformMutableBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathTransformMutableBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}