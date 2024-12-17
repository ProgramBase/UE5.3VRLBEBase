using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionBreakMaterialAttributes")]
	public partial class UMaterialExpressionBreakMaterialAttributes : UMaterialExpression, IStaticClass
	{
		public FMaterialAttributesInput MaterialAttributes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialAttributes, __ReturnBuffer);

					return *(FMaterialAttributesInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialAttributes, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionBreakMaterialAttributes");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MaterialAttributes = 0;
	}
}