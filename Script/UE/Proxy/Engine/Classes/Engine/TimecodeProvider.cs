using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TimecodeProvider")]
	public partial class UTimecodeProvider : UObject, IStaticClass
	{
		public float FrameDelay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FrameDelay, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FrameDelay, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.TimecodeProvider");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FTimecode GetTimecode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetTimecode, __ReturnBuffer);

				return *(FTimecode*)__ReturnBuffer;
			}
		}

		public virtual ETimecodeProviderSynchronizationState GetSynchronizationState()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSynchronizationState, __ReturnBuffer);

				return *(ETimecodeProviderSynchronizationState*)__ReturnBuffer;
			}
		}

		public virtual FQualifiedFrameTime GetQualifiedFrameTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetQualifiedFrameTime, __ReturnBuffer);

				return *(FQualifiedFrameTime*)__ReturnBuffer;
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

		public virtual FTimecode GetDelayedTimecode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDelayedTimecode, __ReturnBuffer);

				return *(FTimecode*)__ReturnBuffer;
			}
		}

		public virtual FQualifiedFrameTime GetDelayedQualifiedFrameTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDelayedQualifiedFrameTime, __ReturnBuffer);

				return *(FQualifiedFrameTime*)__ReturnBuffer;
			}
		}

		public virtual bool FetchTimecode(ref FQualifiedFrameTime OutFrameTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutFrameTime?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __FetchTimecode, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutFrameTime = *(FQualifiedFrameTime*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void FetchAndUpdate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FetchAndUpdate);
			}
		}

		private static uint __FrameDelay = 0;

		private static uint __GetTimecode = 0;

		private static uint __GetSynchronizationState = 0;

		private static uint __GetQualifiedFrameTime = 0;

		private static uint __GetFrameRate = 0;

		private static uint __GetDelayedTimecode = 0;

		private static uint __GetDelayedQualifiedFrameTime = 0;

		private static uint __FetchTimecode = 0;

		private static uint __FetchAndUpdate = 0;
	}
}