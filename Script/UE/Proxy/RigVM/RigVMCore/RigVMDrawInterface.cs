using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMDrawInterface")]
	public partial class FRigVMDrawInterface : FRigVMDrawContainer, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMDrawInterface");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMDrawInterface()
		{
		}

		public static bool operator ==(FRigVMDrawInterface A, FRigVMDrawInterface B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMDrawInterface A, FRigVMDrawInterface B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMDrawInterface;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}