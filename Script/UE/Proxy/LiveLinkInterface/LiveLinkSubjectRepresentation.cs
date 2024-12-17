using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation")]
	public partial class FLiveLinkSubjectRepresentation : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkSubjectRepresentation");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkSubjectRepresentation() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLiveLinkSubjectRepresentation() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLiveLinkSubjectRepresentation A, FLiveLinkSubjectRepresentation B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkSubjectRepresentation A, FLiveLinkSubjectRepresentation B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkSubjectRepresentation;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLiveLinkSubjectName Subject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Subject, __ReturnBuffer);

					return *(FLiveLinkSubjectName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Subject, __InBuffer);
				}
			}
		}

		public TSubclassOf<ULiveLinkRole> Role
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Role, __ReturnBuffer);

					return *(TSubclassOf<ULiveLinkRole>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Role, __InBuffer);
				}
			}
		}

		private static uint __Subject = 0;

		private static uint __Role = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}