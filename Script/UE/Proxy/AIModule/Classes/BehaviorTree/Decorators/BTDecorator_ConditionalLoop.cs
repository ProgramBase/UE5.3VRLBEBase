using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTDecorator_ConditionalLoop")]
	public partial class UBTDecorator_ConditionalLoop : UBTDecorator_Blackboard, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTDecorator_ConditionalLoop");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}