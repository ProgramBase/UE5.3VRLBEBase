using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkFramePreProcessor")]
	public partial class ULiveLinkFramePreProcessor : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkFramePreProcessor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}