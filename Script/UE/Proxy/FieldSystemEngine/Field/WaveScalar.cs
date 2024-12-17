using Script.CoreUObject;
using Script.Chaos;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.WaveScalar")]
	public partial class UWaveScalar : UFieldNodeFloat, IStaticClass
	{
		public float Magnitude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Magnitude, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Magnitude, __InBuffer);
				}
			}
		}

		public FVector Position
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Position, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Position, __InBuffer);
				}
			}
		}

		public float Wavelength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Wavelength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Wavelength, __InBuffer);
				}
			}
		}

		public float Period
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Period, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Period, __InBuffer);
				}
			}
		}

		public EWaveFunctionType Function
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Function, __ReturnBuffer);

					return *(EWaveFunctionType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Function, __InBuffer);
				}
			}
		}

		public EFieldFalloffType Falloff
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Falloff, __ReturnBuffer);

					return *(EFieldFalloffType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Falloff, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.WaveScalar");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Magnitude">
		/// Magnitude of the wave function
		/// </param>
		/// <param name="Position">
		/// Center position of the wave field
		/// </param>
		/// <param name="Wavelength">
		/// Distance between 2 wave peaks
		/// </param>
		/// <param name="Period">
		/// Time over which the wave will travel from one peak to another one. The wave velocity is proportional to wavelength/period
		/// </param>
		/// <param name="Function">
		/// Wave function used for the field
		/// </param>
		/// <param name="Falloff">
		/// Type of falloff function used if the falloff function is picked
		/// </param>
		public virtual UWaveScalar SetWaveScalar(float Magnitude, FVector Position, float Wavelength, float Period, float Time, EWaveFunctionType Function, EFieldFalloffType Falloff)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(float*)(__InBuffer) = Magnitude;

				*(nint*)(__InBuffer + 4) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 12) = Wavelength;

				*(float*)(__InBuffer + 16) = Period;

				*(float*)(__InBuffer + 20) = Time;

				*(byte*)(__InBuffer + 24) = (byte)Function;

				*(byte*)(__InBuffer + 25) = (byte)Falloff;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SetWaveScalar, __InBuffer, __ReturnBuffer);

				return *(UWaveScalar*)__ReturnBuffer;
			}
		}

		private static uint __Magnitude = 0;

		private static uint __Position = 0;

		private static uint __Wavelength = 0;

		private static uint __Period = 0;

		private static uint __Function = 0;

		private static uint __Falloff = 0;

		private static uint __SetWaveScalar = 0;
	}
}