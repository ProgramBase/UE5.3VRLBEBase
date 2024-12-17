using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.VariantManagerContent
{
	[PathName("/Script/VariantManagerContent.Variant")]
	public partial class UVariant : UObject, IStaticClass
	{
		public TArray<FVariantDependency> Dependencies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Dependencies, __ReturnBuffer);

					return *(TArray<FVariantDependency>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Dependencies, __InBuffer);
				}
			}
		}

		public TArray<UVariantObjectBinding> ObjectBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectBindings, __ReturnBuffer);

					return *(TArray<UVariantObjectBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectBindings, __InBuffer);
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VariantManagerContent.Variant");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SwitchOn()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SwitchOn);
			}
		}

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

		public virtual void SetDependency(int Index, ref FVariantDependency Dependency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = Dependency?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SetDependency, __InBuffer, __OutBuffer);

				Dependency = *(FVariantDependency*)(__OutBuffer);

			}
		}

		public virtual bool IsActive()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsActive, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
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

		public virtual UVariantSet GetParent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParent, __ReturnBuffer);

				return *(UVariantSet*)__ReturnBuffer;
			}
		}

		public virtual int GetNumDependencies()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumDependencies, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumActors, __ReturnBuffer);

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

		public virtual TArray<UVariant> GetDependents(ULevelVariantSets LevelVariantSets, bool bOnlyEnabledDependencies)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = LevelVariantSets?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOnlyEnabledDependencies;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDependents, __InBuffer, __ReturnBuffer);

				return *(TArray<UVariant>*)__ReturnBuffer;
			}
		}

		public virtual FVariantDependency GetDependency(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDependency, __InBuffer, __ReturnBuffer);

				return *(FVariantDependency*)__ReturnBuffer;
			}
		}

		public virtual AActor GetActor(int ActorIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ActorIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetActor, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual void DeleteDependency(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DeleteDependency, __InBuffer);
			}
		}

		public virtual int AddDependency(ref FVariantDependency Dependency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Dependency?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __AddDependency, __InBuffer, __OutBuffer, __ReturnBuffer);

				Dependency = *(FVariantDependency*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __Dependencies = 0;

		private static uint __ObjectBindings = 0;

		private static uint __Thumbnail = 0;

		private static uint __SwitchOn = 0;

		private static uint __SetThumbnailFromTexture = 0;

		private static uint __SetThumbnailFromFile = 0;

		private static uint __SetThumbnailFromEditorViewport = 0;

		private static uint __SetThumbnailFromCamera = 0;

		private static uint __SetDisplayText = 0;

		private static uint __SetDependency = 0;

		private static uint __IsActive = 0;

		private static uint __GetThumbnail = 0;

		private static uint __GetParent = 0;

		private static uint __GetNumDependencies = 0;

		private static uint __GetNumActors = 0;

		private static uint __GetDisplayText = 0;

		private static uint __GetDependents = 0;

		private static uint __GetDependency = 0;

		private static uint __GetActor = 0;

		private static uint __DeleteDependency = 0;

		private static uint __AddDependency = 0;
	}
}