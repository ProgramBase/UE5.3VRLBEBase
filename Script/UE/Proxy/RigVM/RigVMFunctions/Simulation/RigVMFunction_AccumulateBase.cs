using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_AccumulateBase")]
	public partial class FRigVMFunction_AccumulateBase : FRigVMFunction_SimBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_AccumulateBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_AccumulateBase()
		{
		}

		public static bool operator ==(FRigVMFunction_AccumulateBase A, FRigVMFunction_AccumulateBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_AccumulateBase A, FRigVMFunction_AccumulateBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_AccumulateBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}