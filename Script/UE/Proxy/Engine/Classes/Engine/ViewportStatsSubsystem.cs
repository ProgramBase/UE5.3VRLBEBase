using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ViewportStatsSubsystem")]
	public partial class UViewportStatsSubsystem : UWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ViewportStatsSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="IndexToRemove">
		/// The index in the DisplayDelegates array to remove. 
		/// This is the value returned from AddDisplayDelegate.
		/// </param>
		public virtual void RemoveDisplayDelegate(int IndexToRemove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = IndexToRemove;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveDisplayDelegate, __InBuffer);
			}
		}

		/// <param name="Text">
		/// The text to be displayed
		/// </param>
		/// <param name="Color">
		/// Color of the text to be displayed
		/// </param>
		/// <param name="Duration">
		/// How long the text will be on screen, if 0 then it will stay indefinitely
		/// </param>
		/// <param name="DisplayOffset">
		/// A position offset that the message should use when displayed. 
		/// </param>
		public virtual void AddTimedDisplay(FText Text, FLinearColor Color = null, float Duration = 0.000000f, FVector2D DisplayOffset = null)
		{
			unsafe
			{
				Color ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				DisplayOffset ??= new FVector2D();

				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Color?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Duration;

				*(nint*)(__InBuffer + 20) = DisplayOffset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddTimedDisplay, __InBuffer);
			}
		}

		/// <param name="Callback">
		/// The callback the subsystem will use to determine if a message should be displayed or not
		/// Signature of callbacks should be: bool(FText& OutTest, FLinearColor& OutColor)
		/// </param>
		public virtual int AddDisplayDelegate(FViewportDisplayCallback Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddDisplayDelegate, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __RemoveDisplayDelegate = 0;

		private static uint __AddTimedDisplay = 0;

		private static uint __AddDisplayDelegate = 0;
	}
}