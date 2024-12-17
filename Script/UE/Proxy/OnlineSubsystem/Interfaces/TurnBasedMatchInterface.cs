using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystem
{
	[PathName("/Script/OnlineSubsystem.TurnBasedMatchInterface")]
	public partial class UTurnBasedMatchInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystem.TurnBasedMatchInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/OnlineSubsystem.TurnBasedMatchInterface")]
	public interface ITurnBasedMatchInterface : IInterface
	{
		 void OnMatchReceivedTurn(FString Match, bool bDidBecomeActive);

		 void OnMatchEnded(FString Match);
	}
}