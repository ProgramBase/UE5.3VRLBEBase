using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithCameraLookatTrackingSettingsTemplate")]
	public partial class FDatasmithCameraLookatTrackingSettingsTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithCameraLookatTrackingSettingsTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithCameraLookatTrackingSettingsTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDatasmithCameraLookatTrackingSettingsTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDatasmithCameraLookatTrackingSettingsTemplate A, FDatasmithCameraLookatTrackingSettingsTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithCameraLookatTrackingSettingsTemplate A, FDatasmithCameraLookatTrackingSettingsTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithCameraLookatTrackingSettingsTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bEnableLookAtTracking
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEnableLookAtTracking, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEnableLookAtTracking, __InBuffer);
				}
			}
		}

		public bool bAllowRoll
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowRoll, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowRoll, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<AActor> ActorToTrack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorToTrack, __ReturnBuffer);

					return *(TSoftObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorToTrack, __InBuffer);
				}
			}
		}

		private static uint __bEnableLookAtTracking = 0;

		private static uint __bAllowRoll = 0;

		private static uint __ActorToTrack = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}