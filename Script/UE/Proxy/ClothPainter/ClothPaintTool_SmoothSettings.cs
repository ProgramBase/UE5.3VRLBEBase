using Script.CoreUObject;
using Script.Library;

namespace Script.ClothPainter
{
	[PathName("/Script/ClothPainter.ClothPaintTool_SmoothSettings")]
	public partial class UClothPaintTool_SmoothSettings : UObject, IStaticClass
	{
		public float Strength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Strength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Strength, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothPainter.ClothPaintTool_SmoothSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Strength = 0;
	}
}