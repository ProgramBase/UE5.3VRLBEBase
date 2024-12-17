using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMediaPlayerMediaOpenFailed__PythonCallable.OnMediaPlayerMediaOpenFailed__PythonCallable")]
	public partial class OnMediaPlayerMediaOpenFailed__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMediaPlayerMediaOpenFailed__PythonCallable.OnMediaPlayerMediaOpenFailed__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}