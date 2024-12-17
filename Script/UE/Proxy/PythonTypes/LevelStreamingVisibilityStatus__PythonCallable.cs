using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/LevelStreamingVisibilityStatus__PythonCallable.LevelStreamingVisibilityStatus__PythonCallable")]
	public partial class LevelStreamingVisibilityStatus__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/LevelStreamingVisibilityStatus__PythonCallable.LevelStreamingVisibilityStatus__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}