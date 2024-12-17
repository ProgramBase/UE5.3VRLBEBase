using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementScriptStructTypeInfoColumn")]
	public partial class FTypedElementScriptStructTypeInfoColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementScriptStructTypeInfoColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementScriptStructTypeInfoColumn()
		{
		}

		public static bool operator ==(FTypedElementScriptStructTypeInfoColumn A, FTypedElementScriptStructTypeInfoColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementScriptStructTypeInfoColumn A, FTypedElementScriptStructTypeInfoColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementScriptStructTypeInfoColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}