using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTService_BlueprintBase")]
	public partial class UBTService_BlueprintBase : UBTService, IStaticClass
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

		public bool bShowEventDetails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowEventDetails, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowEventDetails, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTService_BlueprintBase");
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
		/// ReceiveSearchStart for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveSearchStartAI(AAIController OwnerController, APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveSearchStartAI, __InBuffer);
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveSearchStart(AActor OwnerActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveSearchStart, __InBuffer);
			}
		}

		/// <see>
		/// ReceiveDeactivation for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveDeactivationAI(AAIController OwnerController, APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveDeactivationAI, __InBuffer);
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveDeactivation(AActor OwnerActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveDeactivation, __InBuffer);
			}
		}

		/// <see>
		/// ReceiveActivation for more details
		/// </see>
		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveActivationAI(AAIController OwnerController, APawn ControlledPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ControlledPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveActivationAI, __InBuffer);
			}
		}

		/// <Note>
		/// that if both generic and AI event versions are implemented only the more
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise */
		/// </Note>
		public virtual void ReceiveActivation(AActor OwnerActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OwnerActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveActivation, __InBuffer);
			}
		}

		public virtual bool IsServiceActive()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsServiceActive, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __AIOwner = 0;

		private static uint __ActorOwner = 0;

		private static uint __CustomDescription = 0;

		private static uint __bShowPropertyDetails = 0;

		private static uint __bShowEventDetails = 0;

		private static uint __ReceiveTickAI = 0;

		private static uint __ReceiveTick = 0;

		private static uint __ReceiveSearchStartAI = 0;

		private static uint __ReceiveSearchStart = 0;

		private static uint __ReceiveDeactivationAI = 0;

		private static uint __ReceiveDeactivation = 0;

		private static uint __ReceiveActivationAI = 0;

		private static uint __ReceiveActivation = 0;

		private static uint __IsServiceActive = 0;
	}
}