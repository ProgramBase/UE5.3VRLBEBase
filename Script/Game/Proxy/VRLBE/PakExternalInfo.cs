using Script.CoreUObject;
using Script.Library;
using Script.HotPatcherRuntime;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.PakExternalInfo")]
	public partial class FPakExternalInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherCore.PakExternalInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPakExternalInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPakExternalInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPakExternalInfo A, FPakExternalInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPakExternalInfo A, FPakExternalInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPakExternalInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString PakName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PakName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PakName, __InBuffer);
				}
			}
		}

		public TArray<ETargetPlatform> TargetPlatforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetPlatforms, __ReturnBuffer);

					return *(TArray<ETargetPlatform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetPlatforms, __InBuffer);
				}
			}
		}

		public FPlatformExternAssets AddExternAssetsToPlatform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AddExternAssetsToPlatform, __ReturnBuffer);

					return *(FPlatformExternAssets*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AddExternAssetsToPlatform, __InBuffer);
				}
			}
		}

		private static uint __PakName = 0;

		private static uint __TargetPlatforms = 0;

		private static uint __AddExternAssetsToPlatform = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}