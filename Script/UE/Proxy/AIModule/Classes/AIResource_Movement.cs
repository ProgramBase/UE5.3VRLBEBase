using Script.CoreUObject;
using Script.GameplayTasks;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIResource_Movement")]
	public partial class UAIResource_Movement : UGameplayTaskResource, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AIResource_Movement");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}