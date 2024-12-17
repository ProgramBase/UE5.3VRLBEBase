using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BlackboardKeyType_Vector")]
	public partial class UBlackboardKeyType_Vector : UBlackboardKeyType, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BlackboardKeyType_Vector");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}