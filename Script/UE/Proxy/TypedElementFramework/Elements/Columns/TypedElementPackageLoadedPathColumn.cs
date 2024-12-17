using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementPackageLoadedPathColumn")]
	public partial class FTypedElementPackageLoadedPathColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementPackageLoadedPathColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementPackageLoadedPathColumn()
		{
		}

		public static bool operator ==(FTypedElementPackageLoadedPathColumn A, FTypedElementPackageLoadedPathColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementPackageLoadedPathColumn A, FTypedElementPackageLoadedPathColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementPackageLoadedPathColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}