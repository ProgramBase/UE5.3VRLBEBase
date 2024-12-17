using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.VariantSet")]
	public partial class UVariantSet : UObject, IStaticClass
	{
		public bool bExpanded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExpanded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExpanded, __InBuffer);
				}
			}
		}

		public TArray<UVariant> Variants
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Variants, __ReturnBuffer);

					return *(TArray<UVariant>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Variants, __InBuffer);
				}
			}
		}

		public UTexture2D Thumbnail
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Thumbnail, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Thumbnail, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.VariantSet");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetThumbnailFromTexture(UTexture2D NewThumbnail)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewThumbnail?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetThumbnailFromTexture, __InBuffer);
			}
		}

		public virtual void SetThumbnailFromFile(FString FilePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FilePath?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetThumbnailFromFile, __InBuffer);
			}
		}

		public virtual void SetThumbnailFromEditorViewport()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetThumbnailFromEditorViewport);
			}
		}

		public virtual void SetThumbnailFromCamera(UObject WorldContextObject, FTransform CameraTransform, float FOVDegrees = 50.000000f, float MinZ = 50.000000f, float Gamma = 2.200000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CameraTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = FOVDegrees;

				*(float*)(__InBuffer + 20) = MinZ;

				*(float*)(__InBuffer + 24) = Gamma;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetThumbnailFromCamera, __InBuffer);
			}
		}

		public virtual void SetDisplayText(FText NewDisplayText)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewDisplayText?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDisplayText, __InBuffer);
			}
		}

		public virtual UVariant GetVariantByName(FString VariantName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VariantName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVariantByName, __InBuffer, __ReturnBuffer);

				return *(UVariant*)__ReturnBuffer;
			}
		}

		public virtual UVariant GetVariant(int VariantIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = VariantIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetVariant, __InBuffer, __ReturnBuffer);

				return *(UVariant*)__ReturnBuffer;
			}
		}

		public virtual UTexture2D GetThumbnail()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetThumbnail, __ReturnBuffer);

				return *(UTexture2D*)__ReturnBuffer;
			}
		}

		public virtual ULevelVariantSets GetParent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParent, __ReturnBuffer);

				return *(ULevelVariantSets*)__ReturnBuffer;
			}
		}

		public virtual int GetNumVariants()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumVariants, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FText GetDisplayText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDisplayText, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		private static uint __bExpanded = 0;

		private static uint __Variants = 0;

		private static uint __Thumbnail = 0;

		private static uint __SetThumbnailFromTexture = 0;

		private static uint __SetThumbnailFromFile = 0;

		private static uint __SetThumbnailFromEditorViewport = 0;

		private static uint __SetThumbnailFromCamera = 0;

		private static uint __SetDisplayText = 0;

		private static uint __GetVariantByName = 0;

		private static uint __GetVariant = 0;

		private static uint __GetThumbnail = 0;

		private static uint __GetParent = 0;

		private static uint __GetNumVariants = 0;

		private static uint __GetDisplayText = 0;
	}
}