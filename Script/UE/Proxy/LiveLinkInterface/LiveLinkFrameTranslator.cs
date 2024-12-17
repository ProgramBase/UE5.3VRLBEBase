using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkFrameTranslator")]
	public partial class ULiveLinkFrameTranslator : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkFrameTranslator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}