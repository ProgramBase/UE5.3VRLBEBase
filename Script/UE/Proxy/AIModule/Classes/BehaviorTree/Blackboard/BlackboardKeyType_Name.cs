using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BlackboardKeyType_Name")]
	public partial class UBlackboardKeyType_Name : UBlackboardKeyType, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BlackboardKeyType_Name");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}