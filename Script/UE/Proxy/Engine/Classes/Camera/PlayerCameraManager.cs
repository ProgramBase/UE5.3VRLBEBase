using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlayerCameraManager")]
	public partial class APlayerCameraManager : AActor, IStaticClass
	{
		public APlayerController PCOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PCOwner, __ReturnBuffer);

					return *(APlayerController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PCOwner, __InBuffer);
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

		public float DefaultFOV
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultFOV, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultFOV, __InBuffer);
				}
			}
		}

		public float DefaultOrthoWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultOrthoWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultOrthoWidth, __InBuffer);
				}
			}
		}

		public float DefaultAspectRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultAspectRatio, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultAspectRatio, __InBuffer);
				}
			}
		}

		public FTViewTarget ViewTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewTarget, __ReturnBuffer);

					return *(FTViewTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewTarget, __InBuffer);
				}
			}
		}

		public FTViewTarget PendingViewTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PendingViewTarget, __ReturnBuffer);

					return *(FTViewTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PendingViewTarget, __InBuffer);
				}
			}
		}

		public FCameraCacheEntry CameraCachePrivate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CameraCachePrivate, __ReturnBuffer);

					return *(FCameraCacheEntry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CameraCachePrivate, __InBuffer);
				}
			}
		}

		public FCameraCacheEntry LastFrameCameraCachePrivate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastFrameCameraCachePrivate, __ReturnBuffer);

					return *(FCameraCacheEntry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastFrameCameraCachePrivate, __InBuffer);
				}
			}
		}

		public TArray<UCameraModifier> ModifierList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModifierList, __ReturnBuffer);

					return *(TArray<UCameraModifier>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModifierList, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<UCameraModifier>> DefaultModifiers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultModifiers, __ReturnBuffer);

					return *(TArray<TSubclassOf<UCameraModifier>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultModifiers, __InBuffer);
				}
			}
		}

		public float FreeCamDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FreeCamDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FreeCamDistance, __InBuffer);
				}
			}
		}

		public FVector FreeCamOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FreeCamOffset, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FreeCamOffset, __InBuffer);
				}
			}
		}

		public FVector ViewTargetOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewTargetOffset, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewTargetOffset, __InBuffer);
				}
			}
		}

		public FOnAudioFadeChangeSignature OnAudioFadeChangeEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioFadeChangeEvent, __ReturnBuffer);

					return *(FOnAudioFadeChangeSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioFadeChangeEvent, __InBuffer);
				}
			}
		}

		public TArray<TScriptInterface<ICameraLensEffectInterface>> CameraLensEffects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CameraLensEffects, __ReturnBuffer);

					return *(TArray<TScriptInterface<ICameraLensEffectInterface>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CameraLensEffects, __InBuffer);
				}
			}
		}

		public UCameraModifier_CameraShake CachedCameraShakeMod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedCameraShakeMod, __ReturnBuffer);

					return *(UCameraModifier_CameraShake*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedCameraShakeMod, __InBuffer);
				}
			}
		}

		public TArray<FPostProcessSettings> PostProcessBlendCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessBlendCache, __ReturnBuffer);

					return *(TArray<FPostProcessSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessBlendCache, __InBuffer);
				}
			}
		}

		public ACameraActor AnimCameraActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimCameraActor, __ReturnBuffer);

					return *(ACameraActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimCameraActor, __InBuffer);
				}
			}
		}

		public bool bIsOrthographic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsOrthographic, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsOrthographic, __InBuffer);
				}
			}
		}

		public bool bDefaultConstrainAspectRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDefaultConstrainAspectRatio, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDefaultConstrainAspectRatio, __InBuffer);
				}
			}
		}

		public bool bClientSimulatingViewTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bClientSimulatingViewTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bClientSimulatingViewTarget, __InBuffer);
				}
			}
		}

		public bool bUseClientSideCameraUpdates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseClientSideCameraUpdates, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseClientSideCameraUpdates, __InBuffer);
				}
			}
		}

		public bool bGameCameraCutThisFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bGameCameraCutThisFrame, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bGameCameraCutThisFrame, __InBuffer);
				}
			}
		}

		public float ViewPitchMin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewPitchMin, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewPitchMin, __InBuffer);
				}
			}
		}

		public float ViewPitchMax
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewPitchMax, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewPitchMax, __InBuffer);
				}
			}
		}

		public float ViewYawMin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewYawMin, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewYawMin, __InBuffer);
				}
			}
		}

		public float ViewYawMax
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewYawMax, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewYawMax, __InBuffer);
				}
			}
		}

		public float ViewRollMin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewRollMin, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewRollMin, __InBuffer);
				}
			}
		}

		public float ViewRollMax
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewRollMax, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewRollMax, __InBuffer);
				}
			}
		}

		public float ServerUpdateCameraTimeout
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerUpdateCameraTimeout, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerUpdateCameraTimeout, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlayerCameraManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SwapPendingViewTargetWhenUsingClientSideCameraUpdates()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SwapPendingViewTargetWhenUsingClientSideCameraUpdates);
			}
		}

		public virtual void StopCameraShake(UCameraShakeBase ShakeInstance, bool bImmediately = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ShakeInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bImmediately;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopCameraShake, __InBuffer);
			}
		}

		public virtual void StopCameraFade()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopCameraFade);
			}
		}

		public virtual void StopAllInstancesOfCameraShakeFromSource(TSubclassOf<UCameraShakeBase> Shake, UCameraShakeSourceComponent SourceComponent, bool bImmediately = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Shake?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bImmediately;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAllInstancesOfCameraShakeFromSource, __InBuffer);
			}
		}

		public virtual void StopAllInstancesOfCameraShake(TSubclassOf<UCameraShakeBase> Shake, bool bImmediately = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Shake?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bImmediately;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAllInstancesOfCameraShake, __InBuffer);
			}
		}

		public virtual void StopAllCameraShakesFromSource(UCameraShakeSourceComponent SourceComponent, bool bImmediately = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SourceComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bImmediately;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAllCameraShakesFromSource, __InBuffer);
			}
		}

		public virtual void StopAllCameraShakes(bool bImmediately = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bImmediately;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopAllCameraShakes, __InBuffer);
			}
		}

		/// <param name="Shake">
		/// - The class of camera shake to play.
		/// </param>
		/// <param name="SourceComponent">
		/// - The source from which the camera shake originates.
		/// </param>
		/// <param name="Scale">
		/// - Applies an additional constant scale on top of the dynamic scale computed with the distance to the source
		/// </param>
		/// <param name="PlaySpace">
		/// - Which coordinate system to play the shake in (affects oscillations and camera anims)
		/// </param>
		/// <param name="UserPlaySpaceRot">
		/// - Coordinate system to play shake when PlaySpace == CAPS_UserDefined.
		/// </param>
		public virtual UCameraShakeBase StartCameraShakeFromSource(TSubclassOf<UCameraShakeBase> ShakeClass, UCameraShakeSourceComponent SourceComponent, float Scale = 1.000000f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = null)
		{
			unsafe
			{
				UserPlaySpaceRot ??= new FRotator();

				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = ShakeClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Scale;

				*(byte*)(__InBuffer + 20) = (byte)PlaySpace;

				*(nint*)(__InBuffer + 21) = UserPlaySpaceRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __StartCameraShakeFromSource, __InBuffer, __ReturnBuffer);

				return *(UCameraShakeBase*)__ReturnBuffer;
			}
		}

		/// <param name="Shake">
		/// - The class of camera shake to play.
		/// </param>
		/// <param name="Scale">
		/// - Scalar defining how "intense" to play the shake. 1.0 is normal (as authored).
		/// </param>
		/// <param name="PlaySpace">
		/// - Which coordinate system to play the shake in (affects oscillations and camera anims)
		/// </param>
		/// <param name="UserPlaySpaceRot">
		/// - Coordinate system to play shake when PlaySpace == CAPS_UserDefined.
		/// </param>
		public virtual UCameraShakeBase StartCameraShake(TSubclassOf<UCameraShakeBase> ShakeClass, float Scale = 1.000000f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = null)
		{
			unsafe
			{
				UserPlaySpaceRot ??= new FRotator();

				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = ShakeClass?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Scale;

				*(byte*)(__InBuffer + 12) = (byte)PlaySpace;

				*(nint*)(__InBuffer + 13) = UserPlaySpaceRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __StartCameraShake, __InBuffer, __ReturnBuffer);

				return *(UCameraShakeBase*)__ReturnBuffer;
			}
		}

		/// <param name="FromAlpha">
		/// - Alpha at which to begin the fade. Range [0..1], where 0 is fully transparent and 1 is fully opaque solid color.
		/// </param>
		/// <param name="ToAlpha">
		/// - Alpha at which to finish the fade.
		/// </param>
		/// <param name="Duration">
		/// - How long the fade should take, in seconds.
		/// </param>
		/// <param name="Color">
		/// - Color to fade to/from.
		/// </param>
		/// <param name="bShouldFadeAudio">
		/// - True to fade audio volume along with the alpha of the solid color.
		/// </param>
		/// <param name="bHoldWhenFinished">
		/// - True for fade to hold at the ToAlpha until explicitly stopped (e.g. with StopCameraFade)
		/// </param>
		public virtual void StartCameraFade(float FromAlpha, float ToAlpha, float Duration, FLinearColor Color, bool bShouldFadeAudio = false, bool bHoldWhenFinished = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(float*)(__InBuffer) = FromAlpha;

				*(float*)(__InBuffer + 4) = ToAlpha;

				*(float*)(__InBuffer + 8) = Duration;

				*(nint*)(__InBuffer + 12) = Color?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 20) = bShouldFadeAudio;

				*(bool*)(__InBuffer + 21) = bHoldWhenFinished;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartCameraFade, __InBuffer);
			}
		}

		public virtual void SetManualCameraFade(float InFadeAmount, FLinearColor Color, bool bInFadeAudio)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = InFadeAmount;

				*(nint*)(__InBuffer + 4) = Color?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bInFadeAudio;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetManualCameraFade, __InBuffer);
			}
		}

		public virtual void SetGameCameraCutThisFrame()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetGameCameraCutThisFrame);
			}
		}

		/// <param name="Emitter">
		/// - the emitter actor to remove from the camera
		/// </param>
		public virtual void RemoveGenericCameraLensEffect(TScriptInterface<ICameraLensEffectInterface> Emitter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Emitter?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveGenericCameraLensEffect, __InBuffer);
			}
		}

		/// <returns>
		/// True if successfully removed, false otherwise.
		/// </returns>
		public virtual bool RemoveCameraModifier(UCameraModifier ModifierToRemove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ModifierToRemove?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveCameraModifier, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void RemoveCameraLensEffect(AEmitterCameraLensEffectBase Emitter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Emitter?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveCameraLensEffect, __InBuffer);
			}
		}

		public virtual void PhotographyCameraModify(FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, ref FVector ResultCameraLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = NewCameraLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PreviousCameraLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OriginalCameraLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ResultCameraLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __PhotographyCameraModify, __InBuffer, __OutBuffer);

				ResultCameraLocation = *(FVector*)(__OutBuffer);

			}
		}

		public virtual void OnPhotographySessionStart()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnPhotographySessionStart);
			}
		}

		public virtual void OnPhotographySessionEnd()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnPhotographySessionEnd);
			}
		}

		public virtual void OnPhotographyMultiPartCaptureStart()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnPhotographyMultiPartCaptureStart);
			}
		}

		public virtual void OnPhotographyMultiPartCaptureEnd()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnPhotographyMultiPartCaptureEnd);
			}
		}

		public virtual APlayerController GetOwningPlayerController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOwningPlayerController, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		public virtual float GetFOVAngle()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFOVAngle, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetCameraRotation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCameraRotation, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual FVector GetCameraLocation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCameraLocation, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual UCameraModifier FindCameraModifierByClass(TSubclassOf<UCameraModifier> ModifierClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ModifierClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindCameraModifierByClass, __InBuffer, __ReturnBuffer);

				return *(UCameraModifier*)__ReturnBuffer;
			}
		}

		public virtual void ClearCameraLensEffects()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearCameraLensEffects);
			}
		}

		public virtual bool BlueprintUpdateCamera(AActor CameraTarget, ref FVector NewCameraLocation, ref FRotator NewCameraRotation, ref float NewCameraFOV)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = CameraTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewCameraLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewCameraRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = NewCameraFOV;

				var __OutBuffer = stackalloc byte[20];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall7Implementation(GarbageCollectionHandle, __BlueprintUpdateCamera, __InBuffer, __OutBuffer, __ReturnBuffer);

				NewCameraLocation = *(FVector*)(__OutBuffer);

				NewCameraRotation = *(FRotator*)(__OutBuffer + 8);

				NewCameraFOV = *(float*)(__OutBuffer + 16);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ModifierClass">
		/// - The class of camera modifier to create.
		/// </param>
		/// <returns>
		/// Returns the newly created camera modifier.
		/// </returns>
		public virtual UCameraModifier AddNewCameraModifier(TSubclassOf<UCameraModifier> ModifierClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ModifierClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddNewCameraModifier, __InBuffer, __ReturnBuffer);

				return *(UCameraModifier*)__ReturnBuffer;
			}
		}

		/// <param name="LensEffectEmitterClass">
		/// - Class of lens effect emitter to create.
		/// </param>
		/// <returns>
		/// Returns the new emitter actor.
		/// </returns>
		public virtual TScriptInterface<ICameraLensEffectInterface> AddGenericCameraLensEffect(TSubclassOf<AActor> LensEffectEmitterClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LensEffectEmitterClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddGenericCameraLensEffect, __InBuffer, __ReturnBuffer);

				return *(TScriptInterface<ICameraLensEffectInterface>*)__ReturnBuffer;
			}
		}

		public virtual AEmitterCameraLensEffectBase AddCameraLensEffect(TSubclassOf<AEmitterCameraLensEffectBase> LensEffectEmitterClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LensEffectEmitterClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddCameraLensEffect, __InBuffer, __ReturnBuffer);

				return *(AEmitterCameraLensEffectBase*)__ReturnBuffer;
			}
		}

		private static uint __PCOwner = 0;

		private static uint __TransformComponent = 0;

		private static uint __DefaultFOV = 0;

		private static uint __DefaultOrthoWidth = 0;

		private static uint __DefaultAspectRatio = 0;

		private static uint __ViewTarget = 0;

		private static uint __PendingViewTarget = 0;

		private static uint __CameraCachePrivate = 0;

		private static uint __LastFrameCameraCachePrivate = 0;

		private static uint __ModifierList = 0;

		private static uint __DefaultModifiers = 0;

		private static uint __FreeCamDistance = 0;

		private static uint __FreeCamOffset = 0;

		private static uint __ViewTargetOffset = 0;

		private static uint __OnAudioFadeChangeEvent = 0;

		private static uint __CameraLensEffects = 0;

		private static uint __CachedCameraShakeMod = 0;

		private static uint __PostProcessBlendCache = 0;

		private static uint __AnimCameraActor = 0;

		private static uint __bIsOrthographic = 0;

		private static uint __bDefaultConstrainAspectRatio = 0;

		private static uint __bClientSimulatingViewTarget = 0;

		private static uint __bUseClientSideCameraUpdates = 0;

		private static uint __bGameCameraCutThisFrame = 0;

		private static uint __ViewPitchMin = 0;

		private static uint __ViewPitchMax = 0;

		private static uint __ViewYawMin = 0;

		private static uint __ViewYawMax = 0;

		private static uint __ViewRollMin = 0;

		private static uint __ViewRollMax = 0;

		private static uint __ServerUpdateCameraTimeout = 0;

		private static uint __SwapPendingViewTargetWhenUsingClientSideCameraUpdates = 0;

		private static uint __StopCameraShake = 0;

		private static uint __StopCameraFade = 0;

		private static uint __StopAllInstancesOfCameraShakeFromSource = 0;

		private static uint __StopAllInstancesOfCameraShake = 0;

		private static uint __StopAllCameraShakesFromSource = 0;

		private static uint __StopAllCameraShakes = 0;

		private static uint __StartCameraShakeFromSource = 0;

		private static uint __StartCameraShake = 0;

		private static uint __StartCameraFade = 0;

		private static uint __SetManualCameraFade = 0;

		private static uint __SetGameCameraCutThisFrame = 0;

		private static uint __RemoveGenericCameraLensEffect = 0;

		private static uint __RemoveCameraModifier = 0;

		private static uint __RemoveCameraLensEffect = 0;

		private static uint __PhotographyCameraModify = 0;

		private static uint __OnPhotographySessionStart = 0;

		private static uint __OnPhotographySessionEnd = 0;

		private static uint __OnPhotographyMultiPartCaptureStart = 0;

		private static uint __OnPhotographyMultiPartCaptureEnd = 0;

		private static uint __GetOwningPlayerController = 0;

		private static uint __GetFOVAngle = 0;

		private static uint __GetCameraRotation = 0;

		private static uint __GetCameraLocation = 0;

		private static uint __FindCameraModifierByClass = 0;

		private static uint __ClearCameraLensEffects = 0;

		private static uint __BlueprintUpdateCamera = 0;

		private static uint __AddNewCameraModifier = 0;

		private static uint __AddGenericCameraLensEffect = 0;

		private static uint __AddCameraLensEffect = 0;
	}
}