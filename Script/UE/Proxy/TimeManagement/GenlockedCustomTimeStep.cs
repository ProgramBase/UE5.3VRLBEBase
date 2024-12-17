using Script.CoreUObject;
using Script.Library;

namespace Script.TimeManagement
{
	[PathName("/Script/TimeManagement.GenlockedCustomTimeStep")]
	public partial class UGenlockedCustomTimeStep : UFixedFrameRateCustomTimeStep, IStaticClass
	{
		public bool bAutoDetectFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoDetectFormat, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoDetectFormat, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TimeManagement.GenlockedCustomTimeStep");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bAutoDetectFormat = 0;
	}
}