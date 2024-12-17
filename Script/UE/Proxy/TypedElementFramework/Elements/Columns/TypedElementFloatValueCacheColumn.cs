using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementFloatValueCacheColumn")]
	public partial class FTypedElementFloatValueCacheColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementFloatValueCacheColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementFloatValueCacheColumn()
		{
		}

		public static bool operator ==(FTypedElementFloatValueCacheColumn A, FTypedElementFloatValueCacheColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementFloatValueCacheColumn A, FTypedElementFloatValueCacheColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementFloatValueCacheColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

	}
}