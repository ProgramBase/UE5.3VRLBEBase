using Script.CoreUObject;
using Script.Library;

namespace Script.ClothPainter
{
	[PathName("/Script/ClothPainter.ClothPaintTool_BrushSettings")]
	public partial class UClothPaintTool_BrushSettings : UObject, IStaticClass
	{
		public float PaintValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PaintValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PaintValue, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothPainter.ClothPaintTool_BrushSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PaintValue = 0;
	}
}