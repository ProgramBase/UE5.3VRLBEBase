using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ControlRig_OnControlSelectedBP__PythonCallable.ControlRig_OnControlSelectedBP__PythonCallable")]
	public partial class ControlRig_OnControlSelectedBP__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ControlRig_OnControlSelectedBP__PythonCallable.ControlRig_OnControlSelectedBP__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}