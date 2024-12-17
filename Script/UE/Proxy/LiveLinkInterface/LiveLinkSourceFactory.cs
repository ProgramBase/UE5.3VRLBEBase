using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkSourceFactory")]
	public partial class ULiveLinkSourceFactory : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkSourceFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}