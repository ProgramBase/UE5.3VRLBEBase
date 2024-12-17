using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UniformGridPanel")]
	public partial class UUniformGridPanel : UPanelWidget, IStaticClass
	{
		public FMargin SlotPadding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SlotPadding, __ReturnBuffer);

					return *(FMargin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SlotPadding, __InBuffer);
				}
			}
		}

		public float MinDesiredSlotWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinDesiredSlotWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinDesiredSlotWidth, __InBuffer);
				}
			}
		}

		public float MinDesiredSlotHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinDesiredSlotHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinDesiredSlotHeight, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.UniformGridPanel");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSlotPadding(FMargin InSlotPadding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSlotPadding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSlotPadding, __InBuffer);
			}
		}

		public virtual void SetMinDesiredSlotWidth(float InMinDesiredSlotWidth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InMinDesiredSlotWidth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMinDesiredSlotWidth, __InBuffer);
			}
		}

		public virtual void SetMinDesiredSlotHeight(float InMinDesiredSlotHeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InMinDesiredSlotHeight;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMinDesiredSlotHeight, __InBuffer);
			}
		}

		public virtual UUniformGridSlot AddChildToUniformGrid(UWidget Content, int InRow = 0, int InColumn = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InRow;

				*(int*)(__InBuffer + 12) = InColumn;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddChildToUniformGrid, __InBuffer, __ReturnBuffer);

				return *(UUniformGridSlot*)__ReturnBuffer;
			}
		}

		private static uint __SlotPadding = 0;

		private static uint __MinDesiredSlotWidth = 0;

		private static uint __MinDesiredSlotHeight = 0;

		private static uint __SetSlotPadding = 0;

		private static uint __SetMinDesiredSlotWidth = 0;

		private static uint __SetMinDesiredSlotHeight = 0;

		private static uint __AddChildToUniformGrid = 0;
	}
}