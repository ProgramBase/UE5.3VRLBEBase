using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimCurveCompressionSettings")]
	public partial class UAnimCurveCompressionSettings : UObject, IStaticClass
	{
		public UAnimCurveCompressionCodec Codec
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Codec, __ReturnBuffer);

					return *(UAnimCurveCompressionCodec*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Codec, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimCurveCompressionSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Codec = 0;
	}
}