using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetStateSettings")]
	public partial class UWidgetStateSettings : UDeveloperSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetStateSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}