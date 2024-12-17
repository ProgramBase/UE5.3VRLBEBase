using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.Engine;
using Script.PhysicsCore;

namespace Script.StaticMeshEditor
{
	[PathName("/Script/StaticMeshEditor.StaticMeshEditorSubsystem")]
	public partial class UStaticMeshEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StaticMeshEditor.StaticMeshEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="StaticMesh">
		/// Mesh to update nanite settings for
		/// </param>
		/// <param name="NaniteSettings">
		/// Settings with which to update the mesh
		/// </param>
		/// <param name="bApplyChanges">
		/// Indicates if changes must be applied or not.
		/// </param>
		public virtual void SetNaniteSettings(UStaticMesh StaticMesh, FMeshNaniteSettings NaniteSettings, bool bApplyChanges = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NaniteSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bApplyChanges;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNaniteSettings, __InBuffer);
			}
		}

		/// <param name="StaticMesh">
		/// Mesh to process.
		/// </param>
		/// <param name="ReductionOptions">
		/// Options on how to generate LODs on the mesh.
		/// </param>
		/// <param name="bApplyChanges">
		/// Indicates if change must be notified.
		/// </param>
		/// <returns>
		/// the number of LODs generated on the input mesh.
		/// An negative value indicates that the reduction could not be performed. See log for explanation.
		/// No action will be performed if ReductionOptions.ReductionSettings is empty
		/// </returns>
		public virtual int SetLodsWithNotification(UStaticMesh StaticMesh, FStaticMeshReductionOptions ReductionOptions, bool bApplyChanges)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReductionOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bApplyChanges;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLodsWithNotification, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Mesh to process.
		/// </param>
		/// <param name="ScreenSizes">
		/// Array of LOD screen sizes to set.
		/// </param>
		/// <returns>
		/// A boolean indicating if setting the screen sizes was successful.
		/// </returns>
		public virtual bool SetLodScreenSizes(UStaticMesh StaticMesh, TArray<float> ScreenSizes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ScreenSizes?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLodScreenSizes, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int SetLods(UStaticMesh StaticMesh, FStaticMeshReductionOptions ReductionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReductionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLods, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// - Mesh to process.
		/// </param>
		/// <param name="LodIndex">
		/// - The LOD we will apply the reduction settings.
		/// </param>
		/// <param name="ReductionOptions">
		/// - The reduction settings we want to apply to the LOD.
		/// </param>
		public virtual void SetLodReductionSettings(UStaticMesh StaticMesh, int LodIndex, FMeshReductionSettings ReductionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = ReductionOptions?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLodReductionSettings, __InBuffer);
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh to Enables/disables shadow casting from.
		/// </param>
		/// <param name="MaterialSlotIndex">
		/// Index of the material slot to use.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the StaticMesh Section.
		/// </param>
		public virtual void SetLODMaterialSlot(UStaticMesh StaticMesh, int MaterialSlotIndex, int LODIndex, int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = MaterialSlotIndex;

				*(int*)(__InBuffer + 12) = LODIndex;

				*(int*)(__InBuffer + 16) = SectionIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLODMaterialSlot, __InBuffer);
			}
		}

		/// <param name="StaticMesh">
		/// - Mesh to process.
		/// </param>
		/// <param name="LODGroup">
		/// - Name of the LODGroup to apply
		/// </param>
		/// <param name="bRebuildImmediately">
		/// - If true, rebuild the static mesh immediately
		/// </param>
		/// <returns>
		/// Success
		/// </returns>
		public virtual bool SetLODGroup(UStaticMesh StaticMesh, FName LODGroup, bool bRebuildImmediately = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LODGroup?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bRebuildImmediately;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLODGroup, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DestinationStaticMesh">
		/// The static mesh to set the LOD in.
		/// </param>
		/// <param name="DestinationLodIndex">
		/// The index of the LOD to set.
		/// </param>
		/// <param name="SourceStaticMesh">
		/// The static mesh to get the LOD from.
		/// </param>
		/// <param name="SourceLodIndex">
		/// The index of the LOD to get.
		/// </param>
		/// <param name="bReuseExistingMaterialSlots">
		/// If true, sections from SourceStaticMesh will be remapped to match the material slots of DestinationStaticMesh
		/// when they have the same material assigned. If false, all material slots of SourceStaticMesh will be appended in DestinationStaticMesh.
		/// </param>
		/// <returns>
		/// The index of the LOD that was set. It can be different than DestinationLodIndex if it wasn't a valid index.
		/// A negative value indicates that the LOD was not set. See log for explanation.
		/// </returns>
		public virtual int SetLodFromStaticMesh(UStaticMesh DestinationStaticMesh, int DestinationLodIndex, UStaticMesh SourceStaticMesh, int SourceLodIndex, bool bReuseExistingMaterialSlots)
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

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLodFromStaticMesh, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// - Mesh to process.
		/// </param>
		/// <param name="LodIndex">
		/// - The LOD we will apply the build settings.
		/// </param>
		/// <param name="BuildOptions">
		/// - The build settings we want to apply to the LOD.
		/// </param>
		public virtual void SetLodBuildSettings(UStaticMesh StaticMesh, int LodIndex, FMeshBuildSettings BuildOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = BuildOptions?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLodBuildSettings, __InBuffer);
			}
		}

		public virtual bool SetGenerateLightmapUVs(UStaticMesh StaticMesh, bool bGenerateLightmapUVs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bGenerateLightmapUVs;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetGenerateLightmapUVs, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh to add convex collision on.
		/// </param>
		/// <param name="HullCount">
		/// Maximum number of convex pieces that will be created. Must be positive.
		/// </param>
		/// <param name="MaxHullVerts">
		/// Maximum number of vertices allowed for any generated convex hull.
		/// </param>
		/// <param name="HullPrecision">
		/// Number of voxels to use when generating collision. Must be positive.
		/// </param>
		/// <param name="bApplyChanges">
		/// Indicates if changes must be apply or not.
		/// </param>
		/// <returns>
		/// A boolean indicating if the addition was successful or not.
		/// </returns>
		public virtual bool SetConvexDecompositionCollisionsWithNotification(UStaticMesh StaticMesh, int HullCount, int MaxHullVerts, int HullPrecision, bool bApplyChanges)
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

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetConvexDecompositionCollisionsWithNotification, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetConvexDecompositionCollisions(UStaticMesh StaticMesh, int HullCount, int MaxHullVerts, int HullPrecision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = HullCount;

				*(int*)(__InBuffer + 12) = MaxHullVerts;

				*(int*)(__InBuffer + 16) = HullPrecision;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetConvexDecompositionCollisions, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetAllowCPUAccess(UStaticMesh StaticMesh, bool bAllowCPUAccess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAllowCPUAccess;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllowCPUAccess, __InBuffer);
			}
		}

		/// <param name="Actors">
		/// List of Actors to search from.
		/// </param>
		/// <param name="MeshToBeReplaced">
		/// Mesh we want to replace.
		/// </param>
		/// <param name="NewMesh">
		/// Mesh to replace MeshToBeReplaced by.
		/// </param>
		public virtual void ReplaceMeshComponentsMeshesOnActors(TArray<AActor> Actors, UStaticMesh MeshToBeReplaced, UStaticMesh NewMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MeshToBeReplaced?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReplaceMeshComponentsMeshesOnActors, __InBuffer);
			}
		}

		/// <param name="MeshComponents">
		/// List of MeshComponent to search from.
		/// </param>
		/// <param name="MeshToBeReplaced">
		/// Mesh we want to replace.
		/// </param>
		/// <param name="NewMesh">
		/// Mesh to replace MeshToBeReplaced by.
		/// </param>
		public virtual void ReplaceMeshComponentsMeshes(TArray<UStaticMeshComponent> MeshComponents, UStaticMesh MeshToBeReplaced, UStaticMesh NewMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MeshComponents?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MeshToBeReplaced?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReplaceMeshComponentsMeshes, __InBuffer);
			}
		}

		/// <param name="Actors">
		/// List of Actors to search from.
		/// </param>
		/// <param name="MaterialToBeReplaced">
		/// Material we want to replace.
		/// </param>
		/// <param name="NewMaterial">
		/// Material to replace MaterialToBeReplaced by.
		/// </param>
		public virtual void ReplaceMeshComponentsMaterialsOnActors(TArray<AActor> Actors, UMaterialInterface MaterialToBeReplaced, UMaterialInterface NewMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MaterialToBeReplaced?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReplaceMeshComponentsMaterialsOnActors, __InBuffer);
			}
		}

		/// <param name="MeshComponents">
		/// List of MeshComponent to search from.
		/// </param>
		/// <param name="MaterialToBeReplaced">
		/// Material we want to replace.
		/// </param>
		/// <param name="NewMaterial">
		/// Material to replace MaterialToBeReplaced by.
		/// </param>
		public virtual void ReplaceMeshComponentsMaterials(TArray<UMeshComponent> MeshComponents, UMaterialInterface MaterialToBeReplaced, UMaterialInterface NewMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = MeshComponents?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MaterialToBeReplaced?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReplaceMeshComponentsMaterials, __InBuffer);
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh on which to remove the UV channel.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <param name="UVChannelIndex">
		/// Index where to remove the UV channel.
		/// </param>
		/// <returns>
		/// true if the UV channel was removed.
		/// </returns>
		public virtual bool RemoveUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = UVChannelIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Mesh to remove LOD from.
		/// </param>
		/// <returns>
		/// A boolean indicating if the removal was successful, true, or not.
		/// </returns>
		public virtual bool RemoveLods(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveLods, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh to remove collisions from.
		/// </param>
		/// <param name="bApplyChanges">
		/// Indicates if changes must be apply or not.
		/// </param>
		/// <returns>
		/// A boolean indicating if the removal was successful or not.
		/// </returns>
		public virtual bool RemoveCollisionsWithNotification(UStaticMesh StaticMesh, bool bApplyChanges)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bApplyChanges;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveCollisionsWithNotification, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveCollisions(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveCollisions, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// : is the static mesh we import or re-import all LODs.
		/// </param>
		/// <returns>
		/// true if re-import all LODs works, false otherwise see log for explanation.
		/// </returns>
		public virtual bool ReimportAllCustomLODs(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ReimportAllCustomLODs, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ActorsToMerge">
		/// List of Actors to merge.
		/// </param>
		/// <param name="MergeOptions">
		/// Options on how to merge the actors.
		/// </param>
		/// <param name="OutMergedActor">
		/// The new created actor, if requested.
		/// </param>
		/// <returns>
		/// if the operation is successful.
		/// </returns>
		public virtual bool MergeStaticMeshActors(TArray<AStaticMeshActor> ActorsToMerge, FMergeStaticMeshActorsOptions MergeOptions, ref AStaticMeshActor OutMergedActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ActorsToMerge?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MergeOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutMergedActor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __MergeStaticMeshActors, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutMergedActor = *(AStaticMeshActor*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ActorsToJoin">
		/// List of Actors to join.
		/// </param>
		/// <param name="JoinOptions">
		/// Options on how to join the actors.
		/// </param>
		/// <returns>
		/// The new created actor.
		/// </returns>
		public virtual AActor JoinStaticMeshActors(TArray<AStaticMeshActor> ActorsToJoin, FJoinStaticMeshActorsOptions JoinOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ActorsToJoin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = JoinOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __JoinStaticMeshActors, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh to remove collisions from.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the StaticMesh Section.
		/// </param>
		/// <returns>
		/// True if the collision is enabled for the specified LOD of the StaticMesh section.
		/// </returns>
		public virtual bool IsSectionCollisionEnabled(UStaticMesh StaticMesh, int LODIndex, int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsSectionCollisionEnabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh on which to insert a UV channel.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <param name="UVChannelIndex">
		/// Index where to insert the UV channel.
		/// </param>
		/// <returns>
		/// true if a UV channel was added.
		/// </returns>
		public virtual bool InsertUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = UVChannelIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __InsertUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BaseStaticMesh">
		/// : The static mesh we import or re-import a LOD.
		/// </param>
		/// <param name="LODIndex">
		/// : The index of the LOD to import or re-import. Valid value should be between 0 and the base static mesh LOD number. Invalid value will return INDEX_NONE
		/// </param>
		/// <param name="SourceFilename">
		/// : The fbx source filename. If we are re-importing an existing LOD, it can be empty in this case it will use the last import file. Otherwise it must be an existing fbx file.
		/// </param>
		/// <returns>
		/// the index of the LOD that was imported or re-imported. Will return INDEX_NONE if anything goes bad.
		/// </returns>
		public virtual int ImportLOD(UStaticMesh BaseStaticMesh, int LODIndex, FString SourceFilename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = BaseStaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(nint*)(__InBuffer + 12) = SourceFilename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ImportLOD, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual bool HasVertexColors(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasVertexColors, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasInstanceVertexColors(UStaticMeshComponent StaticMeshComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMeshComponent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasInstanceVertexColors, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Mesh to query on.
		/// </param>
		/// <returns>
		/// An integer representing the number of simple collisions on the input static mesh.
		/// An negative value indicates that the command could not be executed. See log for explanation.
		/// </returns>
		public virtual int GetSimpleCollisionCount(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetSimpleCollisionCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh to query.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <returns>
		/// the number of UV channels.
		/// </returns>
		public virtual int GetNumUVChannels(UStaticMesh StaticMesh, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumUVChannels, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumberVerts(UStaticMesh StaticMesh, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumberVerts, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumberMaterials(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumberMaterials, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Mesh to access
		/// </param>
		/// <returns>
		/// FMeshNaniteSettings struct for the given static mesh
		/// </returns>
		public virtual FMeshNaniteSettings GetNaniteSettings(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNaniteSettings, __InBuffer, __ReturnBuffer);

				return *(FMeshNaniteSettings*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Mesh to process.
		/// </param>
		/// <returns>
		/// array of LOD screen sizes.
		/// </returns>
		public virtual TArray<float> GetLodScreenSizes(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLodScreenSizes, __InBuffer, __ReturnBuffer);

				return *(TArray<float>*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// - Mesh to process.
		/// </param>
		/// <param name="LodIndex">
		/// - The LOD we get the reduction settings.
		/// </param>
		/// <param name="OutReductionOptions">
		/// - The reduction settings where we copy the reduction options.
		/// </param>
		public virtual void GetLodReductionSettings(UStaticMesh StaticMesh, int LodIndex, ref FMeshReductionSettings OutReductionOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = OutReductionOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetLodReductionSettings, __InBuffer, __OutBuffer);

				OutReductionOptions = *(FMeshReductionSettings*)(__OutBuffer);

			}
		}

		/// <param name="StaticMesh">
		/// Static mesh to get the material index from.
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
		public virtual int GetLODMaterialSlot(UStaticMesh StaticMesh, int LODIndex, int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				*(int*)(__InBuffer + 12) = SectionIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetLODMaterialSlot, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// </param>
		/// <returns>
		/// LODGroup
		/// </returns>
		public virtual FName GetLODGroup(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLODGroup, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Mesh to process.
		/// </param>
		/// <returns>
		/// the number of LODs present on the input mesh.
		/// An negative value indicates that the command could not be executed. See log for explanation.
		/// </returns>
		public virtual int GetLodCount(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetLodCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// - Mesh to process.
		/// </param>
		/// <param name="LodIndex">
		/// - The LOD we get the reduction settings.
		/// </param>
		/// <param name="OutBuildOptions">
		/// - The build settings where we copy the build options.
		/// </param>
		public virtual void GetLodBuildSettings(UStaticMesh StaticMesh, int LodIndex, ref FMeshBuildSettings OutBuildOptions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LodIndex;

				*(nint*)(__InBuffer + 12) = OutBuildOptions?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetLodBuildSettings, __InBuffer, __OutBuffer);

				OutBuildOptions = *(FMeshBuildSettings*)(__OutBuffer);

			}
		}

		/// <param name="StaticMesh">
		/// Mesh to query on.
		/// </param>
		/// <returns>
		/// An integer representing the number of convex collisions on the input static mesh.
		/// An negative value indicates that the command could not be executed. See log for explanation.
		/// </returns>
		public virtual int GetConvexCollisionCount(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetConvexCollisionCount, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Mesh to query on.
		/// </param>
		/// <returns>
		/// the Collision Trace behavior.
		/// </returns>
		public virtual ECollisionTraceFlag GetCollisionComplexity(UStaticMesh StaticMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetCollisionComplexity, __InBuffer, __ReturnBuffer);

				return *(ECollisionTraceFlag*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh on which to generate the UV mapping.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <param name="UVChannelIndex">
		/// Channel where to save the UV mapping.
		/// </param>
		/// <param name="Position">
		/// Position of the center of the projection gizmo.
		/// </param>
		/// <param name="Orientation">
		/// Rotation to apply to the projection gizmo.
		/// </param>
		/// <param name="Tiling">
		/// The UV tiling to use to generate the UV mapping.
		/// </param>
		/// <returns>
		/// true if the UV mapping was generated.
		/// </returns>
		public virtual bool GeneratePlanarUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex, FVector Position, FRotator Orientation, FVector2D Tiling)
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

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GeneratePlanarUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh on which to generate the UV mapping.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <param name="UVChannelIndex">
		/// Channel where to save the UV mapping.
		/// </param>
		/// <param name="Position">
		/// Position of the center of the projection gizmo.
		/// </param>
		/// <param name="Orientation">
		/// Rotation to apply to the projection gizmo.
		/// </param>
		/// <param name="Tiling">
		/// The UV tiling to use to generate the UV mapping.
		/// </param>
		/// <returns>
		/// true if the UV mapping was generated.
		/// </returns>
		public virtual bool GenerateCylindricalUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex, FVector Position, FRotator Orientation, FVector2D Tiling)
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

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GenerateCylindricalUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh on which to generate the UV mapping.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <param name="UVChannelIndex">
		/// Channel where to save the UV mapping.
		/// </param>
		/// <param name="Position">
		/// Position of the center of the projection gizmo.
		/// </param>
		/// <param name="Orientation">
		/// Rotation to apply to the projection gizmo.
		/// </param>
		/// <param name="Size">
		/// The size of the box projection gizmo.
		/// </param>
		/// <returns>
		/// true if the UV mapping was generated.
		/// </returns>
		public virtual bool GenerateBoxUVChannel(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex, FVector Position, FRotator Orientation, FVector Size)
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

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GenerateBoxUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh to Enables/disables collisions from.
		/// </param>
		/// <param name="bCollisionEnabled">
		/// If the collision is enabled or not.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the StaticMesh Section.
		/// </param>
		public virtual void EnableSectionCollision(UStaticMesh StaticMesh, bool bCollisionEnabled, int LODIndex, int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bCollisionEnabled;

				*(int*)(__InBuffer + 9) = LODIndex;

				*(int*)(__InBuffer + 13) = SectionIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EnableSectionCollision, __InBuffer);
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh to Enables/disables shadow casting from.
		/// </param>
		/// <param name="bCastShadow">
		/// If the section should cast shadow.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <param name="SectionIndex">
		/// Index of the StaticMesh Section.
		/// </param>
		public virtual void EnableSectionCastShadow(UStaticMesh StaticMesh, bool bCastShadow, int LODIndex, int SectionIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bCastShadow;

				*(int*)(__InBuffer + 9) = LODIndex;

				*(int*)(__InBuffer + 13) = SectionIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EnableSectionCastShadow, __InBuffer);
			}
		}

		/// <param name="ActorsToMerge">
		/// List of actors to build a proxy for.
		/// </param>
		/// <param name="MergeOptions">
		/// </param>
		/// <param name="OutMergedActor">
		/// generated actor if requested
		/// </param>
		/// <returns>
		/// Success of the proxy creation
		/// </returns>
		public virtual bool CreateProxyMeshActor(TArray<AStaticMeshActor> ActorsToMerge, FCreateProxyMeshActorOptions MergeOptions, ref AStaticMeshActor OutMergedActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ActorsToMerge?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MergeOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutMergedActor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __CreateProxyMeshActor, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutMergedActor = *(AStaticMeshActor*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMeshes">
		/// Set of Static mesh to add convex collision on.
		/// </param>
		/// <param name="HullCount">
		/// Maximum number of convex pieces that will be created. Must be positive.
		/// </param>
		/// <param name="MaxHullVerts">
		/// Maximum number of vertices allowed for any generated convex hull.
		/// </param>
		/// <param name="HullPrecision">
		/// Number of voxels to use when generating collision. Must be positive.
		/// </param>
		/// <param name="bApplyChanges">
		/// Indicates if changes must be apply or not.
		/// </param>
		/// <returns>
		/// A boolean indicating if the addition was successful or not.
		/// </returns>
		public virtual bool BulkSetConvexDecompositionCollisionsWithNotification(TArray<UStaticMesh> StaticMeshes, int HullCount, int MaxHullVerts, int HullPrecision, bool bApplyChanges)
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

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BulkSetConvexDecompositionCollisionsWithNotification, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool BulkSetConvexDecompositionCollisions(TArray<UStaticMesh> StaticMeshes, int HullCount, int MaxHullVerts, int HullPrecision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = StaticMeshes?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = HullCount;

				*(int*)(__InBuffer + 12) = MaxHullVerts;

				*(int*)(__InBuffer + 16) = HullPrecision;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BulkSetConvexDecompositionCollisions, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Static mesh on which to add a UV channel.
		/// </param>
		/// <param name="LODIndex">
		/// Index of the StaticMesh LOD.
		/// </param>
		/// <returns>
		/// true if a UV channel was added.
		/// </returns>
		public virtual bool AddUVChannel(UStaticMesh StaticMesh, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = LODIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddUVChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StaticMesh">
		/// Mesh to generate simple collision for.
		/// </param>
		/// <param name="ShapeType">
		/// Options on which simple collision to add to the mesh.
		/// </param>
		/// <param name="bApplyChanges">
		/// Indicates if changes must be apply or not.
		/// </param>
		/// <returns>
		/// An integer indicating the index of the collision newly created.
		/// A negative value indicates the addition failed.
		/// </returns>
		public virtual int AddSimpleCollisionsWithNotification(UStaticMesh StaticMesh, EScriptCollisionShapeType ShapeType, bool bApplyChanges)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ShapeType;

				*(bool*)(__InBuffer + 9) = bApplyChanges;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddSimpleCollisionsWithNotification, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int AddSimpleCollisions(UStaticMesh StaticMesh, EScriptCollisionShapeType ShapeType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = StaticMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ShapeType;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddSimpleCollisions, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __SetNaniteSettings = 0;

		private static uint __SetLodsWithNotification = 0;

		private static uint __SetLodScreenSizes = 0;

		private static uint __SetLods = 0;

		private static uint __SetLodReductionSettings = 0;

		private static uint __SetLODMaterialSlot = 0;

		private static uint __SetLODGroup = 0;

		private static uint __SetLodFromStaticMesh = 0;

		private static uint __SetLodBuildSettings = 0;

		private static uint __SetGenerateLightmapUVs = 0;

		private static uint __SetConvexDecompositionCollisionsWithNotification = 0;

		private static uint __SetConvexDecompositionCollisions = 0;

		private static uint __SetAllowCPUAccess = 0;

		private static uint __ReplaceMeshComponentsMeshesOnActors = 0;

		private static uint __ReplaceMeshComponentsMeshes = 0;

		private static uint __ReplaceMeshComponentsMaterialsOnActors = 0;

		private static uint __ReplaceMeshComponentsMaterials = 0;

		private static uint __RemoveUVChannel = 0;

		private static uint __RemoveLods = 0;

		private static uint __RemoveCollisionsWithNotification = 0;

		private static uint __RemoveCollisions = 0;

		private static uint __ReimportAllCustomLODs = 0;

		private static uint __MergeStaticMeshActors = 0;

		private static uint __JoinStaticMeshActors = 0;

		private static uint __IsSectionCollisionEnabled = 0;

		private static uint __InsertUVChannel = 0;

		private static uint __ImportLOD = 0;

		private static uint __HasVertexColors = 0;

		private static uint __HasInstanceVertexColors = 0;

		private static uint __GetSimpleCollisionCount = 0;

		private static uint __GetNumUVChannels = 0;

		private static uint __GetNumberVerts = 0;

		private static uint __GetNumberMaterials = 0;

		private static uint __GetNaniteSettings = 0;

		private static uint __GetLodScreenSizes = 0;

		private static uint __GetLodReductionSettings = 0;

		private static uint __GetLODMaterialSlot = 0;

		private static uint __GetLODGroup = 0;

		private static uint __GetLodCount = 0;

		private static uint __GetLodBuildSettings = 0;

		private static uint __GetConvexCollisionCount = 0;

		private static uint __GetCollisionComplexity = 0;

		private static uint __GeneratePlanarUVChannel = 0;

		private static uint __GenerateCylindricalUVChannel = 0;

		private static uint __GenerateBoxUVChannel = 0;

		private static uint __EnableSectionCollision = 0;

		private static uint __EnableSectionCastShadow = 0;

		private static uint __CreateProxyMeshActor = 0;

		private static uint __BulkSetConvexDecompositionCollisionsWithNotification = 0;

		private static uint __BulkSetConvexDecompositionCollisions = 0;

		private static uint __AddUVChannel = 0;

		private static uint __AddSimpleCollisionsWithNotification = 0;

		private static uint __AddSimpleCollisions = 0;
	}
}