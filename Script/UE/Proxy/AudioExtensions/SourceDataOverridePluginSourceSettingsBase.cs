using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.SourceDataOverridePluginSourceSettingsBase")]
	public partial class USourceDataOverridePluginSourceSettingsBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.SourceDataOverridePluginSourceSettingsBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}