using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementSelectionColumn")]
	public partial class FTypedElementSelectionColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementSelectionColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementSelectionColumn()
		{
		}

		public static bool operator ==(FTypedElementSelectionColumn A, FTypedElementSelectionColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementSelectionColumn A, FTypedElementSelectionColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementSelectionColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}