using Script.CoreUObject;
using Script.Library;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneScriptingBoolKey")]
	public partial class UMovieSceneScriptingBoolKey : UMovieSceneScriptingKey, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneScriptingBoolKey");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InNewValue">
		/// The new value for this key.
		/// </param>
		public virtual void SetValue(bool InNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValue, __InBuffer);
			}
		}

		/// <param name="NewFrameNumber">
		/// What frame should this key be moved to? This should be in the time unit specified by TimeUnit.
		/// </param>
		/// <param name="SubFrame">
		/// If using Display Rate time, what is the sub-frame this should go to? Clamped [0-1), and ignored with when TimeUnit is set to Tick Resolution.
		/// </param>
		/// <param name="TimeUnit">
		/// Should the NewFrameNumber be interpreted as Display Rate frames or in Tick Resolution?
		/// </param>
		public virtual void SetTime(FFrameNumber NewFrameNumber, float SubFrame = 0.000000f, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = NewFrameNumber?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = SubFrame;

				*(byte*)(__InBuffer + 12) = (byte)TimeUnit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTime, __InBuffer);
			}
		}

		/// <returns>
		/// The value for this key.
		/// </returns>
		public virtual bool GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TimeUnit">
		/// Should the time be returned in Display Rate frames (possibly with a sub-frame value) or in Tick Resolution with no sub-frame values?
		/// </param>
		/// <returns>
		/// The time of this key which combines both the frame number and the sub-frame it is on. Sub-frame will be zero if you request Tick Resolution.
		/// </returns>
		public virtual FFrameTime GetTime(ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)TimeUnit;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetTime, __InBuffer, __ReturnBuffer);

				return *(FFrameTime*)__ReturnBuffer;
			}
		}

		private static uint __SetValue = 0;

		private static uint __SetTime = 0;

		private static uint __GetValue = 0;

		private static uint __GetTime = 0;
	}
}