using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.GameplayTask_ClaimResource")]
	public partial class UGameplayTask_ClaimResource : UGameplayTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTasks.GameplayTask_ClaimResource");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UGameplayTask_ClaimResource ClaimResources(TScriptInterface<IGameplayTaskOwnerInterface> InTaskOwner, TArray<TSubclassOf<UGameplayTaskResource>> ResourceClasses, byte Priority = 192, FName TaskInstanceName = null)
		{
			unsafe
			{
				TaskInstanceName ??= new FName("None");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InTaskOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ResourceClasses?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = Priority;

				*(nint*)(__InBuffer + 17) = TaskInstanceName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ClaimResources, __InBuffer, __ReturnBuffer);

				return *(UGameplayTask_ClaimResource*)__ReturnBuffer;
			}
		}

		public static UGameplayTask_ClaimResource ClaimResource(TScriptInterface<IGameplayTaskOwnerInterface> InTaskOwner, TSubclassOf<UGameplayTaskResource> ResourceClass, byte Priority = 192, FName TaskInstanceName = null)
		{
			unsafe
			{
				TaskInstanceName ??= new FName("None");

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InTaskOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ResourceClass?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = Priority;

				*(nint*)(__InBuffer + 17) = TaskInstanceName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ClaimResource, __InBuffer, __ReturnBuffer);

				return *(UGameplayTask_ClaimResource*)__ReturnBuffer;
			}
		}

		private static uint __ClaimResources = 0;

		private static uint __ClaimResource = 0;
	}
}