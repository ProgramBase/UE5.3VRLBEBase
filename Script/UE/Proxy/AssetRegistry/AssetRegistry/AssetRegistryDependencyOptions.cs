using Script.CoreUObject;
using Script.Library;

namespace Script.AssetRegistry
{
	[PathName("/Script/AssetRegistry.AssetRegistryDependencyOptions")]
	public partial class FAssetRegistryDependencyOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AssetRegistry.AssetRegistryDependencyOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAssetRegistryDependencyOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAssetRegistryDependencyOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAssetRegistryDependencyOptions A, FAssetRegistryDependencyOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAssetRegistryDependencyOptions A, FAssetRegistryDependencyOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAssetRegistryDependencyOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bIncludeSoftPackageReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeSoftPackageReferences, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeSoftPackageReferences, __InBuffer);
				}
			}
		}

		public bool bIncludeHardPackageReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeHardPackageReferences, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeHardPackageReferences, __InBuffer);
				}
			}
		}

		public bool bIncludeSearchableNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeSearchableNames, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeSearchableNames, __InBuffer);
				}
			}
		}

		public bool bIncludeSoftManagementReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeSoftManagementReferences, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeSoftManagementReferences, __InBuffer);
				}
			}
		}

		public bool bIncludeHardManagementReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeHardManagementReferences, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIncludeHardManagementReferences, __InBuffer);
				}
			}
		}

		private static uint __bIncludeSoftPackageReferences = 0;

		private static uint __bIncludeHardPackageReferences = 0;

		private static uint __bIncludeSearchableNames = 0;

		private static uint __bIncludeSoftManagementReferences = 0;

		private static uint __bIncludeHardManagementReferences = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}