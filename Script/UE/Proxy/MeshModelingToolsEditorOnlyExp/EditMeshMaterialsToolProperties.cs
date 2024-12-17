using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;
using Script.Engine;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EditMeshMaterialsToolProperties")]
	public partial class UEditMeshMaterialsToolProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public FString ActiveMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveMaterial, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveMaterial, __InBuffer);
				}
			}
		}

		public TArray<FString> MaterialNamesList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialNamesList, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialNamesList, __InBuffer);
				}
			}
		}

		public TArray<UMaterialInterface> Materials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Materials, __ReturnBuffer);

					return *(TArray<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Materials, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.EditMeshMaterialsToolProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<FString> GetMaterialNamesFunc()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMaterialNamesFunc, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		private static uint __ActiveMaterial = 0;

		private static uint __MaterialNamesList = 0;

		private static uint __Materials = 0;

		private static uint __GetMaterialNamesFunc = 0;
	}
}