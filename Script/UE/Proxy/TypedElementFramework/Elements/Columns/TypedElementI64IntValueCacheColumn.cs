using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementI64IntValueCacheColumn")]
	public partial class FTypedElementI64IntValueCacheColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementI64IntValueCacheColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementI64IntValueCacheColumn()
		{
		}

		public static bool operator ==(FTypedElementI64IntValueCacheColumn A, FTypedElementI64IntValueCacheColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementI64IntValueCacheColumn A, FTypedElementI64IntValueCacheColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementI64IntValueCacheColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public long Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(long*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(long*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

	}
}