using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AITask_LockLogic")]
	public partial class UAITask_LockLogic : UAITask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AITask_LockLogic");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}