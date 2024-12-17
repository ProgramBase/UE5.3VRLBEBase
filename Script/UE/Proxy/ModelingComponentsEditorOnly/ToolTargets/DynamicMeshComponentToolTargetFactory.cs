using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponentsEditorOnly
{
	[PathName("/Script/ModelingComponentsEditorOnly.DynamicMeshComponentToolTargetFactory")]
	public partial class UDynamicMeshComponentToolTargetFactory : UToolTargetFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponentsEditorOnly.DynamicMeshComponentToolTargetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}