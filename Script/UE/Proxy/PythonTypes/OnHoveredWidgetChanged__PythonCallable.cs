using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnHoveredWidgetChanged__PythonCallable.OnHoveredWidgetChanged__PythonCallable")]
	public partial class OnHoveredWidgetChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnHoveredWidgetChanged__PythonCallable.OnHoveredWidgetChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}