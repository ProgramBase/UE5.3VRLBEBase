using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponentsEditorOnly
{
	[PathName("/Script/ModelingComponentsEditorOnly.StaticMeshComponentToolTargetFactory")]
	public partial class UStaticMeshComponentToolTargetFactory : UToolTargetFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponentsEditorOnly.StaticMeshComponentToolTargetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}