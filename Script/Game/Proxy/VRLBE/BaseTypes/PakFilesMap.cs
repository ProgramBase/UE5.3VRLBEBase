using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PakFilesMap")]
	public partial class FPakFilesMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PakFilesMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPakFilesMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPakFilesMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPakFilesMap A, FPakFilesMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPakFilesMap A, FPakFilesMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPakFilesMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, FPakFileArray> PakFilesMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PakFilesMap, __ReturnBuffer);

					return *(TMap<FString, FPakFileArray>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PakFilesMap, __InBuffer);
				}
			}
		}

		private static uint __PakFilesMap = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}