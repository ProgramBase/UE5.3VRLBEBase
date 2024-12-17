using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BlackboardAssetProvider")]
	public partial class UBlackboardAssetProvider : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BlackboardAssetProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AIModule.BlackboardAssetProvider")]
	public interface IBlackboardAssetProvider : IInterface
	{
		 UBlackboardData GetBlackboardAsset();
	}
}