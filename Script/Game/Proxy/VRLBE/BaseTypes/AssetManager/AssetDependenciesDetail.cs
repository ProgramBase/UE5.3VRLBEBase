using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.AssetDependenciesDetail")]
	public partial class FAssetDependenciesDetail : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.AssetDependenciesDetail");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAssetDependenciesDetail() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAssetDependenciesDetail() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAssetDependenciesDetail A, FAssetDependenciesDetail B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAssetDependenciesDetail A, FAssetDependenciesDetail B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAssetDependenciesDetail;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ModuleCategory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModuleCategory, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModuleCategory, __InBuffer);
				}
			}
		}

		public TMap<FString, FAssetDetail> AssetDependencyDetails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetDependencyDetails, __ReturnBuffer);

					return *(TMap<FString, FAssetDetail>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetDependencyDetails, __InBuffer);
				}
			}
		}

		private static uint __ModuleCategory = 0;

		private static uint __AssetDependencyDetails = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}