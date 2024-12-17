using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundModulationDefaultSettings")]
	public partial class FSoundModulationDefaultSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SoundModulationDefaultSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundModulationDefaultSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSoundModulationDefaultSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSoundModulationDefaultSettings A, FSoundModulationDefaultSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundModulationDefaultSettings A, FSoundModulationDefaultSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundModulationDefaultSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoundModulationDestinationSettings VolumeModulationDestination
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VolumeModulationDestination, __ReturnBuffer);

					return *(FSoundModulationDestinationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VolumeModulationDestination, __InBuffer);
				}
			}
		}

		public FSoundModulationDestinationSettings PitchModulationDestination
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PitchModulationDestination, __ReturnBuffer);

					return *(FSoundModulationDestinationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PitchModulationDestination, __InBuffer);
				}
			}
		}

		public FSoundModulationDestinationSettings HighpassModulationDestination
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HighpassModulationDestination, __ReturnBuffer);

					return *(FSoundModulationDestinationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HighpassModulationDestination, __InBuffer);
				}
			}
		}

		public FSoundModulationDestinationSettings LowpassModulationDestination
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LowpassModulationDestination, __ReturnBuffer);

					return *(FSoundModulationDestinationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LowpassModulationDestination, __InBuffer);
				}
			}
		}

		private static uint __VolumeModulationDestination = 0;

		private static uint __PitchModulationDestination = 0;

		private static uint __HighpassModulationDestination = 0;

		private static uint __LowpassModulationDestination = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}