using Script.CoreUObject;
using Script.Library;

namespace Script.AudioWidgets
{
	[PathName("/Script/AudioWidgets.AudioFrequencyRadialSlider")]
	public partial class UAudioFrequencyRadialSlider : UAudioRadialSlider, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioWidgets.AudioFrequencyRadialSlider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}