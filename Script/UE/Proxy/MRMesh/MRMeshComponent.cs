using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MRMesh
{
	[PathName("/Script/MRMesh.MRMeshComponent")]
	public partial class UMRMeshComponent : UPrimitiveComponent, IStaticClass
	{
		public UMaterialInterface Material
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Material, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Material, __InBuffer);
				}
			}
		}

		public UMaterialInterface WireframeMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WireframeMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WireframeMaterial, __InBuffer);
				}
			}
		}

		public bool bCreateMeshProxySections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCreateMeshProxySections, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCreateMeshProxySections, __InBuffer);
				}
			}
		}

		public bool bUpdateNavMeshOnMeshUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateNavMeshOnMeshUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUpdateNavMeshOnMeshUpdate, __InBuffer);
				}
			}
		}

		public bool bNeverCreateCollisionMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNeverCreateCollisionMesh, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNeverCreateCollisionMesh, __InBuffer);
				}
			}
		}

		public TArray<UMRMeshBodyHolder> BodyHolders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BodyHolders, __ReturnBuffer);

					return *(TArray<UMRMeshBodyHolder>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BodyHolders, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MRMesh.MRMeshComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetWireframeMaterial(UMaterialInterface InMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWireframeMaterial, __InBuffer);
			}
		}

		public virtual void SetWireframeColor(FLinearColor InColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWireframeColor, __InBuffer);
			}
		}

		public virtual void SetUseWireframe(bool bUseWireframe)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bUseWireframe;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUseWireframe, __InBuffer);
			}
		}

		public virtual void SetEnableMeshOcclusion(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableMeshOcclusion, __InBuffer);
			}
		}

		public virtual void RequestNavMeshUpdate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RequestNavMeshUpdate);
			}
		}

		public virtual bool IsConnected()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsConnected, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FLinearColor GetWireframeColor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetWireframeColor, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public virtual bool GetUseWireframe()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetUseWireframe, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetEnableMeshOcclusion()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetEnableMeshOcclusion, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ForceNavMeshUpdate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ForceNavMeshUpdate);
			}
		}

		public virtual void Clear()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Clear);
			}
		}

		private static uint __Material = 0;

		private static uint __WireframeMaterial = 0;

		private static uint __bCreateMeshProxySections = 0;

		private static uint __bUpdateNavMeshOnMeshUpdate = 0;

		private static uint __bNeverCreateCollisionMesh = 0;

		private static uint __BodyHolders = 0;

		private static uint __SetWireframeMaterial = 0;

		private static uint __SetWireframeColor = 0;

		private static uint __SetUseWireframe = 0;

		private static uint __SetEnableMeshOcclusion = 0;

		private static uint __RequestNavMeshUpdate = 0;

		private static uint __IsConnected = 0;

		private static uint __GetWireframeColor = 0;

		private static uint __GetUseWireframe = 0;

		private static uint __GetEnableMeshOcclusion = 0;

		private static uint __ForceNavMeshUpdate = 0;

		private static uint __Clear = 0;
	}
}