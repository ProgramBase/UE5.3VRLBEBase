using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.FilePath")]
	public partial class FFilePath : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.FilePath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFilePath() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFilePath() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFilePath A, FFilePath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFilePath A, FFilePath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFilePath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString FilePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilePath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilePath, __InBuffer);
				}
			}
		}

		private static uint __FilePath = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}