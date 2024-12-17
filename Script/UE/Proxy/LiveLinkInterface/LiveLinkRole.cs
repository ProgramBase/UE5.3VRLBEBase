using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkRole")]
	public partial class ULiveLinkRole : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkRole");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}