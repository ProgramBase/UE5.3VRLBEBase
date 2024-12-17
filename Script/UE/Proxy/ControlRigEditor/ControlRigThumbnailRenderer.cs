using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigThumbnailRenderer")]
	public partial class UControlRigThumbnailRenderer : USkeletalMeshThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}