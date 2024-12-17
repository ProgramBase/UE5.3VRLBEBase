using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementU32IntValueCacheColumn")]
	public partial class FTypedElementU32IntValueCacheColumn : FTypedElementDataStorageColumn, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementFramework.TypedElementU32IntValueCacheColumn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementU32IntValueCacheColumn()
		{
		}

		public static bool operator ==(FTypedElementU32IntValueCacheColumn A, FTypedElementU32IntValueCacheColumn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementU32IntValueCacheColumn A, FTypedElementU32IntValueCacheColumn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementU32IntValueCacheColumn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

	}
}