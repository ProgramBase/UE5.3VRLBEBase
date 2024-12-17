using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.GenerateStaticMeshLODAssetToolPresetProperties")]
	public partial class UGenerateStaticMeshLODAssetToolPresetProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public TWeakObjectPtr<UStaticMeshLODGenerationSettings> Preset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Preset, __ReturnBuffer);

					return *(TWeakObjectPtr<UStaticMeshLODGenerationSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Preset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.GenerateStaticMeshLODAssetToolPresetProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void WriteToPreset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __WriteToPreset);
			}
		}

		public virtual void ReadFromPreset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ReadFromPreset);
			}
		}

		private static uint __Preset = 0;

		private static uint __WriteToPreset = 0;

		private static uint __ReadFromPreset = 0;
	}
}