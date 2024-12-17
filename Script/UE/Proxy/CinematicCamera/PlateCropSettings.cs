using Script.CoreUObject;
using Script.Library;

namespace Script.CinematicCamera
{
	[PathName("/Script/CinematicCamera.PlateCropSettings")]
	public partial class FPlateCropSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CinematicCamera.PlateCropSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlateCropSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlateCropSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlateCropSettings A, FPlateCropSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlateCropSettings A, FPlateCropSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlateCropSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float AspectRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AspectRatio, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AspectRatio, __InBuffer);
				}
			}
		}

		private static uint __AspectRatio = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}