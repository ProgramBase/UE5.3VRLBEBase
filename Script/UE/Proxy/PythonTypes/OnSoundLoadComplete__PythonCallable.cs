using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnSoundLoadComplete__PythonCallable.OnSoundLoadComplete__PythonCallable")]
	public partial class OnSoundLoadComplete__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnSoundLoadComplete__PythonCallable.OnSoundLoadComplete__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}