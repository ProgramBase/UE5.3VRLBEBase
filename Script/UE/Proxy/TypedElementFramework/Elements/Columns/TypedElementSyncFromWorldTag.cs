using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementSyncFromWorldTag")]
	public partial class FTypedElementSyncFromWorldTag : FTypedElementDataStorageTag, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementSyncFromWorldTag");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementSyncFromWorldTag()
		{
		}

		public static bool operator ==(FTypedElementSyncFromWorldTag A, FTypedElementSyncFromWorldTag B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementSyncFromWorldTag A, FTypedElementSyncFromWorldTag B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementSyncFromWorldTag;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}