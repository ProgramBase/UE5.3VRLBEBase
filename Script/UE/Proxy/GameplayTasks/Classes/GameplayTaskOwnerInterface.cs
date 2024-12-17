using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.GameplayTaskOwnerInterface")]
	public partial class UGameplayTaskOwnerInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTasks.GameplayTaskOwnerInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/GameplayTasks.GameplayTaskOwnerInterface")]
	public interface IGameplayTaskOwnerInterface : IInterface
	{
	}
}