using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ClassCookedMetaData")]
	public partial class UClassCookedMetaData : UObject, IStaticClass
	{
		public FStructCookedMetaDataStore ClassMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClassMetaData, __ReturnBuffer);

					return *(FStructCookedMetaDataStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClassMetaData, __InBuffer);
				}
			}
		}

		public TMap<FName, FStructCookedMetaDataStore> FunctionsMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionsMetaData, __ReturnBuffer);

					return *(TMap<FName, FStructCookedMetaDataStore>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionsMetaData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ClassCookedMetaData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ClassMetaData = 0;

		private static uint __FunctionsMetaData = 0;
	}
}