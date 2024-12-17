using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Controller")]
	public partial class AController : AActor, IStaticClass, INavAgentInterface
	{
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

		public FInstigatedAnyDamageSignature OnInstigatedAnyDamage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInstigatedAnyDamage, __ReturnBuffer);

					return *(FInstigatedAnyDamageSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInstigatedAnyDamage, __InBuffer);
				}
			}
		}

		public FOnPossessedPawnChanged OnPossessedPawnChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPossessedPawnChanged, __ReturnBuffer);

					return *(FOnPossessedPawnChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPossessedPawnChanged, __InBuffer);
				}
			}
		}

		public FName StateName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StateName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StateName, __InBuffer);
				}
			}
		}

		public APawn Pawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Pawn, __ReturnBuffer);

					return *(APawn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Pawn, __InBuffer);
				}
			}
		}

		public ACharacter Character
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Character, __ReturnBuffer);

					return *(ACharacter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Character, __InBuffer);
				}
			}
		}

		public USceneComponent TransformComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformComponent, __InBuffer);
				}
			}
		}

		public FRotator ControlRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRotation, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRotation, __InBuffer);
				}
			}
		}

		public bool bAttachToPawn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAttachToPawn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAttachToPawn, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Controller");
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

		public virtual void UnPossess()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UnPossess);
			}
		}

		public virtual void StopMovement()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopMovement);
			}
		}

		public virtual void SetInitialLocationAndRotation(FVector NewLocation, FRotator NewRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInitialLocationAndRotation, __InBuffer);
			}
		}

		/// <param name="bNewMoveInput">
		/// If true, move input is ignored. If false, input is not ignored.
		/// </param>
		public virtual void SetIgnoreMoveInput(bool bNewMoveInput)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewMoveInput;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIgnoreMoveInput, __InBuffer);
			}
		}

		/// <param name="bNewLookInput">
		/// If true, look input is ignored. If false, input is not ignored.
		/// </param>
		public virtual void SetIgnoreLookInput(bool bNewLookInput)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewLookInput;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIgnoreLookInput, __InBuffer);
			}
		}

		public virtual void SetControlRotation(FRotator NewRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetControlRotation, __InBuffer);
			}
		}

		public virtual void ResetIgnoreMoveInput()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetIgnoreMoveInput);
			}
		}

		public virtual void ResetIgnoreLookInput()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetIgnoreLookInput);
			}
		}

		public virtual void ResetIgnoreInputFlags()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetIgnoreInputFlags);
			}
		}

		public virtual void ReceiveUnPossess(APawn UnpossessedPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UnpossessedPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveUnPossess, __InBuffer);
			}
		}

		public virtual void ReceivePossess(APawn PossessedPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PossessedPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceivePossess, __InBuffer);
			}
		}

		public virtual void ReceiveInstigatedAnyDamage(float Damage, UDamageType DamageType, AActor DamagedActor, AActor DamageCauser)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(float*)(__InBuffer) = Damage;

				*(nint*)(__InBuffer + 4) = DamageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = DamagedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveInstigatedAnyDamage, __InBuffer);
			}
		}

		/// <param name="InPawn">
		/// The Pawn to be possessed.
		/// </param>
		/// <see>
		/// HasAuthority, OnPossess, ReceivePossess
		/// </see>
		public virtual void Possess(APawn InPawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPawn?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Possess, __InBuffer);
			}
		}

		public virtual void OnRep_PlayerState()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_PlayerState);
			}
		}

		public virtual void OnRep_Pawn()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_Pawn);
			}
		}

		/// <param name="Other">
		/// is the actor whose visibility is being checked.
		/// </param>
		/// <param name="ViewPoint">
		/// is eye position visibility is being checked from.  If vect(0,0,0) passed in, uses current viewtarget's eye position.
		/// </param>
		/// <param name="bAlternateChecks">
		/// used only in AIController implementation
		/// </param>
		/// <returns>
		/// true if controller's pawn can see Other actor.
		/// </returns>
		public virtual bool LineOfSightTo(AActor Other, FVector ViewPoint = null, bool bAlternateChecks = false)
		{
			unsafe
			{
				ViewPoint ??= new FVector();

				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Other?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ViewPoint?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAlternateChecks;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __LineOfSightTo, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual APawn K2_GetPawn()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_GetPawn, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		public virtual bool IsPlayerController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPlayerController, __ReturnBuffer);

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

		public virtual bool IsLookInputIgnored()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLookInputIgnored, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLocalPlayerController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLocalPlayerController, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLocalController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLocalController, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual AActor GetViewTarget()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetViewTarget, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		/// <output>
		/// out_Location, view location of player
		/// </output>
		/// <output>
		/// out_rotation, view rotation of player
		/// </output>
		public virtual void GetPlayerViewPoint(ref FVector Location, ref FRotator Rotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetPlayerViewPoint, __InBuffer, __OutBuffer);

				Location = *(FVector*)(__OutBuffer);

				Rotation = *(FRotator*)(__OutBuffer + 8);

			}
		}

		public virtual FRotator GetDesiredRotation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDesiredRotation, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
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

		public virtual void ClientSetRotation(FRotator NewRotation, bool bResetCamera)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bResetCamera;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSetRotation, __InBuffer);
			}
		}

		public virtual void ClientSetLocation(FVector NewLocation, FRotator NewRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSetLocation, __InBuffer);
			}
		}

		private static uint __PlayerState = 0;

		private static uint __OnInstigatedAnyDamage = 0;

		private static uint __OnPossessedPawnChanged = 0;

		private static uint __StateName = 0;

		private static uint __Pawn = 0;

		private static uint __Character = 0;

		private static uint __TransformComponent = 0;

		private static uint __ControlRotation = 0;

		private static uint __bAttachToPawn = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __UnPossess = 0;

		private static uint __StopMovement = 0;

		private static uint __SetInitialLocationAndRotation = 0;

		private static uint __SetIgnoreMoveInput = 0;

		private static uint __SetIgnoreLookInput = 0;

		private static uint __SetControlRotation = 0;

		private static uint __ResetIgnoreMoveInput = 0;

		private static uint __ResetIgnoreLookInput = 0;

		private static uint __ResetIgnoreInputFlags = 0;

		private static uint __ReceiveUnPossess = 0;

		private static uint __ReceivePossess = 0;

		private static uint __ReceiveInstigatedAnyDamage = 0;

		private static uint __Possess = 0;

		private static uint __OnRep_PlayerState = 0;

		private static uint __OnRep_Pawn = 0;

		private static uint __LineOfSightTo = 0;

		private static uint __K2_GetPawn = 0;

		private static uint __IsPlayerController = 0;

		private static uint __IsMoveInputIgnored = 0;

		private static uint __IsLookInputIgnored = 0;

		private static uint __IsLocalPlayerController = 0;

		private static uint __IsLocalController = 0;

		private static uint __GetViewTarget = 0;

		private static uint __GetPlayerViewPoint = 0;

		private static uint __GetDesiredRotation = 0;

		private static uint __GetControlRotation = 0;

		private static uint __ClientSetRotation = 0;

		private static uint __ClientSetLocation = 0;
	}
}