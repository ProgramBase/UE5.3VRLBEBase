using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/SlateAccessibleWidgetData_GetText__PythonCallable.SlateAccessibleWidgetData_GetText__PythonCallable")]
	public partial class SlateAccessibleWidgetData_GetText__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/SlateAccessibleWidgetData_GetText__PythonCallable.SlateAccessibleWidgetData_GetText__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}