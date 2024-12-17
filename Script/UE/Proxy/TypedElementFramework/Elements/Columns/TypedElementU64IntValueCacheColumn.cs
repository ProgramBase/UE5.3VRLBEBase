using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementU64IntValueCacheColumn")]
	public partial class FTypedElementU64IntValueCacheColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementU64IntValueCacheColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementU64IntValueCacheColumn()
		{
		}

		public static bool operator ==(FTypedElementU64IntValueCacheColumn A, FTypedElementU64IntValueCacheColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementU64IntValueCacheColumn A, FTypedElementU64IntValueCacheColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementU64IntValueCacheColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ulong Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(ulong*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(ulong*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

	}
}