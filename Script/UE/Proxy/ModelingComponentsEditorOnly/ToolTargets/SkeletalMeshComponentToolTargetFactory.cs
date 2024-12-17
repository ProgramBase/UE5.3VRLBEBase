using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponentsEditorOnly
{
	[PathName("/Script/ModelingComponentsEditorOnly.SkeletalMeshComponentToolTargetFactory")]
	public partial class USkeletalMeshComponentToolTargetFactory : UToolTargetFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponentsEditorOnly.SkeletalMeshComponentToolTargetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}