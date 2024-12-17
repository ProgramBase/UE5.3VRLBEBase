using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLevelEditorPreSaveWorld__PythonCallable.OnLevelEditorPreSaveWorld__PythonCallable")]
	public partial class OnLevelEditorPreSaveWorld__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLevelEditorPreSaveWorld__PythonCallable.OnLevelEditorPreSaveWorld__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}