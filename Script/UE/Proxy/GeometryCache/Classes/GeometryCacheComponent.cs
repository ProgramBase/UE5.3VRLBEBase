using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheComponent")]
	public partial class UGeometryCacheComponent : UMeshComponent, IStaticClass
	{
		public UGeometryCache GeometryCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCache, __ReturnBuffer);

					return *(UGeometryCache*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeometryCache, __InBuffer);
				}
			}
		}

		public bool bRunning
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRunning, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRunning, __InBuffer);
				}
			}
		}

		public bool bLooping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLooping, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLooping, __InBuffer);
				}
			}
		}

		public bool bExtrapolateFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExtrapolateFrames, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExtrapolateFrames, __InBuffer);
				}
			}
		}

		public float StartTimeOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartTimeOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartTimeOffset, __InBuffer);
				}
			}
		}

		public float PlaybackSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaybackSpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaybackSpeed, __InBuffer);
				}
			}
		}

		public float MotionVectorScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MotionVectorScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MotionVectorScale, __InBuffer);
				}
			}
		}

		public int NumTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumTracks, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumTracks, __InBuffer);
				}
			}
		}

		public float ElapsedTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ElapsedTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ElapsedTime, __InBuffer);
				}
			}
		}

		public float Duration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Duration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Duration, __InBuffer);
				}
			}
		}

		public bool bManualTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bManualTick, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bManualTick, __InBuffer);
				}
			}
		}

		public bool bOverrideWireframeColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideWireframeColor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideWireframeColor, __InBuffer);
				}
			}
		}

		public FLinearColor WireframeOverrideColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WireframeOverrideColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WireframeOverrideColor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCache.GeometryCacheComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void TickAtThisTime(float Time, bool bInIsRunning, bool bInBackwards, bool bInIsLooping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[7];

				*(float*)(__InBuffer) = Time;

				*(bool*)(__InBuffer + 4) = bInIsRunning;

				*(bool*)(__InBuffer + 5) = bInBackwards;

				*(bool*)(__InBuffer + 6) = bInIsLooping;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __TickAtThisTime, __InBuffer);
			}
		}

		public virtual void Stop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Stop);
			}
		}

		public virtual void SetWireframeOverrideColor(FLinearColor Color)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Color?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWireframeOverrideColor, __InBuffer);
			}
		}

		public virtual void SetStartTimeOffset(float NewStartTimeOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewStartTimeOffset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartTimeOffset, __InBuffer);
			}
		}

		public virtual void SetPlaybackSpeed(float NewPlaybackSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewPlaybackSpeed;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaybackSpeed, __InBuffer);
			}
		}

		public virtual void SetOverrideWireframeColor(bool bOverride)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bOverride;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOverrideWireframeColor, __InBuffer);
			}
		}

		public virtual void SetMotionVectorScale(float NewMotionVectorScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewMotionVectorScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMotionVectorScale, __InBuffer);
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

		public virtual bool SetGeometryCache(UGeometryCache NewGeomCache)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewGeomCache?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetGeometryCache, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetExtrapolateFrames(bool bNewExtrapolating)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewExtrapolating;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetExtrapolateFrames, __InBuffer);
			}
		}

		public virtual void PlayReversedFromEnd()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PlayReversedFromEnd);
			}
		}

		public virtual void PlayReversed()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PlayReversed);
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

		public virtual void Pause()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Pause);
			}
		}

		public virtual bool IsPlayingReversed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPlayingReversed, __ReturnBuffer);

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

		public virtual bool IsExtrapolatingFrames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsExtrapolatingFrames, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FLinearColor GetWireframeOverrideColor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetWireframeOverrideColor, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public virtual float GetStartTimeOffset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetStartTimeOffset, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetPlaybackSpeed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlaybackSpeed, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetPlaybackDirection()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlaybackDirection, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual bool GetOverrideWireframeColor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetOverrideWireframeColor, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int GetNumberOfFrames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumberOfFrames, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual float GetMotionVectorScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMotionVectorScale, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDuration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDuration, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetAnimationTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAnimationTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __GeometryCache = 0;

		private static uint __bRunning = 0;

		private static uint __bLooping = 0;

		private static uint __bExtrapolateFrames = 0;

		private static uint __StartTimeOffset = 0;

		private static uint __PlaybackSpeed = 0;

		private static uint __MotionVectorScale = 0;

		private static uint __NumTracks = 0;

		private static uint __ElapsedTime = 0;

		private static uint __Duration = 0;

		private static uint __bManualTick = 0;

		private static uint __bOverrideWireframeColor = 0;

		private static uint __WireframeOverrideColor = 0;

		private static uint __TickAtThisTime = 0;

		private static uint __Stop = 0;

		private static uint __SetWireframeOverrideColor = 0;

		private static uint __SetStartTimeOffset = 0;

		private static uint __SetPlaybackSpeed = 0;

		private static uint __SetOverrideWireframeColor = 0;

		private static uint __SetMotionVectorScale = 0;

		private static uint __SetLooping = 0;

		private static uint __SetGeometryCache = 0;

		private static uint __SetExtrapolateFrames = 0;

		private static uint __PlayReversedFromEnd = 0;

		private static uint __PlayReversed = 0;

		private static uint __PlayFromStart = 0;

		private static uint __Play = 0;

		private static uint __Pause = 0;

		private static uint __IsPlayingReversed = 0;

		private static uint __IsPlaying = 0;

		private static uint __IsLooping = 0;

		private static uint __IsExtrapolatingFrames = 0;

		private static uint __GetWireframeOverrideColor = 0;

		private static uint __GetStartTimeOffset = 0;

		private static uint __GetPlaybackSpeed = 0;

		private static uint __GetPlaybackDirection = 0;

		private static uint __GetOverrideWireframeColor = 0;

		private static uint __GetNumberOfFrames = 0;

		private static uint __GetMotionVectorScale = 0;

		private static uint __GetDuration = 0;

		private static uint __GetAnimationTime = 0;
	}
}