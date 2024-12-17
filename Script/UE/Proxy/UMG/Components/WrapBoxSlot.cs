using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WrapBoxSlot")]
	public partial class UWrapBoxSlot : UPanelSlot, IStaticClass
	{
		public FMargin Padding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Padding, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Padding, __InBuffer);
				}
			}
		}

		public float FillSpanWhenLessThan
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FillSpanWhenLessThan, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FillSpanWhenLessThan, __InBuffer);
				}
			}
		}

		public EHorizontalAlignment HorizontalAlignment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HorizontalAlignment, __ReturnBuffer);

					return *(EHorizontalAlignment*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HorizontalAlignment, __InBuffer);
				}
			}
		}

		public EVerticalAlignment VerticalAlignment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VerticalAlignment, __ReturnBuffer);

					return *(EVerticalAlignment*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VerticalAlignment, __InBuffer);
				}
			}
		}

		public bool bFillEmptySpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFillEmptySpace, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFillEmptySpace, __InBuffer);
				}
			}
		}

		public bool bForceNewLine
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceNewLine, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceNewLine, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WrapBoxSlot");
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

		public virtual void SetNewLine(bool InForceNewLine)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InForceNewLine;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNewLine, __InBuffer);
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

		public virtual void SetFillSpanWhenLessThan(float InFillSpanWhenLessThan)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InFillSpanWhenLessThan;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFillSpanWhenLessThan, __InBuffer);
			}
		}

		public virtual void SetFillEmptySpace(bool InbFillEmptySpace)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InbFillEmptySpace;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFillEmptySpace, __InBuffer);
			}
		}

		private static uint __Padding = 0;

		private static uint __FillSpanWhenLessThan = 0;

		private static uint __HorizontalAlignment = 0;

		private static uint __VerticalAlignment = 0;

		private static uint __bFillEmptySpace = 0;

		private static uint __bForceNewLine = 0;

		private static uint __SetVerticalAlignment = 0;

		private static uint __SetPadding = 0;

		private static uint __SetNewLine = 0;

		private static uint __SetHorizontalAlignment = 0;

		private static uint __SetFillSpanWhenLessThan = 0;

		private static uint __SetFillEmptySpace = 0;
	}
}