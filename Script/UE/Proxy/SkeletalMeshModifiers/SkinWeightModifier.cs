using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.SkeletalMeshModifiers
{
	[PathName("/Script/SkeletalMeshModifiers.SkinWeightModifier")]
	public partial class USkinWeightModifier : UObject, IStaticClass
	{
		public USkeletalMesh Mesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Mesh, __ReturnBuffer);

					return *(USkeletalMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Mesh, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SkeletalMeshModifiers.SkinWeightModifier");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="VertexID">
		/// the index of the vertex
		/// </param>
		/// <param name="InWeights">
		/// a map of Bone-Name to Weight for all bones that influence the specified vertex, ie {"Head": 0.6, "Neck": 0.4}
		/// </param>
		/// <param name="bReplaceAll">
		/// if true, all weights on this vertex will be replaced with the input weights. Default is false.
		/// </param>
		public virtual bool SetVertexWeights(int VertexID, TMap<FName, float> InWeights, bool bReplaceAll = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = VertexID;

				*(nint*)(__InBuffer + 4) = InWeights?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bReplaceAll;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetVertexWeights, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InMesh">
		/// - The skeletal mesh asset to load for weight editing
		/// </param>
		/// <returns>
		/// bool - true if the mesh weights were successfully loaded.
		/// </returns>
		public virtual bool SetSkeletalMesh(USkeletalMesh InMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSkeletalMesh, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="VertexID">
		/// the index of the vertex to prune weights on
		/// </param>
		/// <param name="WeightThreshold">
		/// vertex weights below this value will be removed. 
		/// </param>
		/// <returns>
		/// true if influences were removed, false otherwise
		/// </returns>
		public virtual bool PruneVertexWeights(int VertexID, float WeightThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = VertexID;

				*(float*)(__InBuffer + 4) = WeightThreshold;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __PruneVertexWeights, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WeightThreshold">
		/// vertex weights below this value will be removed. 
		/// </param>
		/// <returns>
		/// true if influences were removed, false otherwise
		/// </returns>
		public virtual bool PruneAllWeights(float WeightThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = WeightThreshold;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __PruneAllWeights, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="VertexID">
		/// the index of the vertex to normalize weights on
		/// </param>
		/// <returns>
		/// true if normalization was performed, false otherwise
		/// </returns>
		public virtual bool NormalizeVertexWeights(int VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = VertexID;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __NormalizeVertexWeights, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if normalization was performed, false otherwise
		/// </returns>
		public virtual bool NormalizeAllWeights()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __NormalizeAllWeights, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="VertexID">
		/// the index of the vertex
		/// </param>
		/// <returns>
		/// a map of Bone Name to weight values for all bones that influence the specified vertex.
		/// </returns>
		public virtual TMap<FName, float> GetVertexWeights(int VertexID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = VertexID;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVertexWeights, __InBuffer, __ReturnBuffer);

				return *(TMap<FName, float>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// USkeletalMesh* - the mesh that was loaded, or null
		/// </returns>
		public virtual USkeletalMesh GetSkeletalMesh()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSkeletalMesh, __ReturnBuffer);

				return *(USkeletalMesh*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// int, number of vertices
		/// </returns>
		public virtual int GetNumVertices()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumVertices, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// array of bone names
		/// </returns>
		public virtual TArray<FName> GetAllBoneNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllBoneNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		/// <param name="MaxInfluences">
		/// The maximum number of influences to allow for each vertex in the mesh. If -1 is passed, will use the project-wide MaxInfluences amount.
		/// </param>
		/// <returns>
		/// true if influences were removed, false otherwise
		/// </returns>
		public virtual bool EnforceMaxInfluences(int MaxInfluences = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = MaxInfluences;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __EnforceMaxInfluences, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if weights were applied to a skeletal mesh, false otherwise
		/// </returns>
		public virtual bool CommitWeightsToSkeletalMesh()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __CommitWeightsToSkeletalMesh, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Mesh = 0;

		private static uint __SetVertexWeights = 0;

		private static uint __SetSkeletalMesh = 0;

		private static uint __PruneVertexWeights = 0;

		private static uint __PruneAllWeights = 0;

		private static uint __NormalizeVertexWeights = 0;

		private static uint __NormalizeAllWeights = 0;

		private static uint __GetVertexWeights = 0;

		private static uint __GetSkeletalMesh = 0;

		private static uint __GetNumVertices = 0;

		private static uint __GetAllBoneNames = 0;

		private static uint __EnforceMaxInfluences = 0;

		private static uint __CommitWeightsToSkeletalMesh = 0;
	}
}