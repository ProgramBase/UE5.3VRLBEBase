using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMEditor
{
	[PathName("/Script/RigVMEditor.RigVMEdGraphVariableNodeSpawner")]
	public partial class URigVMEdGraphVariableNodeSpawner : URigVMEdGraphNodeSpawner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMEditor.RigVMEdGraphVariableNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}