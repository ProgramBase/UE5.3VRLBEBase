using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkFrameInterpolationProcessor")]
	public partial class ULiveLinkFrameInterpolationProcessor : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkFrameInterpolationProcessor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}