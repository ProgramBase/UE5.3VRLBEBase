using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneScriptingDoubleKey")]
	public partial class UMovieSceneScriptingDoubleKey : UMovieSceneScriptingKey, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneScriptingDoubleKey");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InNewValue">
		/// The new double value for this key.
		/// </param>
		public virtual void SetValue(double InNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = InNewValue;

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

		/// <param name="InNewValue">
		/// Specifies which tangent weights should be respected when evaluating the key. 
		/// </param>
		public virtual void SetTangentWeightMode(ERichCurveTangentWeightMode InNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTangentWeightMode, __InBuffer);
			}
		}

		/// <param name="InNewValue">
		/// Tangent mode that this key should use to specify which tangent values are respected when evaluating. See ERichCurveTangentMode for more details.
		/// </param>
		public virtual void SetTangentMode(ERichCurveTangentMode InNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTangentMode, __InBuffer);
			}
		}

		/// <param name="InNewValue">
		/// Specifies the new leaving tangent weight. Represents the length of the hypotenuse in the form of "sqrt(x*x+y*y)" using the same definitions for x and y as tangents.
		/// </param>
		public virtual void SetLeaveTangentWeight(float InNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLeaveTangentWeight, __InBuffer);
			}
		}

		/// <param name="InNewValue">
		/// Represents the geometric tangents in the form of "tan(y/x)" where y is the key's value and x is the seconds (both relative to key)
		/// </param>
		public virtual void SetLeaveTangent(float InNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLeaveTangent, __InBuffer);
			}
		}

		/// <param name="InNewValue">
		/// Interpolation mode this key should use to interpolate between this key and the next.
		/// </param>
		public virtual void SetInterpolationMode(ERichCurveInterpMode InNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInterpolationMode, __InBuffer);
			}
		}

		/// <param name="InNewValue">
		/// Specifies the new arriving tangent weight. Represents the length of the hypotenuse in the form of "sqrt(x*x+y*y)" using the same definitions for x and y as tangents.
		/// </param>
		public virtual void SetArriveTangentWeight(float InNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetArriveTangentWeight, __InBuffer);
			}
		}

		/// <param name="InNewValue">
		/// Represents the geometric tangents in the form of "tan(y/x)" where y is the key's value and x is the seconds (both relative to key)
		/// </param>
		public virtual void SetArriveTangent(float InNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetArriveTangent, __InBuffer);
			}
		}

		/// <returns>
		/// The double value this key represents.
		/// </returns>
		public virtual double GetValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetValue, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
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

		/// <returns>
		/// Tangent Weight Mode. See ERichCurveTangentWeightMode for more detail on what each mode does.
		/// </returns>
		public virtual ERichCurveTangentWeightMode GetTangentWeightMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTangentWeightMode, __ReturnBuffer);

				return *(ERichCurveTangentWeightMode*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Tangent mode that this key is using specifying which tangent values are respected when evaluating.
		/// </returns>
		public virtual ERichCurveTangentMode GetTangentMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTangentMode, __ReturnBuffer);

				return *(ERichCurveTangentMode*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Tangent Weight. Represents the length of the hypotenuse in the form of "sqrt(x*x+y*y)" using the same definitions for x and y as tangents.
		/// </returns>
		public virtual float GetLeaveTangentWeight()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLeaveTangentWeight, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Leaving Tangent value. Represents the geometric tangents in the form of "tan(y/x)" where y is the key's value and x is the seconds (both relative to key)
		/// </returns>
		public virtual float GetLeaveTangent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLeaveTangent, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Interpolation mode this key uses to interpolate between this key and the next.
		/// </returns>
		public virtual ERichCurveInterpMode GetInterpolationMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetInterpolationMode, __ReturnBuffer);

				return *(ERichCurveInterpMode*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Tangent Weight. Represents the length of the hypotenuse in the form of "sqrt(x*x+y*y)" using the same definitions for x and y as tangents.
		/// </returns>
		public virtual float GetArriveTangentWeight()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetArriveTangentWeight, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Arrival Tangent value. Represents the geometric tangents in the form of "tan(y/x)" where y is the key's value and x is the seconds (both relative to key)
		/// </returns>
		public virtual float GetArriveTangent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetArriveTangent, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __SetValue = 0;

		private static uint __SetTime = 0;

		private static uint __SetTangentWeightMode = 0;

		private static uint __SetTangentMode = 0;

		private static uint __SetLeaveTangentWeight = 0;

		private static uint __SetLeaveTangent = 0;

		private static uint __SetInterpolationMode = 0;

		private static uint __SetArriveTangentWeight = 0;

		private static uint __SetArriveTangent = 0;

		private static uint __GetValue = 0;

		private static uint __GetTime = 0;

		private static uint __GetTangentWeightMode = 0;

		private static uint __GetTangentMode = 0;

		private static uint __GetLeaveTangentWeight = 0;

		private static uint __GetLeaveTangent = 0;

		private static uint __GetInterpolationMode = 0;

		private static uint __GetArriveTangentWeight = 0;

		private static uint __GetArriveTangent = 0;
	}
}