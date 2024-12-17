using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigDispatch_FromString")]
	public partial class FRigDispatch_FromString : FRigVMDispatchFactory, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigDispatch_FromString");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigDispatch_FromString()
		{
		}

		public static bool operator ==(FRigDispatch_FromString A, FRigDispatch_FromString B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigDispatch_FromString A, FRigDispatch_FromString B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigDispatch_FromString;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}