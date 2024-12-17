using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISense_Hearing")]
	public partial class UAISense_Hearing : UAISense, IStaticClass
	{
		public TArray<FAINoiseEvent> NoiseEvents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NoiseEvents, __ReturnBuffer);

					return *(TArray<FAINoiseEvent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NoiseEvents, __InBuffer);
				}
			}
		}

		public float SpeedOfSoundSq
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpeedOfSoundSq, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpeedOfSoundSq, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISense_Hearing");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="NoiseLocation">
		/// Location of the noise.
		/// </param>
		/// <param name="Loudness">
		/// Loudness of the noise. If MaxRange is non-zero, modifies MaxRange, otherwise modifies the squared distance of the sensor's range.
		/// </param>
		/// <param name="Instigator">
		/// Actor that triggered the noise.
		/// </param>
		/// <param name="MaxRange">
		/// Max range at which the sound can be heard, multiplied by Loudness. Values <= 0 mean no limit (still limited by listener's range however).
		/// </param>
		/// <param name="Tag">
		/// Identifier for the event.
		/// </param>
		public static void ReportNoiseEvent(UObject WorldContextObject, FVector NoiseLocation, float Loudness = 1.000000f, AActor Instigator = null, float MaxRange = 0.000000f, FName Tag = null)
		{
			unsafe
			{
				Tag ??= new FName("None");

				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NoiseLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Loudness;

				*(nint*)(__InBuffer + 20) = Instigator?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 28) = MaxRange;

				*(nint*)(__InBuffer + 32) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReportNoiseEvent, __InBuffer);
			}
		}

		private static uint __NoiseEvents = 0;

		private static uint __SpeedOfSoundSq = 0;

		private static uint __ReportNoiseEvent = 0;
	}
}