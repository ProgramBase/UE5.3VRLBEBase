using Script.CoreUObject;
using Script.Library;
using Script.InputCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.InputComponent")]
	public partial class UInputComponent : UActorComponent, IStaticClass
	{
		public TArray<FCachedKeyToActionInfo> CachedKeyToActionInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedKeyToActionInfo, __ReturnBuffer);

					return *(TArray<FCachedKeyToActionInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedKeyToActionInfo, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InputComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool WasControllerKeyJustReleased(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasControllerKeyJustReleased, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool WasControllerKeyJustPressed(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __WasControllerKeyJustPressed, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void OnInputOwnerEndPlayed(AActor InOwner, EEndPlayReason EndPlayReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)EndPlayReason;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnInputOwnerEndPlayed, __InBuffer);
			}
		}

		public virtual bool IsControllerKeyDown(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsControllerKeyDown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetTouchState(int FingerIndex, ref float LocationX, ref float LocationY, ref bool bIsCurrentlyPressed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = FingerIndex;

				*(float*)(__InBuffer + 4) = LocationX;

				*(float*)(__InBuffer + 8) = LocationY;

				*(bool*)(__InBuffer + 12) = bIsCurrentlyPressed;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTouchState, __InBuffer, __OutBuffer);

				LocationX = *(float*)(__OutBuffer);

				LocationY = *(float*)(__OutBuffer + 4);

				bIsCurrentlyPressed = *(bool*)(__OutBuffer + 8);

			}
		}

		public virtual FVector GetControllerVectorKeyState(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetControllerVectorKeyState, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual void GetControllerMouseDelta(ref float DeltaX, ref float DeltaY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = DeltaX;

				*(float*)(__InBuffer + 4) = DeltaY;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetControllerMouseDelta, __InBuffer, __OutBuffer);

				DeltaX = *(float*)(__OutBuffer);

				DeltaY = *(float*)(__OutBuffer + 4);

			}
		}

		public virtual float GetControllerKeyTimeDown(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetControllerKeyTimeDown, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void GetControllerAnalogStickState(EControllerAnalogStick WhichStick, ref float StickX, ref float StickY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)WhichStick;

				*(float*)(__InBuffer + 1) = StickX;

				*(float*)(__InBuffer + 5) = StickY;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetControllerAnalogStickState, __InBuffer, __OutBuffer);

				StickX = *(float*)(__OutBuffer);

				StickY = *(float*)(__OutBuffer + 4);

			}
		}

		public virtual float GetControllerAnalogKeyState(FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetControllerAnalogKeyState, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __CachedKeyToActionInfo = 0;

		private static uint __WasControllerKeyJustReleased = 0;

		private static uint __WasControllerKeyJustPressed = 0;

		private static uint __OnInputOwnerEndPlayed = 0;

		private static uint __IsControllerKeyDown = 0;

		private static uint __GetTouchState = 0;

		private static uint __GetControllerVectorKeyState = 0;

		private static uint __GetControllerMouseDelta = 0;

		private static uint __GetControllerKeyTimeDown = 0;

		private static uint __GetControllerAnalogStickState = 0;

		private static uint __GetControllerAnalogKeyState = 0;
	}
}