using Script.CoreUObject;
using Script.Library;

namespace Script.DeveloperSettings
{
	[PathName("/Script/DeveloperSettings.DeveloperSettings")]
	public partial class UDeveloperSettings : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DeveloperSettings.DeveloperSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}