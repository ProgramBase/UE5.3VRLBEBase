using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.SpinBoxWidgetStyle")]
	public partial class USpinBoxWidgetStyle : USlateWidgetStyleContainerBase, IStaticClass
	{
		public FSpinBoxStyle SpinBoxStyle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpinBoxStyle, __ReturnBuffer);

					return *(FSpinBoxStyle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpinBoxStyle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Slate.SpinBoxWidgetStyle");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SpinBoxStyle = 0;
	}
}