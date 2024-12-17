using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnLevelEditorEditorCameraMoved__PythonCallable.OnLevelEditorEditorCameraMoved__PythonCallable")]
	public partial class OnLevelEditorEditorCameraMoved__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnLevelEditorEditorCameraMoved__PythonCallable.OnLevelEditorEditorCameraMoved__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}