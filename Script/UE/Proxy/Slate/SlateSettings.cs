using Script.CoreUObject;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.SlateSettings")]
	public partial class USlateSettings : UObject, IStaticClass
	{
		public bool bExplicitCanvasChildZOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExplicitCanvasChildZOrder, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExplicitCanvasChildZOrder, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.SlateSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bExplicitCanvasChildZOrder = 0;
	}
}