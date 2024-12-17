using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.UMG
{
	[PathName("/Script/UMG.WindowTitleBarArea")]
	public partial class UWindowTitleBarArea : UContentWidget, IStaticClass
	{
		public bool bWindowButtonsEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bWindowButtonsEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bWindowButtonsEnabled, __InBuffer);
				}
			}
		}

		public bool bDoubleClickTogglesFullscreen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDoubleClickTogglesFullscreen, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDoubleClickTogglesFullscreen, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WindowTitleBarArea");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InVerticalAlignment;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVerticalAlignment, __InBuffer);
			}
		}

		public virtual void SetPadding(FMargin InPadding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPadding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPadding, __InBuffer);
			}
		}

		public virtual void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InHorizontalAlignment;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHorizontalAlignment, __InBuffer);
			}
		}

		private static uint __bWindowButtonsEnabled = 0;

		private static uint __bDoubleClickTogglesFullscreen = 0;

		private static uint __SetVerticalAlignment = 0;

		private static uint __SetPadding = 0;

		private static uint __SetHorizontalAlignment = 0;
	}
}