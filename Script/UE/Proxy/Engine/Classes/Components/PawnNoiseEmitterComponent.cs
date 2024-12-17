using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PawnNoiseEmitterComponent")]
	public partial class UPawnNoiseEmitterComponent : UActorComponent, IStaticClass
	{
		public bool bAIPerceptionSystemCompatibilityMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAIPerceptionSystemCompatibilityMode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAIPerceptionSystemCompatibilityMode, __InBuffer);
				}
			}
		}

		public FVector LastRemoteNoisePosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastRemoteNoisePosition, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastRemoteNoisePosition, __InBuffer);
				}
			}
		}

		public float NoiseLifetime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NoiseLifetime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NoiseLifetime, __InBuffer);
				}
			}
		}

		public float LastRemoteNoiseVolume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastRemoteNoiseVolume, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastRemoteNoiseVolume, __InBuffer);
				}
			}
		}

		public float LastRemoteNoiseTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastRemoteNoiseTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastRemoteNoiseTime, __InBuffer);
				}
			}
		}

		public float LastLocalNoiseVolume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastLocalNoiseVolume, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastLocalNoiseVolume, __InBuffer);
				}
			}
		}

		public float LastLocalNoiseTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastLocalNoiseTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastLocalNoiseTime, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PawnNoiseEmitterComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="NoiseMaker">
		/// - is the actual actor which made the noise
		/// </param>
		/// <param name="Loudness">
		/// - is the relative loudness of the noise (0.0 to 1.0)
		/// </param>
		/// <param name="NoiseLocation">
		/// - is the position of the noise
		/// </param>
		public virtual void MakeNoise(AActor NoiseMaker, float Loudness, FVector NoiseLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NoiseMaker?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Loudness;

				*(nint*)(__InBuffer + 12) = NoiseLocation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __MakeNoise, __InBuffer);
			}
		}

		private static uint __bAIPerceptionSystemCompatibilityMode = 0;

		private static uint __LastRemoteNoisePosition = 0;

		private static uint __NoiseLifetime = 0;

		private static uint __LastRemoteNoiseVolume = 0;

		private static uint __LastRemoteNoiseTime = 0;

		private static uint __LastLocalNoiseVolume = 0;

		private static uint __LastLocalNoiseTime = 0;

		private static uint __MakeNoise = 0;
	}
}