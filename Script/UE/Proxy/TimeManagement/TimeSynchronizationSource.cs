using Script.CoreUObject;
using Script.Library;

namespace Script.TimeManagement
{
	[PathName("/Script/TimeManagement.TimeSynchronizationSource")]
	public partial class UTimeSynchronizationSource : UObject, IStaticClass
	{
		public bool bUseForSynchronization
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseForSynchronization, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseForSynchronization, __InBuffer);
				}
			}
		}

		public int FrameOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FrameOffset, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FrameOffset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TimeManagement.TimeSynchronizationSource");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bUseForSynchronization = 0;

		private static uint __FrameOffset = 0;
	}
}