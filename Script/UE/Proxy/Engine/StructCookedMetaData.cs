using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StructCookedMetaData")]
	public partial class UStructCookedMetaData : UObject, IStaticClass
	{
		public FStructCookedMetaDataStore StructMetaData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StructMetaData, __ReturnBuffer);

					return *(FStructCookedMetaDataStore*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StructMetaData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StructCookedMetaData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __StructMetaData = 0;
	}
}