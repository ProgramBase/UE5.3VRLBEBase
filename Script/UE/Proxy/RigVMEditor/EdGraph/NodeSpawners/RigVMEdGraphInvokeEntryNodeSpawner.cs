using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMEditor
{
	[PathName("/Script/RigVMEditor.RigVMEdGraphInvokeEntryNodeSpawner")]
	public partial class URigVMEdGraphInvokeEntryNodeSpawner : URigVMEdGraphNodeSpawner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMEditor.RigVMEdGraphInvokeEntryNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}