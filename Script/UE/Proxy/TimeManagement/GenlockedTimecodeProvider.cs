using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.TimeManagement
{
	[PathName("/Script/TimeManagement.GenlockedTimecodeProvider")]
	public partial class UGenlockedTimecodeProvider : UTimecodeProvider, IStaticClass
	{
		public bool bUseGenlockToCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseGenlockToCount, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseGenlockToCount, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TimeManagement.GenlockedTimecodeProvider");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bUseGenlockToCount = 0;
	}
}