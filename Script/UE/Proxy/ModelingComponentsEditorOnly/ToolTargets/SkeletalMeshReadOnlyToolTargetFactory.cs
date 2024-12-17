using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponentsEditorOnly
{
	[PathName("/Script/ModelingComponentsEditorOnly.SkeletalMeshReadOnlyToolTargetFactory")]
	public partial class USkeletalMeshReadOnlyToolTargetFactory : UToolTargetFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponentsEditorOnly.SkeletalMeshReadOnlyToolTargetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}