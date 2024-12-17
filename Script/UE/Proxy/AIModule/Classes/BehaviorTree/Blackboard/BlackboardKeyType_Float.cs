using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BlackboardKeyType_Float")]
	public partial class UBlackboardKeyType_Float : UBlackboardKeyType, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BlackboardKeyType_Float");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}