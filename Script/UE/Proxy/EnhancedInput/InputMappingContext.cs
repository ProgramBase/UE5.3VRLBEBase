using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.InputCore;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputMappingContext")]
	public partial class UInputMappingContext : UDataAsset, IStaticClass
	{
		public TArray<FEnhancedActionKeyMapping> Mappings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Mappings, __ReturnBuffer);

					return *(TArray<FEnhancedActionKeyMapping>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Mappings, __InBuffer);
				}
			}
		}

		public FText ContextDescription
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ContextDescription, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ContextDescription, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputMappingContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnmapKey(UInputAction Action, FKey Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnmapKey, __InBuffer);
			}
		}

		public virtual void UnmapAllKeysFromAction(UInputAction Action)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnmapAllKeysFromAction, __InBuffer);
			}
		}

		public virtual void UnmapAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UnmapAll);
			}
		}

		public virtual void UnmapAction(UInputAction Action)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnmapAction, __InBuffer);
			}
		}

		public virtual FEnhancedActionKeyMapping MapKey(UInputAction Action, FKey ToKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ToKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __MapKey, __InBuffer, __ReturnBuffer);

				return *(FEnhancedActionKeyMapping*)__ReturnBuffer;
			}
		}

		private static uint __Mappings = 0;

		private static uint __ContextDescription = 0;

		private static uint __UnmapKey = 0;

		private static uint __UnmapAllKeysFromAction = 0;

		private static uint __UnmapAll = 0;

		private static uint __UnmapAction = 0;

		private static uint __MapKey = 0;
	}
}