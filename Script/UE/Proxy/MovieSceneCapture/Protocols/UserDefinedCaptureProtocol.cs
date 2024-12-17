using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.UserDefinedCaptureProtocol")]
	public partial class UUserDefinedCaptureProtocol : UMovieSceneImageCaptureProtocolBase, IStaticClass
	{
		public UWorld World
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __World, __ReturnBuffer);

					return *(UWorld*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __World, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.UserDefinedCaptureProtocol");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StopCapturingFinalPixels()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopCapturingFinalPixels);
			}
		}

		/// <param name="StreamID">
		/// The identifier to use for the final pixels buffer
		/// </param>
		public virtual void StartCapturingFinalPixels(FCapturedPixelsID StreamID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StreamID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartCapturingFinalPixels, __InBuffer);
			}
		}

		/// <param name="Buffer">
		/// The desired buffer to save
		/// </param>
		/// <param name="BufferID">
		/// The ID of this buffer that is passed to the pixel handler (e.g. a composition pass name).
		/// </param>
		public virtual void ResolveBuffer(UTexture Buffer, FCapturedPixelsID BufferID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Buffer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BufferID?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResolveBuffer, __InBuffer);
			}
		}

		public virtual void OnWarmUp()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnWarmUp);
			}
		}

		public virtual void OnTick()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnTick);
			}
		}

		public virtual void OnStartCapture()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnStartCapture);
			}
		}

		/// <returns>
		/// true if this protocol set up successfully, false otherwise
		/// </returns>
		public virtual bool OnSetup()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __OnSetup, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void OnPreTick()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnPreTick);
			}
		}

		public virtual void OnPixelsReceived(FCapturedPixels Pixels, FCapturedPixelsID ID, FFrameMetrics FrameMetrics)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Pixels?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FrameMetrics?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnPixelsReceived, __InBuffer);
			}
		}

		public virtual void OnPauseCapture()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnPauseCapture);
			}
		}

		public virtual void OnFinalize()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnFinalize);
			}
		}

		public virtual void OnCaptureFrame()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnCaptureFrame);
			}
		}

		public virtual bool OnCanFinalize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __OnCanFinalize, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void OnBeginFinalize()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnBeginFinalize);
			}
		}

		public virtual FFrameMetrics GetCurrentFrameMetrics()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentFrameMetrics, __ReturnBuffer);

				return *(FFrameMetrics*)__ReturnBuffer;
			}
		}

		public virtual FString GenerateFilename(FFrameMetrics InFrameMetrics)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFrameMetrics?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GenerateFilename, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __World = 0;

		private static uint __StopCapturingFinalPixels = 0;

		private static uint __StartCapturingFinalPixels = 0;

		private static uint __ResolveBuffer = 0;

		private static uint __OnWarmUp = 0;

		private static uint __OnTick = 0;

		private static uint __OnStartCapture = 0;

		private static uint __OnSetup = 0;

		private static uint __OnPreTick = 0;

		private static uint __OnPixelsReceived = 0;

		private static uint __OnPauseCapture = 0;

		private static uint __OnFinalize = 0;

		private static uint __OnCaptureFrame = 0;

		private static uint __OnCanFinalize = 0;

		private static uint __OnBeginFinalize = 0;

		private static uint __GetCurrentFrameMetrics = 0;

		private static uint __GenerateFilename = 0;
	}
}