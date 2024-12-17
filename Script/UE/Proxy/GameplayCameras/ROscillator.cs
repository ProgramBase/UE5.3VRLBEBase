using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.ROscillator")]
	public partial class FROscillator : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayCameras.ROscillator");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FROscillator() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FROscillator() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FROscillator A, FROscillator B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FROscillator A, FROscillator B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FROscillator;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFOscillator Pitch
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pitch, __ReturnBuffer);

					return *(FFOscillator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Pitch, __InBuffer);
				}
			}
		}

		public FFOscillator Yaw
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Yaw, __ReturnBuffer);

					return *(FFOscillator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Yaw, __InBuffer);
				}
			}
		}

		public FFOscillator Roll
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Roll, __ReturnBuffer);

					return *(FFOscillator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Roll, __InBuffer);
				}
			}
		}

		private static uint __Pitch = 0;

		private static uint __Yaw = 0;

		private static uint __Roll = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}