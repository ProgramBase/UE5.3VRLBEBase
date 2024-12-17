using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkBasicRole")]
	public partial class ULiveLinkBasicRole : ULiveLinkRole, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkBasicRole");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}