using Script.CoreUObject;
using Script.Engine;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.BaseDynamicMeshComponent")]
	public partial class UBaseDynamicMeshComponent : UMeshComponent, IStaticClass, IToolFrameworkComponent, IMeshVertexCommandChangeTarget, IMeshCommandChangeTarget, IMeshReplacementCommandChangeTarget
	{
		public bool bExplicitShowWireframe
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExplicitShowWireframe, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExplicitShowWireframe, __InBuffer);
				}
			}
		}

		public FLinearColor WireframeColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WireframeColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WireframeColor, __InBuffer);
				}
			}
		}

		public EDynamicMeshComponentColorOverrideMode ColorMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorMode, __ReturnBuffer);

					return *(EDynamicMeshComponentColorOverrideMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorMode, __InBuffer);
				}
			}
		}

		public FColor ConstantColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstantColor, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstantColor, __InBuffer);
				}
			}
		}

		public EDynamicMeshVertexColorTransformMode ColorSpaceMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorSpaceMode, __ReturnBuffer);

					return *(EDynamicMeshVertexColorTransformMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorSpaceMode, __InBuffer);
				}
			}
		}

		public bool bEnableFlatShading
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableFlatShading, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableFlatShading, __InBuffer);
				}
			}
		}

		public bool bEnableViewModeOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableViewModeOverrides, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableViewModeOverrides, __InBuffer);
				}
			}
		}

		public UMaterialInterface OverrideRenderMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideRenderMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverrideRenderMaterial, __InBuffer);
				}
			}
		}

		public UMaterialInterface SecondaryRenderMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SecondaryRenderMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SecondaryRenderMaterial, __InBuffer);
				}
			}
		}

		public bool bEnableRaytracing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRaytracing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableRaytracing, __InBuffer);
				}
			}
		}

		public TArray<UMaterialInterface> BaseMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseMaterials, __ReturnBuffer);

					return *(TArray<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseMaterials, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryFramework.BaseDynamicMeshComponent");
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

		public virtual void SetViewModeOverridesEnabled(bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetViewModeOverridesEnabled, __InBuffer);
			}
		}

		public virtual void SetVertexColorSpaceTransformMode(EDynamicMeshVertexColorTransformMode NewMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVertexColorSpaceTransformMode, __InBuffer);
			}
		}

		public virtual void SetShadowsEnabled(bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShadowsEnabled, __InBuffer);
			}
		}

		public virtual void SetSecondaryRenderMaterial(UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSecondaryRenderMaterial, __InBuffer);
			}
		}

		public virtual void SetSecondaryBuffersVisibility(bool bSetVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSetVisible;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSecondaryBuffersVisibility, __InBuffer);
			}
		}

		public virtual void SetOverrideRenderMaterial(UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOverrideRenderMaterial, __InBuffer);
			}
		}

		public virtual void SetEnableWireframeRenderPass(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableWireframeRenderPass, __InBuffer);
			}
		}

		public virtual void SetEnableRaytracing(bool bSetEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSetEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableRaytracing, __InBuffer);
			}
		}

		public virtual void SetEnableFlatShading(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableFlatShading, __InBuffer);
			}
		}

		public virtual void SetConstantOverrideColor(FColor NewColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConstantOverrideColor, __InBuffer);
			}
		}

		public virtual void SetColorOverrideMode(EDynamicMeshComponentColorOverrideMode NewMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetColorOverrideMode, __InBuffer);
			}
		}

		/// <returns>
		/// true if an override render material is currently enabled for the given MaterialIndex
		/// </returns>
		public virtual bool HasOverrideRenderMaterial(int k)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = k;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasOverrideRenderMaterial, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetViewModeOverridesEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetViewModeOverridesEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// active Color Override mode
		/// </returns>
		public virtual EDynamicMeshVertexColorTransformMode GetVertexColorSpaceTransformMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetVertexColorSpaceTransformMode, __ReturnBuffer);

				return *(EDynamicMeshVertexColorTransformMode*)__ReturnBuffer;
			}
		}

		public virtual bool GetShadowsEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetShadowsEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// active secondary render material
		/// </returns>
		public virtual UMaterialInterface GetSecondaryRenderMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSecondaryRenderMaterial, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if secondary buffers are currently set to be visible
		/// </returns>
		public virtual bool GetSecondaryBuffersVisibility()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSecondaryBuffersVisibility, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// active override render material for the given MaterialIndex
		/// </returns>
		public virtual UMaterialInterface GetOverrideRenderMaterial(int MaterialIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = MaterialIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetOverrideRenderMaterial, __InBuffer, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// active Color used for Constant Color Override Mode
		/// </returns>
		public virtual bool GetFlatShadingEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFlatShadingEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if wireframe rendering pass is enabled
		/// </returns>
		public virtual bool GetEnableWireframeRenderPass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetEnableWireframeRenderPass, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if raytracing support is currently enabled
		/// </returns>
		public virtual bool GetEnableRaytracing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetEnableRaytracing, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the child UDynamicMesh
		/// </returns>
		public virtual UDynamicMesh GetDynamicMesh()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDynamicMesh, __ReturnBuffer);

				return *(UDynamicMesh*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// active Color used for Constant Color Override Mode
		/// </returns>
		public virtual FColor GetConstantOverrideColor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetConstantOverrideColor, __ReturnBuffer);

				return *(FColor*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// active Color Override mode
		/// </returns>
		public virtual EDynamicMeshComponentColorOverrideMode GetColorOverrideMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetColorOverrideMode, __ReturnBuffer);

				return *(EDynamicMeshComponentColorOverrideMode*)__ReturnBuffer;
			}
		}

		public virtual void ClearSecondaryRenderMaterial()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearSecondaryRenderMaterial);
			}
		}

		public virtual void ClearOverrideRenderMaterial()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearOverrideRenderMaterial);
			}
		}

		private static uint __bExplicitShowWireframe = 0;

		private static uint __WireframeColor = 0;

		private static uint __ColorMode = 0;

		private static uint __ConstantColor = 0;

		private static uint __ColorSpaceMode = 0;

		private static uint __bEnableFlatShading = 0;

		private static uint __bEnableViewModeOverrides = 0;

		private static uint __OverrideRenderMaterial = 0;

		private static uint __SecondaryRenderMaterial = 0;

		private static uint __bEnableRaytracing = 0;

		private static uint __BaseMaterials = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetViewModeOverridesEnabled = 0;

		private static uint __SetVertexColorSpaceTransformMode = 0;

		private static uint __SetShadowsEnabled = 0;

		private static uint __SetSecondaryRenderMaterial = 0;

		private static uint __SetSecondaryBuffersVisibility = 0;

		private static uint __SetOverrideRenderMaterial = 0;

		private static uint __SetEnableWireframeRenderPass = 0;

		private static uint __SetEnableRaytracing = 0;

		private static uint __SetEnableFlatShading = 0;

		private static uint __SetConstantOverrideColor = 0;

		private static uint __SetColorOverrideMode = 0;

		private static uint __HasOverrideRenderMaterial = 0;

		private static uint __GetViewModeOverridesEnabled = 0;

		private static uint __GetVertexColorSpaceTransformMode = 0;

		private static uint __GetShadowsEnabled = 0;

		private static uint __GetSecondaryRenderMaterial = 0;

		private static uint __GetSecondaryBuffersVisibility = 0;

		private static uint __GetOverrideRenderMaterial = 0;

		private static uint __GetFlatShadingEnabled = 0;

		private static uint __GetEnableWireframeRenderPass = 0;

		private static uint __GetEnableRaytracing = 0;

		private static uint __GetDynamicMesh = 0;

		private static uint __GetConstantOverrideColor = 0;

		private static uint __GetColorOverrideMode = 0;

		private static uint __ClearSecondaryRenderMaterial = 0;

		private static uint __ClearOverrideRenderMaterial = 0;
	}
}