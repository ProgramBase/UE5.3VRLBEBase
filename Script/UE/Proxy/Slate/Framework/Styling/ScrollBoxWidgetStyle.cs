using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.ScrollBoxWidgetStyle")]
	public partial class UScrollBoxWidgetStyle : USlateWidgetStyleContainerBase, IStaticClass
	{
		public FScrollBoxStyle ScrollBoxStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollBoxStyle, __ReturnBuffer);

					return *(FScrollBoxStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScrollBoxStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.ScrollBoxWidgetStyle");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ScrollBoxStyle = 0;
	}
}