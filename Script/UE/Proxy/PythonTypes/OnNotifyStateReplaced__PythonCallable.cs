using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnNotifyStateReplaced__PythonCallable.OnNotifyStateReplaced__PythonCallable")]
	public partial class OnNotifyStateReplaced__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnNotifyStateReplaced__PythonCallable.OnNotifyStateReplaced__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}