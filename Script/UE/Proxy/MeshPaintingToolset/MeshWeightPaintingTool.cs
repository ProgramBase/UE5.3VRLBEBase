using Script.CoreUObject;
using Script.Library;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.MeshWeightPaintingTool")]
	public partial class UMeshWeightPaintingTool : UMeshVertexPaintingTool, IStaticClass
	{
		public UMeshWeightPaintingToolProperties WeightProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeightProperties, __ReturnBuffer);

					return *(UMeshWeightPaintingToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeightProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintingToolset.MeshWeightPaintingTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WeightProperties = 0;
	}
}