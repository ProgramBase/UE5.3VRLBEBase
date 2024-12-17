using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.GenerateStaticMeshLODAssetToolOutputProperties")]
	public partial class UGenerateStaticMeshLODAssetToolOutputProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public EGenerateLODAssetOutputMode OutputMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutputMode, __ReturnBuffer);

					return *(EGenerateLODAssetOutputMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutputMode, __InBuffer);
				}
			}
		}

		public FString NewAssetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NewAssetName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NewAssetName, __InBuffer);
				}
			}
		}

		public bool bSaveInputAsHiResSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSaveInputAsHiResSource, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSaveInputAsHiResSource, __InBuffer);
				}
			}
		}

		public FString GeneratedSuffix
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GeneratedSuffix, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GeneratedSuffix, __InBuffer);
				}
			}
		}

		public bool bShowOutputMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowOutputMode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowOutputMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.GenerateStaticMeshLODAssetToolOutputProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OutputMode = 0;

		private static uint __NewAssetName = 0;

		private static uint __bSaveInputAsHiResSource = 0;

		private static uint __GeneratedSuffix = 0;

		private static uint __bShowOutputMode = 0;
	}
}