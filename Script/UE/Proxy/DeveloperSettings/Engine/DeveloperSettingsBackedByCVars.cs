using Script.CoreUObject;
using Script.Library;

namespace Script.DeveloperSettings
{
	[PathName("/Script/DeveloperSettings.DeveloperSettingsBackedByCVars")]
	public partial class UDeveloperSettingsBackedByCVars : UDeveloperSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DeveloperSettings.DeveloperSettingsBackedByCVars");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}