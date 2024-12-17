using Script.CoreUObject;
using Script.Library;

namespace Script.StructUtils
{
	[PathName("/Script/StructUtils.PropertyBagPropertyDescMetaData")]
	public partial class FPropertyBagPropertyDescMetaData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/StructUtils.PropertyBagPropertyDescMetaData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyBagPropertyDescMetaData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyBagPropertyDescMetaData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyBagPropertyDescMetaData A, FPropertyBagPropertyDescMetaData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyBagPropertyDescMetaData A, FPropertyBagPropertyDescMetaData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyBagPropertyDescMetaData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Key
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Key, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Key, __InBuffer);
				}
			}
		}

		public FString Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Key = 0;

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}