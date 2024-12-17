using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimatedSparseVolumeTextureController")]
	public partial class UAnimatedSparseVolumeTextureController : UObject, IStaticClass
	{
		public USparseVolumeTexture SparseVolumeTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SparseVolumeTexture, __ReturnBuffer);

					return *(USparseVolumeTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SparseVolumeTexture, __InBuffer);
				}
			}
		}

		public float Time
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Time, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Time, __InBuffer);
				}
			}
		}

		public bool bIsPlaying
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsPlaying, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsPlaying, __InBuffer);
				}
			}
		}

		public float FrameRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FrameRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FrameRate, __InBuffer);
				}
			}
		}

		public int MipLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MipLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MipLevel, __InBuffer);
				}
			}
		}

		public bool bBlockingStreamingRequests
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bBlockingStreamingRequests, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bBlockingStreamingRequests, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimatedSparseVolumeTextureController");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Update(float DeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DeltaTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Update, __InBuffer);
			}
		}

		public virtual void Stop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Stop);
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

		public virtual USparseVolumeTextureFrame GetFrameByIndex(int FrameIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = FrameIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetFrameByIndex, __InBuffer, __ReturnBuffer);

				return *(USparseVolumeTextureFrame*)__ReturnBuffer;
			}
		}

		public virtual float GetFractionalFrameIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFractionalFrameIndex, __ReturnBuffer);

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

		public virtual void GetCurrentFramesForInterpolation(ref USparseVolumeTextureFrame Frame0, ref USparseVolumeTextureFrame Frame1, ref float LerpAlpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Frame0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Frame1?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = LerpAlpha;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCurrentFramesForInterpolation, __InBuffer, __OutBuffer);

				Frame0 = *(USparseVolumeTextureFrame*)(__OutBuffer);

				Frame1 = *(USparseVolumeTextureFrame*)(__OutBuffer + 8);

				LerpAlpha = *(float*)(__OutBuffer + 16);

			}
		}

		public virtual USparseVolumeTextureFrame GetCurrentFrame()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentFrame, __ReturnBuffer);

				return *(USparseVolumeTextureFrame*)__ReturnBuffer;
			}
		}

		private static uint __SparseVolumeTexture = 0;

		private static uint __Time = 0;

		private static uint __bIsPlaying = 0;

		private static uint __FrameRate = 0;

		private static uint __MipLevel = 0;

		private static uint __bBlockingStreamingRequests = 0;

		private static uint __Update = 0;

		private static uint __Stop = 0;

		private static uint __Play = 0;

		private static uint __Pause = 0;

		private static uint __GetFrameByIndex = 0;

		private static uint __GetFractionalFrameIndex = 0;

		private static uint __GetDuration = 0;

		private static uint __GetCurrentFramesForInterpolation = 0;

		private static uint __GetCurrentFrame = 0;
	}
}