using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LevelEditorPlayNetworkEmulationSettings")]
	public partial class FLevelEditorPlayNetworkEmulationSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.LevelEditorPlayNetworkEmulationSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelEditorPlayNetworkEmulationSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelEditorPlayNetworkEmulationSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelEditorPlayNetworkEmulationSettings A, FLevelEditorPlayNetworkEmulationSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelEditorPlayNetworkEmulationSettings A, FLevelEditorPlayNetworkEmulationSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelEditorPlayNetworkEmulationSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bIsNetworkEmulationEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsNetworkEmulationEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsNetworkEmulationEnabled, __InBuffer);
				}
			}
		}

		public NetworkEmulationTarget EmulationTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmulationTarget, __ReturnBuffer);

					return *(NetworkEmulationTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmulationTarget, __InBuffer);
				}
			}
		}

		public FString CurrentProfile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurrentProfile, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurrentProfile, __InBuffer);
				}
			}
		}

		public FNetworkEmulationPacketSettings OutPackets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutPackets, __ReturnBuffer);

					return *(FNetworkEmulationPacketSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutPackets, __InBuffer);
				}
			}
		}

		public FNetworkEmulationPacketSettings InPackets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InPackets, __ReturnBuffer);

					return *(FNetworkEmulationPacketSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InPackets, __InBuffer);
				}
			}
		}

		private static uint __bIsNetworkEmulationEnabled = 0;

		private static uint __EmulationTarget = 0;

		private static uint __CurrentProfile = 0;

		private static uint __OutPackets = 0;

		private static uint __InPackets = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}