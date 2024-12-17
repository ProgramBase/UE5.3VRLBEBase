using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Renderer
{
	[PathName("/Script/Renderer.SparseVolumeTextureViewer")]
	public partial class ASparseVolumeTextureViewer : AInfo, IStaticClass
	{
		public USparseVolumeTextureViewerComponent SparseVolumeTextureViewerComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SparseVolumeTextureViewerComponent, __ReturnBuffer);

					return *(USparseVolumeTextureViewerComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SparseVolumeTextureViewerComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Renderer.SparseVolumeTextureViewer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SparseVolumeTextureViewerComponent = 0;
	}
}