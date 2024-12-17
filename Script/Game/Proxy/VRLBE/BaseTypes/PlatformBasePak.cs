using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PlatformBasePak")]
	public partial class FPlatformBasePak : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PlatformBasePak");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlatformBasePak() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlatformBasePak() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlatformBasePak A, FPlatformBasePak B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlatformBasePak A, FPlatformBasePak B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlatformBasePak;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ETargetPlatform Platform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Platform, __ReturnBuffer);

					return *(ETargetPlatform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Platform, __InBuffer);
				}
			}
		}

		public TArray<FFilePath> Paks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Paks, __ReturnBuffer);

					return *(TArray<FFilePath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Paks, __InBuffer);
				}
			}
		}

		private static uint __Platform = 0;

		private static uint __Paks = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}