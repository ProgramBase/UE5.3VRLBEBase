using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTTask_BlueprintBase")]
	public partial class UBTTask_BlueprintBase : UBTTaskNode, IStaticClass
	{
		public AAIController AIOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AIOwner, __ReturnBuffer);

					return *(AAIController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AIOwner, __InBuffer);
				}
			}
		}

		public AActor ActorOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActorOwner, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActorOwner, __InBuffer);
				}
			}
		}

		public FIntervalCountdown TickInterval
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TickInterval, __ReturnBuffer);

					return *(FIntervalCountdown*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TickInterval, __InBuffer);
				}
			}
		}

		public FString CustomDescription
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomDescription, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomDescription, __InBuffer);
				}
			}
		}

		public bool bShowPropertyDetails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPropertyDetails, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowPropertyDetails, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTTask_BlueprintBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetFinishOnMessageWithId(FName MessageName, int RequestID = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = MessageName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = RequestID;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFinishOnMessageWithId, __InBuffer);
			}
		}

		public virtual void SetFinishOnMessage(FName MessageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MessageName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFinishOnMessage, __InBuffer);
			}
		}

		/// <see>
		/// ReceiveTick for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveTickAI(AAIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = DeltaSeconds;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveTickAI, __InBuffer);
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = DeltaSeconds;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveTick, __InBuffer);
			}
		}

		/// <see>
		/// ReceiveExecute for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveExecuteAI(AAIController OwnerController, APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveExecuteAI, __InBuffer);
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more 
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveExecute(AActor OwnerActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveExecute, __InBuffer);
			}
		}

		/// <see>
		/// ReceiveAbort for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveAbortAI(AAIController OwnerController, APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveAbortAI, __InBuffer);
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveAbort(AActor OwnerActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveAbort, __InBuffer);
			}
		}

		public virtual bool IsTaskExecuting()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsTaskExecuting, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsTaskAborting()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsTaskAborting, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void FinishExecute(bool bSuccess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSuccess;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FinishExecute, __InBuffer);
			}
		}

		public virtual void FinishAbort()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FinishAbort);
			}
		}

		private static uint __AIOwner = 0;

		private static uint __ActorOwner = 0;

		private static uint __TickInterval = 0;

		private static uint __CustomDescription = 0;

		private static uint __bShowPropertyDetails = 0;

		private static uint __SetFinishOnMessageWithId = 0;

		private static uint __SetFinishOnMessage = 0;

		private static uint __ReceiveTickAI = 0;

		private static uint __ReceiveTick = 0;

		private static uint __ReceiveExecuteAI = 0;

		private static uint __ReceiveExecute = 0;

		private static uint __ReceiveAbortAI = 0;

		private static uint __ReceiveAbort = 0;

		private static uint __IsTaskExecuting = 0;

		private static uint __IsTaskAborting = 0;

		private static uint __FinishExecute = 0;

		private static uint __FinishAbort = 0;
	}
}