using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/Widget_GetInt32__PythonCallable.Widget_GetInt32__PythonCallable")]
	public partial class Widget_GetInt32__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/Widget_GetInt32__PythonCallable.Widget_GetInt32__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}