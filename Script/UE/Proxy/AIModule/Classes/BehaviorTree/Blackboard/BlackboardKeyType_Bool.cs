using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BlackboardKeyType_Bool")]
	public partial class UBlackboardKeyType_Bool : UBlackboardKeyType, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BlackboardKeyType_Bool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}