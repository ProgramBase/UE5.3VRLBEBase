using Script.CoreUObject;
using Script.ImageWriteQueue;
using Script.Library;
using Script.Engine;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol")]
	public partial class UUserDefinedImageCaptureProtocol : UUserDefinedCaptureProtocol, IStaticClass
	{
		public EDesiredImageFormat Format
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Format, __ReturnBuffer);

					return *(EDesiredImageFormat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Format, __InBuffer);
				}
			}
		}

		public bool bEnableCompression
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableCompression, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableCompression, __InBuffer);
				}
			}
		}

		public int CompressionQuality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CompressionQuality, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CompressionQuality, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneCapture.UserDefinedImageCaptureProtocol");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// A fully qualified file name for the current frame number
		/// </returns>
		public virtual void WriteImageToDisk(FCapturedPixels PixelData, FCapturedPixelsID StreamID, FFrameMetrics FrameMetrics, bool bCopyImageData = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = PixelData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StreamID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FrameMetrics?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bCopyImageData;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteImageToDisk, __InBuffer);
			}
		}

		/// <returns>
		/// A fully qualified file name for the current frame number
		/// </returns>
		public virtual FString GenerateFilenameForCurrentFrame()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GenerateFilenameForCurrentFrame, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Buffer">
		/// The desired buffer to generate a filename for
		/// </param>
		/// <param name="StreamID">
		/// The ID of the stream for this buffer (e.g. a composition pass name)
		/// </param>
		/// <returns>
		/// A fully qualified file name
		/// </returns>
		public virtual FString GenerateFilenameForBuffer(UTexture Buffer, FCapturedPixelsID StreamID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Buffer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StreamID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GenerateFilenameForBuffer, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __Format = 0;

		private static uint __bEnableCompression = 0;

		private static uint __CompressionQuality = 0;

		private static uint __WriteImageToDisk = 0;

		private static uint __GenerateFilenameForCurrentFrame = 0;

		private static uint __GenerateFilenameForBuffer = 0;
	}
}