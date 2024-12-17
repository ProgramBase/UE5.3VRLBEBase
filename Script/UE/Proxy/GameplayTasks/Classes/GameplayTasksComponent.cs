using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.GameplayTasksComponent")]
	public partial class UGameplayTasksComponent : UActorComponent, IStaticClass, IGameplayTaskOwnerInterface, IVisualLoggerDebugSnapshotInterface
	{
		public TArray<UGameplayTask> TaskPriorityQueue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TaskPriorityQueue, __ReturnBuffer);

					return *(TArray<UGameplayTask>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TaskPriorityQueue, __InBuffer);
				}
			}
		}

		public TArray<UGameplayTask> TickingTasks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TickingTasks, __ReturnBuffer);

					return *(TArray<UGameplayTask>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TickingTasks, __InBuffer);
				}
			}
		}

		public TArray<UGameplayTask> KnownTasks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __KnownTasks, __ReturnBuffer);

					return *(TArray<UGameplayTask>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __KnownTasks, __InBuffer);
				}
			}
		}

		public FOnClaimedResourcesChangeSignature OnClaimedResourcesChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnClaimedResourcesChange, __ReturnBuffer);

					return *(FOnClaimedResourcesChangeSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnClaimedResourcesChange, __InBuffer);
				}
			}
		}

		public TArray<UGameplayTask> SimulatedTasks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SimulatedTasks, __ReturnBuffer);

					return *(TArray<UGameplayTask>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SimulatedTasks, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTasks.GameplayTasksComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void OnRep_SimulatedTasks(TArray<UGameplayTask> PreviousSimulatedTasks)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PreviousSimulatedTasks?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnRep_SimulatedTasks, __InBuffer);
			}
		}

		public static EGameplayTaskRunResult K2_RunGameplayTask(TScriptInterface<IGameplayTaskOwnerInterface> TaskOwner, UGameplayTask Task, byte Priority, TArray<TSubclassOf<UGameplayTaskResource>> AdditionalRequiredResources, TArray<TSubclassOf<UGameplayTaskResource>> AdditionalClaimedResources)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = TaskOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Task?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = Priority;

				*(nint*)(__InBuffer + 17) = AdditionalRequiredResources?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = AdditionalClaimedResources?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_RunGameplayTask, __InBuffer, __ReturnBuffer);

				return *(EGameplayTaskRunResult*)__ReturnBuffer;
			}
		}

		private static uint __TaskPriorityQueue = 0;

		private static uint __TickingTasks = 0;

		private static uint __KnownTasks = 0;

		private static uint __OnClaimedResourcesChange = 0;

		private static uint __SimulatedTasks = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __OnRep_SimulatedTasks = 0;

		private static uint __K2_RunGameplayTask = 0;
	}
}