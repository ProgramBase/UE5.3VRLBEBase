using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.GameViewportSubsystem")]
	public partial class UGameViewportSubsystem : UEngineSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.GameViewportSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Position">
		/// The 2D position to set the widget to in the viewport.
		/// </param>
		/// <param name="bRemoveDPIScale">
		/// If you've already calculated inverse DPI, set this to false.
		/// Otherwise inverse DPI is applied to the position so that when the location is scaled
		/// by DPI, it ends up in the expected position.
		/// </param>
		public static FGameViewportWidgetSlot SetWidgetSlotPosition(FGameViewportWidgetSlot Slot, UWidget Widget, FVector2D Position, bool bRemoveDPIScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Slot?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bRemoveDPIScale;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetWidgetSlotPosition, __InBuffer, __ReturnBuffer);

				return *(FGameViewportWidgetSlot*)__ReturnBuffer;
			}
		}

		public static FGameViewportWidgetSlot SetWidgetSlotDesiredSize(FGameViewportWidgetSlot Slot, FVector2D Size)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Slot?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Size?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SetWidgetSlotDesiredSize, __InBuffer, __ReturnBuffer);

				return *(FGameViewportWidgetSlot*)__ReturnBuffer;
			}
		}

		public virtual void SetWidgetSlot(UWidget Widget, FGameViewportWidgetSlot Slot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Slot?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWidgetSlot, __InBuffer);
			}
		}

		public virtual void RemoveWidget(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveWidget, __InBuffer);
			}
		}

		/// <returns>
		/// true if the widget was added to the viewport using AddWidget or AddWidgetForPlayer. */
		/// </returns>
		public virtual bool IsWidgetAdded(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsWidgetAdded, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FGameViewportWidgetSlot GetWidgetSlot(UWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetWidgetSlot, __InBuffer, __ReturnBuffer);

				return *(FGameViewportWidgetSlot*)__ReturnBuffer;
			}
		}

		public virtual bool AddWidgetForPlayer(UWidget Widget, ULocalPlayer Player, FGameViewportWidgetSlot Slot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Slot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddWidgetForPlayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddWidget(UWidget Widget, FGameViewportWidgetSlot Slot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Slot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddWidget, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetWidgetSlotPosition = 0;

		private static uint __SetWidgetSlotDesiredSize = 0;

		private static uint __SetWidgetSlot = 0;

		private static uint __RemoveWidget = 0;

		private static uint __IsWidgetAdded = 0;

		private static uint __GetWidgetSlot = 0;

		private static uint __AddWidgetForPlayer = 0;

		private static uint __AddWidget = 0;
	}
}