using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.HotPatcherAssetDependency")]
	public partial class FHotPatcherAssetDependency : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.HotPatcherAssetDependency");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHotPatcherAssetDependency() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FHotPatcherAssetDependency() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FHotPatcherAssetDependency A, FHotPatcherAssetDependency B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHotPatcherAssetDependency A, FHotPatcherAssetDependency B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHotPatcherAssetDependency;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FAssetDetail Asset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Asset, __ReturnBuffer);

					return *(FAssetDetail*)__ReturnBuffer;
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

		public TArray<FAssetDetail> AssetReference
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetReference, __ReturnBuffer);

					return *(TArray<FAssetDetail>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetReference, __InBuffer);
				}
			}
		}

		public TArray<FAssetDetail> AssetDependency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetDependency, __ReturnBuffer);

					return *(TArray<FAssetDetail>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetDependency, __InBuffer);
				}
			}
		}

		private static uint __Asset = 0;

		private static uint __AssetReference = 0;

		private static uint __AssetDependency = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}