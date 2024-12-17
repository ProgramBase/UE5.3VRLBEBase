using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ResonanceAudio
{
	[PathName("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset")]
	public partial class UResonanceAudioReverbPluginPreset : USoundEffectSubmixPreset, IStaticClass
	{
		public FResonanceAudioReverbPluginSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FResonanceAudioReverbPluginSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ResonanceAudio.ResonanceAudioReverbPluginPreset");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetRoomRotation(FQuat InRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InRotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRoomRotation, __InBuffer);
			}
		}

		public virtual void SetRoomPosition(FVector InPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRoomPosition, __InBuffer);
			}
		}

		public virtual void SetRoomMaterials(TArray<ERaMaterialName> InMaterials)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMaterials?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRoomMaterials, __InBuffer);
			}
		}

		public virtual void SetRoomDimensions(FVector InDimensions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDimensions?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRoomDimensions, __InBuffer);
			}
		}

		public virtual void SetReverbTimeModifier(float InReverbTimeModifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InReverbTimeModifier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReverbTimeModifier, __InBuffer);
			}
		}

		public virtual void SetReverbGain(float InReverbGain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InReverbGain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReverbGain, __InBuffer);
			}
		}

		public virtual void SetReverbBrightness(float InReverbBrightness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InReverbBrightness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReverbBrightness, __InBuffer);
			}
		}

		public virtual void SetReflectionScalar(float InReflectionScalar)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InReflectionScalar;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReflectionScalar, __InBuffer);
			}
		}

		public virtual void SetEnableRoomEffects(bool bInEnableRoomEffects)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInEnableRoomEffects;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableRoomEffects, __InBuffer);
			}
		}

		private static uint __Settings = 0;

		private static uint __SetRoomRotation = 0;

		private static uint __SetRoomPosition = 0;

		private static uint __SetRoomMaterials = 0;

		private static uint __SetRoomDimensions = 0;

		private static uint __SetReverbTimeModifier = 0;

		private static uint __SetReverbGain = 0;

		private static uint __SetReverbBrightness = 0;

		private static uint __SetReflectionScalar = 0;

		private static uint __SetEnableRoomEffects = 0;
	}
}