using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimSingleNodeInstance")]
	public partial class UAnimSingleNodeInstance : UAnimInstance, IStaticClass
	{
		public UAnimationAsset CurrentAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentAsset, __ReturnBuffer);

					return *(UAnimationAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentAsset, __InBuffer);
				}
			}
		}

		public FPostEvaluateAnimEvent PostEvaluateAnimEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PostEvaluateAnimEvent, __ReturnBuffer);

					return *(FPostEvaluateAnimEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PostEvaluateAnimEvent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimSingleNodeInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StopAnim()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopAnim);
			}
		}

		public virtual void SetReverse(bool bInReverse)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInReverse;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReverse, __InBuffer);
			}
		}

		public virtual void SetPreviewCurveOverride(FName PoseName, float Value, bool bRemoveIfZero)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = PoseName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				*(bool*)(__InBuffer + 12) = bRemoveIfZero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPreviewCurveOverride, __InBuffer);
			}
		}

		public virtual void SetPositionWithPreviousTime(float InPosition, float InPreviousTime, bool bFireNotifies = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(float*)(__InBuffer) = InPosition;

				*(float*)(__InBuffer + 4) = InPreviousTime;

				*(bool*)(__InBuffer + 8) = bFireNotifies;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPositionWithPreviousTime, __InBuffer);
			}
		}

		public virtual void SetPosition(float InPosition, bool bFireNotifies = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InPosition;

				*(bool*)(__InBuffer + 4) = bFireNotifies;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPosition, __InBuffer);
			}
		}

		public virtual void SetPlayRate(float InPlayRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InPlayRate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlayRate, __InBuffer);
			}
		}

		public virtual void SetPlaying(bool bIsPlaying)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsPlaying;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaying, __InBuffer);
			}
		}

		public virtual void SetMirrorDataTable(UMirrorDataTable MirrorDataTable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MirrorDataTable?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMirrorDataTable, __InBuffer);
			}
		}

		public virtual void SetLooping(bool bIsLooping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsLooping;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLooping, __InBuffer);
			}
		}

		public virtual void SetBlendSpacePosition(FVector InPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBlendSpacePosition, __InBuffer);
			}
		}

		public virtual void SetAnimationAsset(UAnimationAsset NewAsset, bool bIsLooping = true, float InPlayRate = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = NewAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsLooping;

				*(float*)(__InBuffer + 9) = InPlayRate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimationAsset, __InBuffer);
			}
		}

		public virtual void PlayAnim(bool bIsLooping = false, float InPlayRate = 1.000000f, float InStartPosition = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bIsLooping;

				*(float*)(__InBuffer + 1) = InPlayRate;

				*(float*)(__InBuffer + 5) = InStartPosition;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __PlayAnim, __InBuffer);
			}
		}

		public virtual UMirrorDataTable GetMirrorDataTable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMirrorDataTable, __ReturnBuffer);

				return *(UMirrorDataTable*)__ReturnBuffer;
			}
		}

		public virtual float GetLength()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLength, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UAnimationAsset GetAnimationAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAnimationAsset, __ReturnBuffer);

				return *(UAnimationAsset*)__ReturnBuffer;
			}
		}

		private static uint __CurrentAsset = 0;

		private static uint __PostEvaluateAnimEvent = 0;

		private static uint __StopAnim = 0;

		private static uint __SetReverse = 0;

		private static uint __SetPreviewCurveOverride = 0;

		private static uint __SetPositionWithPreviousTime = 0;

		private static uint __SetPosition = 0;

		private static uint __SetPlayRate = 0;

		private static uint __SetPlaying = 0;

		private static uint __SetMirrorDataTable = 0;

		private static uint __SetLooping = 0;

		private static uint __SetBlendSpacePosition = 0;

		private static uint __SetAnimationAsset = 0;

		private static uint __PlayAnim = 0;

		private static uint __GetMirrorDataTable = 0;

		private static uint __GetLength = 0;

		private static uint __GetAnimationAsset = 0;
	}
}