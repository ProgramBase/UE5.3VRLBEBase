using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequencePlayer")]
	public partial class UMovieSceneSequencePlayer : UObject, IStaticClass, IMovieSceneSequenceTickManagerClient
	{
		public TScriptInterface<IMovieSceneSequencePlayerObserver> Observer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Observer, __ReturnBuffer);

					return *(TScriptInterface<IMovieSceneSequencePlayerObserver>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Observer, __InBuffer);
				}
			}
		}

		public FOnMovieSceneSequencePlayerEvent OnPlay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlay, __ReturnBuffer);

					return *(FOnMovieSceneSequencePlayerEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlay, __InBuffer);
				}
			}
		}

		public FOnMovieSceneSequencePlayerEvent OnPlayReverse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlayReverse, __ReturnBuffer);

					return *(FOnMovieSceneSequencePlayerEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlayReverse, __InBuffer);
				}
			}
		}

		public FOnMovieSceneSequencePlayerEvent OnStop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnStop, __ReturnBuffer);

					return *(FOnMovieSceneSequencePlayerEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnStop, __InBuffer);
				}
			}
		}

		public FOnMovieSceneSequencePlayerEvent OnPause
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPause, __ReturnBuffer);

					return *(FOnMovieSceneSequencePlayerEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPause, __InBuffer);
				}
			}
		}

		public FOnMovieSceneSequencePlayerEvent OnFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFinished, __ReturnBuffer);

					return *(FOnMovieSceneSequencePlayerEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnFinished, __InBuffer);
				}
			}
		}

		public EMovieScenePlayerStatus Status
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Status, __ReturnBuffer);

					return *(EMovieScenePlayerStatus*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Status, __InBuffer);
				}
			}
		}

		public bool bReversePlayback
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReversePlayback, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReversePlayback, __InBuffer);
				}
			}
		}

		public UMovieSceneSequence Sequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sequence, __ReturnBuffer);

					return *(UMovieSceneSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Sequence, __InBuffer);
				}
			}
		}

		public FFrameNumber StartTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartTime, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartTime, __InBuffer);
				}
			}
		}

		public int DurationFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DurationFrames, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DurationFrames, __InBuffer);
				}
			}
		}

		public float DurationSubFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DurationSubFrames, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DurationSubFrames, __InBuffer);
				}
			}
		}

		public int CurrentNumLoops
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentNumLoops, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentNumLoops, __InBuffer);
				}
			}
		}

		public int SerialNumber
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SerialNumber, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SerialNumber, __InBuffer);
				}
			}
		}

		public FMovieSceneSequencePlaybackSettings PlaybackSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaybackSettings, __ReturnBuffer);

					return *(FMovieSceneSequencePlaybackSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaybackSettings, __InBuffer);
				}
			}
		}

		public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootTemplateInstance, __ReturnBuffer);

					return *(FMovieSceneRootEvaluationTemplateInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootTemplateInstance, __InBuffer);
				}
			}
		}

		public FMovieSceneSequenceReplProperties NetSyncProps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetSyncProps, __ReturnBuffer);

					return *(FMovieSceneSequenceReplProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetSyncProps, __InBuffer);
				}
			}
		}

		public TScriptInterface<IMovieScenePlaybackClient> PlaybackClient
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaybackClient, __ReturnBuffer);

					return *(TScriptInterface<IMovieScenePlaybackClient>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaybackClient, __InBuffer);
				}
			}
		}

		public UMovieSceneSequenceTickManager TickManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TickManager, __ReturnBuffer);

					return *(UMovieSceneSequenceTickManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TickManager, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneSequencePlayer");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void StopAtCurrentTime()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopAtCurrentTime);
			}
		}

		public virtual void Stop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Stop);
			}
		}

		/// <note>
		/// : It is recommended that a weight between 0 and 1 is supplied, though this is not enforced
		/// </note>
		/// <note>
		/// : It is recommended that either FMovieSceneSequencePlaybackSettings::DynamicWeighting should be true for this player or the asset it's playing back should be set to enable dynamic weight to avoid undesirable behavior
		/// </note>
		/// <param name="InWeight">
		/// The weight to suuply to all elements in this sequence
		/// </param>
		public virtual void SetWeight(double InWeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = InWeight;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWeight, __InBuffer);
			}
		}

		/// <param name="StartTime">
		/// The time to start playing back the sequence in seconds
		/// </param>
		/// <param name="Duration">
		/// The length to play for
		/// </param>
		public virtual void SetTimeRange(float StartTime, float Duration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = StartTime;

				*(float*)(__InBuffer + 4) = Duration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTimeRange, __InBuffer);
			}
		}

		/// <param name="PlayRate">
		/// - The new rate of playback for the animation.
		/// </param>
		public virtual void SetPlayRate(float PlayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = PlayRate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlayRate, __InBuffer);
			}
		}

		/// <param name="PlaybackParams">
		/// The position settings (ie. the position to set playback to)
		/// </param>
		public virtual void SetPlaybackPosition(FMovieSceneSequencePlaybackParams PlaybackParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlaybackParams?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaybackPosition, __InBuffer);
			}
		}

		public virtual void SetFrameRate(FFrameRate FrameRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FrameRate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrameRate, __InBuffer);
			}
		}

		/// <param name="StartFrame">
		/// The frame number to start playing back the sequence
		/// </param>
		/// <param name="Duration">
		/// The number of frames to play
		/// </param>
		public virtual void SetFrameRange(int StartFrame, int Duration, float SubFrames = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = StartFrame;

				*(int*)(__InBuffer + 4) = Duration;

				*(float*)(__InBuffer + 8) = SubFrames;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrameRange, __InBuffer);
			}
		}

		public virtual void SetDisableCameraCuts(bool bInDisableCameraCuts)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInDisableCameraCuts;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDisableCameraCuts, __InBuffer);
			}
		}

		public virtual void Scrub()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Scrub);
			}
		}

		public virtual void RPC_OnStopEvent(FFrameTime StoppedTime, int NewSerialNumber)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = StoppedTime?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NewSerialNumber;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __RPC_OnStopEvent, __InBuffer);
			}
		}

		public virtual void RPC_OnFinishPlaybackEvent(FFrameTime StoppedTime, int NewSerialNumber)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = StoppedTime?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NewSerialNumber;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __RPC_OnFinishPlaybackEvent, __InBuffer);
			}
		}

		public virtual void RPC_ExplicitServerUpdateEvent(EUpdatePositionMethod Method, FFrameTime RelevantTime, int NewSerialNumber)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(byte*)(__InBuffer) = (byte)Method;

				*(nint*)(__InBuffer + 1) = RelevantTime?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 9) = NewSerialNumber;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __RPC_ExplicitServerUpdateEvent, __InBuffer);
			}
		}

		public virtual void RestoreState()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RestoreState);
			}
		}

		public virtual void RemoveWeight()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RemoveWeight);
			}
		}

		/// <param name="PlaybackParams">
		/// The position settings (ie. the position to play to)
		/// </param>
		public virtual void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams, FMovieSceneSequencePlayToParams PlayToParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PlaybackParams?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlayToParams?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PlayTo, __InBuffer);
			}
		}

		public virtual void PlayReverse()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PlayReverse);
			}
		}

		/// <param name="NumLoops">
		/// - The number of loops to play. -1 indicates infinite looping.
		/// </param>
		public virtual void PlayLooping(int NumLoops = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumLoops;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PlayLooping, __InBuffer);
			}
		}

		public virtual void Play()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Play);
			}
		}

		public virtual void Pause()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Pause);
			}
		}

		public virtual bool IsReversed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsReversed, __ReturnBuffer);

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

		public virtual bool IsPaused()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPaused, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GoToEndAndStop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __GoToEndAndStop);
			}
		}

		public virtual FQualifiedFrameTime GetStartTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetStartTime, __ReturnBuffer);

				return *(FQualifiedFrameTime*)__ReturnBuffer;
			}
		}

		/// <param name="bAddClientInfo">
		/// If true, add client index if running as a client
		/// </param>
		/// <returns>
		/// the name of the sequence, or None if no sequence is set
		/// </returns>
		public virtual FString GetSequenceName(bool bAddClientInfo = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bAddClientInfo;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSequenceName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the sequence currently assigned to this player
		/// </returns>
		public virtual UMovieSceneSequence GetSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSequence, __ReturnBuffer);

				return *(UMovieSceneSequence*)__ReturnBuffer;
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

		public virtual TArray<FMovieSceneObjectBindingID> GetObjectBindings(UObject InObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetObjectBindings, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneObjectBindingID>*)__ReturnBuffer;
			}
		}

		public virtual FFrameRate GetFrameRate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFrameRate, __ReturnBuffer);

				return *(FFrameRate*)__ReturnBuffer;
			}
		}

		public virtual int GetFrameDuration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFrameDuration, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FQualifiedFrameTime GetEndTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEndTime, __ReturnBuffer);

				return *(FQualifiedFrameTime*)__ReturnBuffer;
			}
		}

		public virtual FQualifiedFrameTime GetDuration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDuration, __ReturnBuffer);

				return *(FQualifiedFrameTime*)__ReturnBuffer;
			}
		}

		public virtual bool GetDisableCameraCuts()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDisableCameraCuts, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The current playback position
		/// </returns>
		public virtual FQualifiedFrameTime GetCurrentTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentTime, __ReturnBuffer);

				return *(FQualifiedFrameTime*)__ReturnBuffer;
			}
		}

		public virtual TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoundObjects, __InBuffer, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		public virtual void ChangePlaybackDirection()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ChangePlaybackDirection);
			}
		}

		private static uint __Observer = 0;

		private static uint __OnPlay = 0;

		private static uint __OnPlayReverse = 0;

		private static uint __OnStop = 0;

		private static uint __OnPause = 0;

		private static uint __OnFinished = 0;

		private static uint __Status = 0;

		private static uint __bReversePlayback = 0;

		private static uint __Sequence = 0;

		private static uint __StartTime = 0;

		private static uint __DurationFrames = 0;

		private static uint __DurationSubFrames = 0;

		private static uint __CurrentNumLoops = 0;

		private static uint __SerialNumber = 0;

		private static uint __PlaybackSettings = 0;

		private static uint __RootTemplateInstance = 0;

		private static uint __NetSyncProps = 0;

		private static uint __PlaybackClient = 0;

		private static uint __TickManager = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __StopAtCurrentTime = 0;

		private static uint __Stop = 0;

		private static uint __SetWeight = 0;

		private static uint __SetTimeRange = 0;

		private static uint __SetPlayRate = 0;

		private static uint __SetPlaybackPosition = 0;

		private static uint __SetFrameRate = 0;

		private static uint __SetFrameRange = 0;

		private static uint __SetDisableCameraCuts = 0;

		private static uint __Scrub = 0;

		private static uint __RPC_OnStopEvent = 0;

		private static uint __RPC_OnFinishPlaybackEvent = 0;

		private static uint __RPC_ExplicitServerUpdateEvent = 0;

		private static uint __RestoreState = 0;

		private static uint __RemoveWeight = 0;

		private static uint __PlayTo = 0;

		private static uint __PlayReverse = 0;

		private static uint __PlayLooping = 0;

		private static uint __Play = 0;

		private static uint __Pause = 0;

		private static uint __IsReversed = 0;

		private static uint __IsPlaying = 0;

		private static uint __IsPaused = 0;

		private static uint __GoToEndAndStop = 0;

		private static uint __GetStartTime = 0;

		private static uint __GetSequenceName = 0;

		private static uint __GetSequence = 0;

		private static uint __GetPlayRate = 0;

		private static uint __GetObjectBindings = 0;

		private static uint __GetFrameRate = 0;

		private static uint __GetFrameDuration = 0;

		private static uint __GetEndTime = 0;

		private static uint __GetDuration = 0;

		private static uint __GetDisableCameraCuts = 0;

		private static uint __GetCurrentTime = 0;

		private static uint __GetBoundObjects = 0;

		private static uint __ChangePlaybackDirection = 0;
	}
}