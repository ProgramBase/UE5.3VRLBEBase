using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.DetourCrowdAIController")]
	public partial class ADetourCrowdAIController : AAIController, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.DetourCrowdAIController");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}