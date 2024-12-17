using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/OnTakeRecorderPanelChanged__PythonCallable.OnTakeRecorderPanelChanged__PythonCallable")]
	public partial class OnTakeRecorderPanelChanged__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/OnTakeRecorderPanelChanged__PythonCallable.OnTakeRecorderPanelChanged__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}