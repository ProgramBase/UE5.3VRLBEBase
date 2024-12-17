using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PatchVersionDiff")]
	public partial class FPatchVersionDiff : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PatchVersionDiff");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPatchVersionDiff() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPatchVersionDiff() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPatchVersionDiff A, FPatchVersionDiff B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPatchVersionDiff A, FPatchVersionDiff B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPatchVersionDiff;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPatchVersionAssetDiff AssetDiffInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetDiffInfo, __ReturnBuffer);

					return *(FPatchVersionAssetDiff*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetDiffInfo, __InBuffer);
				}
			}
		}

		public TMap<ETargetPlatform, FPatchVersionExternDiff> PlatformExternDiffInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlatformExternDiffInfo, __ReturnBuffer);

					return *(TMap<ETargetPlatform, FPatchVersionExternDiff>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlatformExternDiffInfo, __InBuffer);
				}
			}
		}

		private static uint __AssetDiffInfo = 0;

		private static uint __PlatformExternDiffInfo = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}