using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/RigVMGraphModifiedDynamicEvent__PythonCallable.RigVMGraphModifiedDynamicEvent__PythonCallable")]
	public partial class RigVMGraphModifiedDynamicEvent__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/RigVMGraphModifiedDynamicEvent__PythonCallable.RigVMGraphModifiedDynamicEvent__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}