using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.InputModifierFOVScaling")]
	public partial class UInputModifierFOVScaling : UInputModifier, IStaticClass
	{
		public float FOVScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FOVScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FOVScale, __InBuffer);
				}
			}
		}

		public EFOVScalingType FOVScalingType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FOVScalingType, __ReturnBuffer);

					return *(EFOVScalingType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FOVScalingType, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.InputModifierFOVScaling");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FOVScale = 0;

		private static uint __FOVScalingType = 0;
	}
}