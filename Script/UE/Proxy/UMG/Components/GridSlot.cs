using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.GridSlot")]
	public partial class UGridSlot : UPanelSlot, IStaticClass
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

		public int Row
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Row, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Row, __InBuffer);
				}
			}
		}

		public int RowSpan
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RowSpan, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RowSpan, __InBuffer);
				}
			}
		}

		public int Column
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Column, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Column, __InBuffer);
				}
			}
		}

		public int ColumnSpan
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColumnSpan, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColumnSpan, __InBuffer);
				}
			}
		}

		public int Layer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Layer, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Layer, __InBuffer);
				}
			}
		}

		public FVector2D Nudge
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Nudge, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Nudge, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.GridSlot");
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

		public virtual void SetRowSpan(int InRowSpan)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InRowSpan;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRowSpan, __InBuffer);
			}
		}

		public virtual void SetRow(int InRow)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InRow;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRow, __InBuffer);
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

		public virtual void SetNudge(FVector2D InNudge)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InNudge?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNudge, __InBuffer);
			}
		}

		public virtual void SetLayer(int InLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InLayer;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLayer, __InBuffer);
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

		public virtual void SetColumnSpan(int InColumnSpan)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InColumnSpan;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetColumnSpan, __InBuffer);
			}
		}

		public virtual void SetColumn(int InColumn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InColumn;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetColumn, __InBuffer);
			}
		}

		private static uint __Padding = 0;

		private static uint __HorizontalAlignment = 0;

		private static uint __VerticalAlignment = 0;

		private static uint __Row = 0;

		private static uint __RowSpan = 0;

		private static uint __Column = 0;

		private static uint __ColumnSpan = 0;

		private static uint __Layer = 0;

		private static uint __Nudge = 0;

		private static uint __SetVerticalAlignment = 0;

		private static uint __SetRowSpan = 0;

		private static uint __SetRow = 0;

		private static uint __SetPadding = 0;

		private static uint __SetNudge = 0;

		private static uint __SetLayer = 0;

		private static uint __SetHorizontalAlignment = 0;

		private static uint __SetColumnSpan = 0;

		private static uint __SetColumn = 0;
	}
}