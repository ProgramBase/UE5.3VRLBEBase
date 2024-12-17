using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.MovieScene;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneScriptingDoubleChannel")]
	public partial class UMovieSceneScriptingDoubleChannel : UMovieSceneScriptingChannel, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneScriptingDoubleChannel");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InExtrapolation">
		/// The new extrapolation mode this key should use for evaluating before this key.
		/// </param>
		public virtual void SetPreInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InExtrapolation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPreInfinityExtrapolation, __InBuffer);
			}
		}

		/// <param name="InExtrapolation">
		/// The new extrapolation mode this key should use for evaluating after this key.
		/// </param>
		public virtual void SetPostInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InExtrapolation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPostInfinityExtrapolation, __InBuffer);
			}
		}

		public virtual void SetDefault(double InDefaultValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = InDefaultValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefault, __InBuffer);
			}
		}

		public virtual void RemoveKey(UMovieSceneScriptingKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Key?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveKey, __InBuffer);
			}
		}

		public virtual void RemoveDefault()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RemoveDefault);
			}
		}

		/// <returns>
		/// Does this channel have a default value set?
		/// </returns>
		public virtual bool HasDefault()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasDefault, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Gets the Pre-infinity extrapolation state. See ERichCurveExtrapolation for more detail.
		/// </returns>
		public virtual ERichCurveExtrapolation GetPreInfinityExtrapolation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPreInfinityExtrapolation, __ReturnBuffer);

				return *(ERichCurveExtrapolation*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Gets the Post-infinity extrapolation state. See ERichCurveExtrapolation for more detail.
		/// </returns>
		public virtual ERichCurveExtrapolation GetPostInfinityExtrapolation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPostInfinityExtrapolation, __ReturnBuffer);

				return *(ERichCurveExtrapolation*)__ReturnBuffer;
			}
		}

		public virtual int GetNumKeys()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumKeys, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// An array of UMovieSceneScriptingDoubleKey's contained by this channel.
		/// Returns all keys even if clipped by the owning section's boundaries or outside of the current sequence play range.
		/// </returns>
		public virtual TArray<UMovieSceneScriptingKey> GetKeys()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetKeys, __ReturnBuffer);

				return *(TArray<UMovieSceneScriptingKey>*)__ReturnBuffer;
			}
		}

		public virtual double GetDefault()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDefault, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// An array of double's contained by this channel.
		/// Returns baked keys in the specified range.
		/// </returns>
		public virtual TArray<double> EvaluateKeys(FSequencerScriptingRange Range, FFrameRate FrameRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Range?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FrameRate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __EvaluateKeys, __InBuffer, __ReturnBuffer);

				return *(TArray<double>*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// A range that represents the greatest range of times occupied by this channel, in the sequence's frame resolution
		/// </returns>
		public virtual FSequencerScriptingRange ComputeEffectiveRange()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __ComputeEffectiveRange, __ReturnBuffer);

				return *(FSequencerScriptingRange*)__ReturnBuffer;
			}
		}

		/// <param name="InTime">
		/// The frame this key should go on. Respects TimeUnit to determine if it is a display rate frame or a tick resolution frame.
		/// </param>
		/// <param name="NewValue">
		/// The value that this key should be created with.
		/// </param>
		/// <param name="SubFrame">
		/// Optional [0-1) clamped sub-frame to put this key on. Ignored if TimeUnit is set to Tick Resolution.
		/// </param>
		/// <param name="TimeUnit">
		/// Is the specified InTime in Display Rate frames or Tick Resolution.
		/// </param>
		/// <param name="InInterpolation">
		/// Interpolation method the key should use.
		/// </param>
		/// <returns>
		/// The key that was created with the specified values at the specified time.
		/// </returns>
		public virtual UMovieSceneScriptingDoubleKey AddKey(FFrameNumber InTime, double NewValue, float SubFrame = 0.000000f, ESequenceTimeUnit TimeUnit = ESequenceTimeUnit.DisplayRate, EMovieSceneKeyInterpolation InInterpolation = EMovieSceneKeyInterpolation.Auto)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = InTime?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = NewValue;

				*(float*)(__InBuffer + 16) = SubFrame;

				*(byte*)(__InBuffer + 20) = (byte)TimeUnit;

				*(byte*)(__InBuffer + 21) = (byte)InInterpolation;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddKey, __InBuffer, __ReturnBuffer);

				return *(UMovieSceneScriptingDoubleKey*)__ReturnBuffer;
			}
		}

		private static uint __SetPreInfinityExtrapolation = 0;

		private static uint __SetPostInfinityExtrapolation = 0;

		private static uint __SetDefault = 0;

		private static uint __RemoveKey = 0;

		private static uint __RemoveDefault = 0;

		private static uint __HasDefault = 0;

		private static uint __GetPreInfinityExtrapolation = 0;

		private static uint __GetPostInfinityExtrapolation = 0;

		private static uint __GetNumKeys = 0;

		private static uint __GetKeys = 0;

		private static uint __GetDefault = 0;

		private static uint __EvaluateKeys = 0;

		private static uint __ComputeEffectiveRange = 0;

		private static uint __AddKey = 0;
	}
}