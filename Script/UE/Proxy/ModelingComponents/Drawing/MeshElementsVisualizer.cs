using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.MeshElementsVisualizer")]
	public partial class UMeshElementsVisualizer : UPreviewGeometry, IStaticClass
	{
		public UMeshElementsVisualizerProperties Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(UMeshElementsVisualizerProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public UMeshWireframeComponent WireframeComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WireframeComponent, __ReturnBuffer);

					return *(UMeshWireframeComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WireframeComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.MeshElementsVisualizer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Settings = 0;

		private static uint __WireframeComponent = 0;
	}
}