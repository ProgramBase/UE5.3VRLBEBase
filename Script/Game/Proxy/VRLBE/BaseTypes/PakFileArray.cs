using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PakFileArray")]
	public partial class FPakFileArray : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PakFileArray");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPakFileArray() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPakFileArray() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPakFileArray A, FPakFileArray B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPakFileArray A, FPakFileArray B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPakFileArray;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPakFileInfo> PakFileInfos
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PakFileInfos, __ReturnBuffer);

					return *(TArray<FPakFileInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PakFileInfos, __InBuffer);
				}
			}
		}

		private static uint __PakFileInfos = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}