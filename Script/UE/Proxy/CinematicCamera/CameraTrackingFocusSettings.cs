using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.CinematicCamera
{
	[PathName("/Script/CinematicCamera.CameraTrackingFocusSettings")]
	public partial class FCameraTrackingFocusSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CinematicCamera.CameraTrackingFocusSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCameraTrackingFocusSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCameraTrackingFocusSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCameraTrackingFocusSettings A, FCameraTrackingFocusSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCameraTrackingFocusSettings A, FCameraTrackingFocusSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCameraTrackingFocusSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		public FVector RelativeOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RelativeOffset, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RelativeOffset, __InBuffer);
				}
			}
		}

		public bool bDrawDebugTrackingFocusPoint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDrawDebugTrackingFocusPoint, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDrawDebugTrackingFocusPoint, __InBuffer);
				}
			}
		}

		private static uint __ActorToTrack = 0;

		private static uint __RelativeOffset = 0;

		private static uint __bDrawDebugTrackingFocusPoint = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}