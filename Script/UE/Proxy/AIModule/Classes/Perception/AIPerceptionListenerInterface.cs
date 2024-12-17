using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIPerceptionListenerInterface")]
	public partial class UAIPerceptionListenerInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AIPerceptionListenerInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AIModule.AIPerceptionListenerInterface")]
	public interface IAIPerceptionListenerInterface : IInterface
	{
	}
}