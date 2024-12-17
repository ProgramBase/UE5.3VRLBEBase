using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.RecentProjectFile")]
	public partial class FRecentProjectFile : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.RecentProjectFile");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRecentProjectFile() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRecentProjectFile() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRecentProjectFile A, FRecentProjectFile B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRecentProjectFile A, FRecentProjectFile B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRecentProjectFile;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ProjectName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProjectName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProjectName, __InBuffer);
				}
			}
		}

		public FDateTime LastOpenTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastOpenTime, __ReturnBuffer);

					return *(FDateTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastOpenTime, __InBuffer);
				}
			}
		}

		private static uint __ProjectName = 0;

		private static uint __LastOpenTime = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}