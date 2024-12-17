using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.PartialNetObjectAttachmentHandler")]
	public partial class UPartialNetObjectAttachmentHandler : USequentialPartialNetBlobHandler, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.PartialNetObjectAttachmentHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}