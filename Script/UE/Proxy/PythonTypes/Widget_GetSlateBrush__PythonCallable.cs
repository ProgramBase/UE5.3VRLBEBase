using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/Widget_GetSlateBrush__PythonCallable.Widget_GetSlateBrush__PythonCallable")]
	public partial class Widget_GetSlateBrush__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/Widget_GetSlateBrush__PythonCallable.Widget_GetSlateBrush__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}