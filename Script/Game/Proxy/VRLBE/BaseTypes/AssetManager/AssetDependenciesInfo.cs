using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.AssetDependenciesInfo")]
	public partial class FAssetDependenciesInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.AssetDependenciesInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAssetDependenciesInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAssetDependenciesInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAssetDependenciesInfo A, FAssetDependenciesInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAssetDependenciesInfo A, FAssetDependenciesInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAssetDependenciesInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, FAssetDependenciesDetail> AssetsDependenciesMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AssetsDependenciesMap, __ReturnBuffer);

					return *(TMap<FString, FAssetDependenciesDetail>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AssetsDependenciesMap, __InBuffer);
				}
			}
		}

		private static uint __AssetsDependenciesMap = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}