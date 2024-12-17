using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.AssetToolsSettings")]
	public partial class UAssetToolsSettings : UDeveloperSettings, IStaticClass
	{
		public TArray<FAdvancedCopyMap> AdvancedCopyCustomizations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AdvancedCopyCustomizations, __ReturnBuffer);

					return *(TArray<FAdvancedCopyMap>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AdvancedCopyCustomizations, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetTools.AssetToolsSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AdvancedCopyCustomizations = 0;
	}
}