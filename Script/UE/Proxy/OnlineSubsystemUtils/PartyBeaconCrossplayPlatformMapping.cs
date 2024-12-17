using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.PartyBeaconCrossplayPlatformMapping")]
	public partial class FPartyBeaconCrossplayPlatformMapping : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/OnlineSubsystemUtils.PartyBeaconCrossplayPlatformMapping");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPartyBeaconCrossplayPlatformMapping() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPartyBeaconCrossplayPlatformMapping() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPartyBeaconCrossplayPlatformMapping A, FPartyBeaconCrossplayPlatformMapping B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPartyBeaconCrossplayPlatformMapping A, FPartyBeaconCrossplayPlatformMapping B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPartyBeaconCrossplayPlatformMapping;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString PlatformName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlatformName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlatformName, __InBuffer);
				}
			}
		}

		public FString PlatformType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlatformType, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlatformType, __InBuffer);
				}
			}
		}

		private static uint __PlatformName = 0;

		private static uint __PlatformType = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}