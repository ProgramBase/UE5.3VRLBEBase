using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialInstanceEditorOnlyData")]
	public partial class UMaterialInstanceEditorOnlyData : UMaterialInterfaceEditorOnlyData, IStaticClass
	{
		public FStaticParameterSetEditorOnlyData StaticParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticParameters, __ReturnBuffer);

					return *(FStaticParameterSetEditorOnlyData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticParameters, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialInstanceEditorOnlyData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __StaticParameters = 0;
	}
}