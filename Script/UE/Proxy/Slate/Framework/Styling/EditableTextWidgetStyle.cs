using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.EditableTextWidgetStyle")]
	public partial class UEditableTextWidgetStyle : USlateWidgetStyleContainerBase, IStaticClass
	{
		public FEditableTextStyle EditableTextStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditableTextStyle, __ReturnBuffer);

					return *(FEditableTextStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditableTextStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.EditableTextWidgetStyle");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EditableTextStyle = 0;
	}
}