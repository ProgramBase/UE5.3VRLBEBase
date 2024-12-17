using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTDecorator_BlueprintBase")]
	public partial class UBTDecorator_BlueprintBase : UBTDecorator, IStaticClass
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

		public TArray<FName> ObservedKeyNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObservedKeyNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObservedKeyNames, __InBuffer);
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

		public bool bCheckConditionOnlyBlackBoardChanges
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCheckConditionOnlyBlackBoardChanges, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCheckConditionOnlyBlackBoardChanges, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTDecorator_BlueprintBase");
		}

		private static UClass StaticClassSingleton { get; set; }

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
		/// ReceiveObserverDeactivated for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveObserverDeactivatedAI(AAIController OwnerController, APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveObserverDeactivatedAI, __InBuffer);
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveObserverDeactivated(AActor OwnerActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveObserverDeactivated, __InBuffer);
			}
		}

		/// <see>
		/// ReceiveObserverActivated for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveObserverActivatedAI(AAIController OwnerController, APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveObserverActivatedAI, __InBuffer);
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveObserverActivated(AActor OwnerActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveObserverActivated, __InBuffer);
			}
		}

		/// <see>
		/// ReceiveExecutionStart for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveExecutionStartAI(AAIController OwnerController, APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveExecutionStartAI, __InBuffer);
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveExecutionStart(AActor OwnerActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveExecutionStart, __InBuffer);
			}
		}

		/// <see>
		/// ReceiveExecutionFinish for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveExecutionFinishAI(AAIController OwnerController, APawn ControlledPawn, EBTNodeResult NodeResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)NodeResult;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveExecutionFinishAI, __InBuffer);
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveExecutionFinish(AActor OwnerActor, EBTNodeResult NodeResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)NodeResult;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveExecutionFinish, __InBuffer);
			}
		}

		/// <see>
		/// ReceiveConditionCheck for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual bool PerformConditionCheckAI(AAIController OwnerController, APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __PerformConditionCheckAI, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual bool PerformConditionCheck(AActor OwnerActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __PerformConditionCheck, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsDecoratorObserverActive()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDecoratorObserverActive, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsDecoratorExecutionActive()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDecoratorExecutionActive, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __AIOwner = 0;

		private static uint __ActorOwner = 0;

		private static uint __ObservedKeyNames = 0;

		private static uint __CustomDescription = 0;

		private static uint __bShowPropertyDetails = 0;

		private static uint __bCheckConditionOnlyBlackBoardChanges = 0;

		private static uint __ReceiveTickAI = 0;

		private static uint __ReceiveTick = 0;

		private static uint __ReceiveObserverDeactivatedAI = 0;

		private static uint __ReceiveObserverDeactivated = 0;

		private static uint __ReceiveObserverActivatedAI = 0;

		private static uint __ReceiveObserverActivated = 0;

		private static uint __ReceiveExecutionStartAI = 0;

		private static uint __ReceiveExecutionStart = 0;

		private static uint __ReceiveExecutionFinishAI = 0;

		private static uint __ReceiveExecutionFinish = 0;

		private static uint __PerformConditionCheckAI = 0;

		private static uint __PerformConditionCheck = 0;

		private static uint __IsDecoratorObserverActive = 0;

		private static uint __IsDecoratorExecutionActive = 0;
	}
}