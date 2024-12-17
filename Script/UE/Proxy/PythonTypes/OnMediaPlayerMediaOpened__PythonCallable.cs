using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnMediaPlayerMediaOpened__PythonCallable.OnMediaPlayerMediaOpened__PythonCallable")]
	public partial class OnMediaPlayerMediaOpened__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnMediaPlayerMediaOpened__PythonCallable.OnMediaPlayerMediaOpened__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}