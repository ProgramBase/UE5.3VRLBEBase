using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureMaterialsSettings")]
	public partial class UFractureMaterialsSettings : UFractureToolSettings, IStaticClass
	{
		public FString EditingCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditingCollection, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditingCollection, __InBuffer);
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

		public bool bOnlySelectedComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlySelectedComponents, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlySelectedComponents, __InBuffer);
				}
			}
		}

		public FString AssignMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssignMaterial, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssignMaterial, __InBuffer);
				}
			}
		}

		public EMaterialAssignmentTargets ToFaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ToFaces, __ReturnBuffer);

					return *(EMaterialAssignmentTargets*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ToFaces, __InBuffer);
				}
			}
		}

		public bool bOnlySelectedBones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlySelectedBones, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlySelectedBones, __InBuffer);
				}
			}
		}

		public bool bHaveTargetCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHaveTargetCollection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHaveTargetCollection, __InBuffer);
				}
			}
		}

		public TArray<FString> AssignMaterialNamesList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssignMaterialNamesList, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssignMaterialNamesList, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureMaterialsSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UseAssetMaterialsOnComponents()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UseAssetMaterialsOnComponents);
			}
		}

		public virtual void RemoveMaterialSlot()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RemoveMaterialSlot);
			}
		}

		public virtual TArray<FString> GetMaterialNamesFunc()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMaterialNamesFunc, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual void AddMaterialSlot()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __AddMaterialSlot);
			}
		}

		private static uint __EditingCollection = 0;

		private static uint __Materials = 0;

		private static uint __bOnlySelectedComponents = 0;

		private static uint __AssignMaterial = 0;

		private static uint __ToFaces = 0;

		private static uint __bOnlySelectedBones = 0;

		private static uint __bHaveTargetCollection = 0;

		private static uint __AssignMaterialNamesList = 0;

		private static uint __UseAssetMaterialsOnComponents = 0;

		private static uint __RemoveMaterialSlot = 0;

		private static uint __GetMaterialNamesFunc = 0;

		private static uint __AddMaterialSlot = 0;
	}
}