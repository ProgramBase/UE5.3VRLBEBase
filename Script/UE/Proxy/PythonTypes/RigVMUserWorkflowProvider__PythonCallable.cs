using Script.CoreUObject;
using Script.PythonScriptPlugin;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/RigVMUserWorkflowProvider__PythonCallable.RigVMUserWorkflowProvider__PythonCallable")]
	public partial class RigVMUserWorkflowProvider__PythonCallable : UPythonCallableForDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/RigVMUserWorkflowProvider__PythonCallable.RigVMUserWorkflowProvider__PythonCallable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}