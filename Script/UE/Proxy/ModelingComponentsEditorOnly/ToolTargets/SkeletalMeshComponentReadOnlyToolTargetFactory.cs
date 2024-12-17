using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponentsEditorOnly
{
	[PathName("/Script/ModelingComponentsEditorOnly.SkeletalMeshComponentReadOnlyToolTargetFactory")]
	public partial class USkeletalMeshComponentReadOnlyToolTargetFactory : UToolTargetFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponentsEditorOnly.SkeletalMeshComponentReadOnlyToolTargetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}