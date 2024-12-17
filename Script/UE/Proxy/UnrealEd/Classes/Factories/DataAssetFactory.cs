using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DataAssetFactory")]
	public partial class UDataAssetFactory : UFactory, IStaticClass
	{
		public TSubclassOf<UDataAsset> DataAssetClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataAssetClass, __ReturnBuffer);

					return *(TSubclassOf<UDataAsset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataAssetClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DataAssetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DataAssetClass = 0;
	}
}