using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunction_AnimBase")]
	public partial class FRigVMFunction_AnimBase : FRigVMStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunction_AnimBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunction_AnimBase()
		{
		}

		public static bool operator ==(FRigVMFunction_AnimBase A, FRigVMFunction_AnimBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunction_AnimBase A, FRigVMFunction_AnimBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunction_AnimBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}