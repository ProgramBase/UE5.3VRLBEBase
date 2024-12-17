using Script.CoreUObject;
using Script.GameplayTasks.GameplayTask_TimeLimitedExecution;
using Script.Library;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution")]
	public partial class UGameplayTask_TimeLimitedExecution : UGameplayTask, IStaticClass
	{
		public FTaskFinishDelegate OnFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFinished, __ReturnBuffer);

					return *(FTaskFinishDelegate*)__ReturnBuffer;
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

		public FTaskFinishDelegate OnTimeExpired
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTimeExpired, __ReturnBuffer);

					return *(FTaskFinishDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTimeExpired, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTasks.GameplayTask_TimeLimitedExecution");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OnFinished = 0;

		private static uint __OnTimeExpired = 0;
	}
}