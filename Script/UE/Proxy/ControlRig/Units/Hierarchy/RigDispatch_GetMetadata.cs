using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigDispatch_GetMetadata")]
	public partial class FRigDispatch_GetMetadata : FRigDispatch_MetadataBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigDispatch_GetMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigDispatch_GetMetadata()
		{
		}

		public static bool operator ==(FRigDispatch_GetMetadata A, FRigDispatch_GetMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigDispatch_GetMetadata A, FRigDispatch_GetMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigDispatch_GetMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}