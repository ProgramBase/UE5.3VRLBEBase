using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendInterfaceUClassOptions")]
	public partial class FMetasoundFrontendInterfaceUClassOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendInterfaceUClassOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendInterfaceUClassOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendInterfaceUClassOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendInterfaceUClassOptions A, FMetasoundFrontendInterfaceUClassOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendInterfaceUClassOptions A, FMetasoundFrontendInterfaceUClassOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendInterfaceUClassOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTopLevelAssetPath ClassPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ClassPath, __ReturnBuffer);

					return *(FTopLevelAssetPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ClassPath, __InBuffer);
				}
			}
		}

		public bool bIsModifiable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsModifiable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsModifiable, __InBuffer);
				}
			}
		}

		public bool bIsDefault
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsDefault, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsDefault, __InBuffer);
				}
			}
		}

		private static uint __ClassPath = 0;

		private static uint __bIsModifiable = 0;

		private static uint __bIsDefault = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}