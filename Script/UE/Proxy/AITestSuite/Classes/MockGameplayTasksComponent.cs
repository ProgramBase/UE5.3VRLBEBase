using Script.CoreUObject;
using Script.GameplayTasks;
using Script.Library;

namespace Script.AITestSuite
{
	[PathName("/Script/AITestSuite.MockGameplayTasksComponent")]
	public partial class UMockGameplayTasksComponent : UGameplayTasksComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AITestSuite.MockGameplayTasksComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}