using Script.CoreUObject;
using Script.GameplayTasks;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AITask")]
	public partial class UAITask : UGameplayTask, IStaticClass
	{
		public AAIController OwnerController
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwnerController, __ReturnBuffer);

					return *(AAIController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwnerController, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AITask");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OwnerController = 0;
	}
}