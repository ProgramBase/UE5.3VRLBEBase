using Script.CoreUObject;
using Script.Library;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.MeshWeightPaintingToolProperties")]
	public partial class UMeshWeightPaintingToolProperties : UMeshVertexPaintingToolProperties, IStaticClass
	{
		public EMeshPaintWeightTypes TextureWeightType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextureWeightType, __ReturnBuffer);

					return *(EMeshPaintWeightTypes*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextureWeightType, __InBuffer);
				}
			}
		}

		public EMeshPaintTextureIndex PaintTextureWeightIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PaintTextureWeightIndex, __ReturnBuffer);

					return *(EMeshPaintTextureIndex*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PaintTextureWeightIndex, __InBuffer);
				}
			}
		}

		public EMeshPaintTextureIndex EraseTextureWeightIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EraseTextureWeightIndex, __ReturnBuffer);

					return *(EMeshPaintTextureIndex*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EraseTextureWeightIndex, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintingToolset.MeshWeightPaintingToolProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TextureWeightType = 0;

		private static uint __PaintTextureWeightIndex = 0;

		private static uint __EraseTextureWeightIndex = 0;
	}
}