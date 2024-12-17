using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SlateBrushAsset")]
	public partial class USlateBrushAsset : UObject, IStaticClass
	{
		public FSlateBrush Brush
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Brush, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Brush, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SlateBrushAsset");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Brush = 0;
	}
}