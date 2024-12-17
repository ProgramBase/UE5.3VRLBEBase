using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.ModelingToolsEditorMode
{
	[PathName("/Script/ModelingToolsEditorMode.ModelingToolsModeCustomizationSettings")]
	public partial class UModelingToolsModeCustomizationSettings : UDeveloperSettings, IStaticClass
	{
		public bool bUseLegacyModelingPalette
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseLegacyModelingPalette, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseLegacyModelingPalette, __InBuffer);
				}
			}
		}

		public TArray<FString> ToolSectionOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToolSectionOrder, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToolSectionOrder, __InBuffer);
				}
			}
		}

		public TArray<FModelingModeCustomSectionColor> SectionColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SectionColors, __ReturnBuffer);

					return *(TArray<FModelingModeCustomSectionColor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SectionColors, __InBuffer);
				}
			}
		}

		public TArray<FModelingModeCustomToolColor> ToolColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToolColors, __ReturnBuffer);

					return *(TArray<FModelingModeCustomToolColor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToolColors, __InBuffer);
				}
			}
		}

		public TArray<FModelingModeAssetCollectionSet> BrushAlphaSets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrushAlphaSets, __ReturnBuffer);

					return *(TArray<FModelingModeAssetCollectionSet>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrushAlphaSets, __InBuffer);
				}
			}
		}

		public bool bShowCategoryButtonLabels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowCategoryButtonLabels, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowCategoryButtonLabels, __InBuffer);
				}
			}
		}

		public bool bAlwaysShowToolButtons
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysShowToolButtons, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAlwaysShowToolButtons, __InBuffer);
				}
			}
		}

		public int LastMeshSelectionDragMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastMeshSelectionDragMode, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastMeshSelectionDragMode, __InBuffer);
				}
			}
		}

		public int LastMeshSelectionElementType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastMeshSelectionElementType, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastMeshSelectionElementType, __InBuffer);
				}
			}
		}

		public int LastMeshSelectionTopologyMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastMeshSelectionTopologyMode, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastMeshSelectionTopologyMode, __InBuffer);
				}
			}
		}

		public bool bLastMeshSelectionVolumeToggle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLastMeshSelectionVolumeToggle, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLastMeshSelectionVolumeToggle, __InBuffer);
				}
			}
		}

		public bool bLastMeshSelectionStaticMeshToggle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLastMeshSelectionStaticMeshToggle, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLastMeshSelectionStaticMeshToggle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingToolsEditorMode.ModelingToolsModeCustomizationSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bUseLegacyModelingPalette = 0;

		private static uint __ToolSectionOrder = 0;

		private static uint __SectionColors = 0;

		private static uint __ToolColors = 0;

		private static uint __BrushAlphaSets = 0;

		private static uint __bShowCategoryButtonLabels = 0;

		private static uint __bAlwaysShowToolButtons = 0;

		private static uint __LastMeshSelectionDragMode = 0;

		private static uint __LastMeshSelectionElementType = 0;

		private static uint __LastMeshSelectionTopologyMode = 0;

		private static uint __bLastMeshSelectionVolumeToggle = 0;

		private static uint __bLastMeshSelectionStaticMeshToggle = 0;
	}
}