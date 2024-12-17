using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNotifyLibrary")]
	public partial class UAnimNotifyLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimNotifyLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EventReference">
		/// The event to inspect
		/// </param>
		public static bool NotifyStateReachedEnd(FAnimNotifyEventReference EventReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotifyStateReachedEnd, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="EventReference">
		/// The event to inspect
		/// </param>
		/// <returns>
		/// the time as a ratio (0 -> 1) through the animation for when this notify was fired
		/// </returns>
		public static float GetCurrentAnimationTimeRatio(FAnimNotifyEventReference EventReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentAnimationTimeRatio, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="EventReference">
		/// The event to inspect
		/// </param>
		/// <returns>
		/// the time in seconds through the current animation for when this notify was fired
		/// </returns>
		public static float GetCurrentAnimationTime(FAnimNotifyEventReference EventReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentAnimationTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="EventReference">
		/// The event to inspect
		/// </param>
		/// <returns>
		/// the current time as a ratio (0 -> 1) relative to the start of the notify state
		/// </returns>
		public static float GetCurrentAnimationNotifyStateTimeRatio(FAnimNotifyEventReference EventReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentAnimationNotifyStateTimeRatio, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="EventReference">
		/// The event to inspect
		/// </param>
		/// <returns>
		/// the current time in seconds relative to the start of the notify state, clamped to the range of the
		/// notify state
		/// </returns>
		public static float GetCurrentAnimationNotifyStateTime(FAnimNotifyEventReference EventReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = EventReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentAnimationNotifyStateTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __NotifyStateReachedEnd = 0;

		private static uint __GetCurrentAnimationTimeRatio = 0;

		private static uint __GetCurrentAnimationTime = 0;

		private static uint __GetCurrentAnimationNotifyStateTimeRatio = 0;

		private static uint __GetCurrentAnimationNotifyStateTime = 0;
	}
}