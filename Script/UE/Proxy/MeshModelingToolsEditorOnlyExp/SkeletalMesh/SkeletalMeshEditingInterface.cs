using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.SkeletalMeshEditingInterface")]
	public partial class USkeletalMeshEditingInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.SkeletalMeshEditingInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MeshModelingToolsEditorOnlyExp.SkeletalMeshEditingInterface")]
	public interface ISkeletalMeshEditingInterface : IInterface
	{
	}
}