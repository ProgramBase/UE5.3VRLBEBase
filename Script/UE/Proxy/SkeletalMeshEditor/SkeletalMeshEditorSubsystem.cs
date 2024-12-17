using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.Engine;

namespace Script.SkeletalMeshEditor
{
	[PathName("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem")]
	public partial class USkeletalMeshEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="SkeletalMesh">
		/// Mesh to get number of vertices from.
		/// </param>
		/// <param name="LodIndex">
		/// Index of the mesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the LOD section.
		/// </param>
		/// <param name="bVisibleInRayTracing">
		/// The function will set the bVisibleInRayTracing used by the section
		/// </param>
		/// <returns>
		/// false if invalid mesh or LOD index or section index.
		/// </returns>
		public virtual bool SetSectionVisibleInRayTracing(USkeletalMesh SkeletalMesh, int LODIndex, int SectionIndex, bool bVisibleInRayTracing)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(bool*)(__InBuffer + 16) = bVisibleInRayTracing;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSectionVisibleInRayTracing, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// Mesh to get number of vertices from.
		/// </param>
		/// <param name="LodIndex">
		/// Index of the mesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the LOD section.
		/// </param>
		/// <param name="RecomputeTangentsVertexMaskChannel">
		/// The function will set the RecomputeTangentsVertexMaskChannel used by the section
		/// </param>
		/// <returns>
		/// false if invalid mesh or LOD index or section index.
		/// </returns>
		public virtual bool SetSectionRecomputeTangentsVertexMaskChannel(USkeletalMesh SkeletalMesh, int LODIndex, int SectionIndex, byte RecomputeTangentsVertexMaskChannel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(byte*)(__InBuffer + 16) = RecomputeTangentsVertexMaskChannel;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSectionRecomputeTangentsVertexMaskChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// Mesh to get number of vertices from.
		/// </param>
		/// <param name="LodIndex">
		/// Index of the mesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the LOD section.
		/// </param>
		/// <param name="bRecomputeTangent">
		/// The function will set the bRecomputeTangent used by the section
		/// </param>
		/// <returns>
		/// false if invalid mesh or LOD index or section index.
		/// </returns>
		public virtual bool SetSectionRecomputeTangent(USkeletalMesh SkeletalMesh, int LODIndex, int SectionIndex, bool bRecomputeTangent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(bool*)(__InBuffer + 16) = bRecomputeTangent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSectionRecomputeTangent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// Mesh to get number of vertices from.
		/// </param>
		/// <param name="LodIndex">
		/// Index of the mesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the LOD section.
		/// </param>
		/// <param name="bCastShadow">
		/// The function will set the bCastShadow used by the section
		/// </param>
		/// <returns>
		/// false if invalid mesh or LOD index or section index.
		/// </returns>
		public virtual bool SetSectionCastShadow(USkeletalMesh SkeletalMesh, int LODIndex, int SectionIndex, bool bCastShadow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(bool*)(__InBuffer + 16) = bCastShadow;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSectionCastShadow, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// - Mesh to process.
		/// </param>
		/// <param name="LodIndex">
		/// - The LOD we will apply the build settings.
		/// </param>
		/// <param name="BuildOptions">
		/// - The build settings we want to apply to the LOD.
		/// </param>
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

		/// <param name="SkeletalMesh">
		/// The mesh inside which we are renaming a socket
		/// </param>
		/// <param name="OldName">
		/// The old name of the socket
		/// </param>
		/// <param name="NewName">
		/// The new name of the socket
		/// </param>
		/// <returns>
		/// true if the renaming succeeded.
		/// </returns>
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
		/// : is the skeletal mesh we import or re-import a LOD.
		/// </param>
		/// <returns>
		/// true if re-import works, false otherwise see log for explanation.
		/// </returns>
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

		/// <param name="SkeletalMesh">
		/// The mesh that will regenerate LOD
		/// </param>
		/// <param name="NewLODCount">
		/// Set valid value (>0) if you want to change LOD count.
		/// Otherwise, it will use the current LOD and regenerate
		/// </param>
		/// <param name="bRegenerateEvenIfImported">
		/// If this is true, it only regenerate even if this LOD was imported before
		/// If false, it will regenerate for only previously auto generated ones
		/// </param>
		/// <param name="bGenerateBaseLOD">
		/// If this is true and there is some reduction data, the base LOD will be reduce according to the settings
		/// </param>
		/// <returns>
		/// true if succeed. If mesh reduction is not available this will return false.
		/// </returns>
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

		/// <param name="BaseSkeletalMesh">
		/// : The static mesh we import or re-import a LOD.
		/// </param>
		/// <param name="LODIndex">
		/// : The index of the LOD to import or re-import. Valid value should be between 0 and the base skeletal mesh LOD number. Invalid value will return INDEX_NONE
		/// </param>
		/// <param name="SourceFilename">
		/// : The fbx source filename. If we are re-importing an existing LOD, it can be empty in this case it will use the last import file. Otherwise it must be an existing fbx file.
		/// </param>
		/// <returns>
		/// The index of the LOD that was imported or re-imported. Will return INDEX_NONE if anything goes bad.
		/// </returns>
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

		/// <param name="SkeletalMesh">
		/// Mesh to get number of vertices from.
		/// </param>
		/// <param name="LodIndex">
		/// Index of the mesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the LOD section.
		/// </param>
		/// <param name="bOutVisibleInRayTracing">
		/// The function will set the bVisibleInRayTracing used by the section
		/// </param>
		/// <returns>
		/// false if invalid mesh or LOD index or section index.
		/// </returns>
		public virtual bool GetSectionVisibleInRayTracing(USkeletalMesh SkeletalMesh, int LODIndex, int SectionIndex, ref bool bOutVisibleInRayTracing)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(bool*)(__InBuffer + 16) = bOutVisibleInRayTracing;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetSectionVisibleInRayTracing, __InBuffer, __OutBuffer, __ReturnBuffer);

				bOutVisibleInRayTracing = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// Mesh to get number of vertices from.
		/// </param>
		/// <param name="LodIndex">
		/// Index of the mesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the LOD section.
		/// </param>
		/// <param name="OutRecomputeTangentsVertexMaskChannel">
		/// The function will set the RecomputeTangentsVertexMaskChannel used by the section
		/// </param>
		/// <returns>
		/// false if invalid mesh or LOD index or section index.
		/// </returns>
		public virtual bool GetSectionRecomputeTangentsVertexMaskChannel(USkeletalMesh SkeletalMesh, int LODIndex, int SectionIndex, ref byte OutRecomputeTangentsVertexMaskChannel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(byte*)(__InBuffer + 16) = OutRecomputeTangentsVertexMaskChannel;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetSectionRecomputeTangentsVertexMaskChannel, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutRecomputeTangentsVertexMaskChannel = *(byte*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// Mesh to get number of vertices from.
		/// </param>
		/// <param name="LodIndex">
		/// Index of the mesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the LOD section.
		/// </param>
		/// <param name="bOutRecomputeTangent">
		/// The function will set the bRecomputeTangent used by the section
		/// </param>
		/// <returns>
		/// false if invalid mesh or LOD index or section index.
		/// </returns>
		public virtual bool GetSectionRecomputeTangent(USkeletalMesh SkeletalMesh, int LODIndex, int SectionIndex, ref bool bOutRecomputeTangent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(bool*)(__InBuffer + 16) = bOutRecomputeTangent;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetSectionRecomputeTangent, __InBuffer, __OutBuffer, __ReturnBuffer);

				bOutRecomputeTangent = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// Mesh to get number of vertices from.
		/// </param>
		/// <param name="LodIndex">
		/// Index of the mesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the LOD section.
		/// </param>
		/// <param name="bOutCastShadow">
		/// The function will set the bCastShadow used by the section
		/// </param>
		/// <returns>
		/// false if invalid mesh or LOD index or section index.
		/// </returns>
		public virtual bool GetSectionCastShadow(USkeletalMesh SkeletalMesh, int LODIndex, int SectionIndex, ref bool bOutCastShadow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				*(bool*)(__InBuffer + 16) = bOutCastShadow;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetSectionCastShadow, __InBuffer, __OutBuffer, __ReturnBuffer);

				bOutCastShadow = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// Mesh to get number of vertices from.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the mesh LOD.
		/// </param>
		/// <returns>
		/// Number of vertices. Returns 0 if invalid mesh or LOD index.
		/// </returns>
		public virtual int GetNumVerts(USkeletalMesh SkeletalMesh, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumVerts, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// Mesh to get number of vertices from.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the mesh LOD.
		/// </param>
		/// <returns>
		/// Number of sections. Returns INDEX_NONE if invalid mesh or LOD index.
		/// </returns>
		public virtual int GetNumSections(USkeletalMesh SkeletalMesh, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumSections, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// SkeletalMesh to get the material index from.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the StaticMesh Section.
		/// </param>
		/// <returns>
		/// MaterialSlotIndex	Index of the material slot used by the section or INDEX_NONE in case of error.
		/// </returns>
		public virtual int GetLODMaterialSlot(USkeletalMesh SkeletalMesh, int LODIndex, int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetLODMaterialSlot, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="SkeletalMesh">
		/// : The static mesh we import or re-import a LOD.
		/// </param>
		/// <returns>
		/// The LOD number.
		/// </returns>
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

		/// <param name="SkeletalMesh">
		/// - Mesh to process.
		/// </param>
		/// <param name="LodIndex">
		/// - The LOD we get the reduction settings.
		/// </param>
		/// <param name="OutBuildOptions">
		/// - The build settings where we copy the build options.
		/// </param>
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

		private static uint __SetSectionVisibleInRayTracing = 0;

		private static uint __SetSectionRecomputeTangentsVertexMaskChannel = 0;

		private static uint __SetSectionRecomputeTangent = 0;

		private static uint __SetSectionCastShadow = 0;

		private static uint __SetLodBuildSettings = 0;

		private static uint __RenameSocket = 0;

		private static uint __ReimportAllCustomLODs = 0;

		private static uint __RegenerateLOD = 0;

		private static uint __ImportLOD = 0;

		private static uint __GetSectionVisibleInRayTracing = 0;

		private static uint __GetSectionRecomputeTangentsVertexMaskChannel = 0;

		private static uint __GetSectionRecomputeTangent = 0;

		private static uint __GetSectionCastShadow = 0;

		private static uint __GetNumVerts = 0;

		private static uint __GetNumSections = 0;

		private static uint __GetLODMaterialSlot = 0;

		private static uint __GetLODCount = 0;

		private static uint __GetLodBuildSettings = 0;

		private static uint __CreatePhysicsAsset = 0;
	}
}