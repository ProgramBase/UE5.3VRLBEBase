using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_SimBase")]
	public partial class FRigVMFunction_SimBase : FRigVMStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_SimBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_SimBase()
		{
		}

		public static bool operator ==(FRigVMFunction_SimBase A, FRigVMFunction_SimBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_SimBase A, FRigVMFunction_SimBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_SimBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}