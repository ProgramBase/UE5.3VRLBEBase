using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Pawn")]
	public partial class APawn : AActor, IStaticClass, INavAgentInterface
	{
		public bool bUseControllerRotationPitch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseControllerRotationPitch, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseControllerRotationPitch, __InBuffer);
				}
			}
		}

		public bool bUseControllerRotationYaw
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseControllerRotationYaw, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseControllerRotationYaw, __InBuffer);
				}
			}
		}

		public bool bUseControllerRotationRoll
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseControllerRotationRoll, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseControllerRotationRoll, __InBuffer);
				}
			}
		}

		public bool bCanAffectNavigationGeneration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanAffectNavigationGeneration, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanAffectNavigationGeneration, __InBuffer);
				}
			}
		}

		public bool bIsLocalViewTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsLocalViewTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsLocalViewTarget, __InBuffer);
				}
			}
		}

		public float BaseEyeHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseEyeHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseEyeHeight, __InBuffer);
				}
			}
		}

		public EAutoReceiveInput AutoPossessPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoPossessPlayer, __ReturnBuffer);

					return *(EAutoReceiveInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoPossessPlayer, __InBuffer);
				}
			}
		}

		public EAutoPossessAI AutoPossessAI
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoPossessAI, __ReturnBuffer);

					return *(EAutoPossessAI*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoPossessAI, __InBuffer);
				}
			}
		}

		public byte RemoteViewPitch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RemoteViewPitch, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RemoteViewPitch, __InBuffer);
				}
			}
		}

		public TSubclassOf<AController> AIControllerClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AIControllerClass, __ReturnBuffer);

					return *(TSubclassOf<AController>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AIControllerClass, __InBuffer);
				}
			}
		}

		public APlayerState PlayerState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerState, __ReturnBuffer);

					return *(APlayerState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerState, __InBuffer);
				}
			}
		}

		public AController LastHitBy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastHitBy, __ReturnBuffer);

					return *(AController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastHitBy, __InBuffer);
				}
			}
		}

		public AController Controller
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Controller, __ReturnBuffer);

					return *(AController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Controller, __InBuffer);
				}
			}
		}

		public AController PreviousController
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviousController, __ReturnBuffer);

					return *(AController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviousController, __InBuffer);
				}
			}
		}

		public FPawnControllerChangedSignature ReceiveControllerChangedDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReceiveControllerChangedDelegate, __ReturnBuffer);

					return *(FPawnControllerChangedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReceiveControllerChangedDelegate, __InBuffer);
				}
			}
		}

		public FPawnRestartedSignature ReceiveRestartedDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReceiveRestartedDelegate, __ReturnBuffer);

					return *(FPawnRestartedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReceiveRestartedDelegate, __InBuffer);
				}
			}
		}

		public FVector ControlInputVector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlInputVector, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlInputVector, __InBuffer);
				}
			}
		}

		public FVector LastControlInputVector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastControlInputVector, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastControlInputVector, __InBuffer);
				}
			}
		}

		public TSubclassOf<UInputComponent> OverrideInputComponentClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideInputComponentClass, __ReturnBuffer);

					return *(TSubclassOf<UInputComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideInputComponentClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Pawn");
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

		public virtual void SpawnDefaultController()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SpawnDefaultController);
			}
		}

		public virtual void SetCanAffectNavigationGeneration(bool bNewValue, bool bForceUpdate = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bNewValue;

				*(bool*)(__InBuffer + 1) = bForceUpdate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCanAffectNavigationGeneration, __InBuffer);
			}
		}

		public virtual void ReceiveUnpossessed(AController OldController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OldController?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveUnpossessed, __InBuffer);
			}
		}

		public virtual void ReceiveRestarted()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveRestarted);
			}
		}

		public virtual void ReceivePossessed(AController NewController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewController?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceivePossessed, __InBuffer);
			}
		}

		public virtual void ReceiveControllerChanged(AController OldController, AController NewController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OldController?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewController?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveControllerChanged, __InBuffer);
			}
		}

		/// <param name="Loudness">
		/// - is the relative loudness of this noise (range 0.0 to 1.0).  Directly affects the hearing range specified by the AI's HearingThreshold.
		/// </param>
		/// <param name="NoiseLocation">
		/// - Position of noise source.  If zero vector, use the actor's location.
		/// </param>
		/// <param name="bUseNoiseMakerLocation">
		/// - If true, use the location of the NoiseMaker rather than NoiseLocation.  If false, use NoiseLocation.
		/// </param>
		/// <param name="NoiseMaker">
		/// - Which actor is the source of the noise.  Not to be confused with the Noise Instigator, which is responsible for the noise (and is the pawn on which this function is called).  If not specified, the pawn instigating the noise will be used as the NoiseMaker
		/// </param>
		public virtual void PawnMakeNoise(float Loudness, FVector NoiseLocation, bool bUseNoiseMakerLocation = true, AActor NoiseMaker = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(float*)(__InBuffer) = Loudness;

				*(nint*)(__InBuffer + 4) = NoiseLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bUseNoiseMakerLocation;

				*(nint*)(__InBuffer + 13) = NoiseMaker?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PawnMakeNoise, __InBuffer);
			}
		}

		public virtual void OnRep_PlayerState()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_PlayerState);
			}
		}

		public virtual void OnRep_Controller()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_Controller);
			}
		}

		public virtual bool IsPlayerControlled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPlayerControlled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPawnControlled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPawnControlled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsMoveInputIgnored()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsMoveInputIgnored, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLocallyViewed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLocallyViewed, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLocallyControlled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLocallyControlled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsControlled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsControlled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsBotControlled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsBotControlled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FPlatformUserId GetPlatformUserId()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlatformUserId, __ReturnBuffer);

				return *(FPlatformUserId*)__ReturnBuffer;
			}
		}

		/// <see>
		/// AddMovementInput(), GetLastMovementInputVector(), ConsumeMovementInputVector()
		/// </see>
		/// <returns>
		/// The pending input vector in world space.
		/// </returns>
		public virtual FVector GetPendingMovementInputVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPendingMovementInputVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual TSubclassOf<UInputComponent> GetOverrideInputComponentClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOverrideInputComponentClass, __ReturnBuffer);

				return *(TSubclassOf<UInputComponent>*)__ReturnBuffer;
			}
		}

		public virtual FVector GetNavAgentLocation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNavAgentLocation, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual UPawnMovementComponent GetMovementComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMovementComponent, __ReturnBuffer);

				return *(UPawnMovementComponent*)__ReturnBuffer;
			}
		}

		public static AActor GetMovementBaseActor(APawn Pawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Pawn?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetMovementBaseActor, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual APlayerController GetLocalViewingPlayerController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLocalViewingPlayerController, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		/// <see>
		/// AddMovementInput(), GetPendingMovementInputVector(), ConsumeMovementInputVector()
		/// </see>
		/// <returns>
		/// The last input vector in world space that was processed by ConsumeMovementInputVector().
		/// </returns>
		public virtual FVector GetLastMovementInputVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastMovementInputVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetControlRotation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetControlRotation, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual AController GetController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetController, __ReturnBuffer);

				return *(AController*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetBaseAimRotation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBaseAimRotation, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual void DetachFromControllerPendingDestroy()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DetachFromControllerPendingDestroy);
			}
		}

		/// <returns>
		/// The pending input vector.
		/// </returns>
		public virtual FVector ConsumeMovementInputVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __ConsumeMovementInputVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="WorldDirection">
		/// Direction in world space to apply input
		/// </param>
		/// <param name="ScaleValue">
		/// Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction.
		/// </param>
		/// <param name="bForce">
		/// If true always add the input, ignoring the result of IsMoveInputIgnored().
		/// </param>
		/// <see>
		/// GetPendingMovementInputVector(), GetLastMovementInputVector(), ConsumeMovementInputVector()
		/// </see>
		public virtual void AddMovementInput(FVector WorldDirection, float ScaleValue = 1.000000f, bool bForce = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = WorldDirection?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ScaleValue;

				*(bool*)(__InBuffer + 12) = bForce;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddMovementInput, __InBuffer);
			}
		}

		/// <param name="Val">
		/// Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value.
		/// </param>
		/// <see>
		/// PlayerController::InputYawScale
		/// </see>
		public virtual void AddControllerYawInput(float Val)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Val;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddControllerYawInput, __InBuffer);
			}
		}

		/// <param name="Val">
		/// Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value.
		/// </param>
		/// <see>
		/// PlayerController::InputRollScale
		/// </see>
		public virtual void AddControllerRollInput(float Val)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Val;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddControllerRollInput, __InBuffer);
			}
		}

		/// <param name="Val">
		/// Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value.
		/// </param>
		/// <see>
		/// PlayerController::InputPitchScale
		/// </see>
		public virtual void AddControllerPitchInput(float Val)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Val;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddControllerPitchInput, __InBuffer);
			}
		}

		private static uint __bUseControllerRotationPitch = 0;

		private static uint __bUseControllerRotationYaw = 0;

		private static uint __bUseControllerRotationRoll = 0;

		private static uint __bCanAffectNavigationGeneration = 0;

		private static uint __bIsLocalViewTarget = 0;

		private static uint __BaseEyeHeight = 0;

		private static uint __AutoPossessPlayer = 0;

		private static uint __AutoPossessAI = 0;

		private static uint __RemoteViewPitch = 0;

		private static uint __AIControllerClass = 0;

		private static uint __PlayerState = 0;

		private static uint __LastHitBy = 0;

		private static uint __Controller = 0;

		private static uint __PreviousController = 0;

		private static uint __ReceiveControllerChangedDelegate = 0;

		private static uint __ReceiveRestartedDelegate = 0;

		private static uint __ControlInputVector = 0;

		private static uint __LastControlInputVector = 0;

		private static uint __OverrideInputComponentClass = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SpawnDefaultController = 0;

		private static uint __SetCanAffectNavigationGeneration = 0;

		private static uint __ReceiveUnpossessed = 0;

		private static uint __ReceiveRestarted = 0;

		private static uint __ReceivePossessed = 0;

		private static uint __ReceiveControllerChanged = 0;

		private static uint __PawnMakeNoise = 0;

		private static uint __OnRep_PlayerState = 0;

		private static uint __OnRep_Controller = 0;

		private static uint __IsPlayerControlled = 0;

		private static uint __IsPawnControlled = 0;

		private static uint __IsMoveInputIgnored = 0;

		private static uint __IsLocallyViewed = 0;

		private static uint __IsLocallyControlled = 0;

		private static uint __IsControlled = 0;

		private static uint __IsBotControlled = 0;

		private static uint __GetPlatformUserId = 0;

		private static uint __GetPendingMovementInputVector = 0;

		private static uint __GetOverrideInputComponentClass = 0;

		private static uint __GetNavAgentLocation = 0;

		private static uint __GetMovementComponent = 0;

		private static uint __GetMovementBaseActor = 0;

		private static uint __GetLocalViewingPlayerController = 0;

		private static uint __GetLastMovementInputVector = 0;

		private static uint __GetControlRotation = 0;

		private static uint __GetController = 0;

		private static uint __GetBaseAimRotation = 0;

		private static uint __DetachFromControllerPendingDestroy = 0;

		private static uint __ConsumeMovementInputVector = 0;

		private static uint __AddMovementInput = 0;

		private static uint __AddControllerYawInput = 0;

		private static uint __AddControllerRollInput = 0;

		private static uint __AddControllerPitchInput = 0;
	}
}