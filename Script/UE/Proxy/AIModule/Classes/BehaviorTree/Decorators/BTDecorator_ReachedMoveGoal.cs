using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTDecorator_ReachedMoveGoal")]
	public partial class UBTDecorator_ReachedMoveGoal : UBTDecorator, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTDecorator_ReachedMoveGoal");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}