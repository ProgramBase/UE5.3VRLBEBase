using Script.CoreUObject;
using Script.Engine;
using Script.MovieScene;
using Script.MediaAssets;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceMediaController")]
	public partial class ALevelSequenceMediaController : AActor, IStaticClass, IMovieSceneCustomClockSource
	{
		public ALevelSequenceActor Sequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sequence, __ReturnBuffer);

					return *(ALevelSequenceActor*)__ReturnBuffer;
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

		public UMediaComponent MediaComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediaComponent, __ReturnBuffer);

					return *(UMediaComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediaComponent, __InBuffer);
				}
			}
		}

		public float ServerStartTimeSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerStartTimeSeconds, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerStartTimeSeconds, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.LevelSequenceMediaController");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnTick(float DeltaSeconds, float InPlayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = DeltaSeconds;

				*(float*)(__InBuffer + 4) = InPlayRate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnTick, __InBuffer);
			}
		}

		public virtual void OnStopPlaying(FQualifiedFrameTime InStopTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStopTime?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnStopPlaying, __InBuffer);
			}
		}

		public virtual void OnStartPlaying(FQualifiedFrameTime InStartTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStartTime?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnStartPlaying, __InBuffer);
			}
		}

		public virtual FFrameTime OnRequestCurrentTime(FQualifiedFrameTime InCurrentTime, float InPlayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InCurrentTime?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InPlayRate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __OnRequestCurrentTime, __InBuffer, __ReturnBuffer);

				return *(FFrameTime*)__ReturnBuffer;
			}
		}

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

		public virtual void SynchronizeToServer(float DesyncThresholdSeconds = 2.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DesyncThresholdSeconds;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SynchronizeToServer, __InBuffer);
			}
		}

		public virtual void Play()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Play);
			}
		}

		public virtual void OnRep_ServerStartTimeSeconds()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ServerStartTimeSeconds);
			}
		}

		public virtual ALevelSequenceActor GetSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSequence, __ReturnBuffer);

				return *(ALevelSequenceActor*)__ReturnBuffer;
			}
		}

		public virtual UMediaComponent GetMediaComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMediaComponent, __ReturnBuffer);

				return *(UMediaComponent*)__ReturnBuffer;
			}
		}

		private static uint __Sequence = 0;

		private static uint __MediaComponent = 0;

		private static uint __ServerStartTimeSeconds = 0;

		private static uint __OnTick = 0;

		private static uint __OnStopPlaying = 0;

		private static uint __OnStartPlaying = 0;

		private static uint __OnRequestCurrentTime = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SynchronizeToServer = 0;

		private static uint __Play = 0;

		private static uint __OnRep_ServerStartTimeSeconds = 0;

		private static uint __GetSequence = 0;

		private static uint __GetMediaComponent = 0;
	}
}