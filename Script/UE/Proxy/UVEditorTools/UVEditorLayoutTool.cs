using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.ModelingOperators;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorLayoutTool")]
	public partial class UUVEditorLayoutTool : UInteractiveTool, IStaticClass, IUVToolSupportsSelection
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

		public UUVLayoutProperties Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(UUVLayoutProperties*)__ReturnBuffer;
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

		public TArray<UUVLayoutOperatorFactory> Factories
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Factories, __ReturnBuffer);

					return *(TArray<UUVLayoutOperatorFactory>*)__ReturnBuffer;
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

		public UUVToolSelectionAPI UVToolSelectionAPI
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UVToolSelectionAPI, __ReturnBuffer);

					return *(UUVToolSelectionAPI*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UVToolSelectionAPI, __InBuffer);
				}
			}
		}

		public UUVTool2DViewportAPI UVTool2DViewportAPI
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UVTool2DViewportAPI, __ReturnBuffer);

					return *(UUVTool2DViewportAPI*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UVTool2DViewportAPI, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorLayoutTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __Targets = 0;

		private static uint __Settings = 0;

		private static uint __Factories = 0;

		private static uint __UVToolSelectionAPI = 0;

		private static uint __UVTool2DViewportAPI = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}