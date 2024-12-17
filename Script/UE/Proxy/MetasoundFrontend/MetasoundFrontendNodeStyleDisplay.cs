using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetasoundFrontendNodeStyleDisplay")]
	public partial class FMetasoundFrontendNodeStyleDisplay : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundFrontend.MetasoundFrontendNodeStyleDisplay");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundFrontendNodeStyleDisplay() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMetasoundFrontendNodeStyleDisplay() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMetasoundFrontendNodeStyleDisplay A, FMetasoundFrontendNodeStyleDisplay B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundFrontendNodeStyleDisplay A, FMetasoundFrontendNodeStyleDisplay B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundFrontendNodeStyleDisplay;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EMetasoundFrontendNodeStyleDisplayVisibility Visibility
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Visibility, __ReturnBuffer);

					return *(EMetasoundFrontendNodeStyleDisplayVisibility*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Visibility, __InBuffer);
				}
			}
		}

		public TMap<FGuid, FVector2D> Locations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Locations, __ReturnBuffer);

					return *(TMap<FGuid, FVector2D>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Locations, __InBuffer);
				}
			}
		}

		private static uint __Visibility = 0;

		private static uint __Locations = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}