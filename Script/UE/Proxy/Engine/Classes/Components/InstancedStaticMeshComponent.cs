using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InstancedStaticMeshComponent")]
	public partial class UInstancedStaticMeshComponent : UStaticMeshComponent, IStaticClass, ISMInstanceManager
	{
		public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerInstanceSMData, __ReturnBuffer);

					return *(TArray<FInstancedStaticMeshInstanceData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerInstanceSMData, __InBuffer);
				}
			}
		}

		public TArray<FMatrix> PerInstancePrevTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerInstancePrevTransform, __ReturnBuffer);

					return *(TArray<FMatrix>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerInstancePrevTransform, __InBuffer);
				}
			}
		}

		public int NumCustomDataFloats
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumCustomDataFloats, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumCustomDataFloats, __InBuffer);
				}
			}
		}

		public TArray<float> PerInstanceSMCustomData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerInstanceSMCustomData, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerInstanceSMCustomData, __InBuffer);
				}
			}
		}

		public int InstancingRandomSeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstancingRandomSeed, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstancingRandomSeed, __InBuffer);
				}
			}
		}

		public TArray<FInstancedStaticMeshRandomSeed> AdditionalRandomSeeds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AdditionalRandomSeeds, __ReturnBuffer);

					return *(TArray<FInstancedStaticMeshRandomSeed>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AdditionalRandomSeeds, __InBuffer);
				}
			}
		}

		public int InstanceStartCullDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceStartCullDistance, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceStartCullDistance, __InBuffer);
				}
			}
		}

		public int InstanceEndCullDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceEndCullDistance, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceEndCullDistance, __InBuffer);
				}
			}
		}

		public TArray<int> InstanceReorderTable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceReorderTable, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceReorderTable, __InBuffer);
				}
			}
		}

		public int NumPendingLightmaps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumPendingLightmaps, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumPendingLightmaps, __InBuffer);
				}
			}
		}

		public TArray<FInstancedStaticMeshMappingInfo> CachedMappings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedMappings, __ReturnBuffer);

					return *(TArray<FInstancedStaticMeshMappingInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedMappings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InstancedStaticMeshComponent");
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

		/// <param name="InstanceIndex">
		/// The index of the instance to update
		/// </param>
		/// <param name="NewInstanceTransform">
		/// The new transform
		/// </param>
		/// <param name="bWorldSpace">
		/// If true, the new transform is interpreted as a World Space transform, otherwise it is interpreted as Local Space
		/// </param>
		/// <param name="bMarkRenderStateDirty">
		/// If true, the change should be visible immediately. If you are updating many instances you should only set this to true for the last instance.
		/// </param>
		/// <param name="bTeleport">
		/// Whether or not the instance's physics should be moved normally, or teleported (moved instantly, ignoring velocity).
		/// </param>
		/// <returns>
		/// True on success.
		/// </returns>
		public virtual bool UpdateInstanceTransform(int InstanceIndex, FTransform NewInstanceTransform, bool bWorldSpace = false, bool bMarkRenderStateDirty = false, bool bTeleport = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(int*)(__InBuffer) = InstanceIndex;

				*(nint*)(__InBuffer + 4) = NewInstanceTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bWorldSpace;

				*(bool*)(__InBuffer + 13) = bMarkRenderStateDirty;

				*(bool*)(__InBuffer + 14) = bTeleport;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UpdateInstanceTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetNumCustomDataFloats(int InNumCustomDataFloats)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InNumCustomDataFloats;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNumCustomDataFloats, __InBuffer);
			}
		}

		public virtual bool SetCustomDataValue(int InstanceIndex, int CustomDataIndex, float CustomDataValue, bool bMarkRenderStateDirty = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = InstanceIndex;

				*(int*)(__InBuffer + 4) = CustomDataIndex;

				*(float*)(__InBuffer + 8) = CustomDataValue;

				*(bool*)(__InBuffer + 12) = bMarkRenderStateDirty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomDataValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetCullDistances(int StartCullDistance, int EndCullDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = StartCullDistance;

				*(int*)(__InBuffer + 4) = EndCullDistance;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCullDistances, __InBuffer);
			}
		}

		public virtual bool RemoveInstances(TArray<int> InstancesToRemove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InstancesToRemove?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveInstances, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveInstance(int InstanceIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InstanceIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveInstance, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsValidInstance(int InstanceIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InstanceIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsValidInstance, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetInstanceTransform(int InstanceIndex, ref FTransform OutInstanceTransform, bool bWorldSpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = InstanceIndex;

				*(nint*)(__InBuffer + 4) = OutInstanceTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bWorldSpace;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetInstanceTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutInstanceTransform = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<int> GetInstancesOverlappingSphere(FVector Center, float Radius, bool bSphereInWorldSpace = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = Center?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Radius;

				*(bool*)(__InBuffer + 12) = bSphereInWorldSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetInstancesOverlappingSphere, __InBuffer, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		public virtual TArray<int> GetInstancesOverlappingBox(FBox Box, bool bBoxInWorldSpace = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Box?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bBoxInWorldSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetInstancesOverlappingBox, __InBuffer, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		public virtual int GetInstanceCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetInstanceCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetCullDistances(ref int OutStartCullDistance, ref int OutEndCullDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = OutStartCullDistance;

				*(int*)(__InBuffer + 4) = OutEndCullDistance;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCullDistances, __InBuffer, __OutBuffer);

				OutStartCullDistance = *(int*)(__OutBuffer);

				OutEndCullDistance = *(int*)(__OutBuffer + 4);

			}
		}

		public virtual void ClearInstances()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearInstances);
			}
		}

		/// <param name="StartInstanceIndex">
		/// The starting index of the instances to update
		/// </param>
		/// <param name="NewInstancesTransforms">
		/// The new transforms
		/// </param>
		/// <param name="bWorldSpace">
		/// If true, the new transforms are interpreted as a World Space transform, otherwise it is interpreted as Local Space
		/// </param>
		/// <param name="bMarkRenderStateDirty">
		/// If true, the change should be visible immediately. If you are updating many instances you should only set this to true for the last instance.
		/// </param>
		/// <param name="bTeleport">
		/// Whether or not the instances physics should be moved normally, or teleported (moved instantly, ignoring velocity).
		/// </param>
		/// <returns>
		/// True on success.
		/// </returns>
		public virtual bool BatchUpdateInstancesTransforms(int StartInstanceIndex, TArray<FTransform> NewInstancesTransforms, bool bWorldSpace = false, bool bMarkRenderStateDirty = false, bool bTeleport = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(int*)(__InBuffer) = StartInstanceIndex;

				*(nint*)(__InBuffer + 4) = NewInstancesTransforms?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bWorldSpace;

				*(bool*)(__InBuffer + 13) = bMarkRenderStateDirty;

				*(bool*)(__InBuffer + 14) = bTeleport;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BatchUpdateInstancesTransforms, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="StartInstanceIndex">
		/// The starting index of the instances to update
		/// </param>
		/// <param name="NumInstances">
		/// The number of instances to update
		/// </param>
		/// <param name="NewInstancesTransform">
		/// The new transform
		/// </param>
		/// <param name="bWorldSpace">
		/// If true, the new transform is interpreted as a World Space transform, otherwise it is interpreted as Local Space
		/// </param>
		/// <param name="bMarkRenderStateDirty">
		/// If true, the change should be visible immediately. If you are updating many instances you should only set this to true for the last instance.
		/// </param>
		/// <param name="bTeleport">
		/// Whether or not the instances physics should be moved normally, or teleported (moved instantly, ignoring velocity).
		/// </param>
		/// <returns>
		/// True on success.
		/// </returns>
		public virtual bool BatchUpdateInstancesTransform(int StartInstanceIndex, int NumInstances, FTransform NewInstancesTransform, bool bWorldSpace = false, bool bMarkRenderStateDirty = false, bool bTeleport = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(int*)(__InBuffer) = StartInstanceIndex;

				*(int*)(__InBuffer + 4) = NumInstances;

				*(nint*)(__InBuffer + 8) = NewInstancesTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bWorldSpace;

				*(bool*)(__InBuffer + 17) = bMarkRenderStateDirty;

				*(bool*)(__InBuffer + 18) = bTeleport;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BatchUpdateInstancesTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int AddInstanceWorldSpace(FTransform WorldTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldTransform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddInstanceWorldSpace, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual TArray<int> AddInstances(TArray<FTransform> InstanceTransforms, bool bShouldReturnIndices, bool bWorldSpace = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = InstanceTransforms?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldReturnIndices;

				*(bool*)(__InBuffer + 9) = bWorldSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddInstances, __InBuffer, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		public virtual int AddInstance(FTransform InstanceTransform, bool bWorldSpace = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InstanceTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bWorldSpace;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddInstance, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __PerInstanceSMData = 0;

		private static uint __PerInstancePrevTransform = 0;

		private static uint __NumCustomDataFloats = 0;

		private static uint __PerInstanceSMCustomData = 0;

		private static uint __InstancingRandomSeed = 0;

		private static uint __AdditionalRandomSeeds = 0;

		private static uint __InstanceStartCullDistance = 0;

		private static uint __InstanceEndCullDistance = 0;

		private static uint __InstanceReorderTable = 0;

		private static uint __NumPendingLightmaps = 0;

		private static uint __CachedMappings = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __UpdateInstanceTransform = 0;

		private static uint __SetNumCustomDataFloats = 0;

		private static uint __SetCustomDataValue = 0;

		private static uint __SetCullDistances = 0;

		private static uint __RemoveInstances = 0;

		private static uint __RemoveInstance = 0;

		private static uint __IsValidInstance = 0;

		private static uint __GetInstanceTransform = 0;

		private static uint __GetInstancesOverlappingSphere = 0;

		private static uint __GetInstancesOverlappingBox = 0;

		private static uint __GetInstanceCount = 0;

		private static uint __GetCullDistances = 0;

		private static uint __ClearInstances = 0;

		private static uint __BatchUpdateInstancesTransforms = 0;

		private static uint __BatchUpdateInstancesTransform = 0;

		private static uint __AddInstanceWorldSpace = 0;

		private static uint __AddInstances = 0;

		private static uint __AddInstance = 0;
	}
}