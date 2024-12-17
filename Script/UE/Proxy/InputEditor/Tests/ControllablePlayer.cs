using Script.CoreUObject;
using Script.Engine;
using Script.EnhancedInput;
using Script.Library;

namespace Script.InputEditor
{
	[PathName("/Script/InputEditor.ControllablePlayer")]
	public partial class UControllablePlayer : UObject, IStaticClass
	{
		public APlayerController Player
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Player, __ReturnBuffer);

					return *(APlayerController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Player, __InBuffer);
				}
			}
		}

		public TMap<FName, FBindingTargets> BindingTargets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BindingTargets, __ReturnBuffer);

					return *(TMap<FName, FBindingTargets>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BindingTargets, __InBuffer);
				}
			}
		}

		public TMap<FName, UInputMappingContext> InputContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputContext, __ReturnBuffer);

					return *(TMap<FName, UInputMappingContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputContext, __InBuffer);
				}
			}
		}

		public TMap<FName, UInputAction> InputAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputAction, __ReturnBuffer);

					return *(TMap<FName, UInputAction>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputAction, __InBuffer);
				}
			}
		}

		public UEnhancedInputUserSettings UserSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UserSettings, __ReturnBuffer);

					return *(UEnhancedInputUserSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UserSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputEditor.ControllablePlayer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Player = 0;

		private static uint __BindingTargets = 0;

		private static uint __InputContext = 0;

		private static uint __InputAction = 0;

		private static uint __UserSettings = 0;
	}
}