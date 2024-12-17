using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkTransformRole")]
	public partial class ULiveLinkTransformRole : ULiveLinkBasicRole, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkTransformRole");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}