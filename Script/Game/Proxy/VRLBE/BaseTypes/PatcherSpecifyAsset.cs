using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PatcherSpecifyAsset")]
	public partial class FPatcherSpecifyAsset : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PatcherSpecifyAsset");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPatcherSpecifyAsset() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPatcherSpecifyAsset() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPatcherSpecifyAsset A, FPatcherSpecifyAsset B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPatcherSpecifyAsset A, FPatcherSpecifyAsset B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPatcherSpecifyAsset;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftObjectPath Asset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Asset, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Asset, __InBuffer);
				}
			}
		}

		public bool bAnalysisAssetDependencies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAnalysisAssetDependencies, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAnalysisAssetDependencies, __InBuffer);
				}
			}
		}

		public TArray<EAssetRegistryDependencyTypeEx> AssetRegistryDependencyTypes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetRegistryDependencyTypes, __ReturnBuffer);

					return *(TArray<EAssetRegistryDependencyTypeEx>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetRegistryDependencyTypes, __InBuffer);
				}
			}
		}

		private static uint __Asset = 0;

		private static uint __bAnalysisAssetDependencies = 0;

		private static uint __AssetRegistryDependencyTypes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}