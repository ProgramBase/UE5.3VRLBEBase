using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.SpatializationPluginSourceSettingsBase")]
	public partial class USpatializationPluginSourceSettingsBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.SpatializationPluginSourceSettingsBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}