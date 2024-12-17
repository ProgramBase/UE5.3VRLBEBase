using Script.CoreUObject;
using Script.Library;

namespace Script.MeshPaint
{
	[PathName("/Script/MeshPaint.MeshPaintSettings")]
	public partial class UMeshPaintSettings : UObject, IStaticClass
	{
		public float VertexPreviewSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VertexPreviewSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VertexPreviewSize, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaint.MeshPaintSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VertexPreviewSize = 0;
	}
}