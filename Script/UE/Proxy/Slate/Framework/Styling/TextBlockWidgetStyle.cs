using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.TextBlockWidgetStyle")]
	public partial class UTextBlockWidgetStyle : USlateWidgetStyleContainerBase, IStaticClass
	{
		public FTextBlockStyle TextBlockStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextBlockStyle, __ReturnBuffer);

					return *(FTextBlockStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextBlockStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.TextBlockWidgetStyle");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TextBlockStyle = 0;
	}
}