using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.StaticMeshEditor;
using Script.PhysicsCore;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorStaticMeshLibrary")]
	public partial class UDEPRECATED_EditorStaticMeshLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorScriptingUtilities.EditorStaticMeshLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static int SetLodsWithNotification(UStaticMesh StaticMesh, FStaticMeshReductionOptions ReductionOptions, bool bApplyChanges)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReductionOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bApplyChanges;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetLodsWithNotification, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int SetLods(UStaticMesh StaticMesh, FStaticMeshReductionOptions ReductionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReductionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetLods, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void SetLodReductionSettings(UStaticMesh StaticMesh, int LodIndex, FMeshReductionSettings ReductionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = ReductionOptions?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLodReductionSettings, __InBuffer);
			}
		}

		public static int SetLodFromStaticMesh(UStaticMesh DestinationStaticMesh, int DestinationLodIndex, UStaticMesh SourceStaticMesh, int SourceLodIndex, bool bReuseExistingMaterialSlots)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = DestinationStaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = DestinationLodIndex;

				*(nint*)(__InBuffer + 12) = SourceStaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 20) = SourceLodIndex;

				*(bool*)(__InBuffer + 24) = bReuseExistingMaterialSlots;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetLodFromStaticMesh, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void SetLodBuildSettings(UStaticMesh StaticMesh, int LodIndex, FMeshBuildSettings BuildOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = BuildOptions?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLodBuildSettings, __InBuffer);
			}
		}

		public static bool SetGenerateLightmapUVs(UStaticMesh StaticMesh, bool bGenerateLightmapUVs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bGenerateLightmapUVs;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetGenerateLightmapUVs, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SetConvexDecompositionCollisionsWithNotification(UStaticMesh StaticMesh, int HullCount, int MaxHullVerts, int HullPrecision, bool bApplyChanges)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = HullCount;

				*(int*)(__InBuffer + 12) = MaxHullVerts;

				*(int*)(__InBuffer + 16) = HullPrecision;

				*(bool*)(__InBuffer + 20) = bApplyChanges;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetConvexDecompositionCollisionsWithNotification, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool SetConvexDecompositionCollisions(UStaticMesh StaticMesh, int HullCount, int MaxHullVerts, int HullPrecision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = HullCount;

				*(int*)(__InBuffer + 12) = MaxHullVerts;

				*(int*)(__InBuffer + 16) = HullPrecision;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetConvexDecompositionCollisions, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void SetAllowCPUAccess(UStaticMesh StaticMesh, bool bAllowCPUAccess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAllowCPUAccess;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetAllowCPUAccess, __InBuffer);
			}
		}

		public static bool RemoveUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = UVChannelIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool RemoveLods(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveLods, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool RemoveCollisionsWithNotification(UStaticMesh StaticMesh, bool bApplyChanges)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bApplyChanges;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveCollisionsWithNotification, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool RemoveCollisions(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveCollisions, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ReimportAllCustomLODs(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ReimportAllCustomLODs, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsSectionCollisionEnabled(UStaticMesh StaticMesh, int LODIndex, int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsSectionCollisionEnabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool InsertUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = UVChannelIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InsertUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int ImportLOD(UStaticMesh BaseStaticMesh, int LODIndex, FString SourceFilename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = BaseStaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(nint*)(__InBuffer + 12) = SourceFilename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ImportLOD, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static bool HasVertexColors(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasVertexColors, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool HasInstanceVertexColors(UStaticMeshComponent StaticMeshComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasInstanceVertexColors, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int GetSimpleCollisionCount(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSimpleCollisionCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetNumUVChannels(UStaticMesh StaticMesh, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumUVChannels, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetNumberVerts(UStaticMesh StaticMesh, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumberVerts, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetNumberMaterials(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumberMaterials, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static TArray<float> GetLodScreenSizes(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLodScreenSizes, __InBuffer, __ReturnBuffer);

				return *(TArray<float>*)__ReturnBuffer;
			}
		}

		public static void GetLodReductionSettings(UStaticMesh StaticMesh, int LodIndex, ref FMeshReductionSettings OutReductionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = OutReductionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLodReductionSettings, __InBuffer, __OutBuffer);

				OutReductionOptions = *(FMeshReductionSettings*)(__OutBuffer);

			}
		}

		public static int GetLodCount(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLodCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void GetLodBuildSettings(UStaticMesh StaticMesh, int LodIndex, ref FMeshBuildSettings OutBuildOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = OutBuildOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLodBuildSettings, __InBuffer, __OutBuffer);

				OutBuildOptions = *(FMeshBuildSettings*)(__OutBuffer);

			}
		}

		public static int GetConvexCollisionCount(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetConvexCollisionCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static ECollisionTraceFlag GetCollisionComplexity(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCollisionComplexity, __InBuffer, __ReturnBuffer);

				return *(ECollisionTraceFlag*)__ReturnBuffer;
			}
		}

		public static bool GeneratePlanarUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex, FVector Position, FRotator Orientation, FVector2D Tiling)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = UVChannelIndex;

				*(nint*)(__InBuffer + 16) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Orientation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Tiling?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GeneratePlanarUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GenerateCylindricalUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex, FVector Position, FRotator Orientation, FVector2D Tiling)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = UVChannelIndex;

				*(nint*)(__InBuffer + 16) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Orientation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Tiling?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GenerateCylindricalUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GenerateBoxUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex, FVector Position, FRotator Orientation, FVector Size)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = UVChannelIndex;

				*(nint*)(__InBuffer + 16) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Orientation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Size?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GenerateBoxUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void EnableSectionCollision(UStaticMesh StaticMesh, bool bCollisionEnabled, int LODIndex, int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bCollisionEnabled;

				*(int*)(__InBuffer + 9) = LODIndex;

				*(int*)(__InBuffer + 13) = SectionIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __EnableSectionCollision, __InBuffer);
			}
		}

		public static void EnableSectionCastShadow(UStaticMesh StaticMesh, bool bCastShadow, int LODIndex, int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bCastShadow;

				*(int*)(__InBuffer + 9) = LODIndex;

				*(int*)(__InBuffer + 13) = SectionIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __EnableSectionCastShadow, __InBuffer);
			}
		}

		public static bool BulkSetConvexDecompositionCollisionsWithNotification(TArray<UStaticMesh> StaticMeshes, int HullCount, int MaxHullVerts, int HullPrecision, bool bApplyChanges)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = StaticMeshes?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = HullCount;

				*(int*)(__InBuffer + 12) = MaxHullVerts;

				*(int*)(__InBuffer + 16) = HullPrecision;

				*(bool*)(__InBuffer + 20) = bApplyChanges;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BulkSetConvexDecompositionCollisionsWithNotification, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool BulkSetConvexDecompositionCollisions(TArray<UStaticMesh> StaticMeshes, int HullCount, int MaxHullVerts, int HullPrecision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMeshes?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = HullCount;

				*(int*)(__InBuffer + 12) = MaxHullVerts;

				*(int*)(__InBuffer + 16) = HullPrecision;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BulkSetConvexDecompositionCollisions, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool AddUVChannel(UStaticMesh StaticMesh, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int AddSimpleCollisionsWithNotification(UStaticMesh StaticMesh, EScriptCollisionShapeType ShapeType, bool bApplyChanges)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ShapeType;

				*(bool*)(__InBuffer + 9) = bApplyChanges;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddSimpleCollisionsWithNotification, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int AddSimpleCollisions(UStaticMesh StaticMesh, EScriptCollisionShapeType ShapeType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ShapeType;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddSimpleCollisions, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __SetLodsWithNotification = 0;

		private static uint __SetLods = 0;

		private static uint __SetLodReductionSettings = 0;

		private static uint __SetLodFromStaticMesh = 0;

		private static uint __SetLodBuildSettings = 0;

		private static uint __SetGenerateLightmapUVs = 0;

		private static uint __SetConvexDecompositionCollisionsWithNotification = 0;

		private static uint __SetConvexDecompositionCollisions = 0;

		private static uint __SetAllowCPUAccess = 0;

		private static uint __RemoveUVChannel = 0;

		private static uint __RemoveLods = 0;

		private static uint __RemoveCollisionsWithNotification = 0;

		private static uint __RemoveCollisions = 0;

		private static uint __ReimportAllCustomLODs = 0;

		private static uint __IsSectionCollisionEnabled = 0;

		private static uint __InsertUVChannel = 0;

		private static uint __ImportLOD = 0;

		private static uint __HasVertexColors = 0;

		private static uint __HasInstanceVertexColors = 0;

		private static uint __GetSimpleCollisionCount = 0;

		private static uint __GetNumUVChannels = 0;

		private static uint __GetNumberVerts = 0;

		private static uint __GetNumberMaterials = 0;

		private static uint __GetLodScreenSizes = 0;

		private static uint __GetLodReductionSettings = 0;

		private static uint __GetLodCount = 0;

		private static uint __GetLodBuildSettings = 0;

		private static uint __GetConvexCollisionCount = 0;

		private static uint __GetCollisionComplexity = 0;

		private static uint __GeneratePlanarUVChannel = 0;

		private static uint __GenerateCylindricalUVChannel = 0;

		private static uint __GenerateBoxUVChannel = 0;

		private static uint __EnableSectionCollision = 0;

		private static uint __EnableSectionCastShadow = 0;

		private static uint __BulkSetConvexDecompositionCollisionsWithNotification = 0;

		private static uint __BulkSetConvexDecompositionCollisions = 0;

		private static uint __AddUVChannel = 0;

		private static uint __AddSimpleCollisionsWithNotification = 0;

		private static uint __AddSimpleCollisions = 0;
	}
}