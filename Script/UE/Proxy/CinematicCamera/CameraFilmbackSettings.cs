using Script.CoreUObject;
using Script.Library;

namespace Script.CinematicCamera
{
	[PathName("/Script/CinematicCamera.CameraFilmbackSettings")]
	public partial class FCameraFilmbackSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CinematicCamera.CameraFilmbackSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCameraFilmbackSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCameraFilmbackSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCameraFilmbackSettings A, FCameraFilmbackSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCameraFilmbackSettings A, FCameraFilmbackSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCameraFilmbackSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float SensorWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SensorWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SensorWidth, __InBuffer);
				}
			}
		}

		public float SensorHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SensorHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SensorHeight, __InBuffer);
				}
			}
		}

		public float SensorAspectRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SensorAspectRatio, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SensorAspectRatio, __InBuffer);
				}
			}
		}

		private static uint __SensorWidth = 0;

		private static uint __SensorHeight = 0;

		private static uint __SensorAspectRatio = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}