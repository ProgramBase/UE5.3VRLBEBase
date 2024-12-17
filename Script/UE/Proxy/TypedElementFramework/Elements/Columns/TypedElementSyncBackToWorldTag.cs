using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementSyncBackToWorldTag")]
	public partial class FTypedElementSyncBackToWorldTag : FTypedElementDataStorageTag, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementSyncBackToWorldTag");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementSyncBackToWorldTag()
		{
		}

		public static bool operator ==(FTypedElementSyncBackToWorldTag A, FTypedElementSyncBackToWorldTag B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementSyncBackToWorldTag A, FTypedElementSyncBackToWorldTag B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementSyncBackToWorldTag;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}