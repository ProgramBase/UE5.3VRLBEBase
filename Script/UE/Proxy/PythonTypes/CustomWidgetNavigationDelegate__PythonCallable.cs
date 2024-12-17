using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/CustomWidgetNavigationDelegate__PythonCallable.CustomWidgetNavigationDelegate__PythonCallable")]
	public partial class CustomWidgetNavigationDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/CustomWidgetNavigationDelegate__PythonCallable.CustomWidgetNavigationDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}