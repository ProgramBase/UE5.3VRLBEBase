using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.SkeletalMeshEditorContextObjectBase")]
	public partial class USkeletalMeshEditorContextObjectBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.SkeletalMeshEditorContextObjectBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}