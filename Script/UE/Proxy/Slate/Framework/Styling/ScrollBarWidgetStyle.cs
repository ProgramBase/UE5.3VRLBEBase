using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.ScrollBarWidgetStyle")]
	public partial class UScrollBarWidgetStyle : USlateWidgetStyleContainerBase, IStaticClass
	{
		public FScrollBarStyle ScrollBarStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollBarStyle, __ReturnBuffer);

					return *(FScrollBarStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollBarStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.ScrollBarWidgetStyle");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ScrollBarStyle = 0;
	}
}