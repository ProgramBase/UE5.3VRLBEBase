using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnFloatValueChangedEventSynth2D__PythonCallable.OnFloatValueChangedEventSynth2D__PythonCallable")]
	public partial class OnFloatValueChangedEventSynth2D__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnFloatValueChangedEventSynth2D__PythonCallable.OnFloatValueChangedEventSynth2D__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}