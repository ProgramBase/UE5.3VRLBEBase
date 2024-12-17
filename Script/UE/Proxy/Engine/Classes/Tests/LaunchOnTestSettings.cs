using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LaunchOnTestSettings")]
	public partial class FLaunchOnTestSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.LaunchOnTestSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLaunchOnTestSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLaunchOnTestSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLaunchOnTestSettings A, FLaunchOnTestSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLaunchOnTestSettings A, FLaunchOnTestSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLaunchOnTestSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFilePath LaunchOnTestmap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LaunchOnTestmap, __ReturnBuffer);

					return *(FFilePath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LaunchOnTestmap, __InBuffer);
				}
			}
		}

		public FString DeviceID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeviceID, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeviceID, __InBuffer);
				}
			}
		}

		private static uint __LaunchOnTestmap = 0;

		private static uint __DeviceID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}