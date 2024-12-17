using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementDataStorageColumn")]
	public partial class FTypedElementDataStorageColumn : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementDataStorageColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementDataStorageColumn() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTypedElementDataStorageColumn() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTypedElementDataStorageColumn A, FTypedElementDataStorageColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementDataStorageColumn A, FTypedElementDataStorageColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementDataStorageColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}