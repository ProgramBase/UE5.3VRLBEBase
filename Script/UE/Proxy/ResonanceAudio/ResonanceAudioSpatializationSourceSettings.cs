using Script.CoreUObject;
using Script.AudioExtensions;
using Script.Library;

namespace Script.ResonanceAudio
{
	[PathName("/Script/ResonanceAudio.ResonanceAudioSpatializationSourceSettings")]
	public partial class UResonanceAudioSpatializationSourceSettings : USpatializationPluginSourceSettingsBase, IStaticClass
	{
		public ERaSpatializationMethod SpatializationMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpatializationMethod, __ReturnBuffer);

					return *(ERaSpatializationMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpatializationMethod, __InBuffer);
				}
			}
		}

		public float Pattern
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Pattern, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Pattern, __InBuffer);
				}
			}
		}

		public float Sharpness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sharpness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Sharpness, __InBuffer);
				}
			}
		}

		public bool bToggleVisualization
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bToggleVisualization, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bToggleVisualization, __InBuffer);
				}
			}
		}

		public float Scale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Scale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Scale, __InBuffer);
				}
			}
		}

		public float Spread
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Spread, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Spread, __InBuffer);
				}
			}
		}

		public ERaDistanceRolloffModel Rolloff
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Rolloff, __ReturnBuffer);

					return *(ERaDistanceRolloffModel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Rolloff, __InBuffer);
				}
			}
		}

		public float MinDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinDistance, __InBuffer);
				}
			}
		}

		public float MaxDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDistance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ResonanceAudio.ResonanceAudioSpatializationSourceSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSoundSourceSpread(float InSpread)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InSpread;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSoundSourceSpread, __InBuffer);
			}
		}

		public virtual void SetSoundSourceDirectivity(float InPattern, float InSharpness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = InPattern;

				*(float*)(__InBuffer + 4) = InSharpness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSoundSourceDirectivity, __InBuffer);
			}
		}

		private static uint __SpatializationMethod = 0;

		private static uint __Pattern = 0;

		private static uint __Sharpness = 0;

		private static uint __bToggleVisualization = 0;

		private static uint __Scale = 0;

		private static uint __Spread = 0;

		private static uint __Rolloff = 0;

		private static uint __MinDistance = 0;

		private static uint __MaxDistance = 0;

		private static uint __SetSoundSourceSpread = 0;

		private static uint __SetSoundSourceDirectivity = 0;
	}
}