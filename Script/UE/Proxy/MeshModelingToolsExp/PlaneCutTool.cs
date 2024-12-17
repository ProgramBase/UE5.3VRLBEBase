using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.PlaneCutTool")]
	public partial class UPlaneCutTool : UMultiSelectionMeshEditingTool, IStaticClass
	{
		public UPlaneCutToolProperties BasicProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BasicProperties, __ReturnBuffer);

					return *(UPlaneCutToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BasicProperties, __InBuffer);
				}
			}
		}

		public TArray<UMeshOpPreviewWithBackgroundCompute> Previews
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Previews, __ReturnBuffer);

					return *(TArray<UMeshOpPreviewWithBackgroundCompute>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Previews, __InBuffer);
				}
			}
		}

		public TArray<UDynamicMeshReplacementChangeTarget> MeshesToCut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshesToCut, __ReturnBuffer);

					return *(TArray<UDynamicMeshReplacementChangeTarget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshesToCut, __InBuffer);
				}
			}
		}

		public UConstructionPlaneMechanic PlaneMechanic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneMechanic, __ReturnBuffer);

					return *(UConstructionPlaneMechanic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaneMechanic, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.PlaneCutTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void FlipPlane()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FlipPlane);
			}
		}

		public virtual void Cut()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Cut);
			}
		}

		private static uint __BasicProperties = 0;

		private static uint __Previews = 0;

		private static uint __MeshesToCut = 0;

		private static uint __PlaneMechanic = 0;

		private static uint __FlipPlane = 0;

		private static uint __Cut = 0;
	}
}