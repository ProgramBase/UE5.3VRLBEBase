using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkCameraRole")]
	public partial class ULiveLinkCameraRole : ULiveLinkTransformRole, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LiveLinkInterface.LiveLinkCameraRole");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}