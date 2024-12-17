using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.SelectiveTessellationProperties")]
	public partial class USelectiveTessellationProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public EDisplaceMeshToolTriangleSelectionType SelectionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionType, __ReturnBuffer);

					return *(EDisplaceMeshToolTriangleSelectionType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionType, __InBuffer);
				}
			}
		}

		public FName ActiveMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveMaterial, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
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

		public TArray<FString> MaterialIDList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialIDList, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialIDList, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.SelectiveTessellationProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual TArray<FString> GetMaterialIDsFunc()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMaterialIDsFunc, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		private static uint __SelectionType = 0;

		private static uint __ActiveMaterial = 0;

		private static uint __MaterialIDList = 0;

		private static uint __GetMaterialIDsFunc = 0;
	}
}