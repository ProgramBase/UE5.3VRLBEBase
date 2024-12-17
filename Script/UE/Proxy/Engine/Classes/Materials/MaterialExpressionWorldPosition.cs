using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionWorldPosition")]
	public partial class UMaterialExpressionWorldPosition : UMaterialExpression, IStaticClass
	{
		public EWorldPositionIncludedOffsets WorldPositionShaderOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WorldPositionShaderOffset, __ReturnBuffer);

					return *(EWorldPositionIncludedOffsets*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WorldPositionShaderOffset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionWorldPosition");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WorldPositionShaderOffset = 0;
	}
}