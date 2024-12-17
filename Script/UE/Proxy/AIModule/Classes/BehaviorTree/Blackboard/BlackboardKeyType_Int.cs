using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BlackboardKeyType_Int")]
	public partial class UBlackboardKeyType_Int : UBlackboardKeyType, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BlackboardKeyType_Int");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}