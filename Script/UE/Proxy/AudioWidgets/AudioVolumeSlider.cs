using Script.CoreUObject;
using Script.Library;

namespace Script.AudioWidgets
{
	[PathName("/Script/AudioWidgets.AudioVolumeSlider")]
	public partial class UAudioVolumeSlider : UAudioSlider, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioWidgets.AudioVolumeSlider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}