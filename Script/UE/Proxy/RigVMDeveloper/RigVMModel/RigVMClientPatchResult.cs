using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	[PathName("/Script/RigVMDeveloper.RigVMClientPatchResult")]
	public partial class FRigVMClientPatchResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVMDeveloper.RigVMClientPatchResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMClientPatchResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMClientPatchResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMClientPatchResult A, FRigVMClientPatchResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMClientPatchResult A, FRigVMClientPatchResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMClientPatchResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}