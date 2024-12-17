using Script.CoreUObject;
using Script.Library;

namespace Script.DeveloperSettings
{
	[PathName("/Script/DeveloperSettings.PlatformSettings")]
	public partial class UPlatformSettings : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DeveloperSettings.PlatformSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}