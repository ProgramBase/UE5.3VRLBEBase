using Script.CoreUObject;
using Script.Library;

namespace Script.DeveloperSettings
{
	[PathName("/Script/DeveloperSettings.PlatformSettingsManager")]
	public partial class UPlatformSettingsManager : UObject, IStaticClass
	{
		public TMap<TSubclassOf<UPlatformSettings>, FPlatformSettingsInstances> SettingsMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SettingsMap, __ReturnBuffer);

					return *(TMap<TSubclassOf<UPlatformSettings>, FPlatformSettingsInstances>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SettingsMap, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DeveloperSettings.PlatformSettingsManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SettingsMap = 0;
	}
}