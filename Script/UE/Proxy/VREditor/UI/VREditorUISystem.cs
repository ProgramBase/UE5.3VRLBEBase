using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorUISystem")]
	public partial class UVREditorUISystem : UObject, IStaticClass
	{
		public UVREditorMode VRMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VRMode, __ReturnBuffer);

					return *(UVREditorMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VRMode, __InBuffer);
				}
			}
		}

		public TMap<FName, AVREditorFloatingUI> FloatingUIs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FloatingUIs, __ReturnBuffer);

					return *(TMap<FName, AVREditorFloatingUI>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FloatingUIs, __InBuffer);
				}
			}
		}

		public TMap<FName, AActor> PreviewWindowInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewWindowInfo, __ReturnBuffer);

					return *(TMap<FName, AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewWindowInfo, __InBuffer);
				}
			}
		}

		public AVREditorFloatingUI InfoDisplayPanel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InfoDisplayPanel, __ReturnBuffer);

					return *(AVREditorFloatingUI*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InfoDisplayPanel, __InBuffer);
				}
			}
		}

		public AVREditorRadialFloatingUI QuickRadialMenu
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __QuickRadialMenu, __ReturnBuffer);

					return *(AVREditorRadialFloatingUI*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __QuickRadialMenu, __InBuffer);
				}
			}
		}

		public AVREditorDockableWindow DraggingUI
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DraggingUI, __ReturnBuffer);

					return *(AVREditorDockableWindow*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DraggingUI, __InBuffer);
				}
			}
		}

		public AVREditorDockableWindow ColorPickerUI
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorPickerUI, __ReturnBuffer);

					return *(AVREditorDockableWindow*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorPickerUI, __InBuffer);
				}
			}
		}

		public UVREditorInteractor LaserInteractor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LaserInteractor, __ReturnBuffer);

					return *(UVREditorInteractor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LaserInteractor, __InBuffer);
				}
			}
		}

		public UVREditorInteractor UIInteractor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UIInteractor, __ReturnBuffer);

					return *(UVREditorInteractor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UIInteractor, __InBuffer);
				}
			}
		}

		public TArray<FVRButton> VRButtons
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VRButtons, __ReturnBuffer);

					return *(TArray<FVRButton>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VRButtons, __InBuffer);
				}
			}
		}

		public UVRRadialMenuHandler RadialMenuHandler
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RadialMenuHandler, __ReturnBuffer);

					return *(UVRRadialMenuHandler*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RadialMenuHandler, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorUISystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VRMode = 0;

		private static uint __FloatingUIs = 0;

		private static uint __PreviewWindowInfo = 0;

		private static uint __InfoDisplayPanel = 0;

		private static uint __QuickRadialMenu = 0;

		private static uint __DraggingUI = 0;

		private static uint __ColorPickerUI = 0;

		private static uint __LaserInteractor = 0;

		private static uint __UIInteractor = 0;

		private static uint __VRButtons = 0;

		private static uint __RadialMenuHandler = 0;
	}
}