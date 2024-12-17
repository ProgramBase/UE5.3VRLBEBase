using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioFinished__PythonCallable.OnAudioFinished__PythonCallable")]
	public partial class OnAudioFinished__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioFinished__PythonCallable.OnAudioFinished__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}