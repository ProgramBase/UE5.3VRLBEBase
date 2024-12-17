using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_ControlFlowBase")]
	public partial class FRigVMFunction_ControlFlowBase : FRigVMStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_ControlFlowBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_ControlFlowBase()
		{
		}

		public static bool operator ==(FRigVMFunction_ControlFlowBase A, FRigVMFunction_ControlFlowBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_ControlFlowBase A, FRigVMFunction_ControlFlowBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_ControlFlowBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}