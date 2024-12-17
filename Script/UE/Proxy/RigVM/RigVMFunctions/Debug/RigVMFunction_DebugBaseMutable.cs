using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_DebugBaseMutable")]
	public partial class FRigVMFunction_DebugBaseMutable : FRigVMStructMutable, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_DebugBaseMutable");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_DebugBaseMutable()
		{
		}

		public static bool operator ==(FRigVMFunction_DebugBaseMutable A, FRigVMFunction_DebugBaseMutable B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_DebugBaseMutable A, FRigVMFunction_DebugBaseMutable B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_DebugBaseMutable;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}