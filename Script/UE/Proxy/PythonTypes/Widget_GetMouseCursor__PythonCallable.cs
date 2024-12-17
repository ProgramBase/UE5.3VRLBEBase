using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/Widget_GetMouseCursor__PythonCallable.Widget_GetMouseCursor__PythonCallable")]
	public partial class Widget_GetMouseCursor__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/Widget_GetMouseCursor__PythonCallable.Widget_GetMouseCursor__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}