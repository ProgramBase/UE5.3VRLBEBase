using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/Widget_GetBool__PythonCallable.Widget_GetBool__PythonCallable")]
	public partial class Widget_GetBool__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/Widget_GetBool__PythonCallable.Widget_GetBool__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}