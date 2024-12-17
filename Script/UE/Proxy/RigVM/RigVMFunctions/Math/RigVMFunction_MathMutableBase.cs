using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_MathMutableBase")]
	public partial class FRigVMFunction_MathMutableBase : FRigVMStructMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_MathMutableBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_MathMutableBase()
		{
		}

		public static bool operator ==(FRigVMFunction_MathMutableBase A, FRigVMFunction_MathMutableBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_MathMutableBase A, FRigVMFunction_MathMutableBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_MathMutableBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}