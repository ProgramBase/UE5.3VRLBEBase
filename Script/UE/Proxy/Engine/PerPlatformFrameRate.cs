using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PerPlatformFrameRate")]
	public partial class FPerPlatformFrameRate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PerPlatformFrameRate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerPlatformFrameRate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerPlatformFrameRate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerPlatformFrameRate A, FPerPlatformFrameRate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerPlatformFrameRate A, FPerPlatformFrameRate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerPlatformFrameRate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFrameRate Default
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Default, __ReturnBuffer);

					return *(FFrameRate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Default, __InBuffer);
				}
			}
		}

		public TMap<FName, FFrameRate> PerPlatform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerPlatform, __ReturnBuffer);

					return *(TMap<FName, FFrameRate>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerPlatform, __InBuffer);
				}
			}
		}

		private static uint __Default = 0;

		private static uint __PerPlatform = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}