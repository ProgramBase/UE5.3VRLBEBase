using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementRowReferenceColumn")]
	public partial class FTypedElementRowReferenceColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementRowReferenceColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementRowReferenceColumn()
		{
		}

		public static bool operator ==(FTypedElementRowReferenceColumn A, FTypedElementRowReferenceColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementRowReferenceColumn A, FTypedElementRowReferenceColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementRowReferenceColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}