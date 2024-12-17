using Script.CoreUObject;
using Script.Library;

namespace Script.AudioWidgets
{
	[PathName("/Script/AudioWidgets.AudioVolumeRadialSlider")]
	public partial class UAudioVolumeRadialSlider : UAudioRadialSlider, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioWidgets.AudioVolumeRadialSlider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}