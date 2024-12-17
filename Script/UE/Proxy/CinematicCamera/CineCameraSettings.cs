using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.CinematicCamera
{
	[PathName("/Script/CinematicCamera.CineCameraSettings")]
	public partial class UCineCameraSettings : UDeveloperSettings, IStaticClass
	{
		public FString DefaultLensPresetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultLensPresetName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultLensPresetName, __InBuffer);
				}
			}
		}

		public float DefaultLensFocalLength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultLensFocalLength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultLensFocalLength, __InBuffer);
				}
			}
		}

		public float DefaultLensFStop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultLensFStop, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultLensFStop, __InBuffer);
				}
			}
		}

		public TArray<FNamedLensPreset> LensPresets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LensPresets, __ReturnBuffer);

					return *(TArray<FNamedLensPreset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LensPresets, __InBuffer);
				}
			}
		}

		public FString DefaultFilmbackPreset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultFilmbackPreset, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultFilmbackPreset, __InBuffer);
				}
			}
		}

		public TArray<FNamedFilmbackPreset> FilmbackPresets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilmbackPresets, __ReturnBuffer);

					return *(TArray<FNamedFilmbackPreset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilmbackPresets, __InBuffer);
				}
			}
		}

		public FString DefaultCropPresetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultCropPresetName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultCropPresetName, __InBuffer);
				}
			}
		}

		public TArray<FNamedPlateCropPreset> CropPresets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CropPresets, __ReturnBuffer);

					return *(TArray<FNamedPlateCropPreset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CropPresets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CinematicCamera.CineCameraSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetLensPresets(TArray<FNamedLensPreset> InLensPresets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLensPresets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLensPresets, __InBuffer);
			}
		}

		public virtual void SetFilmbackPresets(TArray<FNamedFilmbackPreset> InFilmbackPresets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFilmbackPresets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilmbackPresets, __InBuffer);
			}
		}

		public virtual void SetDefaultLensPresetName(FString InDefaultLensPresetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDefaultLensPresetName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultLensPresetName, __InBuffer);
			}
		}

		public virtual void SetDefaultLensFStop(float InDefaultLensFStop)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDefaultLensFStop;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultLensFStop, __InBuffer);
			}
		}

		public virtual void SetDefaultLensFocalLength(float InDefaultLensFocalLength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDefaultLensFocalLength;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultLensFocalLength, __InBuffer);
			}
		}

		public virtual void SetDefaultFilmbackPreset(FString InDefaultFilmbackPreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDefaultFilmbackPreset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultFilmbackPreset, __InBuffer);
			}
		}

		public virtual void SetDefaultCropPresetName(FString InDefaultCropPresetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDefaultCropPresetName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultCropPresetName, __InBuffer);
			}
		}

		public virtual void SetCropPresets(TArray<FNamedPlateCropPreset> InCropPresets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InCropPresets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCropPresets, __InBuffer);
			}
		}

		public virtual TArray<FString> GetLensPresetNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLensPresetNames, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual bool GetLensPresetByName(FString PresetName, ref FCameraLensSettings LensSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PresetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LensSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetLensPresetByName, __InBuffer, __OutBuffer, __ReturnBuffer);

				LensSettings = *(FCameraLensSettings*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<FString> GetFilmbackPresetNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFilmbackPresetNames, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual bool GetFilmbackPresetByName(FString PresetName, ref FCameraFilmbackSettings FilmbackSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PresetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FilmbackSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetFilmbackPresetByName, __InBuffer, __OutBuffer, __ReturnBuffer);

				FilmbackSettings = *(FCameraFilmbackSettings*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<FString> GetCropPresetNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCropPresetNames, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual bool GetCropPresetByName(FString PresetName, ref FPlateCropSettings CropSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PresetName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CropSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCropPresetByName, __InBuffer, __OutBuffer, __ReturnBuffer);

				CropSettings = *(FPlateCropSettings*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UCineCameraSettings GetCineCameraSettings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCineCameraSettings, __ReturnBuffer);

				return *(UCineCameraSettings*)__ReturnBuffer;
			}
		}

		private static uint __DefaultLensPresetName = 0;

		private static uint __DefaultLensFocalLength = 0;

		private static uint __DefaultLensFStop = 0;

		private static uint __LensPresets = 0;

		private static uint __DefaultFilmbackPreset = 0;

		private static uint __FilmbackPresets = 0;

		private static uint __DefaultCropPresetName = 0;

		private static uint __CropPresets = 0;

		private static uint __SetLensPresets = 0;

		private static uint __SetFilmbackPresets = 0;

		private static uint __SetDefaultLensPresetName = 0;

		private static uint __SetDefaultLensFStop = 0;

		private static uint __SetDefaultLensFocalLength = 0;

		private static uint __SetDefaultFilmbackPreset = 0;

		private static uint __SetDefaultCropPresetName = 0;

		private static uint __SetCropPresets = 0;

		private static uint __GetLensPresetNames = 0;

		private static uint __GetLensPresetByName = 0;

		private static uint __GetFilmbackPresetNames = 0;

		private static uint __GetFilmbackPresetByName = 0;

		private static uint __GetCropPresetNames = 0;

		private static uint __GetCropPresetByName = 0;

		private static uint __GetCineCameraSettings = 0;
	}
}