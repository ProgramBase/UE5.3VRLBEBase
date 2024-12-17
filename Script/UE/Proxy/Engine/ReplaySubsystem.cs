using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ReplaySubsystem")]
	public partial class UReplaySubsystem : UGameInstanceSubsystem, IStaticClass
	{
		public bool bLoadDefaultMapOnStop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLoadDefaultMapOnStop, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLoadDefaultMapOnStop, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ReplaySubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RequestCheckpoint()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RequestCheckpoint);
			}
		}

		public virtual bool IsRecording()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsRecording, __ReturnBuffer);

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

		/// <returns>
		/// float Current recording/playback time in seconds
		/// </returns>
		public virtual float GetReplayCurrentTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetReplayCurrentTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// FString Name of relpay (session id, file name, etc)
		/// </returns>
		public virtual FString GetActiveReplayName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActiveReplayName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __bLoadDefaultMapOnStop = 0;

		private static uint __RequestCheckpoint = 0;

		private static uint __IsRecording = 0;

		private static uint __IsPlaying = 0;

		private static uint __GetReplayCurrentTime = 0;

		private static uint __GetActiveReplayName = 0;
	}
}