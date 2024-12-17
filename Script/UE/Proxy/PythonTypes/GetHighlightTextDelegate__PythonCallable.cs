using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/GetHighlightTextDelegate__PythonCallable.GetHighlightTextDelegate__PythonCallable")]
	public partial class GetHighlightTextDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/GetHighlightTextDelegate__PythonCallable.GetHighlightTextDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}