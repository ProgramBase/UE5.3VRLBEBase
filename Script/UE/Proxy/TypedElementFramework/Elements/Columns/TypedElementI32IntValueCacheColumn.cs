using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementI32IntValueCacheColumn")]
	public partial class FTypedElementI32IntValueCacheColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementI32IntValueCacheColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementI32IntValueCacheColumn()
		{
		}

		public static bool operator ==(FTypedElementI32IntValueCacheColumn A, FTypedElementI32IntValueCacheColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementI32IntValueCacheColumn A, FTypedElementI32IntValueCacheColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementI32IntValueCacheColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

	}
}