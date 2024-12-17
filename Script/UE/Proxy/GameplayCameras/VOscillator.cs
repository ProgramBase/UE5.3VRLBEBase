using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.VOscillator")]
	public partial class FVOscillator : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayCameras.VOscillator");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVOscillator() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVOscillator() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVOscillator A, FVOscillator B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVOscillator A, FVOscillator B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVOscillator;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFOscillator X
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __X, __ReturnBuffer);

					return *(FFOscillator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __X, __InBuffer);
				}
			}
		}

		public FFOscillator Y
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Y, __ReturnBuffer);

					return *(FFOscillator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Y, __InBuffer);
				}
			}
		}

		public FFOscillator Z
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Z, __ReturnBuffer);

					return *(FFOscillator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Z, __InBuffer);
				}
			}
		}

		private static uint __X = 0;

		private static uint __Y = 0;

		private static uint __Z = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}