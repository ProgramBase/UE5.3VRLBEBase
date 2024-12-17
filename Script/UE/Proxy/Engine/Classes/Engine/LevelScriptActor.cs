using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelScriptActor")]
	public partial class ALevelScriptActor : AActor, IStaticClass
	{
		public bool bInputEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bInputEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bInputEnabled, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelScriptActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="OldOriginLocation">
		/// Previous world origin location
		/// </param>
		/// <param name="NewOriginLocation">
		/// New world origin location
		/// </param>
		public virtual void WorldOriginLocationChanged(FIntVector OldOriginLocation, FIntVector NewOriginLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OldOriginLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewOriginLocation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __WorldOriginLocationChanged, __InBuffer);
			}
		}

		/// <param name="bInCinematicMode">
		/// specify true if the player is entering cinematic mode; false if the player is leaving cinematic mode.
		/// </param>
		/// <param name="bHidePlayer">
		/// specify true to hide the player's pawn (only relevant if bInCinematicMode is true)
		/// </param>
		/// <param name="bAffectsHUD">
		/// specify true if we should show/hide the HUD to match the value of bCinematicMode
		/// </param>
		/// <param name="bAffectsMovement">
		/// specify true to disable movement in cinematic mode, enable it when leaving
		/// </param>
		/// <param name="bAffectsTurning">
		/// specify true to disable turning in cinematic mode or enable it when leaving
		/// </param>
		public virtual void SetCinematicMode(bool bCinematicMode, bool bHidePlayer = true, bool bAffectsHUD = true, bool bAffectsMovement = false, bool bAffectsTurning = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(bool*)(__InBuffer) = bCinematicMode;

				*(bool*)(__InBuffer + 1) = bHidePlayer;

				*(bool*)(__InBuffer + 2) = bAffectsHUD;

				*(bool*)(__InBuffer + 3) = bAffectsMovement;

				*(bool*)(__InBuffer + 4) = bAffectsTurning;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCinematicMode, __InBuffer);
			}
		}

		public virtual bool RemoteEvent(FName EventName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoteEvent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <todo>
		/// document */
		/// </todo>
		public virtual void LevelReset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __LevelReset);
			}
		}

		private static uint __bInputEnabled = 0;

		private static uint __WorldOriginLocationChanged = 0;

		private static uint __SetCinematicMode = 0;

		private static uint __RemoteEvent = 0;

		private static uint __LevelReset = 0;
	}
}