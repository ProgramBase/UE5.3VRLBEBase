using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.UMG;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.WidgetEditingProjectSettings")]
	public partial class UWidgetEditingProjectSettings : UDeveloperSettings, IStaticClass
	{
		public FWidgetCompilerOptions DefaultCompilerOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultCompilerOptions, __ReturnBuffer);

					return *(FWidgetCompilerOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultCompilerOptions, __InBuffer);
				}
			}
		}

		public TArray<FDirectoryWidgetCompilerOptions> DirectoryCompilerOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectoryCompilerOptions, __ReturnBuffer);

					return *(TArray<FDirectoryWidgetCompilerOptions>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectoryCompilerOptions, __InBuffer);
				}
			}
		}

		public bool bShowWidgetsFromEngineContent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowWidgetsFromEngineContent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowWidgetsFromEngineContent, __InBuffer);
				}
			}
		}

		public bool bShowWidgetsFromDeveloperContent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowWidgetsFromDeveloperContent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowWidgetsFromDeveloperContent, __InBuffer);
				}
			}
		}

		public TArray<FString> CategoriesToHide
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CategoriesToHide, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CategoriesToHide, __InBuffer);
				}
			}
		}

		public TArray<FSoftClassPath> WidgetClassesToHide
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetClassesToHide, __ReturnBuffer);

					return *(TArray<FSoftClassPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetClassesToHide, __InBuffer);
				}
			}
		}

		public bool bUseWidgetTemplateSelector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseWidgetTemplateSelector, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseWidgetTemplateSelector, __InBuffer);
				}
			}
		}

		public TArray<TSoftClassPtr<UPanelWidget>> CommonRootWidgetClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CommonRootWidgetClasses, __ReturnBuffer);

					return *(TArray<TSoftClassPtr<UPanelWidget>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CommonRootWidgetClasses, __InBuffer);
				}
			}
		}

		public TSubclassOf<UPanelWidget> DefaultRootWidget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultRootWidget, __ReturnBuffer);

					return *(TSubclassOf<UPanelWidget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultRootWidget, __InBuffer);
				}
			}
		}

		public bool bEnableMakeVariable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMakeVariable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMakeVariable, __InBuffer);
				}
			}
		}

		public bool bEnableWidgetAnimationEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableWidgetAnimationEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableWidgetAnimationEditor, __InBuffer);
				}
			}
		}

		public bool bEnablePaletteWindow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnablePaletteWindow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnablePaletteWindow, __InBuffer);
				}
			}
		}

		public bool bEnableLibraryWindow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableLibraryWindow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableLibraryWindow, __InBuffer);
				}
			}
		}

		public bool bEnableHierarchyWindow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableHierarchyWindow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableHierarchyWindow, __InBuffer);
				}
			}
		}

		public bool bEnableBindWidgetWindow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBindWidgetWindow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBindWidgetWindow, __InBuffer);
				}
			}
		}

		public bool bEnableNavigationSimulationWindow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableNavigationSimulationWindow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableNavigationSimulationWindow, __InBuffer);
				}
			}
		}

		public bool bUseEditorConfigPaletteFiltering
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseEditorConfigPaletteFiltering, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseEditorConfigPaletteFiltering, __InBuffer);
				}
			}
		}

		public bool bUseUserWidgetParentClassViewerSelector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseUserWidgetParentClassViewerSelector, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseUserWidgetParentClassViewerSelector, __InBuffer);
				}
			}
		}

		public bool bUseUserWidgetParentDefaultClassViewerSelector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseUserWidgetParentDefaultClassViewerSelector, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseUserWidgetParentDefaultClassViewerSelector, __InBuffer);
				}
			}
		}

		public TArray<TSoftClassPtr<UUserWidget>> FavoriteWidgetParentClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FavoriteWidgetParentClasses, __ReturnBuffer);

					return *(TArray<TSoftClassPtr<UUserWidget>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FavoriteWidgetParentClasses, __InBuffer);
				}
			}
		}

		public TArray<FDebugResolution> DebugResolutions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugResolutions, __ReturnBuffer);

					return *(TArray<FDebugResolution>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugResolutions, __InBuffer);
				}
			}
		}

		public int Version
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Version, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Version, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.WidgetEditingProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DefaultCompilerOptions = 0;

		private static uint __DirectoryCompilerOptions = 0;

		private static uint __bShowWidgetsFromEngineContent = 0;

		private static uint __bShowWidgetsFromDeveloperContent = 0;

		private static uint __CategoriesToHide = 0;

		private static uint __WidgetClassesToHide = 0;

		private static uint __bUseWidgetTemplateSelector = 0;

		private static uint __CommonRootWidgetClasses = 0;

		private static uint __DefaultRootWidget = 0;

		private static uint __bEnableMakeVariable = 0;

		private static uint __bEnableWidgetAnimationEditor = 0;

		private static uint __bEnablePaletteWindow = 0;

		private static uint __bEnableLibraryWindow = 0;

		private static uint __bEnableHierarchyWindow = 0;

		private static uint __bEnableBindWidgetWindow = 0;

		private static uint __bEnableNavigationSimulationWindow = 0;

		private static uint __bUseEditorConfigPaletteFiltering = 0;

		private static uint __bUseUserWidgetParentClassViewerSelector = 0;

		private static uint __bUseUserWidgetParentDefaultClassViewerSelector = 0;

		private static uint __FavoriteWidgetParentClasses = 0;

		private static uint __DebugResolutions = 0;

		private static uint __Version = 0;
	}
}