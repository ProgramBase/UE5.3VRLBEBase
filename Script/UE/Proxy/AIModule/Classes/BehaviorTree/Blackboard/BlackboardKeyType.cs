using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BlackboardKeyType")]
	public partial class UBlackboardKeyType : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BlackboardKeyType");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}