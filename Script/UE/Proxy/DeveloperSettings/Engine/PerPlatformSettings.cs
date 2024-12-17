using Script.CoreUObject;
using Script.Library;

namespace Script.DeveloperSettings
{
	[PathName("/Script/DeveloperSettings.PerPlatformSettings")]
	public partial class FPerPlatformSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DeveloperSettings.PerPlatformSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerPlatformSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerPlatformSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerPlatformSettings A, FPerPlatformSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerPlatformSettings A, FPerPlatformSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerPlatformSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UPlatformSettings> Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(TArray<UPlatformSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		private static uint __Settings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}