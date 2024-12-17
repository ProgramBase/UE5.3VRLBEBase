using Script.CoreUObject;
using Script.Slate;
using Script.SlateCore;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.TextLayoutWidget")]
	public partial class UTextLayoutWidget : UWidget, IStaticClass
	{
		public FShapedTextOptions ShapedTextOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShapedTextOptions, __ReturnBuffer);

					return *(FShapedTextOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShapedTextOptions, __InBuffer);
				}
			}
		}

		public ETextJustify Justification
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Justification, __ReturnBuffer);

					return *(ETextJustify*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Justification, __InBuffer);
				}
			}
		}

		public ETextWrappingPolicy WrappingPolicy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WrappingPolicy, __ReturnBuffer);

					return *(ETextWrappingPolicy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WrappingPolicy, __InBuffer);
				}
			}
		}

		public bool AutoWrapText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoWrapText, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoWrapText, __InBuffer);
				}
			}
		}

		public float WrapTextAt
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WrapTextAt, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WrapTextAt, __InBuffer);
				}
			}
		}

		public FMargin Margin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Margin, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Margin, __InBuffer);
				}
			}
		}

		public float LineHeightPercentage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LineHeightPercentage, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LineHeightPercentage, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.TextLayoutWidget");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetJustification(ETextJustify InJustification)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InJustification;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetJustification, __InBuffer);
			}
		}

		private static uint __ShapedTextOptions = 0;

		private static uint __Justification = 0;

		private static uint __WrappingPolicy = 0;

		private static uint __AutoWrapText = 0;

		private static uint __WrapTextAt = 0;

		private static uint __Margin = 0;

		private static uint __LineHeightPercentage = 0;

		private static uint __SetJustification = 0;
	}
}