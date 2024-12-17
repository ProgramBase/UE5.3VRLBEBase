using Script.CoreUObject;
using Script.Library;

namespace Script.TargetDeviceServices
{
	[PathName("/Script/TargetDeviceServices.TargetDeviceServiceTerminateLaunchedProcess")]
	public partial class FTargetDeviceServiceTerminateLaunchedProcess : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TargetDeviceServices.TargetDeviceServiceTerminateLaunchedProcess");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTargetDeviceServiceTerminateLaunchedProcess() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTargetDeviceServiceTerminateLaunchedProcess() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTargetDeviceServiceTerminateLaunchedProcess A, FTargetDeviceServiceTerminateLaunchedProcess B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTargetDeviceServiceTerminateLaunchedProcess A, FTargetDeviceServiceTerminateLaunchedProcess B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTargetDeviceServiceTerminateLaunchedProcess;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Variant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Variant, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Variant, __InBuffer);
				}
			}
		}

		public FString AppID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AppID, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AppID, __InBuffer);
				}
			}
		}

		private static uint __Variant = 0;

		private static uint __AppID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}