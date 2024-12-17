using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLevelEditorPostSaveWorld__PythonCallable.OnLevelEditorPostSaveWorld__PythonCallable")]
	public partial class OnLevelEditorPostSaveWorld__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLevelEditorPostSaveWorld__PythonCallable.OnLevelEditorPostSaveWorld__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}