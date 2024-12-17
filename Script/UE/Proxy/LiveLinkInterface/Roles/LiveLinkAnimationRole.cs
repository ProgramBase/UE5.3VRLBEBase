using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkAnimationRole")]
	public partial class ULiveLinkAnimationRole : ULiveLinkBasicRole, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkAnimationRole");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}