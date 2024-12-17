using Script.CoreUObject;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.AutomationEditorTask")]
	public partial class UAutomationEditorTask : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.AutomationEditorTask");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsValidTask()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsValidTask, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsTaskDone()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsTaskDone, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __IsValidTask = 0;

		private static uint __IsTaskDone = 0;
	}
}