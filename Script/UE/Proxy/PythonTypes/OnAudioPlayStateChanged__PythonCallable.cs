using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnAudioPlayStateChanged__PythonCallable.OnAudioPlayStateChanged__PythonCallable")]
	public partial class OnAudioPlayStateChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnAudioPlayStateChanged__PythonCallable.OnAudioPlayStateChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}