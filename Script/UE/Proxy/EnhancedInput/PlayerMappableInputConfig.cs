using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.PlayerMappableInputConfig")]
	public partial class UPlayerMappableInputConfig : UPrimaryDataAsset, IStaticClass
	{
		public FName ConfigName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConfigName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConfigName, __InBuffer);
				}
			}
		}

		public FText ConfigDisplayName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConfigDisplayName, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConfigDisplayName, __InBuffer);
				}
			}
		}

		public bool bIsDeprecated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsDeprecated, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsDeprecated, __InBuffer);
				}
			}
		}

		public UObject Metadata
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Metadata, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Metadata, __InBuffer);
				}
			}
		}

		public TMap<UInputMappingContext, int> Contexts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Contexts, __ReturnBuffer);

					return *(TMap<UInputMappingContext, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Contexts, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.PlayerMappableInputConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ResetToDefault()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetToDefault);
			}
		}

		public virtual bool IsDeprecated()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDeprecated, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<FEnhancedActionKeyMapping> GetPlayerMappableKeys()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlayerMappableKeys, __ReturnBuffer);

				return *(TArray<FEnhancedActionKeyMapping>*)__ReturnBuffer;
			}
		}

		public virtual UObject GetMetadata()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMetadata, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual TMap<UInputMappingContext, int> GetMappingContexts()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMappingContexts, __ReturnBuffer);

				return *(TMap<UInputMappingContext, int>*)__ReturnBuffer;
			}
		}

		public virtual FEnhancedActionKeyMapping GetMappingByName(FName MappingName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MappingName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMappingByName, __InBuffer, __ReturnBuffer);

				return *(FEnhancedActionKeyMapping*)__ReturnBuffer;
			}
		}

		public virtual TArray<FEnhancedActionKeyMapping> GetKeysBoundToAction(UInputAction InAction)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAction?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetKeysBoundToAction, __InBuffer, __ReturnBuffer);

				return *(TArray<FEnhancedActionKeyMapping>*)__ReturnBuffer;
			}
		}

		public virtual FText GetDisplayName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDisplayName, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual FName GetConfigName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetConfigName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		private static uint __ConfigName = 0;

		private static uint __ConfigDisplayName = 0;

		private static uint __bIsDeprecated = 0;

		private static uint __Metadata = 0;

		private static uint __Contexts = 0;

		private static uint __ResetToDefault = 0;

		private static uint __IsDeprecated = 0;

		private static uint __GetPlayerMappableKeys = 0;

		private static uint __GetMetadata = 0;

		private static uint __GetMappingContexts = 0;

		private static uint __GetMappingByName = 0;

		private static uint __GetKeysBoundToAction = 0;

		private static uint __GetDisplayName = 0;

		private static uint __GetConfigName = 0;
	}
}