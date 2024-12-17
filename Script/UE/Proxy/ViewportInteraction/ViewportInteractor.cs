using Script.CoreUObject;
using Script.Library;
using Script.InputCore;
using Script.Engine;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.ViewportInteractor")]
	public partial class UViewportInteractor : UObject, IStaticClass
	{
		public TMap<FKey, FViewportActionKeyInput> KeyToActionMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __KeyToActionMap, __ReturnBuffer);

					return *(TMap<FKey, FViewportActionKeyInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __KeyToActionMap, __InBuffer);
				}
			}
		}

		public UViewportWorldInteraction WorldInteraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WorldInteraction, __ReturnBuffer);

					return *(UViewportWorldInteraction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WorldInteraction, __InBuffer);
				}
			}
		}

		public UViewportInteractor OtherInteractor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OtherInteractor, __ReturnBuffer);

					return *(UViewportInteractor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OtherInteractor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.ViewportInteractor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Tick(float DeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DeltaTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Tick, __InBuffer);
			}
		}

		public virtual void Shutdown()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Shutdown);
			}
		}

		public virtual void SetHitResultGizmoFilterMode(EHitResultGizmoFilterMode newFilter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)newFilter;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHitResultGizmoFilterMode, __InBuffer);
			}
		}

		public virtual void SetDraggingMode(EViewportInteractionDraggingMode NewDraggingMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewDraggingMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDraggingMode, __InBuffer);
			}
		}

		public virtual void SetCanCarry(bool bInCanCarry)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInCanCarry;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCanCarry, __InBuffer);
			}
		}

		public virtual bool IsHoveringOverGizmo()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsHoveringOverGizmo, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void HandleInputKey_BP(FViewportActionKeyInput Action, FKey Key, EInputEvent Event, ref bool bOutWasHandled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Event;

				*(bool*)(__InBuffer + 17) = bOutWasHandled;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __HandleInputKey_BP, __InBuffer, __OutBuffer);

				bOutWasHandled = *(bool*)(__OutBuffer);

			}
		}

		public virtual void HandleInputAxis_BP(FViewportActionKeyInput Action, FKey Key, float Delta, float DeltaTime, ref bool bOutWasHandled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Delta;

				*(float*)(__InBuffer + 20) = DeltaTime;

				*(bool*)(__InBuffer + 24) = bOutWasHandled;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __HandleInputAxis_BP, __InBuffer, __OutBuffer);

				bOutWasHandled = *(bool*)(__OutBuffer);

			}
		}

		public virtual UViewportWorldInteraction GetWorldInteraction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetWorldInteraction, __ReturnBuffer);

				return *(UViewportWorldInteraction*)__ReturnBuffer;
			}
		}

		/// <param name="OutHandTransform">
		/// The created hand transform
		/// </param>
		/// <param name="OutForwardVector">
		/// The forward vector of the hand
		/// </param>
		/// <returns>
		/// True if we have motion controller data for this hand and could return a valid result
		/// </returns>
		public virtual bool GetTransformAndForwardVector(ref FTransform OutHandTransform, ref FVector OutForwardVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OutHandTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutForwardVector?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetTransformAndForwardVector, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHandTransform = *(FTransform*)(__OutBuffer);

				OutForwardVector = *(FVector*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetRoomSpaceTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRoomSpaceTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual UViewportInteractor GetOtherInteractor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOtherInteractor, __ReturnBuffer);

				return *(UViewportInteractor*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetLastTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetLastRoomSpaceTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastRoomSpaceTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="LasertPointerStart">
		/// (Out) The start location of the laser pointer in world space
		/// </param>
		/// <param name="LasertPointerEnd">
		/// (Out) The end location of the laser pointer in world space
		/// </param>
		/// <param name="bEvenIfBlocked">
		/// If true, returns a laser pointer even if the hand has UI in front of it (defaults to false)
		/// </param>
		/// <param name="LaserLengthOverride">
		/// If zero the default laser length (VREdMode::GetLaserLength) is used
		/// </param>
		/// <returns>
		/// True if we have motion controller data for this hand and could return a valid result
		/// </returns>
		public virtual bool GetLaserPointer(ref FVector LaserPointerStart, ref FVector LaserPointerEnd, bool bEvenIfBlocked = false, float LaserLengthOverride = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = LaserPointerStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LaserPointerEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bEvenIfBlocked;

				*(float*)(__InBuffer + 17) = LaserLengthOverride;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetLaserPointer, __InBuffer, __OutBuffer, __ReturnBuffer);

				LaserPointerStart = *(FVector*)(__OutBuffer);

				LaserPointerEnd = *(FVector*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector GetHoverLocation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetHoverLocation, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual EHitResultGizmoFilterMode GetHitResultGizmoFilterMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetHitResultGizmoFilterMode, __ReturnBuffer);

				return *(EHitResultGizmoFilterMode*)__ReturnBuffer;
			}
		}

		public virtual EViewportInteractionDraggingMode GetDraggingMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDraggingMode, __ReturnBuffer);

				return *(EViewportInteractionDraggingMode*)__ReturnBuffer;
			}
		}

		public virtual bool CanCarry()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CanCarry, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __KeyToActionMap = 0;

		private static uint __WorldInteraction = 0;

		private static uint __OtherInteractor = 0;

		private static uint __Tick = 0;

		private static uint __Shutdown = 0;

		private static uint __SetHitResultGizmoFilterMode = 0;

		private static uint __SetDraggingMode = 0;

		private static uint __SetCanCarry = 0;

		private static uint __IsHoveringOverGizmo = 0;

		private static uint __HandleInputKey_BP = 0;

		private static uint __HandleInputAxis_BP = 0;

		private static uint __GetWorldInteraction = 0;

		private static uint __GetTransformAndForwardVector = 0;

		private static uint __GetTransform = 0;

		private static uint __GetRoomSpaceTransform = 0;

		private static uint __GetOtherInteractor = 0;

		private static uint __GetLastTransform = 0;

		private static uint __GetLastRoomSpaceTransform = 0;

		private static uint __GetLaserPointer = 0;

		private static uint __GetHoverLocation = 0;

		private static uint __GetHitResultGizmoFilterMode = 0;

		private static uint __GetDraggingMode = 0;

		private static uint __CanCarry = 0;
	}
}