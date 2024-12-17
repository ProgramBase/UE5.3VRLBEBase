using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.RemoveOccludedTrianglesTool")]
	public partial class URemoveOccludedTrianglesTool : UMultiSelectionMeshEditingTool, IStaticClass
	{
		public URemoveOccludedTrianglesToolProperties BasicProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BasicProperties, __ReturnBuffer);

					return *(URemoveOccludedTrianglesToolProperties*)__ReturnBuffer;
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

		public UPolygroupLayersProperties PolygroupLayersProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PolygroupLayersProperties, __ReturnBuffer);

					return *(UPolygroupLayersProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PolygroupLayersProperties, __InBuffer);
				}
			}
		}

		public URemoveOccludedTrianglesAdvancedProperties AdvancedProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AdvancedProperties, __ReturnBuffer);

					return *(URemoveOccludedTrianglesAdvancedProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AdvancedProperties, __InBuffer);
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

		public TArray<UPreviewMesh> PreviewCopies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewCopies, __ReturnBuffer);

					return *(TArray<UPreviewMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewCopies, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.RemoveOccludedTrianglesTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BasicProperties = 0;

		private static uint __PolygroupLayersProperties = 0;

		private static uint __AdvancedProperties = 0;

		private static uint __Previews = 0;

		private static uint __PreviewCopies = 0;
	}
}