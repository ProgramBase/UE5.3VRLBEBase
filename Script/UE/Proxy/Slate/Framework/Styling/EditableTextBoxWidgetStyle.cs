using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.EditableTextBoxWidgetStyle")]
	public partial class UEditableTextBoxWidgetStyle : USlateWidgetStyleContainerBase, IStaticClass
	{
		public FEditableTextBoxStyle EditableTextBoxStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditableTextBoxStyle, __ReturnBuffer);

					return *(FEditableTextBoxStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditableTextBoxStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.EditableTextBoxWidgetStyle");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EditableTextBoxStyle = 0;
	}
}