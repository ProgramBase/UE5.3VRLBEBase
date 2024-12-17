using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/WidgetLibrary_OnGameWindowCloseButtonClickedDelegate__PythonCallable.WidgetLibrary_OnGameWindowCloseButtonClickedDelegate__PythonCallable")]
	public partial class WidgetLibrary_OnGameWindowCloseButtonClickedDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/WidgetLibrary_OnGameWindowCloseButtonClickedDelegate__PythonCallable.WidgetLibrary_OnGameWindowCloseButtonClickedDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}