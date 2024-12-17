using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.ModelingOperators;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.HoleFillToolProperties")]
	public partial class UHoleFillToolProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public EHoleFillOpFillType FillType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FillType, __ReturnBuffer);

					return *(EHoleFillOpFillType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FillType, __InBuffer);
				}
			}
		}

		public bool bRemoveIsolatedTriangles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRemoveIsolatedTriangles, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRemoveIsolatedTriangles, __InBuffer);
				}
			}
		}

		public bool bQuickFillSmallHoles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bQuickFillSmallHoles, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bQuickFillSmallHoles, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.HoleFillToolProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FillType = 0;

		private static uint __bRemoveIsolatedTriangles = 0;

		private static uint __bQuickFillSmallHoles = 0;
	}
}