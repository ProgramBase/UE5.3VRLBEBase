using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayTasks
{
	[PathName("/Script/GameplayTasks.GameplayTask")]
	public partial class UGameplayTask : UObject, IStaticClass, IGameplayTaskOwnerInterface
	{
		public FName InstanceName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceName, __InBuffer);
				}
			}
		}

		public ETaskResourceOverlapPolicy ResourceOverlapPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ResourceOverlapPolicy, __ReturnBuffer);

					return *(ETaskResourceOverlapPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ResourceOverlapPolicy, __InBuffer);
				}
			}
		}

		public UGameplayTask ChildTask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChildTask, __ReturnBuffer);

					return *(UGameplayTask*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChildTask, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTasks.GameplayTask");
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

		public virtual void ReadyForActivation()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ReadyForActivation);
			}
		}

		/// <NOTE>
		/// : you need to call EndTask before sending out any "on completed" delegates. 
		/// If you don't the task will still be in an "active" state while the event receivers may
		/// assume it's already "finished" */
		/// </NOTE>
		public virtual void EndTask()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EndTask);
			}
		}

		private static uint __InstanceName = 0;

		private static uint __ResourceOverlapPolicy = 0;

		private static uint __ChildTask = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __ReadyForActivation = 0;

		private static uint __EndTask = 0;
	}
}