using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ForceFeedbackComponent")]
	public partial class UForceFeedbackComponent : USceneComponent, IStaticClass
	{
		public UForceFeedbackEffect ForceFeedbackEffect
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForceFeedbackEffect, __ReturnBuffer);

					return *(UForceFeedbackEffect*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForceFeedbackEffect, __InBuffer);
				}
			}
		}

		public bool bAutoDestroy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoDestroy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoDestroy, __InBuffer);
				}
			}
		}

		public bool bStopWhenOwnerDestroyed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStopWhenOwnerDestroyed, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStopWhenOwnerDestroyed, __InBuffer);
				}
			}
		}

		public bool bLooping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLooping, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLooping, __InBuffer);
				}
			}
		}

		public bool bIgnoreTimeDilation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreTimeDilation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreTimeDilation, __InBuffer);
				}
			}
		}

		public bool bOverrideAttenuation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideAttenuation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideAttenuation, __InBuffer);
				}
			}
		}

		public float IntensityMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IntensityMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IntensityMultiplier, __InBuffer);
				}
			}
		}

		public UForceFeedbackAttenuation AttenuationSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationSettings, __ReturnBuffer);

					return *(UForceFeedbackAttenuation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationSettings, __InBuffer);
				}
			}
		}

		public FForceFeedbackAttenuationSettings AttenuationOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationOverrides, __ReturnBuffer);

					return *(FForceFeedbackAttenuationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationOverrides, __InBuffer);
				}
			}
		}

		public FOnForceFeedbackFinished OnForceFeedbackFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnForceFeedbackFinished, __ReturnBuffer);

					return *(FOnForceFeedbackFinished*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnForceFeedbackFinished, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ForceFeedbackComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Stop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Stop);
			}
		}

		public virtual void SetIntensityMultiplier(float NewIntensityMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewIntensityMultiplier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIntensityMultiplier, __InBuffer);
			}
		}

		public virtual void SetForceFeedbackEffect(UForceFeedbackEffect NewForceFeedbackEffect)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewForceFeedbackEffect?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForceFeedbackEffect, __InBuffer);
			}
		}

		public virtual void Play(float StartTime = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = StartTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Play, __InBuffer);
			}
		}

		public virtual bool BP_GetAttenuationSettingsToApply(ref FForceFeedbackAttenuationSettings OutAttenuationSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutAttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __BP_GetAttenuationSettingsToApply, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAttenuationSettings = *(FForceFeedbackAttenuationSettings*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void AdjustAttenuation(FForceFeedbackAttenuationSettings InAttenuationSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AdjustAttenuation, __InBuffer);
			}
		}

		private static uint __ForceFeedbackEffect = 0;

		private static uint __bAutoDestroy = 0;

		private static uint __bStopWhenOwnerDestroyed = 0;

		private static uint __bLooping = 0;

		private static uint __bIgnoreTimeDilation = 0;

		private static uint __bOverrideAttenuation = 0;

		private static uint __IntensityMultiplier = 0;

		private static uint __AttenuationSettings = 0;

		private static uint __AttenuationOverrides = 0;

		private static uint __OnForceFeedbackFinished = 0;

		private static uint __Stop = 0;

		private static uint __SetIntensityMultiplier = 0;

		private static uint __SetForceFeedbackEffect = 0;

		private static uint __Play = 0;

		private static uint __BP_GetAttenuationSettingsToApply = 0;

		private static uint __AdjustAttenuation = 0;
	}
}