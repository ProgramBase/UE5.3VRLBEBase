using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.GridPathAIController")]
	public partial class AGridPathAIController : AAIController, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.GridPathAIController");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}