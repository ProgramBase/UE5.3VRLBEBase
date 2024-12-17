using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementExternalObjectColumn")]
	public partial class FTypedElementExternalObjectColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementExternalObjectColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementExternalObjectColumn()
		{
		}

		public static bool operator ==(FTypedElementExternalObjectColumn A, FTypedElementExternalObjectColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementExternalObjectColumn A, FTypedElementExternalObjectColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementExternalObjectColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}