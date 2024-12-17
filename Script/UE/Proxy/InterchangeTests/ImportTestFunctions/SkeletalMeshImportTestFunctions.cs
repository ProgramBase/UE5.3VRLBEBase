using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.SkeletalMeshImportTestFunctions")]
	public partial class USkeletalMeshImportTestFunctions : UImportTestFunctionsBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.SkeletalMeshImportTestFunctions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FInterchangeTestFunctionResult CheckVertexIndexPosition(USkeletalMesh Mesh, int LodIndex, int VertexIndex, FVector ExpectedVertexPosition)
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

		public static FInterchangeTestFunctionResult CheckVertexIndexNormal(USkeletalMesh Mesh, int LodIndex, int VertexIndex, FVector ExpectedVertexNormal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = VertexIndex;

				*(nint*)(__InBuffer + 16) = ExpectedVertexNormal?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckVertexIndexNormal, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckUVChannelCount(USkeletalMesh Mesh, int LodIndex, int ExpectedNumberOfUVChannels)
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

		public static FInterchangeTestFunctionResult CheckTriangleCountInSection(USkeletalMesh Mesh, int LodIndex, int SectionIndex, int ExpectedNumberOfTriangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(int*)(__InBuffer + 16) = ExpectedNumberOfTriangles;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckTriangleCountInSection, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSkinnedVertexCountForBone(USkeletalMesh Mesh, FString BoneName, bool bTestFirstAlternateProfile, int ExpectedSkinnedVertexCount)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bTestFirstAlternateProfile;

				*(int*)(__InBuffer + 17) = ExpectedSkinnedVertexCount;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckSkinnedVertexCountForBone, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckSectionMaterialName(USkeletalMesh Mesh, int LodIndex, int SectionIndex, FString ExpectedMaterialName)
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

		public static FInterchangeTestFunctionResult CheckSectionImportedMaterialSlotName(USkeletalMesh Mesh, int LodIndex, int SectionIndex, FString ExpectedImportedMaterialSlotName)
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

		public static FInterchangeTestFunctionResult CheckSectionCount(USkeletalMesh Mesh, int LodIndex, int ExpectedNumberOfSections)
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

		public static FInterchangeTestFunctionResult CheckRenderVertexCount(USkeletalMesh Mesh, int LodIndex, int ExpectedNumberOfRenderVertices)
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

		public static FInterchangeTestFunctionResult CheckRenderTriangleCount(USkeletalMesh Mesh, int LodIndex, int ExpectedNumberOfRenderTriangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(int*)(__InBuffer + 12) = ExpectedNumberOfRenderTriangles;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckRenderTriangleCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckMaterialSlotCount(USkeletalMesh Mesh, int ExpectedNumberOfMaterialSlots)
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

		public static FInterchangeTestFunctionResult CheckLodCount(USkeletalMesh Mesh, int ExpectedNumberOfLods)
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

		public static FInterchangeTestFunctionResult CheckImportedSkeletalMeshCount(TArray<USkeletalMesh> Meshes, int ExpectedNumberOfImportedSkeletalMeshes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Meshes?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfImportedSkeletalMeshes;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckImportedSkeletalMeshCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckBonePosition(USkeletalMesh Mesh, int BoneIndex, FVector ExpectedBonePosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = BoneIndex;

				*(nint*)(__InBuffer + 12) = ExpectedBonePosition?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckBonePosition, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckBoneCount(USkeletalMesh Mesh, int ExpectedNumberOfBones)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfBones;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckBoneCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		private static uint __CheckVertexIndexPosition = 0;

		private static uint __CheckVertexIndexNormal = 0;

		private static uint __CheckUVChannelCount = 0;

		private static uint __CheckTriangleCountInSection = 0;

		private static uint __CheckSkinnedVertexCountForBone = 0;

		private static uint __CheckSectionMaterialName = 0;

		private static uint __CheckSectionImportedMaterialSlotName = 0;

		private static uint __CheckSectionCount = 0;

		private static uint __CheckRenderVertexCount = 0;

		private static uint __CheckRenderTriangleCount = 0;

		private static uint __CheckMaterialSlotCount = 0;

		private static uint __CheckLodCount = 0;

		private static uint __CheckImportedSkeletalMeshCount = 0;

		private static uint __CheckBonePosition = 0;

		private static uint __CheckBoneCount = 0;
	}
}