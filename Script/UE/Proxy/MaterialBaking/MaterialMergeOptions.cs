using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MaterialBaking
{
	[PathName("/Script/MaterialBaking.MaterialMergeOptions")]
	public partial class UMaterialMergeOptions : UObject, IStaticClass
	{
		public EMaterialBakeMethod Method
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Method, __ReturnBuffer);

					return *(EMaterialBakeMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Method, __InBuffer);
				}
			}
		}

		public EBlendMode BlendMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlendMode, __ReturnBuffer);

					return *(EBlendMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlendMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MaterialBaking.MaterialMergeOptions");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Method = 0;

		private static uint __BlendMode = 0;
	}
}