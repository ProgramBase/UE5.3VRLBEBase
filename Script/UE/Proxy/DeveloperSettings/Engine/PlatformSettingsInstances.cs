using Script.CoreUObject;
using Script.Library;

namespace Script.DeveloperSettings
{
	[PathName("/Script/DeveloperSettings.PlatformSettingsInstances")]
	public partial class FPlatformSettingsInstances : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DeveloperSettings.PlatformSettingsInstances");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlatformSettingsInstances() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlatformSettingsInstances() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlatformSettingsInstances A, FPlatformSettingsInstances B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlatformSettingsInstances A, FPlatformSettingsInstances B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlatformSettingsInstances;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UPlatformSettings PlatformInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlatformInstance, __ReturnBuffer);

					return *(UPlatformSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlatformInstance, __InBuffer);
				}
			}
		}

		public TMap<FName, UPlatformSettings> OtherPlatforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OtherPlatforms, __ReturnBuffer);

					return *(TMap<FName, UPlatformSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OtherPlatforms, __InBuffer);
				}
			}
		}

		private static uint __PlatformInstance = 0;

		private static uint __OtherPlatforms = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}