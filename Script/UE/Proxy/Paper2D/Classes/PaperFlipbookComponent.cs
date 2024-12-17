using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperFlipbookComponent")]
	public partial class UPaperFlipbookComponent : UMeshComponent, IStaticClass
	{
		public UPaperFlipbook SourceFlipbook
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceFlipbook, __ReturnBuffer);

					return *(UPaperFlipbook*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceFlipbook, __InBuffer);
				}
			}
		}

		public float PlayRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayRate, __InBuffer);
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

		public bool bPlaying
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPlaying, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPlaying, __InBuffer);
				}
			}
		}

		public float AccumulatedTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AccumulatedTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AccumulatedTime, __InBuffer);
				}
			}
		}

		public int CachedFrameIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedFrameIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedFrameIndex, __InBuffer);
				}
			}
		}

		public FLinearColor SpriteColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteColor, __InBuffer);
				}
			}
		}

		public UBodySetup CachedBodySetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedBodySetup, __ReturnBuffer);

					return *(UBodySetup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedBodySetup, __InBuffer);
				}
			}
		}

		public FFlipbookFinishedPlaySignature OnFinishedPlaying
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFinishedPlaying, __ReturnBuffer);

					return *(FFlipbookFinishedPlaySignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnFinishedPlaying, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.PaperFlipbookComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Stop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Stop);
			}
		}

		public virtual void SetSpriteColor(FLinearColor NewColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSpriteColor, __InBuffer);
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

		public virtual void SetPlaybackPositionInFrames(int NewFramePosition, bool bFireEvents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = NewFramePosition;

				*(bool*)(__InBuffer + 4) = bFireEvents;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaybackPositionInFrames, __InBuffer);
			}
		}

		public virtual void SetPlaybackPosition(float NewPosition, bool bFireEvents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = NewPosition;

				*(bool*)(__InBuffer + 4) = bFireEvents;

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

		public virtual bool SetFlipbook(UPaperFlipbook NewFlipbook)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewFlipbook?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetFlipbook, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
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

		public virtual void OnRep_SourceFlipbook(UPaperFlipbook OldFlipbook)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OldFlipbook?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnRep_SourceFlipbook, __InBuffer);
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

		public virtual FLinearColor GetSpriteColor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSpriteColor, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
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

		public virtual int GetPlaybackPositionInFrames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlaybackPositionInFrames, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
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

		public virtual int GetFlipbookLengthInFrames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFlipbookLengthInFrames, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual float GetFlipbookLength()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFlipbookLength, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetFlipbookFramerate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFlipbookFramerate, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UPaperFlipbook GetFlipbook()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFlipbook, __ReturnBuffer);

				return *(UPaperFlipbook*)__ReturnBuffer;
			}
		}

		private static uint __SourceFlipbook = 0;

		private static uint __PlayRate = 0;

		private static uint __bLooping = 0;

		private static uint __bReversePlayback = 0;

		private static uint __bPlaying = 0;

		private static uint __AccumulatedTime = 0;

		private static uint __CachedFrameIndex = 0;

		private static uint __SpriteColor = 0;

		private static uint __CachedBodySetup = 0;

		private static uint __OnFinishedPlaying = 0;

		private static uint __Stop = 0;

		private static uint __SetSpriteColor = 0;

		private static uint __SetPlayRate = 0;

		private static uint __SetPlaybackPositionInFrames = 0;

		private static uint __SetPlaybackPosition = 0;

		private static uint __SetNewTime = 0;

		private static uint __SetLooping = 0;

		private static uint __SetFlipbook = 0;

		private static uint __ReverseFromEnd = 0;

		private static uint __Reverse = 0;

		private static uint __PlayFromStart = 0;

		private static uint __Play = 0;

		private static uint __OnRep_SourceFlipbook = 0;

		private static uint __IsReversing = 0;

		private static uint __IsPlaying = 0;

		private static uint __IsLooping = 0;

		private static uint __GetSpriteColor = 0;

		private static uint __GetPlayRate = 0;

		private static uint __GetPlaybackPositionInFrames = 0;

		private static uint __GetPlaybackPosition = 0;

		private static uint __GetFlipbookLengthInFrames = 0;

		private static uint __GetFlipbookLength = 0;

		private static uint __GetFlipbookFramerate = 0;

		private static uint __GetFlipbook = 0;
	}
}