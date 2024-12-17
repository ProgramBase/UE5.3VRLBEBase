using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TimelineComponent")]
	public partial class UTimelineComponent : UActorComponent, IStaticClass
	{
		public FTimeline TheTimeline
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TheTimeline, __ReturnBuffer);

					return *(FTimeline*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TheTimeline, __InBuffer);
				}
			}
		}

		public bool bIgnoreTimeDilation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreTimeDilation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreTimeDilation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TimelineComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Stop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Stop);
			}
		}

		public virtual void SetVectorCurve(UCurveVector NewVectorCurve, FName VectorTrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewVectorCurve?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VectorTrackName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVectorCurve, __InBuffer);
			}
		}

		public virtual void SetTimelinePostUpdateFunc(FOnTimelineEvent NewTimelinePostUpdateFunc)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTimelinePostUpdateFunc?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTimelinePostUpdateFunc, __InBuffer);
			}
		}

		public virtual void SetTimelineLengthMode(ETimelineLengthMode NewLengthMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewLengthMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTimelineLengthMode, __InBuffer);
			}
		}

		public virtual void SetTimelineLength(float NewLength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewLength;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTimelineLength, __InBuffer);
			}
		}

		public virtual void SetTimelineFinishedFunc(FOnTimelineEvent NewTimelineFinishedFunc)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTimelineFinishedFunc?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTimelineFinishedFunc, __InBuffer);
			}
		}

		public virtual void SetPlayRate(float NewRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewRate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlayRate, __InBuffer);
			}
		}

		/// <param name="bFireEvents">
		/// If true, event functions that are between current position and new playback position will fire. 
		/// </param>
		/// <param name="bFireUpdate">
		/// If true, the update output exec will fire after setting the new playback position.
		/// </param>
		public virtual void SetPlaybackPosition(float NewPosition, bool bFireEvents, bool bFireUpdate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = NewPosition;

				*(bool*)(__InBuffer + 4) = bFireEvents;

				*(bool*)(__InBuffer + 5) = bFireUpdate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaybackPosition, __InBuffer);
			}
		}

		public virtual void SetNewTime(float NewTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNewTime, __InBuffer);
			}
		}

		public virtual void SetLooping(bool bNewLooping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewLooping;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLooping, __InBuffer);
			}
		}

		public virtual void SetLinearColorCurve(UCurveLinearColor NewLinearColorCurve, FName LinearColorTrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewLinearColorCurve?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LinearColorTrackName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearColorCurve, __InBuffer);
			}
		}

		public virtual void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewIgnoreTimeDilation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIgnoreTimeDilation, __InBuffer);
			}
		}

		public virtual void SetFloatCurve(UCurveFloat NewFloatCurve, FName FloatTrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewFloatCurve?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FloatTrackName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFloatCurve, __InBuffer);
			}
		}

		public virtual void ReverseFromEnd()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ReverseFromEnd);
			}
		}

		public virtual void Reverse()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Reverse);
			}
		}

		public virtual void PlayFromStart()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PlayFromStart);
			}
		}

		public virtual void Play()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Play);
			}
		}

		public virtual void OnRep_Timeline(ref FTimeline OldTimeline)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OldTimeline?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __OnRep_Timeline, __InBuffer, __OutBuffer);

				OldTimeline = *(FTimeline*)(__OutBuffer);

			}
		}

		public virtual bool IsReversing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsReversing, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPlaying()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPlaying, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsLooping()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLooping, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetTimelineLength()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTimelineLength, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetScaledTimelineLength()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetScaledTimelineLength, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetPlayRate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlayRate, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetPlaybackPosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlaybackPosition, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual bool GetIgnoreTimeDilation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetIgnoreTimeDilation, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void AddInterpVector(UCurveVector VectorCurve, FOnTimelineVector InterpFunc, FName PropertyName = null, FName TrackName = null)
		{
			unsafe
			{
				PropertyName ??= new FName("None");

				TrackName ??= new FName("None");

				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = VectorCurve?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InterpFunc?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddInterpVector, __InBuffer);
			}
		}

		public virtual void AddInterpLinearColor(UCurveLinearColor LinearColorCurve, FOnTimelineLinearColor InterpFunc, FName PropertyName = null, FName TrackName = null)
		{
			unsafe
			{
				PropertyName ??= new FName("None");

				TrackName ??= new FName("None");

				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = LinearColorCurve?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InterpFunc?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddInterpLinearColor, __InBuffer);
			}
		}

		public virtual void AddInterpFloat(UCurveFloat FloatCurve, FOnTimelineFloat InterpFunc, FName PropertyName = null, FName TrackName = null)
		{
			unsafe
			{
				PropertyName ??= new FName("None");

				TrackName ??= new FName("None");

				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = FloatCurve?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InterpFunc?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddInterpFloat, __InBuffer);
			}
		}

		public virtual void AddEvent(float Time, FOnTimelineEvent EventFunc)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = Time;

				*(nint*)(__InBuffer + 4) = EventFunc?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddEvent, __InBuffer);
			}
		}

		private static uint __TheTimeline = 0;

		private static uint __bIgnoreTimeDilation = 0;

		private static uint __Stop = 0;

		private static uint __SetVectorCurve = 0;

		private static uint __SetTimelinePostUpdateFunc = 0;

		private static uint __SetTimelineLengthMode = 0;

		private static uint __SetTimelineLength = 0;

		private static uint __SetTimelineFinishedFunc = 0;

		private static uint __SetPlayRate = 0;

		private static uint __SetPlaybackPosition = 0;

		private static uint __SetNewTime = 0;

		private static uint __SetLooping = 0;

		private static uint __SetLinearColorCurve = 0;

		private static uint __SetIgnoreTimeDilation = 0;

		private static uint __SetFloatCurve = 0;

		private static uint __ReverseFromEnd = 0;

		private static uint __Reverse = 0;

		private static uint __PlayFromStart = 0;

		private static uint __Play = 0;

		private static uint __OnRep_Timeline = 0;

		private static uint __IsReversing = 0;

		private static uint __IsPlaying = 0;

		private static uint __IsLooping = 0;

		private static uint __GetTimelineLength = 0;

		private static uint __GetScaledTimelineLength = 0;

		private static uint __GetPlayRate = 0;

		private static uint __GetPlaybackPosition = 0;

		private static uint __GetIgnoreTimeDilation = 0;

		private static uint __AddInterpVector = 0;

		private static uint __AddInterpLinearColor = 0;

		private static uint __AddInterpFloat = 0;

		private static uint __AddEvent = 0;
	}
}