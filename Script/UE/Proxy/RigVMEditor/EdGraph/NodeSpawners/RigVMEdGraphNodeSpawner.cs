using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.RigVMEditor
{
	[PathName("/Script/RigVMEditor.RigVMEdGraphNodeSpawner")]
	public partial class URigVMEdGraphNodeSpawner : UBlueprintNodeSpawner, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVMEditor.RigVMEdGraphNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}