using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SubmixEffectTapDelayPreset")]
	public partial class USubmixEffectTapDelayPreset : USoundEffectSubmixPreset, IStaticClass
	{
		public FSubmixEffectTapDelaySettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FSubmixEffectTapDelaySettings*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.SubmixEffectTapDelayPreset");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetTap(int TapId, FTapDelayInfo TapInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = TapId;

				*(nint*)(__InBuffer + 4) = TapInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTap, __InBuffer);
			}
		}

		public virtual void SetSettings(FSubmixEffectTapDelaySettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSettings, __InBuffer);
			}
		}

		public virtual void SetInterpolationTime(float Time)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Time;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInterpolationTime, __InBuffer);
			}
		}

		public virtual void RemoveTap(int TapId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = TapId;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveTap, __InBuffer);
			}
		}

		public virtual void GetTapIds(ref TArray<int> TapIds)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TapIds?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTapIds, __InBuffer, __OutBuffer);

				TapIds = *(TArray<int>*)(__OutBuffer);

			}
		}

		public virtual void GetTap(int TapId, ref FTapDelayInfo TapInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = TapId;

				*(nint*)(__InBuffer + 4) = TapInfo?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTap, __InBuffer, __OutBuffer);

				TapInfo = *(FTapDelayInfo*)(__OutBuffer);

			}
		}

		public virtual float GetMaxDelayInMilliseconds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMaxDelayInMilliseconds, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void AddTap(ref int TapId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = TapId;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __AddTap, __InBuffer, __OutBuffer);

				TapId = *(int*)(__OutBuffer);

			}
		}

		private static uint __Settings = 0;

		private static uint __SetTap = 0;

		private static uint __SetSettings = 0;

		private static uint __SetInterpolationTime = 0;

		private static uint __RemoveTap = 0;

		private static uint __GetTapIds = 0;

		private static uint __GetTap = 0;

		private static uint __GetMaxDelayInMilliseconds = 0;

		private static uint __AddTap = 0;
	}
}