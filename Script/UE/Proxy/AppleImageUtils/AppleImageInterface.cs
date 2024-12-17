using Script.CoreUObject;
using Script.Library;

namespace Script.AppleImageUtils
{
	[PathName("/Script/AppleImageUtils.AppleImageInterface")]
	public partial class UAppleImageInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AppleImageUtils.AppleImageInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AppleImageUtils.AppleImageInterface")]
	public interface IAppleImageInterface : IInterface
	{
	}
}