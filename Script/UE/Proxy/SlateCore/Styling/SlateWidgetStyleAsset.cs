using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.SlateWidgetStyleAsset")]
	public partial class USlateWidgetStyleAsset : UObject, IStaticClass
	{
		public USlateWidgetStyleContainerBase CustomStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomStyle, __ReturnBuffer);

					return *(USlateWidgetStyleContainerBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SlateCore.SlateWidgetStyleAsset");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CustomStyle = 0;
	}
}