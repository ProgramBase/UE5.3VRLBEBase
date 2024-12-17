using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/RigVMPeformUserWorkflowDynamicDelegate__PythonCallable.RigVMPeformUserWorkflowDynamicDelegate__PythonCallable")]
	public partial class RigVMPeformUserWorkflowDynamicDelegate__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/RigVMPeformUserWorkflowDynamicDelegate__PythonCallable.RigVMPeformUserWorkflowDynamicDelegate__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}