using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.IKRigEditor
{
	[PathName("/Script/IKRigEditor.IKRetargeterThumbnailRenderer")]
	public partial class UIKRetargeterThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IKRigEditor.IKRetargeterThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}