using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.CinematicCamera
{
	[PathName("/Script/CinematicCamera.CineCameraComponent")]
	public partial class UCineCameraComponent : UCameraComponent, IStaticClass
	{
		public FCameraFilmbackSettings Filmback
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Filmback, __ReturnBuffer);

					return *(FCameraFilmbackSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Filmback, __InBuffer);
				}
			}
		}

		public FCameraLensSettings LensSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LensSettings, __ReturnBuffer);

					return *(FCameraLensSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LensSettings, __InBuffer);
				}
			}
		}

		public FCameraFocusSettings FocusSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FocusSettings, __ReturnBuffer);

					return *(FCameraFocusSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FocusSettings, __InBuffer);
				}
			}
		}

		public FPlateCropSettings CropSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CropSettings, __ReturnBuffer);

					return *(FPlateCropSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CropSettings, __InBuffer);
				}
			}
		}

		public float CurrentFocalLength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentFocalLength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentFocalLength, __InBuffer);
				}
			}
		}

		public float CurrentAperture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentAperture, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentAperture, __InBuffer);
				}
			}
		}

		public float CurrentFocusDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentFocusDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentFocusDistance, __InBuffer);
				}
			}
		}

		public bool bOverride_CustomNearClippingPlane
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverride_CustomNearClippingPlane, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverride_CustomNearClippingPlane, __InBuffer);
				}
			}
		}

		public float CustomNearClippingPlane
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CustomNearClippingPlane, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CustomNearClippingPlane, __InBuffer);
				}
			}
		}

		public float CurrentHorizontalFOV
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentHorizontalFOV, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentHorizontalFOV, __InBuffer);
				}
			}
		}

		public UStaticMesh FocusPlaneVisualizationMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FocusPlaneVisualizationMesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FocusPlaneVisualizationMesh, __InBuffer);
				}
			}
		}

		public UMaterial FocusPlaneVisualizationMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FocusPlaneVisualizationMaterial, __ReturnBuffer);

					return *(UMaterial*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FocusPlaneVisualizationMaterial, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent DebugFocusPlaneComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugFocusPlaneComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugFocusPlaneComponent, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic DebugFocusPlaneMID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugFocusPlaneMID, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugFocusPlaneMID, __InBuffer);
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CinematicCamera.CineCameraComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetLensSettings(FCameraLensSettings NewLensSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewLensSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLensSettings, __InBuffer);
			}
		}

		public virtual void SetLensPresetByName(FString InPresetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPresetName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLensPresetByName, __InBuffer);
			}
		}

		public virtual void SetFocusSettings(FCameraFocusSettings NewFocusSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewFocusSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFocusSettings, __InBuffer);
			}
		}

		public virtual void SetFilmbackPresetByName(FString InPresetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPresetName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilmbackPresetByName, __InBuffer);
			}
		}

		public virtual void SetFilmback(FCameraFilmbackSettings NewFilmback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewFilmback?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilmback, __InBuffer);
			}
		}

		public virtual void SetCustomNearClippingPlane(float NewCustomNearClippingPlane)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewCustomNearClippingPlane;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCustomNearClippingPlane, __InBuffer);
			}
		}

		public virtual void SetCurrentFocalLength(float InFocalLength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InFocalLength;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCurrentFocalLength, __InBuffer);
			}
		}

		public virtual void SetCurrentAperture(float NewCurrentAperture)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewCurrentAperture;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCurrentAperture, __InBuffer);
			}
		}

		public virtual void SetCropSettings(FPlateCropSettings NewCropSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewCropSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCropSettings, __InBuffer);
			}
		}

		public virtual void SetCropPresetByName(FString InPresetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPresetName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCropPresetByName, __InBuffer);
			}
		}

		public virtual float GetVerticalFieldOfView()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetVerticalFieldOfView, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static TArray<FNamedLensPreset> GetLensPresetsCopy()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetLensPresetsCopy, __ReturnBuffer);

				return *(TArray<FNamedLensPreset>*)__ReturnBuffer;
			}
		}

		public virtual FString GetLensPresetName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLensPresetName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual float GetHorizontalFieldOfView()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetHorizontalFieldOfView, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static TArray<FNamedFilmbackPreset> GetFilmbackPresetsCopy()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetFilmbackPresetsCopy, __ReturnBuffer);

				return *(TArray<FNamedFilmbackPreset>*)__ReturnBuffer;
			}
		}

		public virtual FString GetFilmbackPresetName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFilmbackPresetName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FString GetDefaultFilmbackPresetName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDefaultFilmbackPresetName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FString GetCropPresetName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCropPresetName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __Filmback = 0;

		private static uint __LensSettings = 0;

		private static uint __FocusSettings = 0;

		private static uint __CropSettings = 0;

		private static uint __CurrentFocalLength = 0;

		private static uint __CurrentAperture = 0;

		private static uint __CurrentFocusDistance = 0;

		private static uint __bOverride_CustomNearClippingPlane = 0;

		private static uint __CustomNearClippingPlane = 0;

		private static uint __CurrentHorizontalFOV = 0;

		private static uint __FocusPlaneVisualizationMesh = 0;

		private static uint __FocusPlaneVisualizationMaterial = 0;

		private static uint __DebugFocusPlaneComponent = 0;

		private static uint __DebugFocusPlaneMID = 0;

		private static uint __FilmbackPresets = 0;

		private static uint __LensPresets = 0;

		private static uint __DefaultFilmbackPreset = 0;

		private static uint __DefaultLensPresetName = 0;

		private static uint __DefaultLensFocalLength = 0;

		private static uint __DefaultLensFStop = 0;

		private static uint __SetLensSettings = 0;

		private static uint __SetLensPresetByName = 0;

		private static uint __SetFocusSettings = 0;

		private static uint __SetFilmbackPresetByName = 0;

		private static uint __SetFilmback = 0;

		private static uint __SetCustomNearClippingPlane = 0;

		private static uint __SetCurrentFocalLength = 0;

		private static uint __SetCurrentAperture = 0;

		private static uint __SetCropSettings = 0;

		private static uint __SetCropPresetByName = 0;

		private static uint __GetVerticalFieldOfView = 0;

		private static uint __GetLensPresetsCopy = 0;

		private static uint __GetLensPresetName = 0;

		private static uint __GetHorizontalFieldOfView = 0;

		private static uint __GetFilmbackPresetsCopy = 0;

		private static uint __GetFilmbackPresetName = 0;

		private static uint __GetDefaultFilmbackPresetName = 0;

		private static uint __GetCropPresetName = 0;
	}
}