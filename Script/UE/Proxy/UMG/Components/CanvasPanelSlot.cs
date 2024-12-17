using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;
using Script.Slate;

namespace Script.UMG
{
	[PathName("/Script/UMG.CanvasPanelSlot")]
	public partial class UCanvasPanelSlot : UPanelSlot, IStaticClass
	{
		public FAnchorData LayoutData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LayoutData, __ReturnBuffer);

					return *(FAnchorData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LayoutData, __InBuffer);
				}
			}
		}

		public bool bAutoSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoSize, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoSize, __InBuffer);
				}
			}
		}

		public int ZOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ZOrder, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ZOrder, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.CanvasPanelSlot");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetZOrder(int InZOrder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InZOrder;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetZOrder, __InBuffer);
			}
		}

		public virtual void SetSize(FVector2D InSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSize?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSize, __InBuffer);
			}
		}

		public virtual void SetPosition(FVector2D InPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPosition, __InBuffer);
			}
		}

		public virtual void SetOffsets(FMargin InOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InOffset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOffsets, __InBuffer);
			}
		}

		public virtual void SetMinimum(FVector2D InMinimumAnchors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMinimumAnchors?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMinimum, __InBuffer);
			}
		}

		public virtual void SetMaximum(FVector2D InMaximumAnchors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMaximumAnchors?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaximum, __InBuffer);
			}
		}

		public virtual void SetLayout(FAnchorData InLayoutData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLayoutData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLayout, __InBuffer);
			}
		}

		public virtual void SetAutoSize(bool InbAutoSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InbAutoSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAutoSize, __InBuffer);
			}
		}

		public virtual void SetAnchors(FAnchors InAnchors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnchors?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnchors, __InBuffer);
			}
		}

		public virtual void SetAlignment(FVector2D InAlignment)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAlignment?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAlignment, __InBuffer);
			}
		}

		public virtual int GetZOrder()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetZOrder, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSize, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetPosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPosition, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public virtual FMargin GetOffsets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOffsets, __ReturnBuffer);

				return *(FMargin*)__ReturnBuffer;
			}
		}

		public virtual FAnchorData GetLayout()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLayout, __ReturnBuffer);

				return *(FAnchorData*)__ReturnBuffer;
			}
		}

		public virtual bool GetAutoSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAutoSize, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FAnchors GetAnchors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAnchors, __ReturnBuffer);

				return *(FAnchors*)__ReturnBuffer;
			}
		}

		public virtual FVector2D GetAlignment()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAlignment, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		private static uint __LayoutData = 0;

		private static uint __bAutoSize = 0;

		private static uint __ZOrder = 0;

		private static uint __SetZOrder = 0;

		private static uint __SetSize = 0;

		private static uint __SetPosition = 0;

		private static uint __SetOffsets = 0;

		private static uint __SetMinimum = 0;

		private static uint __SetMaximum = 0;

		private static uint __SetLayout = 0;

		private static uint __SetAutoSize = 0;

		private static uint __SetAnchors = 0;

		private static uint __SetAlignment = 0;

		private static uint __GetZOrder = 0;

		private static uint __GetSize = 0;

		private static uint __GetPosition = 0;

		private static uint __GetOffsets = 0;

		private static uint __GetLayout = 0;

		private static uint __GetAutoSize = 0;

		private static uint __GetAnchors = 0;

		private static uint __GetAlignment = 0;
	}
}