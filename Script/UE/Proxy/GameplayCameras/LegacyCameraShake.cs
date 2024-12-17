using Script.CoreUObject;
using Script.Engine;
using Script.TemplateSequence;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.LegacyCameraShake")]
	public partial class ULegacyCameraShake : UCameraShakeBase, IStaticClass
	{
		public float OscillationDuration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OscillationDuration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OscillationDuration, __InBuffer);
				}
			}
		}

		public float OscillationBlendInTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OscillationBlendInTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OscillationBlendInTime, __InBuffer);
				}
			}
		}

		public float OscillationBlendOutTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OscillationBlendOutTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OscillationBlendOutTime, __InBuffer);
				}
			}
		}

		public FROscillator RotOscillation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RotOscillation, __ReturnBuffer);

					return *(FROscillator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RotOscillation, __InBuffer);
				}
			}
		}

		public FVOscillator LocOscillation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocOscillation, __ReturnBuffer);

					return *(FVOscillator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocOscillation, __InBuffer);
				}
			}
		}

		public FFOscillator FOVOscillation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FOVOscillation, __ReturnBuffer);

					return *(FFOscillator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FOVOscillation, __InBuffer);
				}
			}
		}

		public float AnimPlayRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimPlayRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimPlayRate, __InBuffer);
				}
			}
		}

		public float AnimScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimScale, __InBuffer);
				}
			}
		}

		public float AnimBlendInTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimBlendInTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimBlendInTime, __InBuffer);
				}
			}
		}

		public float AnimBlendOutTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimBlendOutTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimBlendOutTime, __InBuffer);
				}
			}
		}

		public float RandomAnimSegmentDuration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RandomAnimSegmentDuration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RandomAnimSegmentDuration, __InBuffer);
				}
			}
		}

		public UCameraAnimationSequence AnimSequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimSequence, __ReturnBuffer);

					return *(UCameraAnimationSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimSequence, __InBuffer);
				}
			}
		}

		public bool bRandomAnimSegment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRandomAnimSegment, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRandomAnimSegment, __InBuffer);
				}
			}
		}

		public float OscillatorTimeRemaining
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OscillatorTimeRemaining, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OscillatorTimeRemaining, __InBuffer);
				}
			}
		}

		public USequenceCameraShakePattern SequenceShakePattern
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SequenceShakePattern, __ReturnBuffer);

					return *(USequenceCameraShakePattern*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SequenceShakePattern, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayCameras.LegacyCameraShake");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static ULegacyCameraShake StartLegacyCameraShakeFromSource(APlayerCameraManager PlayerCameraManager, TSubclassOf<ULegacyCameraShake> ShakeClass, UCameraShakeSourceComponent SourceComponent, float Scale = 1.000000f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = null)
		{
			unsafe
			{
				UserPlaySpaceRot ??= new FRotator();

				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = PlayerCameraManager?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ShakeClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SourceComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Scale;

				*(byte*)(__InBuffer + 28) = (byte)PlaySpace;

				*(nint*)(__InBuffer + 29) = UserPlaySpaceRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __StartLegacyCameraShakeFromSource, __InBuffer, __ReturnBuffer);

				return *(ULegacyCameraShake*)__ReturnBuffer;
			}
		}

		public static ULegacyCameraShake StartLegacyCameraShake(APlayerCameraManager PlayerCameraManager, TSubclassOf<ULegacyCameraShake> ShakeClass, float Scale = 1.000000f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = null)
		{
			unsafe
			{
				UserPlaySpaceRot ??= new FRotator();

				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = PlayerCameraManager?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ShakeClass?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Scale;

				*(byte*)(__InBuffer + 20) = (byte)PlaySpace;

				*(nint*)(__InBuffer + 21) = UserPlaySpaceRot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __StartLegacyCameraShake, __InBuffer, __ReturnBuffer);

				return *(ULegacyCameraShake*)__ReturnBuffer;
			}
		}

		/// <param name="bImmediatly">
		/// If true, shake stops right away regardless of blend out settings. If false, shake may blend out according to its settings.
		/// </param>
		public virtual void ReceiveStopShake(bool bImmediately)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bImmediately;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveStopShake, __InBuffer);
			}
		}

		public virtual void ReceivePlayShake(float Scale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Scale;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceivePlayShake, __InBuffer);
			}
		}

		public virtual bool ReceiveIsFinished()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ReceiveIsFinished, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void BlueprintUpdateCameraShake(float DeltaTime, float Alpha, FMinimalViewInfo POV, ref FMinimalViewInfo ModifiedPOV)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(float*)(__InBuffer) = DeltaTime;

				*(float*)(__InBuffer + 4) = Alpha;

				*(nint*)(__InBuffer + 8) = POV?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ModifiedPOV?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall6Implementation(GarbageCollectionHandle, __BlueprintUpdateCameraShake, __InBuffer, __OutBuffer);

				ModifiedPOV = *(FMinimalViewInfo*)(__OutBuffer);

			}
		}

		private static uint __OscillationDuration = 0;

		private static uint __OscillationBlendInTime = 0;

		private static uint __OscillationBlendOutTime = 0;

		private static uint __RotOscillation = 0;

		private static uint __LocOscillation = 0;

		private static uint __FOVOscillation = 0;

		private static uint __AnimPlayRate = 0;

		private static uint __AnimScale = 0;

		private static uint __AnimBlendInTime = 0;

		private static uint __AnimBlendOutTime = 0;

		private static uint __RandomAnimSegmentDuration = 0;

		private static uint __AnimSequence = 0;

		private static uint __bRandomAnimSegment = 0;

		private static uint __OscillatorTimeRemaining = 0;

		private static uint __SequenceShakePattern = 0;

		private static uint __StartLegacyCameraShakeFromSource = 0;

		private static uint __StartLegacyCameraShake = 0;

		private static uint __ReceiveStopShake = 0;

		private static uint __ReceivePlayShake = 0;

		private static uint __ReceiveIsFinished = 0;

		private static uint __BlueprintUpdateCameraShake = 0;
	}
}