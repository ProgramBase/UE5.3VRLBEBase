using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigDispatch_SetMetadata")]
	public partial class FRigDispatch_SetMetadata : FRigDispatch_MetadataBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigDispatch_SetMetadata");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigDispatch_SetMetadata()
		{
		}

		public static bool operator ==(FRigDispatch_SetMetadata A, FRigDispatch_SetMetadata B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigDispatch_SetMetadata A, FRigDispatch_SetMetadata B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigDispatch_SetMetadata;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}