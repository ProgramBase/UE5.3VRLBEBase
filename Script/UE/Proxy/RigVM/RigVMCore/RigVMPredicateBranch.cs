using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMPredicateBranch")]
	public partial class FRigVMPredicateBranch : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMPredicateBranch");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMPredicateBranch() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMPredicateBranch() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMPredicateBranch A, FRigVMPredicateBranch B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMPredicateBranch A, FRigVMPredicateBranch B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMPredicateBranch;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}