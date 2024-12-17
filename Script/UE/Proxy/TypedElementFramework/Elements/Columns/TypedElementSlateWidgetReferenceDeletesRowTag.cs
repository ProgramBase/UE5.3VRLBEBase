using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementSlateWidgetReferenceDeletesRowTag")]
	public partial class FTypedElementSlateWidgetReferenceDeletesRowTag : FTypedElementDataStorageTag, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementSlateWidgetReferenceDeletesRowTag");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementSlateWidgetReferenceDeletesRowTag()
		{
		}

		public static bool operator ==(FTypedElementSlateWidgetReferenceDeletesRowTag A, FTypedElementSlateWidgetReferenceDeletesRowTag B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementSlateWidgetReferenceDeletesRowTag A, FTypedElementSlateWidgetReferenceDeletesRowTag B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementSlateWidgetReferenceDeletesRowTag;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}