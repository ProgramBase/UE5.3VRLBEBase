using Script.CoreUObject;
using Script.Library;

namespace Script.SkeletalMeshEditor
{
	[PathName("/Script/SkeletalMeshEditor.SkeletalMeshEditorContextMenuContext")]
	public partial class USkeletalMeshEditorContextMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SkeletalMeshEditor.SkeletalMeshEditorContextMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}