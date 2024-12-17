using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkLightRole")]
	public partial class ULiveLinkLightRole : ULiveLinkTransformRole, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkLightRole");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}