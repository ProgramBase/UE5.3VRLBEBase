using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.ProgressWidgetStyle")]
	public partial class UProgressWidgetStyle : USlateWidgetStyleContainerBase, IStaticClass
	{
		public FProgressBarStyle ProgressBarStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProgressBarStyle, __ReturnBuffer);

					return *(FProgressBarStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProgressBarStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.ProgressWidgetStyle");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ProgressBarStyle = 0;
	}
}