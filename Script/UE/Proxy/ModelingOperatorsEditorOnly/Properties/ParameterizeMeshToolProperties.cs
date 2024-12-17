using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingOperatorsEditorOnly
{
	[PathName("/Script/ModelingOperatorsEditorOnly.ParameterizeMeshToolProperties")]
	public partial class UParameterizeMeshToolProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public EParameterizeMeshUVMethod Method
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Method, __ReturnBuffer);

					return *(EParameterizeMeshUVMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Method, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingOperatorsEditorOnly.ParameterizeMeshToolProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Method = 0;
	}
}