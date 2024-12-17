using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/ControlRigComponentDelegate__PythonCallable.ControlRigComponentDelegate__PythonCallable")]
	public partial class ControlRigComponentDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/ControlRigComponentDelegate__PythonCallable.ControlRigComponentDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}