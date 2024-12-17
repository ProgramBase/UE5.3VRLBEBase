using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityTask")]
	public partial class UEditorUtilityTask : UObject, IStaticClass
	{
		public UEditorUtilitySubsystem MyTaskManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MyTaskManager, __ReturnBuffer);

					return *(UEditorUtilitySubsystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MyTaskManager, __InBuffer);
				}
			}
		}

		public UEditorUtilityTask MyParentTask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MyParentTask, __ReturnBuffer);

					return *(UEditorUtilityTask*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MyParentTask, __InBuffer);
				}
			}
		}

		public bool bCancelRequested
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCancelRequested, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCancelRequested, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityTask");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool WasCancelRequested()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __WasCancelRequested, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetTaskNotificationText(FText Text)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Text?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTaskNotificationText, __InBuffer);
			}
		}

		public virtual void Run()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Run);
			}
		}

		public virtual void ReceiveCancelRequested()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveCancelRequested);
			}
		}

		public virtual void ReceiveBeginExecution()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveBeginExecution);
			}
		}

		public virtual void FinishExecutingTask()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FinishExecutingTask);
			}
		}

		private static uint __MyTaskManager = 0;

		private static uint __MyParentTask = 0;

		private static uint __bCancelRequested = 0;

		private static uint __WasCancelRequested = 0;

		private static uint __SetTaskNotificationText = 0;

		private static uint __Run = 0;

		private static uint __ReceiveCancelRequested = 0;

		private static uint __ReceiveBeginExecution = 0;

		private static uint __FinishExecutingTask = 0;
	}
}