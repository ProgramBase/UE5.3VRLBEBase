using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperFlipbook")]
	public partial class UPaperFlipbook : UObject, IStaticClass
	{
		public float FramesPerSecond
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FramesPerSecond, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FramesPerSecond, __InBuffer);
				}
			}
		}

		public TArray<FPaperFlipbookKeyFrame> KeyFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __KeyFrames, __ReturnBuffer);

					return *(TArray<FPaperFlipbookKeyFrame>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __KeyFrames, __InBuffer);
				}
			}
		}

		public UMaterialInterface DefaultMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMaterial, __InBuffer);
				}
			}
		}

		public EFlipbookCollisionMode CollisionSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionSource, __ReturnBuffer);

					return *(EFlipbookCollisionMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionSource, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.PaperFlipbook");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsValidKeyFrameIndex(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsValidKeyFrameIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetTotalDuration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTotalDuration, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UPaperSprite GetSpriteAtTime(float Time, bool bClampToEnds = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Time;

				*(bool*)(__InBuffer + 4) = bClampToEnds;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSpriteAtTime, __InBuffer, __ReturnBuffer);

				return *(UPaperSprite*)__ReturnBuffer;
			}
		}

		public virtual UPaperSprite GetSpriteAtFrame(int FrameIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = FrameIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSpriteAtFrame, __InBuffer, __ReturnBuffer);

				return *(UPaperSprite*)__ReturnBuffer;
			}
		}

		public virtual int GetNumKeyFrames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumKeyFrames, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumFrames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumFrames, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetKeyFrameIndexAtTime(float Time, bool bClampToEnds = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Time;

				*(bool*)(__InBuffer + 4) = bClampToEnds;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetKeyFrameIndexAtTime, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __FramesPerSecond = 0;

		private static uint __KeyFrames = 0;

		private static uint __DefaultMaterial = 0;

		private static uint __CollisionSource = 0;

		private static uint __IsValidKeyFrameIndex = 0;

		private static uint __GetTotalDuration = 0;

		private static uint __GetSpriteAtTime = 0;

		private static uint __GetSpriteAtFrame = 0;

		private static uint __GetNumKeyFrames = 0;

		private static uint __GetNumFrames = 0;

		private static uint __GetKeyFrameIndexAtTime = 0;
	}
}