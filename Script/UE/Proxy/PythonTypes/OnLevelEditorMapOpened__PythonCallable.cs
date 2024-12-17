using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLevelEditorMapOpened__PythonCallable.OnLevelEditorMapOpened__PythonCallable")]
	public partial class OnLevelEditorMapOpened__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLevelEditorMapOpened__PythonCallable.OnLevelEditorMapOpened__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}