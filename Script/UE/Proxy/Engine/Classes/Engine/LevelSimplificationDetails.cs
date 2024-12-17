using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelSimplificationDetails")]
	public partial class FLevelSimplificationDetails : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.LevelSimplificationDetails");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLevelSimplificationDetails() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLevelSimplificationDetails() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLevelSimplificationDetails A, FLevelSimplificationDetails B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLevelSimplificationDetails A, FLevelSimplificationDetails B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLevelSimplificationDetails;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bCreatePackagePerAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCreatePackagePerAsset, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCreatePackagePerAsset, __InBuffer);
				}
			}
		}

		public float DetailsPercentage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DetailsPercentage, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DetailsPercentage, __InBuffer);
				}
			}
		}

		public FMaterialProxySettings StaticMeshMaterialSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StaticMeshMaterialSettings, __ReturnBuffer);

					return *(FMaterialProxySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StaticMeshMaterialSettings, __InBuffer);
				}
			}
		}

		public bool bOverrideLandscapeExportLOD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideLandscapeExportLOD, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideLandscapeExportLOD, __InBuffer);
				}
			}
		}

		public int LandscapeExportLOD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LandscapeExportLOD, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LandscapeExportLOD, __InBuffer);
				}
			}
		}

		public FMaterialProxySettings LandscapeMaterialSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LandscapeMaterialSettings, __ReturnBuffer);

					return *(FMaterialProxySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LandscapeMaterialSettings, __InBuffer);
				}
			}
		}

		public bool bBakeFoliageToLandscape
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bBakeFoliageToLandscape, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bBakeFoliageToLandscape, __InBuffer);
				}
			}
		}

		public bool bBakeGrassToLandscape
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bBakeGrassToLandscape, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bBakeGrassToLandscape, __InBuffer);
				}
			}
		}

		private static uint __bCreatePackagePerAsset = 0;

		private static uint __DetailsPercentage = 0;

		private static uint __StaticMeshMaterialSettings = 0;

		private static uint __bOverrideLandscapeExportLOD = 0;

		private static uint __LandscapeExportLOD = 0;

		private static uint __LandscapeMaterialSettings = 0;

		private static uint __bBakeFoliageToLandscape = 0;

		private static uint __bBakeGrassToLandscape = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}