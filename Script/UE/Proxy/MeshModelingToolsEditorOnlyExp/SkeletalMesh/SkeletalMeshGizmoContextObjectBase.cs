using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.SkeletalMeshGizmoContextObjectBase")]
	public partial class USkeletalMeshGizmoContextObjectBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.SkeletalMeshGizmoContextObjectBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}