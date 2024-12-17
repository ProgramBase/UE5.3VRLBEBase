using Script.CoreUObject;
using Script.TakesCore;
using Script.Library;

namespace Script.TakeRecorderSources
{
	[PathName("/Script/TakeRecorderSources.TakeRecorderWorldSourceSettings")]
	public partial class UTakeRecorderWorldSourceSettings : UTakeRecorderSource, IStaticClass
	{
		public bool bRecordWorldSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRecordWorldSettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRecordWorldSettings, __InBuffer);
				}
			}
		}

		public bool bAutotrackActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutotrackActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutotrackActors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorderSources.TakeRecorderWorldSourceSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bRecordWorldSettings = 0;

		private static uint __bAutotrackActors = 0;
	}
}