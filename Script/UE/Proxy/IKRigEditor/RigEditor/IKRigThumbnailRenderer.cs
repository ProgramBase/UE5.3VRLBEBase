using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRigThumbnailRenderer")]
	public partial class UIKRigThumbnailRenderer : USkeletalMeshThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRigEditor.IKRigThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}