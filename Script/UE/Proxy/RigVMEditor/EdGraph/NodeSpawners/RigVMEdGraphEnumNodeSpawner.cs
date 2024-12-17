using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMEditor
{
	[PathName("/Script/RigVMEditor.RigVMEdGraphEnumNodeSpawner")]
	public partial class URigVMEdGraphEnumNodeSpawner : URigVMEdGraphNodeSpawner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMEditor.RigVMEdGraphEnumNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}