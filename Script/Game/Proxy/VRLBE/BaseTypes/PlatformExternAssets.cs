using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PlatformExternAssets")]
	public partial class FPlatformExternAssets : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PlatformExternAssets");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlatformExternAssets() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlatformExternAssets() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlatformExternAssets A, FPlatformExternAssets B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlatformExternAssets A, FPlatformExternAssets B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlatformExternAssets;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ETargetPlatform TargetPlatform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetPlatform, __ReturnBuffer);

					return *(ETargetPlatform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetPlatform, __InBuffer);
				}
			}
		}

		public TArray<FExternFileInfo> AddExternFileToPak
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AddExternFileToPak, __ReturnBuffer);

					return *(TArray<FExternFileInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AddExternFileToPak, __InBuffer);
				}
			}
		}

		public TArray<FExternDirectoryInfo> AddExternDirectoryToPak
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AddExternDirectoryToPak, __ReturnBuffer);

					return *(TArray<FExternDirectoryInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AddExternDirectoryToPak, __InBuffer);
				}
			}
		}

		private static uint __TargetPlatform = 0;

		private static uint __AddExternFileToPak = 0;

		private static uint __AddExternDirectoryToPak = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}