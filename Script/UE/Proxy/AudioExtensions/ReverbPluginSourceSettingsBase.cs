using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.ReverbPluginSourceSettingsBase")]
	public partial class UReverbPluginSourceSettingsBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.ReverbPluginSourceSettingsBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}