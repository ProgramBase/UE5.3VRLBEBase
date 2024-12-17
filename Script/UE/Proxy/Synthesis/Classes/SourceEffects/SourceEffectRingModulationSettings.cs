using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectRingModulationSettings")]
	public partial class FSourceEffectRingModulationSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SourceEffectRingModulationSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectRingModulationSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectRingModulationSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectRingModulationSettings A, FSourceEffectRingModulationSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectRingModulationSettings A, FSourceEffectRingModulationSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectRingModulationSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ERingModulatorTypeSourceEffect ModulatorType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModulatorType, __ReturnBuffer);

					return *(ERingModulatorTypeSourceEffect*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModulatorType, __InBuffer);
				}
			}
		}

		public float Frequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Frequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Frequency, __InBuffer);
				}
			}
		}

		public float Depth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Depth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Depth, __InBuffer);
				}
			}
		}

		public float DryLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DryLevel, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DryLevel, __InBuffer);
				}
			}
		}

		public float WetLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WetLevel, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WetLevel, __InBuffer);
				}
			}
		}

		public UAudioBus AudioBusModulator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AudioBusModulator, __ReturnBuffer);

					return *(UAudioBus*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AudioBusModulator, __InBuffer);
				}
			}
		}

		private static uint __ModulatorType = 0;

		private static uint __Frequency = 0;

		private static uint __Depth = 0;

		private static uint __DryLevel = 0;

		private static uint __WetLevel = 0;

		private static uint __AudioBusModulator = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}