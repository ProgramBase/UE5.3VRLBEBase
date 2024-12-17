using Script.CoreUObject;
using Script.ViewportInteraction;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorMode")]
	public partial class UVREditorMode : UVREditorModeBase, IStaticClass
	{
		public AVREditorAvatarActor AvatarActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AvatarActor, __ReturnBuffer);

					return *(AVREditorAvatarActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AvatarActor, __InBuffer);
				}
			}
		}

		public UVREditorUISystem UISystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UISystem, __ReturnBuffer);

					return *(UVREditorUISystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UISystem, __InBuffer);
				}
			}
		}

		public AVREditorTeleporter TeleportActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportActor, __ReturnBuffer);

					return *(AVREditorTeleporter*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportActor, __InBuffer);
				}
			}
		}

		public UVREditorAutoScaler AutoScalerSystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoScalerSystem, __ReturnBuffer);

					return *(UVREditorAutoScaler*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoScalerSystem, __InBuffer);
				}
			}
		}

		public UViewportWorldInteraction WorldInteraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WorldInteraction, __ReturnBuffer);

					return *(UViewportWorldInteraction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WorldInteraction, __InBuffer);
				}
			}
		}

		public UVREditorPlacement PlacementSystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlacementSystem, __ReturnBuffer);

					return *(UVREditorPlacement*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlacementSystem, __InBuffer);
				}
			}
		}

		public TArray<UVREditorInteractor> Interactors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Interactors, __ReturnBuffer);

					return *(TArray<UVREditorInteractor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Interactors, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UVREditorInteractor> InteractorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InteractorClass, __ReturnBuffer);

					return *(TSoftClassPtr<UVREditorInteractor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InteractorClass, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<AVREditorTeleporter> TeleporterClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TeleporterClass, __ReturnBuffer);

					return *(TSoftClassPtr<AVREditorTeleporter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TeleporterClass, __InBuffer);
				}
			}
		}

		public UVREditorAssetContainer AssetContainer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetContainer, __ReturnBuffer);

					return *(UVREditorAssetContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetContainer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorMode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetGameView(bool bGameView)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bGameView;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGameView, __InBuffer);
			}
		}

		public virtual bool IsInGameView()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsInGameView, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetWorldScaleFactor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetWorldScaleFactor, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __AvatarActor = 0;

		private static uint __UISystem = 0;

		private static uint __TeleportActor = 0;

		private static uint __AutoScalerSystem = 0;

		private static uint __WorldInteraction = 0;

		private static uint __PlacementSystem = 0;

		private static uint __Interactors = 0;

		private static uint __InteractorClass = 0;

		private static uint __TeleporterClass = 0;

		private static uint __AssetContainer = 0;

		private static uint __SetGameView = 0;

		private static uint __IsInGameView = 0;

		private static uint __GetWorldScaleFactor = 0;
	}
}