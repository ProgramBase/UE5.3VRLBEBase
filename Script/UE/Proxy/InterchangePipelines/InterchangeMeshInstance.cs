using Script.CoreUObject;
using Script.Library;
using Script.InterchangeNodes;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.InterchangeMeshInstance")]
	public partial class FInterchangeMeshInstance : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangePipelines.InterchangeMeshInstance");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeMeshInstance() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangeMeshInstance() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangeMeshInstance A, FInterchangeMeshInstance B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeMeshInstance A, FInterchangeMeshInstance B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeMeshInstance;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString MeshInstanceUid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeshInstanceUid, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeshInstanceUid, __InBuffer);
				}
			}
		}

		public UInterchangeSceneNode LodGroupNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LodGroupNode, __ReturnBuffer);

					return *(UInterchangeSceneNode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LodGroupNode, __InBuffer);
				}
			}
		}

		public bool bReferenceSkinnedMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bReferenceSkinnedMesh, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bReferenceSkinnedMesh, __InBuffer);
				}
			}
		}

		public bool bReferenceMorphTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bReferenceMorphTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bReferenceMorphTarget, __InBuffer);
				}
			}
		}

		public bool bHasMorphTargets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasMorphTargets, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasMorphTargets, __InBuffer);
				}
			}
		}

		public TMap<int, FInterchangeLodSceneNodeContainer> SceneNodePerLodIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SceneNodePerLodIndex, __ReturnBuffer);

					return *(TMap<int, FInterchangeLodSceneNodeContainer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SceneNodePerLodIndex, __InBuffer);
				}
			}
		}

		public TArray<FString> ReferencingMeshGeometryUids
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReferencingMeshGeometryUids, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReferencingMeshGeometryUids, __InBuffer);
				}
			}
		}

		private static uint __MeshInstanceUid = 0;

		private static uint __LodGroupNode = 0;

		private static uint __bReferenceSkinnedMesh = 0;

		private static uint __bReferenceMorphTarget = 0;

		private static uint __bHasMorphTargets = 0;

		private static uint __SceneNodePerLodIndex = 0;

		private static uint __ReferencingMeshGeometryUids = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}