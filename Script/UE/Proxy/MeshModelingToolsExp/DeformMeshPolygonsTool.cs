using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.GeometryFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.DeformMeshPolygonsTool")]
	public partial class UDeformMeshPolygonsTool : UMeshSurfacePointTool, IStaticClass
	{
		public AInternalToolFrameworkActor PreviewMeshActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMeshActor, __ReturnBuffer);

					return *(AInternalToolFrameworkActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewMeshActor, __InBuffer);
				}
			}
		}

		public UDynamicMeshComponent DynamicMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicMeshComponent, __ReturnBuffer);

					return *(UDynamicMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicMeshComponent, __InBuffer);
				}
			}
		}

		public UDeformMeshPolygonsTransformProperties TransformProps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransformProps, __ReturnBuffer);

					return *(UDeformMeshPolygonsTransformProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransformProps, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.DeformMeshPolygonsTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PreviewMeshActor = 0;

		private static uint __DynamicMeshComponent = 0;

		private static uint __TransformProps = 0;
	}
}