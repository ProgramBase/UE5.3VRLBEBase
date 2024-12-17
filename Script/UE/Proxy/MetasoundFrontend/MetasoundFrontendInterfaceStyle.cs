using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendInterfaceStyle")]
	public partial class FMetasoundFrontendInterfaceStyle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendInterfaceStyle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendInterfaceStyle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendInterfaceStyle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendInterfaceStyle A, FMetasoundFrontendInterfaceStyle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendInterfaceStyle A, FMetasoundFrontendInterfaceStyle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendInterfaceStyle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> DefaultSortOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultSortOrder, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultSortOrder, __InBuffer);
				}
			}
		}

		public TMap<FName, FText> RequiredMembers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RequiredMembers, __ReturnBuffer);

					return *(TMap<FName, FText>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RequiredMembers, __InBuffer);
				}
			}
		}

		private static uint __DefaultSortOrder = 0;

		private static uint __RequiredMembers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}