using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperGroupedSpriteComponent")]
	public partial class UPaperGroupedSpriteComponent : UMeshComponent, IStaticClass
	{
		public TArray<UMaterialInterface> InstanceMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceMaterials, __ReturnBuffer);

					return *(TArray<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceMaterials, __InBuffer);
				}
			}
		}

		public TArray<FSpriteInstanceData> PerInstanceSpriteData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerInstanceSpriteData, __ReturnBuffer);

					return *(TArray<FSpriteInstanceData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerInstanceSpriteData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.PaperGroupedSpriteComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool UpdateInstanceTransform(int InstanceIndex, FTransform NewInstanceTransform, bool bWorldSpace = false, bool bMarkRenderStateDirty = true, bool bTeleport = false)
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

		public virtual bool UpdateInstanceColor(int InstanceIndex, FLinearColor NewInstanceColor, bool bMarkRenderStateDirty = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = InstanceIndex;

				*(nint*)(__InBuffer + 4) = NewInstanceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bMarkRenderStateDirty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UpdateInstanceColor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SortInstancesAlongAxis(FVector WorldSpaceSortAxis)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldSpaceSortAxis?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SortInstancesAlongAxis, __InBuffer);
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

		public virtual int GetInstanceCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetInstanceCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void ClearInstances()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearInstances);
			}
		}

		public virtual int AddInstance(FTransform Transform, UPaperSprite Sprite, bool bWorldSpace = false, FLinearColor Color = null)
		{
			unsafe
			{
				Color ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sprite?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bWorldSpace;

				*(nint*)(__InBuffer + 17) = Color?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddInstance, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __InstanceMaterials = 0;

		private static uint __PerInstanceSpriteData = 0;

		private static uint __UpdateInstanceTransform = 0;

		private static uint __UpdateInstanceColor = 0;

		private static uint __SortInstancesAlongAxis = 0;

		private static uint __RemoveInstance = 0;

		private static uint __GetInstanceTransform = 0;

		private static uint __GetInstanceCount = 0;

		private static uint __ClearInstances = 0;

		private static uint __AddInstance = 0;
	}
}