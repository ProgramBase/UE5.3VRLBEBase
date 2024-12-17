using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundModulationDefaultRoutingSettings")]
	public partial class FSoundModulationDefaultRoutingSettings : FSoundModulationDefaultSettings, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SoundModulationDefaultRoutingSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSoundModulationDefaultRoutingSettings()
		{
		}

		public static bool operator ==(FSoundModulationDefaultRoutingSettings A, FSoundModulationDefaultRoutingSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSoundModulationDefaultRoutingSettings A, FSoundModulationDefaultRoutingSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSoundModulationDefaultRoutingSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EModulationRouting VolumeRouting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VolumeRouting, __ReturnBuffer);

					return *(EModulationRouting*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VolumeRouting, __InBuffer);
				}
			}
		}

		public EModulationRouting PitchRouting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PitchRouting, __ReturnBuffer);

					return *(EModulationRouting*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PitchRouting, __InBuffer);
				}
			}
		}

		public EModulationRouting HighpassRouting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HighpassRouting, __ReturnBuffer);

					return *(EModulationRouting*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HighpassRouting, __InBuffer);
				}
			}
		}

		public EModulationRouting LowpassRouting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LowpassRouting, __ReturnBuffer);

					return *(EModulationRouting*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LowpassRouting, __InBuffer);
				}
			}
		}

		private static uint __VolumeRouting = 0;

		private static uint __PitchRouting = 0;

		private static uint __HighpassRouting = 0;

		private static uint __LowpassRouting = 0;

	}
}