using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioRadialSliderValueChangedEvent__PythonCallable.OnAudioRadialSliderValueChangedEvent__PythonCallable")]
	public partial class OnAudioRadialSliderValueChangedEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioRadialSliderValueChangedEvent__PythonCallable.OnAudioRadialSliderValueChangedEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}