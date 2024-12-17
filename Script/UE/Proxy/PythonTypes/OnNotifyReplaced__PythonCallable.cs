using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnNotifyReplaced__PythonCallable.OnNotifyReplaced__PythonCallable")]
	public partial class OnNotifyReplaced__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnNotifyReplaced__PythonCallable.OnNotifyReplaced__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}