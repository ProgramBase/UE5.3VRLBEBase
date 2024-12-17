using Script.CoreUObject;
using Script.Engine;
using Script.PhysicsCore;
using Script.Library;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.DynamicMeshComponent")]
	public partial class UDynamicMeshComponent : UBaseDynamicMeshComponent, IStaticClass, IInterface_CollisionDataProvider
	{
		public UDynamicMesh MeshObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshObject, __ReturnBuffer);

					return *(UDynamicMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshObject, __InBuffer);
				}
			}
		}

		public EDynamicMeshComponentTangentsMode TangentsType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TangentsType, __ReturnBuffer);

					return *(EDynamicMeshComponentTangentsMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TangentsType, __InBuffer);
				}
			}
		}

		public ECollisionTraceFlag CollisionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionType, __ReturnBuffer);

					return *(ECollisionTraceFlag*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionType, __InBuffer);
				}
			}
		}

		public bool bUseAsyncCooking
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseAsyncCooking, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseAsyncCooking, __InBuffer);
				}
			}
		}

		public bool bEnableComplexCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableComplexCollision, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableComplexCollision, __InBuffer);
				}
			}
		}

		public bool bDeferCollisionUpdates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDeferCollisionUpdates, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDeferCollisionUpdates, __InBuffer);
				}
			}
		}

		public UBodySetup MeshBodySetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshBodySetup, __ReturnBuffer);

					return *(UBodySetup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshBodySetup, __InBuffer);
				}
			}
		}

		public FKAggregateGeom AggGeom
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AggGeom, __ReturnBuffer);

					return *(FKAggregateGeom*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AggGeom, __InBuffer);
				}
			}
		}

		public TArray<UBodySetup> AsyncBodySetupQueue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AsyncBodySetupQueue, __ReturnBuffer);

					return *(TArray<UBodySetup>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AsyncBodySetupQueue, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryFramework.DynamicMeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		/// <param name="bCreateIfMissing">
		/// if true, add extra (empty) Material Slots to match max MaterialID
		/// </param>
		/// <param name="bDeleteExtraSlots">
		/// if true, extra Material Slots beyond max MaterialID are removed
		/// </param>
		/// <returns>
		/// true if at the end of this function, Material Slot Count == Max MaterialID
		/// </returns>
		public virtual bool ValidateMaterialSlots(bool bCreateIfMissing = true, bool bDeleteExtraSlots = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bCreateIfMissing;

				*(bool*)(__InBuffer + 1) = bDeleteExtraSlots;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ValidateMaterialSlots, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bOnlyIfPending">
		/// only update if a collision update is pending, ie the underlying DynamicMesh changed and bDeferCollisionUpdates is enabled
		/// </param>
		public virtual void UpdateCollision(bool bOnlyIfPending = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bOnlyIfPending;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UpdateCollision, __InBuffer);
			}
		}

		public virtual void SetTangentsType(EDynamicMeshComponentTangentsMode NewTangentsType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewTangentsType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTangentsType, __InBuffer);
			}
		}

		/// <warning>
		/// If NewMesh is owned/Outer'd to another DynamicMeshComponent, a GLEO error may occur if that Component is serialized.
		/// </warning>
		public virtual void SetDynamicMesh(UDynamicMesh NewMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDynamicMesh, __InBuffer);
			}
		}

		/// <param name="bImmediateUpdate">
		/// if true, UpdateCollision(true) is called if bEnabled=false, ie to force a collision rebuild
		/// </param>
		public virtual void SetDeferredCollisionUpdatesEnabled(bool bEnabled, bool bImmediateUpdate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bEnabled;

				*(bool*)(__InBuffer + 1) = bImmediateUpdate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDeferredCollisionUpdatesEnabled, __InBuffer);
			}
		}

		/// <param name="bImmediateUpdate">
		/// if true, UpdateCollision(true) is called
		/// </param>
		public virtual void SetComplexAsSimpleCollisionEnabled(bool bEnabled, bool bImmediateUpdate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bEnabled;

				*(bool*)(__InBuffer + 1) = bImmediateUpdate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetComplexAsSimpleCollisionEnabled, __InBuffer);
			}
		}

		/// <warning>
		/// it is invalid to call this function if (1) the mesh triangulation has also been changed, (2) triangle MaterialIDs have been changed,
		/// or (3) any attribute overlay (normal, color, UV) topology has been modified, ie split-vertices have been added/removed.
		/// Behavior of this function is undefined in these cases and may crash. If you are unsure, use Notify Mesh Updated.
		/// </warning>
		public virtual void NotifyMeshVertexAttributesModified(bool bPositions = true, bool bNormals = true, bool bUVs = true, bool bColors = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(bool*)(__InBuffer) = bPositions;

				*(bool*)(__InBuffer + 1) = bNormals;

				*(bool*)(__InBuffer + 2) = bUVs;

				*(bool*)(__InBuffer + 3) = bColors;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NotifyMeshVertexAttributesModified, __InBuffer);
			}
		}

		public virtual void NotifyMeshModified()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __NotifyMeshModified);
			}
		}

		public virtual EDynamicMeshComponentTangentsMode GetTangentsTypePure()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTangentsTypePure, __ReturnBuffer);

				return *(EDynamicMeshComponentTangentsMode*)__ReturnBuffer;
			}
		}

		public virtual EDynamicMeshComponentTangentsMode GetTangentsType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTangentsType, __ReturnBuffer);

				return *(EDynamicMeshComponentTangentsMode*)__ReturnBuffer;
			}
		}

		public virtual void EnableComplexAsSimpleCollision()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EnableComplexAsSimpleCollision);
			}
		}

		public virtual void ConfigureMaterialSet(TArray<UMaterialInterface> NewMaterialSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMaterialSet?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ConfigureMaterialSet, __InBuffer);
			}
		}

		private static uint __MeshObject = 0;

		private static uint __TangentsType = 0;

		private static uint __CollisionType = 0;

		private static uint __bUseAsyncCooking = 0;

		private static uint __bEnableComplexCollision = 0;

		private static uint __bDeferCollisionUpdates = 0;

		private static uint __MeshBodySetup = 0;

		private static uint __AggGeom = 0;

		private static uint __AsyncBodySetupQueue = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __ValidateMaterialSlots = 0;

		private static uint __UpdateCollision = 0;

		private static uint __SetTangentsType = 0;

		private static uint __SetDynamicMesh = 0;

		private static uint __SetDeferredCollisionUpdatesEnabled = 0;

		private static uint __SetComplexAsSimpleCollisionEnabled = 0;

		private static uint __NotifyMeshVertexAttributesModified = 0;

		private static uint __NotifyMeshModified = 0;

		private static uint __GetTangentsTypePure = 0;

		private static uint __GetTangentsType = 0;

		private static uint __EnableComplexAsSimpleCollision = 0;

		private static uint __ConfigureMaterialSet = 0;
	}
}