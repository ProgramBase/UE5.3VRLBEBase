using Script.CoreUObject;
using Script.Library;

namespace Script.AudioExtensions
{
	[PathName("/Script/AudioExtensions.OcclusionPluginSourceSettingsBase")]
	public partial class UOcclusionPluginSourceSettingsBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioExtensions.OcclusionPluginSourceSettingsBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}