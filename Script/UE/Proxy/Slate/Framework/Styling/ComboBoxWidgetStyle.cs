using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.ComboBoxWidgetStyle")]
	public partial class UComboBoxWidgetStyle : USlateWidgetStyleContainerBase, IStaticClass
	{
		public FComboBoxStyle ComboBoxStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComboBoxStyle, __ReturnBuffer);

					return *(FComboBoxStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComboBoxStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.ComboBoxWidgetStyle");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ComboBoxStyle = 0;
	}
}