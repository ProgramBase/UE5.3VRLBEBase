using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.ComboButtonWidgetStyle")]
	public partial class UComboButtonWidgetStyle : USlateWidgetStyleContainerBase, IStaticClass
	{
		public FComboButtonStyle ComboButtonStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComboButtonStyle, __ReturnBuffer);

					return *(FComboButtonStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComboButtonStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.ComboButtonWidgetStyle");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ComboButtonStyle = 0;
	}
}