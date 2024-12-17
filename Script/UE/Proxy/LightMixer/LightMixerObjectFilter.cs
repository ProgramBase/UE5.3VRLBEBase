using Script.CoreUObject;
using Script.ObjectMixerEditor;
using Script.Library;

namespace Script.LightMixer
{
	[PathName("/Script/LightMixer.LightMixerObjectFilter")]
	public partial class ULightMixerObjectFilter : UObjectMixerObjectFilter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LightMixer.LightMixerObjectFilter");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}