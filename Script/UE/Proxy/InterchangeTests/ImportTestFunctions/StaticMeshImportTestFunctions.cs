using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.StaticMeshImportTestFunctions")]
	public partial class UStaticMeshImportTestFunctions : UImportTestFunctionsBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.StaticMeshImportTestFunctions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FInterchangeTestFunctionResult CheckVertexIndexPosition(UStaticMesh Mesh, int LodIndex, int VertexIndex, FVector ExpectedVertexPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = VertexIndex;

				*(nint*)(__InBuffer + 16) = ExpectedVertexPosition?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckVertexIndexPosition, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckVertexCount(UStaticMesh Mesh, int LodIndex, int ExpectedNumberOfVertices)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = ExpectedNumberOfVertices;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckVertexCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckUVChannelCount(UStaticMesh Mesh, int LodIndex, int ExpectedNumberOfUVChannels)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = ExpectedNumberOfUVChannels;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckUVChannelCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckTriangleCountInPolygonGroup(UStaticMesh Mesh, int LodIndex, int PolygonGroupIndex, int ExpectedNumberOfTriangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = PolygonGroupIndex;

				*(int*)(__InBuffer + 16) = ExpectedNumberOfTriangles;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckTriangleCountInPolygonGroup, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckTriangleCount(UStaticMesh Mesh, int LodIndex, int ExpectedTotalNumberOfTriangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = ExpectedTotalNumberOfTriangles;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckTriangleCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckThatMeshHasQuadsOrNgons(UStaticMesh Mesh, int LodIndex, bool bMeshHasQuadsOrNgons)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(bool*)(__InBuffer + 12) = bMeshHasQuadsOrNgons;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckThatMeshHasQuadsOrNgons, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSocketName(UStaticMesh Mesh, int SocketIndex, FString ExpectedSocketName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SocketIndex;

				*(nint*)(__InBuffer + 12) = ExpectedSocketName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSocketName, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSocketLocation(UStaticMesh Mesh, int SocketIndex, FVector ExpectedSocketLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SocketIndex;

				*(nint*)(__InBuffer + 12) = ExpectedSocketLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSocketLocation, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSocketCount(UStaticMesh Mesh, int ExpectedSocketCount)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedSocketCount;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSocketCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSimpleCollisionPrimitiveCount(UStaticMesh Mesh, int ExpectedSphereElementCount, int ExpectedBoxElementCount, int ExpectedCapsuleElementCount, int ExpectedConvexElementCount, int ExpectedTaperedCapsuleElementCount)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedSphereElementCount;

				*(int*)(__InBuffer + 12) = ExpectedBoxElementCount;

				*(int*)(__InBuffer + 16) = ExpectedCapsuleElementCount;

				*(int*)(__InBuffer + 20) = ExpectedConvexElementCount;

				*(int*)(__InBuffer + 24) = ExpectedTaperedCapsuleElementCount;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSimpleCollisionPrimitiveCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSectionMaterialName(UStaticMesh Mesh, int LodIndex, int SectionIndex, FString ExpectedMaterialName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(nint*)(__InBuffer + 16) = ExpectedMaterialName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSectionMaterialName, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSectionMaterialIndex(UStaticMesh Mesh, int LodIndex, int SectionIndex, int ExpectedMaterialIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(int*)(__InBuffer + 16) = ExpectedMaterialIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSectionMaterialIndex, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSectionImportedMaterialSlotName(UStaticMesh Mesh, int LodIndex, int SectionIndex, FString ExpectedImportedMaterialSlotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(nint*)(__InBuffer + 16) = ExpectedImportedMaterialSlotName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSectionImportedMaterialSlotName, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSectionCount(UStaticMesh Mesh, int LodIndex, int ExpectedNumberOfSections)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = ExpectedNumberOfSections;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSectionCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckRenderVertexIndexNormal(UStaticMesh Mesh, int LodIndex, int VertexIndex, FVector4f ExpectedVertexNormal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = VertexIndex;

				*(nint*)(__InBuffer + 16) = ExpectedVertexNormal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckRenderVertexIndexNormal, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckRenderVertexIndexColor(UStaticMesh Mesh, int LodIndex, int VertexIndex, FColor ExpectedVertexColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = VertexIndex;

				*(nint*)(__InBuffer + 16) = ExpectedVertexColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckRenderVertexIndexColor, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckRenderVertexCount(UStaticMesh Mesh, int LodIndex, int ExpectedNumberOfRenderVertices)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = ExpectedNumberOfRenderVertices;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckRenderVertexCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckRenderUVChannelCount(UStaticMesh Mesh, int LodIndex, int ExpectedNumberOfUVChannels)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = ExpectedNumberOfUVChannels;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckRenderUVChannelCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckRenderTriangleCount(UStaticMesh Mesh, int LodIndex, int ExpectedTotalNumberOfTriangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = ExpectedTotalNumberOfTriangles;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckRenderTriangleCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckRenderHasVertexColors(UStaticMesh Mesh, int LodIndex, bool bExpectedHasVertexColors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(bool*)(__InBuffer + 12) = bExpectedHasVertexColors;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckRenderHasVertexColors, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckPolygonGroupImportedMaterialSlotName(UStaticMesh Mesh, int LodIndex, int PolygonGroupIndex, FString ExpectedImportedMaterialSlotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = PolygonGroupIndex;

				*(nint*)(__InBuffer + 16) = ExpectedImportedMaterialSlotName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckPolygonGroupImportedMaterialSlotName, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckPolygonGroupCount(UStaticMesh Mesh, int LodIndex, int ExpectedNumberOfPolygonGroups)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = ExpectedNumberOfPolygonGroups;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckPolygonGroupCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckPolygonCountInPolygonGroup(UStaticMesh Mesh, int LodIndex, int PolygonGroupIndex, int ExpectedNumberOfPolygons)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = PolygonGroupIndex;

				*(int*)(__InBuffer + 16) = ExpectedNumberOfPolygons;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckPolygonCountInPolygonGroup, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckPolygonCount(UStaticMesh Mesh, int LodIndex, int ExpectedNumberOfPolygons)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = ExpectedNumberOfPolygons;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckPolygonCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckNaniteSettings(UStaticMesh Mesh, FMeshNaniteSettings ExpectedNaniteSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExpectedNaniteSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckNaniteSettings, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckMaterialSlotCount(UStaticMesh Mesh, int ExpectedNumberOfMaterialSlots)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfMaterialSlots;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckMaterialSlotCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckLodCount(UStaticMesh Mesh, int ExpectedNumberOfLods)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfLods;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckLodCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckImportedStaticMeshCount(TArray<UStaticMesh> Meshes, int ExpectedNumberOfImportedStaticMeshes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Meshes?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfImportedStaticMeshes;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckImportedStaticMeshCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckImportedMaterialSlotName(UStaticMesh Mesh, int MaterialIndex, FString ExpectedImportedMaterialSlotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = MaterialIndex;

				*(nint*)(__InBuffer + 12) = ExpectedImportedMaterialSlotName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckImportedMaterialSlotName, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckBuildSettings(UStaticMesh Mesh, int LodIndex, FMeshBuildSettings ExpectedBuildSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = ExpectedBuildSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckBuildSettings, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckBoundingBoxSizeLessThan(UStaticMesh Mesh, FVector3f LessThanSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LessThanSize?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckBoundingBoxSizeLessThan, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckBoundingBoxSizeGreaterThan(UStaticMesh Mesh, FVector3f GreaterThanSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GreaterThanSize?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckBoundingBoxSizeGreaterThan, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckBoundingBoxSize(UStaticMesh Mesh, FVector3f ExpectedSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExpectedSize?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckBoundingBoxSize, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckAgainstGroundTruth(UStaticMesh Mesh, TSoftObjectPtr<UStaticMesh> MeshToCompare, bool bCheckVertexCountEqual, bool bCheckTriangleCountEqual, bool bCheckUVChannelCountEqual, bool bCheckCollisionPrimitiveCountEqual, bool bCheckVertexPositionsEqual, bool bCheckNormalsEqual)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MeshToCompare?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bCheckVertexCountEqual;

				*(bool*)(__InBuffer + 17) = bCheckTriangleCountEqual;

				*(bool*)(__InBuffer + 18) = bCheckUVChannelCountEqual;

				*(bool*)(__InBuffer + 19) = bCheckCollisionPrimitiveCountEqual;

				*(bool*)(__InBuffer + 20) = bCheckVertexPositionsEqual;

				*(bool*)(__InBuffer + 21) = bCheckNormalsEqual;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckAgainstGroundTruth, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		private static uint __CheckVertexIndexPosition = 0;

		private static uint __CheckVertexCount = 0;

		private static uint __CheckUVChannelCount = 0;

		private static uint __CheckTriangleCountInPolygonGroup = 0;

		private static uint __CheckTriangleCount = 0;

		private static uint __CheckThatMeshHasQuadsOrNgons = 0;

		private static uint __CheckSocketName = 0;

		private static uint __CheckSocketLocation = 0;

		private static uint __CheckSocketCount = 0;

		private static uint __CheckSimpleCollisionPrimitiveCount = 0;

		private static uint __CheckSectionMaterialName = 0;

		private static uint __CheckSectionMaterialIndex = 0;

		private static uint __CheckSectionImportedMaterialSlotName = 0;

		private static uint __CheckSectionCount = 0;

		private static uint __CheckRenderVertexIndexNormal = 0;

		private static uint __CheckRenderVertexIndexColor = 0;

		private static uint __CheckRenderVertexCount = 0;

		private static uint __CheckRenderUVChannelCount = 0;

		private static uint __CheckRenderTriangleCount = 0;

		private static uint __CheckRenderHasVertexColors = 0;

		private static uint __CheckPolygonGroupImportedMaterialSlotName = 0;

		private static uint __CheckPolygonGroupCount = 0;

		private static uint __CheckPolygonCountInPolygonGroup = 0;

		private static uint __CheckPolygonCount = 0;

		private static uint __CheckNaniteSettings = 0;

		private static uint __CheckMaterialSlotCount = 0;

		private static uint __CheckLodCount = 0;

		private static uint __CheckImportedStaticMeshCount = 0;

		private static uint __CheckImportedMaterialSlotName = 0;

		private static uint __CheckBuildSettings = 0;

		private static uint __CheckBoundingBoxSizeLessThan = 0;

		private static uint __CheckBoundingBoxSizeGreaterThan = 0;

		private static uint __CheckBoundingBoxSize = 0;

		private static uint __CheckAgainstGroundTruth = 0;
	}
}