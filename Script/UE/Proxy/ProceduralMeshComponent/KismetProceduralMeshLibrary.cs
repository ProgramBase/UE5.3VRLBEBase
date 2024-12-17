using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ProceduralMeshComponent
{
	[PathName("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary")]
	public partial class UKismetProceduralMeshLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ProceduralMeshComponent.KismetProceduralMeshLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InProcMesh">
		/// ProceduralMeshComponent to slice
		/// </param>
		/// <param name="PlanePosition">
		/// Point on the plane to use for slicing, in world space
		/// </param>
		/// <param name="PlaneNormal">
		/// Normal of plane used for slicing. Geometry on the positive side of the plane will be kept.
		/// </param>
		/// <param name="bCreateOtherHalf">
		/// If true, an additional ProceduralMeshComponent (OutOtherHalfProcMesh) will be created using the other half of the sliced geometry
		/// </param>
		/// <param name="OutOtherHalfProcMesh">
		/// If bCreateOtherHalf is set, this is the new component created. Its owner will be the same as the supplied InProcMesh.
		/// </param>
		/// <param name="CapOption">
		/// If and how to create 'cap' geometry on the slicing plane
		/// </param>
		/// <param name="CapMaterial">
		/// If creating a new section for the cap, assign this material to that section
		/// </param>
		public static void SliceProceduralMesh(UProceduralMeshComponent InProcMesh, FVector PlanePosition, FVector PlaneNormal, bool bCreateOtherHalf, ref UProceduralMeshComponent OutOtherHalfProcMesh, EProcMeshSliceCapOption CapOption, UMaterialInterface CapMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = InProcMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlanePosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PlaneNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bCreateOtherHalf;

				*(nint*)(__InBuffer + 25) = OutOtherHalfProcMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 33) = (byte)CapOption;

				*(nint*)(__InBuffer + 34) = CapMaterial?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SliceProceduralMesh, __InBuffer, __OutBuffer);

				OutOtherHalfProcMesh = *(UProceduralMeshComponent*)(__OutBuffer);

			}
		}

		public static void GetSectionFromStaticMesh(UStaticMesh InMesh, int LODIndex, int SectionIndex, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UVs, ref TArray<FProcMeshTangent> Tangents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[56];

				*(nint*)(__InBuffer) = InMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(nint*)(__InBuffer + 16) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Normals?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = UVs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = Tangents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[40];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetSectionFromStaticMesh, __InBuffer, __OutBuffer);

				Vertices = *(TArray<FVector>*)(__OutBuffer);

				Triangles = *(TArray<int>*)(__OutBuffer + 8);

				Normals = *(TArray<FVector>*)(__OutBuffer + 16);

				UVs = *(TArray<FVector2D>*)(__OutBuffer + 24);

				Tangents = *(TArray<FProcMeshTangent>*)(__OutBuffer + 32);

			}
		}

		public static void GetSectionFromProceduralMesh(UProceduralMeshComponent InProcMesh, int SectionIndex, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UVs, ref TArray<FProcMeshTangent> Tangents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = InProcMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = SectionIndex;

				*(nint*)(__InBuffer + 12) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = Normals?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = UVs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = Tangents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[40];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetSectionFromProceduralMesh, __InBuffer, __OutBuffer);

				Vertices = *(TArray<FVector>*)(__OutBuffer);

				Triangles = *(TArray<int>*)(__OutBuffer + 8);

				Normals = *(TArray<FVector>*)(__OutBuffer + 16);

				UVs = *(TArray<FVector2D>*)(__OutBuffer + 24);

				Tangents = *(TArray<FProcMeshTangent>*)(__OutBuffer + 32);

			}
		}

		public static void GenerateBoxMesh(FVector BoxRadius, ref TArray<FVector> Vertices, ref TArray<int> Triangles, ref TArray<FVector> Normals, ref TArray<FVector2D> UVs, ref TArray<FProcMeshTangent> Tangents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = BoxRadius?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Normals?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = UVs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = Tangents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[40];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GenerateBoxMesh, __InBuffer, __OutBuffer);

				Vertices = *(TArray<FVector>*)(__OutBuffer);

				Triangles = *(TArray<int>*)(__OutBuffer + 8);

				Normals = *(TArray<FVector>*)(__OutBuffer + 16);

				UVs = *(TArray<FVector2D>*)(__OutBuffer + 24);

				Tangents = *(TArray<FProcMeshTangent>*)(__OutBuffer + 32);

			}
		}

		/// <param name="NumX">
		/// Number of vertices in X direction (must be >= 2)
		/// </param>
		/// <param name="NumY">
		/// Number of vertices in y direction (must be >= 2)
		/// </param>
		/// <out>
		/// Triangles		Output index buffer
		/// </out>
		/// <out>
		/// Vertices		Output vertex buffer
		/// </out>
		/// <out>
		/// UVs				Out UVs
		/// </out>
		/// <param name="GridSpacing">
		/// Size of each quad in world units
		/// </param>
		public static void CreateGridMeshWelded(int NumX, int NumY, ref TArray<int> Triangles, ref TArray<FVector> Vertices, ref TArray<FVector2D> UVs, float GridSpacing)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(int*)(__InBuffer) = NumX;

				*(int*)(__InBuffer + 4) = NumY;

				*(nint*)(__InBuffer + 8) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = UVs?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = GridSpacing;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __CreateGridMeshWelded, __InBuffer, __OutBuffer);

				Triangles = *(TArray<int>*)(__OutBuffer);

				Vertices = *(TArray<FVector>*)(__OutBuffer + 8);

				UVs = *(TArray<FVector2D>*)(__OutBuffer + 16);

			}
		}

		/// <param name="NumX">
		/// Number of vertices in X direction (must be >= 2)
		/// </param>
		/// <param name="NumY">
		/// Number of vertices in y direction (must be >= 2)
		/// </param>
		/// <param name="bWinding">
		/// Reverses winding of indices generated for each quad
		/// </param>
		/// <out>
		/// Triangles		Output index buffer
		/// </out>
		public static void CreateGridMeshTriangles(int NumX, int NumY, bool bWinding, ref TArray<int> Triangles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(int*)(__InBuffer) = NumX;

				*(int*)(__InBuffer + 4) = NumY;

				*(bool*)(__InBuffer + 8) = bWinding;

				*(nint*)(__InBuffer + 9) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __CreateGridMeshTriangles, __InBuffer, __OutBuffer);

				Triangles = *(TArray<int>*)(__OutBuffer);

			}
		}

		/// <param name="NumX">
		/// Number of vertices in X direction (must be >= 2)
		/// </param>
		/// <param name="NumY">
		/// Number of vertices in y direction (must be >= 2)
		/// </param>
		/// <out>
		/// Triangles		Output index buffer
		/// </out>
		/// <out>
		/// Vertices		Output vertex buffer
		/// </out>
		/// <out>
		/// UVs				Out UVs
		/// </out>
		/// <out>
		/// UV1s			Out UV1s
		/// </out>
		/// <param name="GridSpacing">
		/// Size of each quad in world units
		/// </param>
		public static void CreateGridMeshSplit(int NumX, int NumY, ref TArray<int> Triangles, ref TArray<FVector> Vertices, ref TArray<FVector2D> UVs, ref TArray<FVector2D> UV1s, float GridSpacing)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(int*)(__InBuffer) = NumX;

				*(int*)(__InBuffer + 4) = NumY;

				*(nint*)(__InBuffer + 8) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = UVs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = UV1s?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = GridSpacing;

				var __OutBuffer = stackalloc byte[32];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __CreateGridMeshSplit, __InBuffer, __OutBuffer);

				Triangles = *(TArray<int>*)(__OutBuffer);

				Vertices = *(TArray<FVector>*)(__OutBuffer + 8);

				UVs = *(TArray<FVector2D>*)(__OutBuffer + 16);

				UV1s = *(TArray<FVector2D>*)(__OutBuffer + 24);

			}
		}

		public static void CopyProceduralMeshFromStaticMeshComponent(UStaticMeshComponent StaticMeshComponent, int LODIndex, UProceduralMeshComponent ProcMeshComponent, bool bCreateCollision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = StaticMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(nint*)(__InBuffer + 12) = ProcMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 20) = bCreateCollision;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __CopyProceduralMeshFromStaticMeshComponent, __InBuffer);
			}
		}

		public static void ConvertQuadToTriangles(ref TArray<int> Triangles, int Vert0, int Vert1, int Vert2, int Vert3)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Vert0;

				*(int*)(__InBuffer + 12) = Vert1;

				*(int*)(__InBuffer + 16) = Vert2;

				*(int*)(__InBuffer + 20) = Vert3;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ConvertQuadToTriangles, __InBuffer, __OutBuffer);

				Triangles = *(TArray<int>*)(__OutBuffer);

			}
		}

		public static void CalculateTangentsForMesh(TArray<FVector> Vertices, TArray<int> Triangles, TArray<FVector2D> UVs, ref TArray<FVector> Normals, ref TArray<FProcMeshTangent> Tangents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = UVs?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Normals?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Tangents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __CalculateTangentsForMesh, __InBuffer, __OutBuffer);

				Normals = *(TArray<FVector>*)(__OutBuffer);

				Tangents = *(TArray<FProcMeshTangent>*)(__OutBuffer + 8);

			}
		}

		private static uint __SliceProceduralMesh = 0;

		private static uint __GetSectionFromStaticMesh = 0;

		private static uint __GetSectionFromProceduralMesh = 0;

		private static uint __GenerateBoxMesh = 0;

		private static uint __CreateGridMeshWelded = 0;

		private static uint __CreateGridMeshTriangles = 0;

		private static uint __CreateGridMeshSplit = 0;

		private static uint __CopyProceduralMeshFromStaticMeshComponent = 0;

		private static uint __ConvertQuadToTriangles = 0;

		private static uint __CalculateTangentsForMesh = 0;
	}
}