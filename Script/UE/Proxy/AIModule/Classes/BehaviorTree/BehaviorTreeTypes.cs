using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BehaviorTreeTypes")]
	public partial class UBehaviorTreeTypes : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BehaviorTreeTypes");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}