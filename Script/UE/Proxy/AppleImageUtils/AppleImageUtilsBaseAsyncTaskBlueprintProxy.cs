using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AppleImageUtils
{
	[PathName("/Script/AppleImageUtils.AppleImageUtilsBaseAsyncTaskBlueprintProxy")]
	public partial class UAppleImageUtilsBaseAsyncTaskBlueprintProxy : UObject, IStaticClass
	{
		public FAppleImageConversionDelegate OnSuccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __ReturnBuffer);

					return *(FAppleImageConversionDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSuccess, __InBuffer);
				}
			}
		}

		public FAppleImageConversionDelegate OnFailure
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __ReturnBuffer);

					return *(FAppleImageConversionDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnFailure, __InBuffer);
				}
			}
		}

		public FAppleImageUtilsImageConversionResult ConversionResult
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConversionResult, __ReturnBuffer);

					return *(FAppleImageUtilsImageConversionResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConversionResult, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AppleImageUtils.AppleImageUtilsBaseAsyncTaskBlueprintProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="SourceImage">
		/// the image to compress
		/// </param>
		/// <param name="Quality">
		/// the quality level to compress to
		/// </param>
		/// <param name="bWantColor">
		/// whether the TIFF is color (true) or monochrome (false)
		/// </param>
		/// <param name="bUseGpu">
		/// whether to use the GPU (true) or the CPU (false) to compress
		/// </param>
		/// <param name="Scale">
		/// whether to scale the image before conversion, defaults to no scaling
		/// </param>
		/// <param name="Rotate">
		/// a direction to rotate the image in during conversion, defaults to none
		/// </param>
		public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToTIFF(UTexture SourceImage, bool bWantColor = true, bool bUseGpu = true, float Scale = 1.000000f, ETextureRotationDirection Rotate = ETextureRotationDirection.None)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(nint*)(__InBuffer) = SourceImage?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bWantColor;

				*(bool*)(__InBuffer + 9) = bUseGpu;

				*(float*)(__InBuffer + 10) = Scale;

				*(byte*)(__InBuffer + 14) = (byte)Rotate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForConvertToTIFF, __InBuffer, __ReturnBuffer);

				return *(UAppleImageUtilsBaseAsyncTaskBlueprintProxy*)__ReturnBuffer;
			}
		}

		/// <param name="SourceImage">
		/// the image to compress
		/// </param>
		/// <param name="Quality">
		/// the quality level to compress to
		/// </param>
		/// <param name="bWantColor">
		/// whether the PNG is color (true) or monochrome (false)
		/// </param>
		/// <param name="bUseGpu">
		/// whether to use the GPU (true) or the CPU (false) to compress
		/// </param>
		/// <param name="Scale">
		/// whether to scale the image before conversion, defaults to no scaling
		/// </param>
		/// <param name="Rotate">
		/// a direction to rotate the image in during conversion, defaults to none
		/// </param>
		public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToPNG(UTexture SourceImage, bool bWantColor = true, bool bUseGpu = true, float Scale = 1.000000f, ETextureRotationDirection Rotate = ETextureRotationDirection.None)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(nint*)(__InBuffer) = SourceImage?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bWantColor;

				*(bool*)(__InBuffer + 9) = bUseGpu;

				*(float*)(__InBuffer + 10) = Scale;

				*(byte*)(__InBuffer + 14) = (byte)Rotate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForConvertToPNG, __InBuffer, __ReturnBuffer);

				return *(UAppleImageUtilsBaseAsyncTaskBlueprintProxy*)__ReturnBuffer;
			}
		}

		/// <param name="SourceImage">
		/// the image to compress
		/// </param>
		/// <param name="Quality">
		/// the quality level to compress to
		/// </param>
		/// <param name="bWantColor">
		/// whether the JPEG is color (true) or monochrome (false)
		/// </param>
		/// <param name="bUseGpu">
		/// whether to use the GPU (true) or the CPU (false) to compress
		/// </param>
		/// <param name="Scale">
		/// whether to scale the image before conversion, defaults to no scaling
		/// </param>
		/// <param name="Rotate">
		/// a direction to rotate the image in during conversion, defaults to none
		/// </param>
		public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToJPEG(UTexture SourceImage, int Quality = 85, bool bWantColor = true, bool bUseGpu = true, float Scale = 1.000000f, ETextureRotationDirection Rotate = ETextureRotationDirection.None)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = SourceImage?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Quality;

				*(bool*)(__InBuffer + 12) = bWantColor;

				*(bool*)(__InBuffer + 13) = bUseGpu;

				*(float*)(__InBuffer + 14) = Scale;

				*(byte*)(__InBuffer + 18) = (byte)Rotate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForConvertToJPEG, __InBuffer, __ReturnBuffer);

				return *(UAppleImageUtilsBaseAsyncTaskBlueprintProxy*)__ReturnBuffer;
			}
		}

		/// <param name="SourceImage">
		/// the image to compress
		/// </param>
		/// <param name="Quality">
		/// the quality level to compress to
		/// </param>
		/// <param name="bWantColor">
		/// whether the HEIF is color (true) or monochrome (false)
		/// </param>
		/// <param name="bUseGpu">
		/// whether to use the GPU (true) or the CPU (false) to compress
		/// </param>
		/// <param name="Scale">
		/// whether to scale the image before conversion, defaults to no scaling
		/// </param>
		/// <param name="Rotate">
		/// a direction to rotate the image in during conversion, defaults to none
		/// </param>
		public static UAppleImageUtilsBaseAsyncTaskBlueprintProxy CreateProxyObjectForConvertToHEIF(UTexture SourceImage, int Quality = 85, bool bWantColor = true, bool bUseGpu = true, float Scale = 1.000000f, ETextureRotationDirection Rotate = ETextureRotationDirection.None)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = SourceImage?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Quality;

				*(bool*)(__InBuffer + 12) = bWantColor;

				*(bool*)(__InBuffer + 13) = bUseGpu;

				*(float*)(__InBuffer + 14) = Scale;

				*(byte*)(__InBuffer + 18) = (byte)Rotate;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateProxyObjectForConvertToHEIF, __InBuffer, __ReturnBuffer);

				return *(UAppleImageUtilsBaseAsyncTaskBlueprintProxy*)__ReturnBuffer;
			}
		}

		private static uint __OnSuccess = 0;

		private static uint __OnFailure = 0;

		private static uint __ConversionResult = 0;

		private static uint __CreateProxyObjectForConvertToTIFF = 0;

		private static uint __CreateProxyObjectForConvertToPNG = 0;

		private static uint __CreateProxyObjectForConvertToJPEG = 0;

		private static uint __CreateProxyObjectForConvertToHEIF = 0;
	}
}