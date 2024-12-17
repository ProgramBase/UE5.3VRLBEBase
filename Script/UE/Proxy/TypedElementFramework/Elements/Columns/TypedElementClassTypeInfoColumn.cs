using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementClassTypeInfoColumn")]
	public partial class FTypedElementClassTypeInfoColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementClassTypeInfoColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementClassTypeInfoColumn()
		{
		}

		public static bool operator ==(FTypedElementClassTypeInfoColumn A, FTypedElementClassTypeInfoColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementClassTypeInfoColumn A, FTypedElementClassTypeInfoColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementClassTypeInfoColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}