using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.UVEditorTools;
using Script.ModelingOperatorsEditorOnly;
using Script.ModelingComponents;
using Script.Library;

namespace Script.UVEditorToolsEditorOnly
{
	[PathName("/Script/UVEditorToolsEditorOnly.UVEditorParameterizeMeshTool")]
	public partial class UUVEditorParameterizeMeshTool : UInteractiveTool, IStaticClass
	{
		public TArray<UUVEditorToolMeshInput> Targets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Targets, __ReturnBuffer);

					return *(TArray<UUVEditorToolMeshInput>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Targets, __InBuffer);
				}
			}
		}

		public UParameterizeMeshToolProperties Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(UParameterizeMeshToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public UParameterizeMeshToolUVAtlasProperties UVAtlasProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UVAtlasProperties, __ReturnBuffer);

					return *(UParameterizeMeshToolUVAtlasProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UVAtlasProperties, __InBuffer);
				}
			}
		}

		public UParameterizeMeshToolXAtlasProperties XAtlasProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __XAtlasProperties, __ReturnBuffer);

					return *(UParameterizeMeshToolXAtlasProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __XAtlasProperties, __InBuffer);
				}
			}
		}

		public UParameterizeMeshToolPatchBuilderProperties PatchBuilderProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PatchBuilderProperties, __ReturnBuffer);

					return *(UParameterizeMeshToolPatchBuilderProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PatchBuilderProperties, __InBuffer);
				}
			}
		}

		public UPolygroupLayersProperties PolygroupLayerProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PolygroupLayerProperties, __ReturnBuffer);

					return *(UPolygroupLayersProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PolygroupLayerProperties, __InBuffer);
				}
			}
		}

		public TArray<UParameterizeMeshOperatorFactory> Factories
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Factories, __ReturnBuffer);

					return *(TArray<UParameterizeMeshOperatorFactory>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Factories, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorToolsEditorOnly.UVEditorParameterizeMeshTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Targets = 0;

		private static uint __Settings = 0;

		private static uint __UVAtlasProperties = 0;

		private static uint __XAtlasProperties = 0;

		private static uint __PatchBuilderProperties = 0;

		private static uint __PolygroupLayerProperties = 0;

		private static uint __Factories = 0;
	}
}