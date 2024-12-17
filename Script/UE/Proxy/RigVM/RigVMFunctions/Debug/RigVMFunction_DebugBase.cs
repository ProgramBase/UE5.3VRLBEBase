using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_DebugBase")]
	public partial class FRigVMFunction_DebugBase : FRigVMStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_DebugBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_DebugBase()
		{
		}

		public static bool operator ==(FRigVMFunction_DebugBase A, FRigVMFunction_DebugBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_DebugBase A, FRigVMFunction_DebugBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_DebugBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}