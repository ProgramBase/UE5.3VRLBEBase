using Script.CoreUObject;
using Script.GameplayTasks.GameplayTask_WaitDelay;
using Script.Library;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.GameplayTask_WaitDelay")]
	public partial class UGameplayTask_WaitDelay : UGameplayTask, IStaticClass
	{
		public FTaskDelayDelegate OnFinish
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFinish, __ReturnBuffer);

					return *(FTaskDelayDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnFinish, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTasks.GameplayTask_WaitDelay");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UGameplayTask_WaitDelay TaskWaitDelay(TScriptInterface<IGameplayTaskOwnerInterface> TaskOwner, float Time, byte Priority = 192)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = TaskOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				*(byte*)(__InBuffer + 12) = Priority;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TaskWaitDelay, __InBuffer, __ReturnBuffer);

				return *(UGameplayTask_WaitDelay*)__ReturnBuffer;
			}
		}

		private static uint __OnFinish = 0;

		private static uint __TaskWaitDelay = 0;
	}
}