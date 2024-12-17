using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/LevelStreamingLoadedStatus__PythonCallable.LevelStreamingLoadedStatus__PythonCallable")]
	public partial class LevelStreamingLoadedStatus__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/LevelStreamingLoadedStatus__PythonCallable.LevelStreamingLoadedStatus__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}