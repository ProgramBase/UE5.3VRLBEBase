using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EditorScriptingUtilities
{
	[PathName("/Script/EditorScriptingUtilities.EditorSkeletalMeshLibrary")]
	public partial class UDEPRECATED_EditorSkeletalMeshLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorScriptingUtilities.EditorSkeletalMeshLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="SkeletalMesh">
		/// : The skeletalmesh we want to optimize
		/// </param>
		/// <param name="LODIndex">
		/// : The LOD we want to optimize
		/// </param>
		/// <param name="TextureMask">
		/// : The texture containing the stripping mask. non black pixel strip triangle, black pixel keep them.
		/// </param>
		/// <param name="Threshold">
		/// : The threshold we want when comparing the texture value with zero.
		/// </param>
		public static bool StripLODGeometry(USkeletalMesh SkeletalMesh, int LODIndex, UTexture2D TextureMask, float Threshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(nint*)(__InBuffer + 12) = TextureMask?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 20) = Threshold;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __StripLODGeometry, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void SetLodBuildSettings(USkeletalMesh SkeletalMesh, int LodIndex, FSkeletalMeshBuildSettings BuildOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = BuildOptions?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLodBuildSettings, __InBuffer);
			}
		}

		public static bool RenameSocket(USkeletalMesh SkeletalMesh, FName OldName, FName NewName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OldName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RenameSocket, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// The mesh inside which we are renaming a socket
		/// </param>
		/// <param name="ToRemoveLODs">
		/// The LODs we need to remove
		/// </param>
		/// <returns>
		/// true if the successfully remove all the LODs. False otherwise, but evedn if it return false it
		/// will have removed all valid LODs.
		/// </returns>
		public static bool RemoveLODs(USkeletalMesh SkeletalMesh, TArray<int> ToRemoveLODs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ToRemoveLODs?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveLODs, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ReimportAllCustomLODs(USkeletalMesh SkeletalMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ReimportAllCustomLODs, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool RegenerateLOD(USkeletalMesh SkeletalMesh, int NewLODCount = 0, bool bRegenerateEvenIfImported = false, bool bGenerateBaseLOD = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NewLODCount;

				*(bool*)(__InBuffer + 12) = bRegenerateEvenIfImported;

				*(bool*)(__InBuffer + 13) = bGenerateBaseLOD;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RegenerateLOD, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int ImportLOD(USkeletalMesh BaseMesh, int LODIndex, FString SourceFilename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = BaseMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(nint*)(__InBuffer + 12) = SourceFilename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ImportLOD, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetNumVerts(USkeletalMesh SkeletalMesh, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumVerts, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetLODCount(USkeletalMesh SkeletalMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLODCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void GetLodBuildSettings(USkeletalMesh SkeletalMesh, int LodIndex, ref FSkeletalMeshBuildSettings OutBuildOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = OutBuildOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLodBuildSettings, __InBuffer, __OutBuffer);

				OutBuildOptions = *(FSkeletalMeshBuildSettings*)(__OutBuffer);

			}
		}

		/// <param name="SkeletalMesh">
		/// : The SkeletalMesh we want to create the PhysicsAsset for
		/// </param>
		public static UPhysicsAsset CreatePhysicsAsset(USkeletalMesh SkeletalMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreatePhysicsAsset, __InBuffer, __ReturnBuffer);

				return *(UPhysicsAsset*)__ReturnBuffer;
			}
		}

		private static uint __StripLODGeometry = 0;

		private static uint __SetLodBuildSettings = 0;

		private static uint __RenameSocket = 0;

		private static uint __RemoveLODs = 0;

		private static uint __ReimportAllCustomLODs = 0;

		private static uint __RegenerateLOD = 0;

		private static uint __ImportLOD = 0;

		private static uint __GetNumVerts = 0;

		private static uint __GetLODCount = 0;

		private static uint __GetLodBuildSettings = 0;

		private static uint __CreatePhysicsAsset = 0;
	}
}