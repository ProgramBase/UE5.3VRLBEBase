using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;
using Script.Engine;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.CreateMeshObjectTypeProperties")]
	public partial class UCreateMeshObjectTypeProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public FString OutputType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutputType, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutputType, __InBuffer);
				}
			}
		}

		public TSubclassOf<AVolume> VolumeType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumeType, __ReturnBuffer);

					return *(TSubclassOf<AVolume>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumeType, __InBuffer);
				}
			}
		}

		public TArray<FString> OutputTypeNamesList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutputTypeNamesList, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutputTypeNamesList, __InBuffer);
				}
			}
		}

		public bool bShowVolumeList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowVolumeList, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowVolumeList, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.CreateMeshObjectTypeProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// true if we should show this property set on a Tool, ie if there are options the user can actually change (false if only one possible output type that has no options) */
		/// </returns>
		public virtual bool ShouldShowPropertySet()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ShouldShowPropertySet, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<FString> GetOutputTypeNamesFunc()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOutputTypeNamesFunc, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public virtual ECreateObjectTypeHint GetCurrentCreateMeshType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCurrentCreateMeshType, __ReturnBuffer);

				return *(ECreateObjectTypeHint*)__ReturnBuffer;
			}
		}

		private static uint __OutputType = 0;

		private static uint __VolumeType = 0;

		private static uint __OutputTypeNamesList = 0;

		private static uint __bShowVolumeList = 0;

		private static uint __ShouldShowPropertySet = 0;

		private static uint __GetOutputTypeNamesFunc = 0;

		private static uint __GetCurrentCreateMeshType = 0;
	}
}