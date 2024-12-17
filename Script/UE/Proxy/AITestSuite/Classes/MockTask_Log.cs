using Script.CoreUObject;
using Script.GameplayTasks;
using Script.Library;

namespace Script.AITestSuite
{
	[PathName("/Script/AITestSuite.MockTask_Log")]
	public partial class UMockTask_Log : UGameplayTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AITestSuite.MockTask_Log");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}