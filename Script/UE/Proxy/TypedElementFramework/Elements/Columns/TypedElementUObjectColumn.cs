using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementUObjectColumn")]
	public partial class FTypedElementUObjectColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementUObjectColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementUObjectColumn()
		{
		}

		public static bool operator ==(FTypedElementUObjectColumn A, FTypedElementUObjectColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementUObjectColumn A, FTypedElementUObjectColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementUObjectColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}