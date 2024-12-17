using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingOperatorsEditorOnly
{
	[PathName("/Script/ModelingOperatorsEditorOnly.ParameterizeMeshToolXAtlasProperties")]
	public partial class UParameterizeMeshToolXAtlasProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public int MaxIterations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxIterations, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxIterations, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingOperatorsEditorOnly.ParameterizeMeshToolXAtlasProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MaxIterations = 0;
	}
}