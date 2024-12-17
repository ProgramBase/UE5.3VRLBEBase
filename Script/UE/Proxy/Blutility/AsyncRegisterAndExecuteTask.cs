using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.AsyncRegisterAndExecuteTask")]
	public partial class UAsyncRegisterAndExecuteTask : UBlueprintAsyncActionBase, IStaticClass
	{
		public FOnEditorUtilityTaskDynamicDelegate OnFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFinished, __ReturnBuffer);

					return *(FOnEditorUtilityTaskDynamicDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnFinished, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.AsyncRegisterAndExecuteTask");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAsyncRegisterAndExecuteTask RegisterAndExecuteTask(UEditorUtilityTask Task, UEditorUtilityTask OptionalParentTask = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Task?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OptionalParentTask?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RegisterAndExecuteTask, __InBuffer, __ReturnBuffer);

				return *(UAsyncRegisterAndExecuteTask*)__ReturnBuffer;
			}
		}

		private static uint __OnFinished = 0;

		private static uint __RegisterAndExecuteTask = 0;
	}
}