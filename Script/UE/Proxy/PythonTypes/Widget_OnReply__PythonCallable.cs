using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/Widget_OnReply__PythonCallable.Widget_OnReply__PythonCallable")]
	public partial class Widget_OnReply__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/Widget_OnReply__PythonCallable.Widget_OnReply__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}